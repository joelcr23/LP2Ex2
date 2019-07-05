package pucp.gamesoft.rrhh.model;

import java.io.Serializable;

public class Region implements Serializable{
	private String name;
	public Region(String name){
		this.name = name;
	}
	
	public String getName(){
		return name;
	}
	
	public void setName(String name){
		this.name = name;
	}
}