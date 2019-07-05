package pucp.gamesoft.rrhh.model;

import java.io.Serializable;
import java.util.ArrayList;
public class Studio implements Serializable{
	private String name;
	private ArrayList<Department> departments;
	public Studio(String name){
		this.name = name;
		this.departments = new ArrayList<Department>();
	}
	public ArrayList<Department> getDepartments(){
		return departments;
	}
}