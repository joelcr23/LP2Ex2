package pe.edu.pucp.inf.lp2soft.model.bean;

import java.io.Serializable;
import java.text.SimpleDateFormat;

public class Professor implements Serializable{

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getEdad() {
        return edad;
    }

    public void setEdad(int edad) {
        this.edad = edad;
    }
    private String name;
    private int edad;

    
}
