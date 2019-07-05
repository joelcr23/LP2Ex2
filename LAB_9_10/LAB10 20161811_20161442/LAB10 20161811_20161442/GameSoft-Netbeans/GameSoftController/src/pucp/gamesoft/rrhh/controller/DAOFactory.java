package pucp.gamesoft.rrhh.controller;
import pucp.gamesoft.rrhh.controller.config.DBManager;
import pucp.gamesoft.rrhh.controller.dao.DAODepartment;
import pucp.gamesoft.rrhh.controller.dao.DAOEmployee;

public abstract class DAOFactory {
    public static DAOFactory getDAOFactory(){
        if(DBManager.getDBManager().getUrl().contains("mysql"))
            return new MySQLDAOFactory();
        else
            return new MSSQLDAOFactory();
    }
    public abstract DAOEmployee getEmployeeDAO();
    public abstract DAODepartment getDepartmentDAO();
}
