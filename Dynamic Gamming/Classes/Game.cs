using Dynamic_Gamming.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_Gamming
{

    public class Game : Data
    {

        private string game_name;
        private int release_year;
        private bool is_multiplayer;
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();
        protected string genre;

        public Game(string _game_name, int _relese_year, bool _is_multiplayer)
        {
            this.game_name = _game_name;
            this.release_year = _relese_year;
            this.is_multiplayer = _is_multiplayer;
            
            
        }

        public override void storeData()
        {
            string mul = "Yes";
            if (this.is_multiplayer == false)
            {
                mul = "No";
            }


            SqlCommand insertCommand = new SqlCommand("insert into Games(Name, Genre, Multiplayer, [Release year]) values (@name,@genre, @mul,@ry)");
            insertCommand.Parameters.AddWithValue("@name", this.game_name);
            insertCommand.Parameters.AddWithValue("@genre", this.genre);
            insertCommand.Parameters.AddWithValue("@mul", mul);
            insertCommand.Parameters.AddWithValue("@ry", this.release_year);

            int row = objDBAccess.executeQuery(insertCommand);
            if (row == 1)
            {
                Console.WriteLine("Data is stored");
            }
            else
            {
                throw new Exception("Couldn't store data");
            }

        }






        public string getName()
        {
            return this.game_name;
        }

        public void setName(string n)
        {
            n = this.game_name;
        }


        override
        public string ToString()
        {
            return "Name: " + this.game_name + " | Release year: " + this.release_year + " | Multiplayer: " + this.is_multiplayer;
        }


    }

    public class Sports : Game
    {
        public Sports(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Sports";
            storeData();
        }

    }

    public class Action : Game
    {
        public Action(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Action";
            storeData();
        }

    }

    public class Adventure : Game
    {
        public Adventure(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Adventure";
            storeData();
        }

    }

    public class Simulation : Game
    {
        public Simulation(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Simulation";
            storeData();
        }
    }

    public class Strategy : Game
    {
        public Strategy(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Strategy";
            storeData();
        }

    }
    public class Other : Game
    {
        public Other(string game_name, int _relese_year, bool _is_multiplayer) : base(game_name, _relese_year, _is_multiplayer)
        {
            this.genre = "Other";
            storeData();
        }

    }
}
