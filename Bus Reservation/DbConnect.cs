using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bus_Reservation
{
    class DbConnect
    {
        public MySqlConnection DatabaseConnect()
        {
            string connetionString = null;
            MySqlConnection connection;
            connetionString = @"server=localhost; userid=root;password='root';database=busreservation";
            connection = new MySqlConnection(connetionString);
            return connection;
        }
    }
    
    
    
}
