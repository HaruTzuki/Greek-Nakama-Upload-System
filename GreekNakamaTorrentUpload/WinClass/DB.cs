using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreekNakamaTorrentUpload.WinClass
{
    static public class DB
    {
        //Variables
        //This is the variables that load from file
        static private string _serverName { get; set; }
        static private string _usernamer { get; set; }
        static private string _password { get; set; }
        static private string _port { get; set; }
        static private string _databaseName { get; set; }
        //This is the Connection String for connection
        static public OdbcConnection Cn = new OdbcConnection();
        static public string ConnectionString = null;


        //Methods
        static public void Connect()
        {
            ConnectionString = "Provider=MSDASQL.1;Driver={MySQL ODBC 5.3 UNICODE Driver};"
            + ";Server=" + _serverName +
            ";Port=" + _port +
            ";Database=" + _databaseName +
            ";User=" + _usernamer +
            ";Password=" + _password +
            ";Option=3;";

            try
            {
                if (Cn == null)
                {
                    Cn = new OdbcConnection();
                }
                if (Cn.State != ConnectionState.Open)
                {
                    Cn.ConnectionString = ConnectionString;
                    Cn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        static public void InitializeCredetials()
        {
            string line; //Helper Variable that keeps the every in from Stream
            string buffer; //Helper Varieble that help us to load the substring
            string[] cred = new string[5]; // 0 - 4
            int counter = 0;

            //This is the method that load from file (config.txt)
            using (StreamReader credetials = new StreamReader("config.txt"))
            {
                while ((line = credetials.ReadLine()) != null)
                {
                    if (line.StartsWith("#") || string.IsNullOrEmpty(line)) //If line start with "#" or is empty skip it
                    {
                        continue;
                    }
                    else //else do this block
                    {
                        if (counter == 5) break; //Our Credentials need to be four.
                        buffer = line.Substring(16); //SubString help us to skill the first 16 characters from our file
                        Console.WriteLine(buffer); //For Debug
                        cred[counter] = buffer.Trim('\''); //Trim the ' characters and put it to the array
                        counter++; //Increse the counter
                    }
                }

                //put to our credentials variables the loads
                _serverName = cred[0];
                _usernamer = cred[1];
                _password = cred[2];
                _port = cred[3];
                _databaseName = cred[4];
            }

        }

        static public string PrintCredetials()
        {
            return 
                "Server Name : " + _serverName + Environment.NewLine + 
                "Username : " + _usernamer + Environment.NewLine + 
                "Password : " + _password + Environment.NewLine + 
                "Port : " + _port + Environment.NewLine + 
                "Database : " + _databaseName;
        }

    }
}
