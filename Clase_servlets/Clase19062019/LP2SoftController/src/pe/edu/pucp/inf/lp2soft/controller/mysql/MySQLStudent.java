package pe.edu.pucp.inf.lp2soft.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;

import java.util.Set;
import pe.edu.pucp.inf.lp2soft.controller.config.DBManager;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOStudent;
import pe.edu.pucp.inf.lp2soft.model.bean.Student;
public class MySQLStudent implements DAOStudent{

    private SimpleDateFormat formato= new SimpleDateFormat("dd-MM-yyyy");
    
    @Override
    public int insert(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall(
            "{ call INSERT_STUDENT(?,?,?,?,?,?,?,?,?,?)}");
            cs.setString("_FULL_NAME", student.getFullName());
            cs.setInt("_AGE", student.getAge());
            java.util.Date fecha = null;
            try{fecha = formato.parse(student.getBirth());}catch(Exception ex){ ex.getMessage(); }
            cs.setDate("_BIRTH", new java.sql.Date(fecha.getTime()));
            cs.setString("_GENRE", String.valueOf(student.getGenre()));
            cs.setInt("_FID_CAREER", student.getCareer().getId());
            cs.setBoolean("_HAS_PERMISSION_ONLINE_DATABASES", 
                    student.isPermissionOnlineDatabases());
            cs.setBoolean("_HAS_PERMISSION_LIBRARIES", 
                    student.isPermissionLibraries());
            cs.setBoolean("_HAS_PERMISSION_LABORATORIES", 
                    student.isPermissionLaboratories());
            cs.setBytes("_FOTO", student.getFoto());
            cs.registerOutParameter("_ID_STUDENT", 
                    java.sql.Types.INTEGER);
            cs.executeUpdate();
            student.setId(cs.getInt("_ID_STUDENT"));
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int update(Student student) {
        int result = 0;
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call UPDATE_STUDENT(?,?,?,?)}");
            cs.setInt(1, student.getId());
            cs.setString(2, student.getFullName());
            cs.setInt(3, student.getAge());
            cs.setFloat(4, student.getCRAEST());
            result = cs.executeUpdate();
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return result;
    }

    @Override
    public int delete(int idStudent) {
        return 0;
    }

    @Override
    public ArrayList<Student> queryAll() {
        ArrayList<Student> listStudents = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{call LIST_STUDENTS()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Student student = new Student();
                student.setId(rs.getInt("ID_PERSON"));
                student.setFullName(rs.getString("FULL_NAME"));
                student.setAge(rs.getInt("AGE"));
                student.setFoto(rs.getBytes("FOTO"));
                student.setPermissionOnlineDatabases(rs.getBoolean("HAS_PERMISSION_ONLINE_DATABASES"));
                student.setPermissionLaboratories(rs.getBoolean("HAS_PERMISSION_LABORATORIES"));
                student.setPermissionLibraries(rs.getBoolean("HAS_PERMISSION_LIBRARIES"));
                java.util.Date fecha = rs.getDate("BIRTH");
                student.setBirth(formato.format(fecha));
                student.setGenre(rs.getString("GENRE").charAt(0));
                student.getCareer().setId(rs.getInt("ID_CAREER"));
                student.getCareer().setName(rs.getString("NAME"));
                student.getCareer().setActive(true);
                listStudents.add(student);
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return listStudents;
    }
    
    @Override
    public ArrayList<Student> queryAllByName(String name) {
        ArrayList<Student> listStudents = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            String sql = "SELECT ID_PERSON, FULL_NAME, AGE, BIRTH, GENRE, FID_CAREER, C.NAME, C.ID_CAREER AS ID_CAREER, HAS_PERMISSION_ONLINE_DATABASES, HAS_PERMISSION_LIBRARIES, HAS_PERMISSION_LABORATORIES, FOTO FROM PERSON INNER JOIN STUDENT ON STUDENT.ID_STUDENT = PERSON.ID_PERSON INNER JOIN CAREER C ON C.ID_CAREER = STUDENT.FID_CAREER WHERE STUDENT.ACTIVE = 1 AND FULL_NAME LIKE '%"+name+"%';";
            PreparedStatement ps = con.prepareStatement(sql);
            ResultSet rs = ps.executeQuery();
            while(rs.next()){
                Student student = new Student();
                student.setId(rs.getInt("ID_PERSON"));
                student.setFullName(rs.getString("FULL_NAME"));
                student.setAge(rs.getInt("AGE"));
                student.setFoto(rs.getBytes("FOTO"));
                student.setPermissionOnlineDatabases(rs.getBoolean("HAS_PERMISSION_ONLINE_DATABASES"));
                student.setPermissionLaboratories(rs.getBoolean("HAS_PERMISSION_LABORATORIES"));
                student.setPermissionLibraries(rs.getBoolean("HAS_PERMISSION_LIBRARIES"));
                java.util.Date fecha = rs.getDate("BIRTH");
                student.setBirth(formato.format(fecha));
                student.setGenre(rs.getString("GENRE").charAt(0));
                student.getCareer().setId(rs.getInt("ID_CAREER"));
                student.getCareer().setName(rs.getString("NAME"));
                student.getCareer().setActive(true);
                listStudents.add(student);
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return listStudents;
    }
}
