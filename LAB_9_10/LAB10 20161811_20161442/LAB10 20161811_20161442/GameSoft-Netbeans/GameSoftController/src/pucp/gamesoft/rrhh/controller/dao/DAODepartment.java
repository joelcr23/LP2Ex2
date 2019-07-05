package pucp.gamesoft.rrhh.controller.dao;
import java.util.ArrayList;
import pucp.gamesoft.rrhh.model.Department;

public interface DAODepartment {
    ArrayList<Department> queryAllIndependent();
    ArrayList<Department> queryAllDependent(int idDepartment);
}
