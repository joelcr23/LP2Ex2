package pucp.gamesoft.rrhh.controller;
import pucp.gamesoft.rrhh.controller.dao.DAODepartment;
import pucp.gamesoft.rrhh.controller.dao.DAOEmployee;
import pucp.gamesoft.rrhh.controller.mysql.MySQLDepartment;
import pucp.gamesoft.rrhh.controller.mysql.MySQLEmployee;

public class MySQLDAOFactory extends DAOFactory{
    public MySQLDAOFactory(){
        
    }

    @Override
    public DAOEmployee getEmployeeDAO() {
        return new MySQLEmployee();
    }

    @Override
    public DAODepartment getDepartmentDAO() {
        return new MySQLDepartment();
    }
}
