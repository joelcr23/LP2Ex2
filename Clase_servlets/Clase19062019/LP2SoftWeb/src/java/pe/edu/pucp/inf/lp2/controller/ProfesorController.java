package pe.edu.pucp.inf.lp2.controller;

import java.io.Serializable;
import pe.edu.pucp.inf.lp2soft.controller.config.DBController;
import pe.edu.pucp.inf.lp2soft.model.bean.Professor;

public class ProfesorController implements
        Serializable{

    public ProfesorController(){
        profesor = new Professor();
    }
    
    public Professor getProfesor() {
        return profesor;
    }

    public void setProfesor(Professor profesor) {
        this.profesor = profesor;
    }
    private Professor profesor;
    
    public void registrarProfesor(){
        DBController.insertProfesor(profesor);
    }
}
