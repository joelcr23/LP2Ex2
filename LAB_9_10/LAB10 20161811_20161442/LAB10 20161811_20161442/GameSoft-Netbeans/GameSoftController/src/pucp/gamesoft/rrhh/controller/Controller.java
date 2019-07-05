package pucp.gamesoft.rrhh.controller;

import java.util.ArrayList;
import pucp.gamesoft.rrhh.model.Department;
import pucp.gamesoft.rrhh.model.Employee;

public abstract class Controller{
    private static final DAOFactory daoFactory = DAOFactory.getDAOFactory();
    
    public static ArrayList<Employee> queryAllEmployeesIndependent(int idDepartment){
        return daoFactory.getEmployeeDAO().queryAllIndependent(idDepartment);
    }
    
    public static ArrayList<Employee> queryAllEmployeesDependent(int idEmployee){
        return daoFactory.getEmployeeDAO().queryAllDependent(idEmployee);
    }
    
    public static ArrayList<Department> queryAllDepartmentsIndependent(){
        return daoFactory.getDepartmentDAO().queryAllIndependent();
    }
    
    public static ArrayList<Department> queryAllDepartmentsDependent(int idDepartment){
        return daoFactory.getDepartmentDAO().queryAllDependent(idDepartment);
    }
    
    public static Employee queryEmployeeById(int idEmployee){
        return daoFactory.getEmployeeDAO().queryById(idEmployee);
    }
}