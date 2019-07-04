package pe.edu.pucp.inf.lp2soft.controller.config;

import pe.edu.pucp.inf.lp2soft.controller.dao.DAOCareer;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOProfesor;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOStudent;

public abstract class DAOFactory {
    
    public static DAOFactory getDAOFactory(){
        if(DBManager.getdbManager().getUrl().contains("mysql")){
                return new MySQLDAOFactory();
        }
        else{
                return new MSSQLDAOFactory();
        }
            
    }
    
    public abstract DAOStudent getStudentDAO();
    public abstract DAOCareer getCareerDAO();
    public abstract DAOProfesor getProfesorDAO();
}
