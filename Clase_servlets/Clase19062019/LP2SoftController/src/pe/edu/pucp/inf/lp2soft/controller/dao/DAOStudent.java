package pe.edu.pucp.inf.lp2soft.controller.dao;

import java.util.ArrayList;
import pe.edu.pucp.inf.lp2soft.model.bean.Student;

public interface DAOStudent {
    int insert(Student student);
    int update(Student student);
    int delete(int idStudent);
    ArrayList<Student> queryAll();
    ArrayList<Student> queryAllByName(String name);
}
