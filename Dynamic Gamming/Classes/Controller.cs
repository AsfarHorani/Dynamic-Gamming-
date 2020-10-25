 using System;
    using System.Collections;
    using System.Collections.Generic;
using System.Data;
using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Dynamic_Gamming
    {
    public class Controller
    {
        private List<Game> game_list = new List<Game>();
        private List<Slot> slot_list = new List<Slot>();
        private List<Admin> admin_list = new List<Admin>();
        private List<Customer> customer_list = new List<Customer>();
        DBAccess objDBAccess = new DBAccess();
        DataTable dtg = new DataTable();
        DataTable dts = new DataTable();
        DataTable dta = new DataTable();
        DataTable dtc = new DataTable();



        //game objects control
        public void addGame(Game g)
        {
            game_list.Add(g);
        }

        public void removGame(Game g)
        {
            game_list.Remove(g);
        }



        public List<Game> getGameList()
        {
            return game_list;
        }

        public DataTable retriveGameData()
        {
            dtg.Clear();
            string query = "Select * from Games";
            objDBAccess.readDatathroughAdapter(query, dtg);
            return this.dtg;
        }





        //slot objects control
        public void addSlot(Slot s)
        {
            slot_list.Add(s);
        }

        public List<Slot> getSlotList()
        {
            return slot_list;

        }

        public void removeSlot(Slot s)
        {
            slot_list.Remove(s);
        }

        public DataTable retriveSlotData()
        {
            dts.Clear();
            string query = "Select * from Slots";
            objDBAccess.readDatathroughAdapter(query, dts);
            return this.dts;
        }




        //admin object control

        public void addAdmin(Admin _admin)
        {
            admin_list.Add(_admin);

        }

        public void removeAdmin(Admin _admin)
        {

        }

        public List<Admin> getAdminList()
        {
            return admin_list;

        }

        public DataTable retriveAdminData()
        {
            dta.Clear();
            string query = "Select * from Users";
            objDBAccess.readDatathroughAdapter(query, dta);
            return this.dta;
        }



        //customer object controll


        public void addCustomer(Customer _customer)
        {
            customer_list.Add(_customer);

        }



        public void removeCustomer(Admin _admin)
        {
            admin_list.Remove(_admin);
        }

        public List<Customer> getCustomerList()
        {
            return customer_list;

        }

        public DataTable retriveCustomerData()
        {
            dtc.Clear();
            string query = "Select * from Customer_Data";
            objDBAccess.readDatathroughAdapter(query, dtc);
            return this.dtc;
        }


    }
}

