package pe.edu.pucp.inf.lp2soft.controller.config;

import pe.edu.pucp.inf.lp2soft.controller.dao.DAOCareer;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOProfesor;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOStudent;
import pe.edu.pucp.inf.lp2soft.controller.mysql.MySQLCareer;
import pe.edu.pucp.inf.lp2soft.controller.mysql.MySQLProfesor;
import pe.edu.pucp.inf.lp2soft.controller.mysql.MySQLStudent;

public class MySQLDAOFactory extends DAOFactory{
    
    public MySQLDAOFactory(){
        
    }
    
    public DAOStudent getStudentDAO(){
        return new MySQLStudent();
    }
    
    public DAOCareer getCareerDAO(){
        return new MySQLCareer();
    }
    
    public DAOProfesor getProfesorDAO(){
        return new MySQLProfesor();
    }
}
