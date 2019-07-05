using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftConfig
{
    public sealed class DBManager
    {
        private string _stringConn;
        private string _type;
        private readonly static DBManager _dbManager = new DBManager();

        private DBManager()
        {
            System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(ConnectionParameters));
            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\config.xml");
            ConnectionParameters parameters = (ConnectionParameters)reader.Deserialize(file);
            file.Close();
            _type = parameters.Type;
            _stringConn =
            "database=" + parameters.Database + ";" +
            "server=" + parameters.Server + ";" +
            "user=" + parameters.User + ";" +
            "password=" + parameters.Password + ";sslMode=none;";
            if (_type == "mysql")
                _stringConn = _stringConn + "port=" + parameters.Port + ";";
        }

        public static DBManager DbManager => _dbManager;
        public string StringConn { get => _stringConn; set => _stringConn = value; }
        public string Type { get => _type; set => _type = value; }

    }
}
