package pe.edu.pucp.inf.lp2soft.model.bean;
import java.io.Serializable;

public class Career implements Serializable{
    private int id;
    private String name;
    private boolean active;

    public Career() {
    }
    
    public Career(int id, String name, boolean active) {
        this.id = id;
        this.name = name;
        this.active = active;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public boolean isActive() {
        return active;
    }

    public void setActive(boolean active) {
        this.active = active;
    }

    @Override
    public String toString() {
        return name;
    }
    
    
}
