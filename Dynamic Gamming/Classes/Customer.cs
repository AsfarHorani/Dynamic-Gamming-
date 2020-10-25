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

    //customers will have access to all games
    public class Customer : Data
    {
        string name;
        double mobile_number;
        double hours;
        DataTable dt = new DataTable();

        DBAccess objDBAccess = new DBAccess();

        public Customer(string _name, double _mobile_number, double _hours)
        {
            this.name = _name;
            this.mobile_number = _mobile_number;
            this.hours = _hours;

            storeData();

        }

        public override void storeData()
        {

            SqlCommand insertCommand = new SqlCommand("insert into Customer_Data(Name, MobileNumber, Hours) values (@name,@mobile_number,@hours)");
            insertCommand.Parameters.AddWithValue("@name", this.name);
            insertCommand.Parameters.AddWithValue("@mobile_number", this.mobile_number);
            insertCommand.Parameters.AddWithValue("@hours", this.hours);
            int row = objDBAccess.executeQuery(insertCommand);
            if (row == 1)
            {
                Console.WriteLine("Data is stored");
            }

        }

      




        public string getName()
        {
            return this.name;
        }

        void setName(string n)
        {
            n = this.name;
        }


        public double getMobileNumber()
        {
            return this.mobile_number;
        }

        void setMobileNumber(double mn)
        {
            mn = this.mobile_number;
        }


        public void setHours(double _hours)
        {
            this.hours += _hours;
        }


    }
}
