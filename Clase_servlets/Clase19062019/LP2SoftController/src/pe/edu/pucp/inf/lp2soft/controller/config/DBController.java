package pe.edu.pucp.inf.lp2soft.controller.config;

import java.util.ArrayList;
import pe.edu.pucp.inf.lp2soft.model.bean.Career;
import pe.edu.pucp.inf.lp2soft.model.bean.Professor;
import pe.edu.pucp.inf.lp2soft.model.bean.Student;

public abstract class DBController {
    private static DAOFactory daoFactory = 
            DAOFactory.getDAOFactory();
    
    public static int insertStudent(Student student){
        return daoFactory.getStudentDAO().insert(student);
    }
    
    public static ArrayList<Career> queryAllCareers(){
        return daoFactory.getCareerDAO().queryAll();
    }
    
    public static ArrayList<Student> queryAllStudents(){
        return daoFactory.getStudentDAO().queryAll();
    }
    
    public static ArrayList<Student> queryAllStudentsByName(String name){
        return daoFactory.getStudentDAO().queryAllByName(name);
    }
    
    public static int insertProfesor(Professor p){
        return daoFactory.getProfesorDAO().insert(p);
    }
}
