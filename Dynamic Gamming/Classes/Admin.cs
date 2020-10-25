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

    public class Admin : Data
    {


        private string username;
        //private string email;
        private string password;
        //private double mobile_number;
        private string id;
        DataTable dt = new DataTable();
        DBAccess objDBAccess = new DBAccess();





        public Admin(string _uname, string _password)
        {
            this.username = _uname;
            // this.email = _email;
            this.password = _password;
            // this.mobile_number = mobile_number;


            storeData();
        }

        public override void storeData()
        {

            SqlCommand insertCommand = new SqlCommand("insert into Users(Username, Password) values (@username,@password)");
            insertCommand.Parameters.AddWithValue("@username", this.username);
            insertCommand.Parameters.AddWithValue("@password", this.password);
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



       





        public void setPassword(string old_password, string new_password)
        {
            try
            {
                if (this.getPassword().Equals(old_password))
                {
                    this.password = new_password;
                }
                else if (old_password != this.getPassword())
                {
                    Console.WriteLine("Old password you entered is wrong");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }



        public string getUserName()
        {
            return this.username;
        }

        void setUserName(string n)
        {
            n = this.username;
        }








        public string getPassword()
        {
            return this.password;
        }

        void setPassword(string p)
        {
            p = this.password;
        }








        public void setId(string _id)
        {
            this.id = _id;

        }
        public string getId()
        {
            return this.id;
        }







        override
             public string ToString()
        {
            return "ID: " + this.getId() + "|   User Name: " + this.getUserName();

        }


    }

}
