package pucp.gamesoft.rrhh.controller;

import pucp.gamesoft.rrhh.controller.dao.DAODepartment;
import pucp.gamesoft.rrhh.controller.dao.DAOEmployee;
import pucp.gamesoft.rrhh.controller.mssql.MSSQLDepartment;
import pucp.gamesoft.rrhh.controller.mssql.MSSQLEmployee;

public class MSSQLDAOFactory extends DAOFactory{
    public MSSQLDAOFactory(){
        
    }
    
    @Override
    public DAOEmployee getEmployeeDAO(){
        return new MSSQLEmployee();
    }

    @Override
    public DAODepartment getDepartmentDAO() {
        return new MSSQLDepartment();
    }
}
