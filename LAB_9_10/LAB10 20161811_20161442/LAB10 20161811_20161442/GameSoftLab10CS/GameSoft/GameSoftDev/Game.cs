using GameSoftDev.opt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSoftDev
{
    public class Game
    {
        private int _id;
        private String _name;
        private Genre _genre;
        private Platform _platform;
        private GameMode _gameMode;
        private ContentClassificationSystem _CCS;
        private bool _active;

        public Game() { }

        public Game(string name, Genre genre, Platform platform, GameMode gameMode, ContentClassificationSystem CCS)
        {
            _name = name;
            _genre = genre;
            _platform = platform;
            _gameMode = gameMode;
            _CCS = CCS;
            _active = true;
        }

        public string Name { get => _name; set => _name = value; }
        public Genre Genre { get => _genre; set => _genre = value; }
        public Platform Platform { get => _platform; set => _platform = value; }
        public GameMode GameMode { get => _gameMode; set => _gameMode = value; }
        public ContentClassificationSystem CCS { get => _CCS; set => _CCS = value; }
        public int Id { get => _id; set => _id = value; }
        public bool Active { get => _active; set => _active = value; }
    }
}
