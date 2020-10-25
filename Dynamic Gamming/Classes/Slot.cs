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




    public class Slot : Data
    {
        private string customer_name;
        private string game;
        private double hours;
        private string slot_id;
        private string date;
        DBAccess objDBAccess = new DBAccess();
        DataTable dt = new DataTable();

        public Slot(string _customer_name, string _game, double _hours, string _date)
        {

            this.date = _date;
            this.customer_name = _customer_name;
            this.game = _game;
            this.hours = _hours;
            storeData();
        }

        //Constructor to create slots for customers have an account
        public Slot(string _name, double _hours, string _date)
        {

            this.date = _date;
            this.hours = _hours;
            this.customer_name = _name;
            this.game = "All allowed";
            storeData();
        }



        public override void storeData()
        {

            SqlCommand insertCommand = new SqlCommand("insert into Slots(Name, Game, Hours, Date) values (@name,@game, @hours, @date)");
            insertCommand.Parameters.AddWithValue("@name", this.customer_name);
            insertCommand.Parameters.AddWithValue("@game", this.game);
            insertCommand.Parameters.AddWithValue("@hours", this.hours);
            insertCommand.Parameters.AddWithValue("@date", this.date);
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

     



        public string getCustomerName()
        {
            return this.customer_name;
        }

        public void setCustomerName(string _customer_name)
        {
            this.customer_name = _customer_name;
        }

        public string getSlotId()
        {
            return this.slot_id;
        }

        public void setSlotId(string _slot_id)
        {
            this.slot_id = _slot_id;
        }

        public string getGame()
        {
            return this.game;
        }

        public void setGame(string _game)
        {
            this.game = _game;
        }

        public double getHours()
        {
            return this.hours;
        }

        public void setHours(double _hours)
        {
            this.hours = _hours;
        }



        override
        public string ToString()
        {
            return "Date: " + this.date + " |  Customer name: " + this.customer_name + " |  Game selected: " + this.game + " |  Time: " + this.hours + "hrs\n";
        }

    }

}
