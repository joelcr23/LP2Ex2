package pe.edu.pucp.inf.lp2soft.model.bean;
import java.io.Serializable;
import java.util.Date;

public class Person implements Serializable{
    private int id;
    private String fullName;
    private int age;
    private String birth;
    private char genre;

    public Person() {
    }

    public Person(String fullName, int age, String birth, char genre) {
        this.fullName = fullName;
        this.age = age;
        this.birth = birth;
        this.genre = genre;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getFullName() {
        return fullName;
    }

    public void setFullName(String fullName) {
        this.fullName = fullName;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public String getBirth() {
        return birth;
    }

    public void setBirth(String birth) {
        this.birth = birth;
    }

    public char getGenre() {
        return genre;
    }

    public void setGenre(char genre) {
        this.genre = genre;
    }
    
    
    
}
