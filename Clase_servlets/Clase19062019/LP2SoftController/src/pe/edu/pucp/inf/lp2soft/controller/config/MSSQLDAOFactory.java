
package pe.edu.pucp.inf.lp2soft.controller.config;

import pe.edu.pucp.inf.lp2soft.controller.dao.DAOCareer;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOProfesor;
import pe.edu.pucp.inf.lp2soft.controller.dao.DAOStudent;
import pe.edu.pucp.inf.lp2soft.controller.mssql.MSSQLStudent;

public class MSSQLDAOFactory extends DAOFactory{
    public MSSQLDAOFactory(){
        
    }
    
    public DAOStudent getStudentDAO(){
        return new MSSQLStudent();
    }

    @Override
    public DAOCareer getCareerDAO() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public DAOProfesor getProfesorDAO() {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
