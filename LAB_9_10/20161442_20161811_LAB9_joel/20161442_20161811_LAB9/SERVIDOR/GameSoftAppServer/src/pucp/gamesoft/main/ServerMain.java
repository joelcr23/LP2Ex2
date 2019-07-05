package pucp.gamesoft.main;

import java.rmi.registry.LocateRegistry;
import pucp.gamesoft.rrhh.controller.dao.DAODepartment;
import pucp.gamesoft.rrhh.controller.dao.DAOEmployee;
import pucp.gamesoft.rrhh.controller.mysql.MySQLDepartment;
import pucp.gamesoft.rrhh.controller.mysql.MySQLEmployee;

public class ServerMain {
    public static void main(String[] args){
        try{
            System.setProperty("java.rmi.server.hostname", 
                    "192.168.207.105"); //IP SERVER
            LocateRegistry.createRegistry(1234);
            DAOEmployee daoEmployee = new MySQLEmployee();
            java.rmi.Naming.rebind("//192.168.207.105:1234/daoEmployee", daoEmployee);
            DAODepartment daoDepartment = new MySQLDepartment();
            java.rmi.Naming.rebind("//192.168.207.105:1234/daoDepartment", daoDepartment);
            System.out.println("Se ha levantado el servidor...");
        }catch(Exception ex){
           System.err.println(ex.getMessage());
        }
    }
}
