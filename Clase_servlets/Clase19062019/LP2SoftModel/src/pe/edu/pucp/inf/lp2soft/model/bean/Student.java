package pe.edu.pucp.inf.lp2soft.model.bean;
import java.io.Serializable;
import java.util.Date;

public class Student extends Person implements Serializable{
    private Career career;
    private float CRAEST;
    private boolean permissionOnlineDatabases;
    private boolean permissionLibraries;
    private boolean permissionLaboratories;
    private byte[] foto;
    
    public byte[] getFoto() {
        return foto;
    }

    public void setFoto(byte[] foto) {
        this.foto = foto;
    }
    

    public Student() {
        this.career = new Career();
    }

    public Student(Career career, float CRAEST, boolean permissionOnlineDatabases, boolean permissionLibraries, boolean permissionLaboratories, String fullName, int age, String birth, char genre) {
        super(fullName, age, birth, genre);
        this.career = career;
        this.CRAEST = CRAEST;
        this.permissionOnlineDatabases = permissionOnlineDatabases;
        this.permissionLibraries = permissionLibraries;
        this.permissionLaboratories = permissionLaboratories;
    }

    public Career getCareer() {
        return career;
    }

    public void setCareer(Career career) {
        this.career = career;
    }

    public float getCRAEST() {
        return CRAEST;
    }

    public void setCRAEST(float CRAEST) {
        this.CRAEST = CRAEST;
    }

    public boolean isPermissionOnlineDatabases() {
        return permissionOnlineDatabases;
    }

    public void setPermissionOnlineDatabases(boolean permissionOnlineDatabases) {
        this.permissionOnlineDatabases = permissionOnlineDatabases;
    }

    public boolean isPermissionLibraries() {
        return permissionLibraries;
    }

    public void setPermissionLibraries(boolean permissionLibraries) {
        this.permissionLibraries = permissionLibraries;
    }

    public boolean isPermissionLaboratories() {
        return permissionLaboratories;
    }

    public void setPermissionLaboratories(boolean permissionLaboratories) {
        this.permissionLaboratories = permissionLaboratories;
    }

    @Override
    public String toString() {
        return getFullName();
    }
    
    
}
