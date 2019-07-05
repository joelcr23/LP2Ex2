package pucp.gamesoft.rrhh.model;

import java.io.Serializable;
import java.util.ArrayList;
public class Brand implements Serializable{
	private String name;
	private ArrayList<Studio> studios;
	private Location location;
	public Brand(String name, Location location){
		this.name = name;
		this.studios = new ArrayList<Studio>();
		this.location = location;
	}
	public ArrayList<Studio> getStudios(){
		return studios;
	}
}