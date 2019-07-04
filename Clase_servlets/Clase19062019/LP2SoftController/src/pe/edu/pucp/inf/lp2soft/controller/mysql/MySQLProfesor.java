package pe.edu.pucp.inf.lp2soft.controller.mysql;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import pe.edu.pucp.inf.lp2soft.controller.config.DBManager;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOProfesor;
import pe.edu.pucp.inf.lp2soft.model.bean.Professor;

public class MySQLProfesor implements DAOProfesor{
    public int insert(Professor p){
        int res = 0;
        try{
      DBManager dbManager = DBManager.getdbManager();
      Connection con = DriverManager.getConnection
      (dbManager.getUrl(), dbManager.getUser(), dbManager.getPassword());
      Statement s = con.createStatement();
      res = s.executeUpdate("INSERT INTO "
              + "PROFESOR(NOMBRE_COMPLETO,EDAD) "
              + "values('"+p.getName()+"',"
              +String.valueOf(p.getEdad())+")");
      con.close();
      
 }catch(Exception ex){
     System.out.println(ex.getMessage());
 }
        return res;
    }
}
