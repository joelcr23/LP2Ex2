using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftConfig
{
    public class ConnectionParameters
    {
        private string _server;
        private string _database;
        private string _user;
        private string _password;
        private string _port;
        private string _type;

        public string Server { get => _server; set => _server = value; }
        public string Database { get => _database; set => _database = value; }
        public string User { get => _user; set => _user = value; }
        public string Password { get => _password; set => _password = value; }
        public string Port { get => _port; set => _port = value; }
        public string Type { get => _type; set => _type = value; }
    }
}
