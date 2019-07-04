package pe.edu.pucp.inf.lp2soft.controller.mysql;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import pe.edu.pucp.inf.lp2soft.controller.config.DBManager;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOCareer;
import pe.edu.pucp.inf.lp2soft.model.bean.Career;

public class MySQLCareer implements DAOCareer{

    @Override
    public ArrayList<Career> queryAll() {
        ArrayList<Career> careers = new ArrayList<>();
        try{
            DBManager dbManager = DBManager.getdbManager();
            Connection con = DriverManager.getConnection(dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
            CallableStatement cs = con.prepareCall("{ call LIST_CAREERS()}");
            ResultSet rs = cs.executeQuery();
            while(rs.next()){
                Career c = new Career();
                c.setId(rs.getInt("ID_CAREER"));
                c.setName(rs.getString("NAME"));
                c.setActive(rs.getBoolean("ACTIVE"));
                careers.add(c);
            }
            con.close();
        }catch(SQLException ex){
            System.out.println(ex.getMessage());
        }
        return careers;
    }
    
}
