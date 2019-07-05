package pucp.gamesoft.rrhh.controller.dao;
import java.util.ArrayList;
import pucp.gamesoft.rrhh.model.Employee;
public interface DAOEmployee {
    ArrayList<Employee> queryAllIndependent(int idDepartment);
    ArrayList<Employee> queryAllDependent(int idEmployee);
    Employee queryById(int idEmployee);
}