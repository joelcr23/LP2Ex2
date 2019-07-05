package pucp.gamesoft.rrhh.controller.config;
 
import com.thoughtworks.xstream.XStream;
import com.thoughtworks.xstream.security.AnyTypePermission;
import java.io.File;
import java.io.FileNotFoundException;
import java.io.FileReader;

public class DBManager{
    private final String strMySQLDriverClass = "com.mysql.cj.jdbc.Driver";
    private final String strSQLServerDriverClass = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
    private static DBManager dbManager = new DBManager(DBManager.class.getResource("/pucp/gamesoft/web/config/config.xml").getFile());
    
    public String getUrl() {
        return url;
    }

    public void setUrl(String url) {
        this.url = url;
    }

    public String getUser() {
        return user;
    }

    public void setUser(String user) {
        this.user = user;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
    private String url;
    private String user;
    private String password;
    private FileReader reader;
    
    public DBManager(String configXMLPath){
        XStream xstream = new XStream();
        xstream.addPermission(AnyTypePermission.ANY);        
        try{
            reader = new FileReader(configXMLPath); //"src/pucp/gamesoft/config/config.xml");
            ConnectionParameters connParam =
            (ConnectionParameters) xstream.fromXML(reader);
            url = connParam.getUrl();
            password = connParam.getPassword();
            user = connParam.getUser();
            if(url.contains("mysql")){
                Class.forName(strMySQLDriverClass);
            }else{
                Class.forName(strSQLServerDriverClass);
            }
            System.out.println("Se ha registrado el Driver");
        }catch(FileNotFoundException | ClassNotFoundException ex){
            ex.printStackTrace();
        }
    }

    public static DBManager getDBManager() {
	return dbManager;
    }	
}