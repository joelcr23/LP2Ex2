package pe.edu.pucp.inf.lp2.services;

import java.util.ArrayList;
import javax.jws.WebService;
import javax.jws.WebMethod;
import javax.jws.WebParam;
import pe.edu.pucp.inf.lp2soft.controller.config.DBController;
import pe.edu.pucp.inf.lp2soft.model.bean.Career;
import pe.edu.pucp.inf.lp2soft.model.bean.Student;
@WebService(serviceName = "DBControllerWS")
public class DBControllerWS {
    
    @WebMethod(operationName = "queryAllCareers")
    public ArrayList<Career> queryAllCareers(){
        return DBController.queryAllCareers();
    }
    
    @WebMethod(operationName = "queryAllStudents")
    public ArrayList<Student> queryAllStudents(){
        return DBController.queryAllStudents();
    }
    
    @WebMethod(operationName = "queryAllStudentsByName")
    public ArrayList<Student> queryAllStudentsByName(@WebParam(name = "name") String name){
        return DBController.queryAllStudentsByName(name);
    }
    
    @WebMethod(operationName = "insertStudent")
    public int insertStudent(@WebParam(name = "student") Student student){
        return DBController.insertStudent(student);
    }
}
