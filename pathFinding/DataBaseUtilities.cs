using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace pathFinding
{
    class DataBaseUtilities
    {
        
        string mmeDatabase = @"\Resources\data-v1.11p.mdb";
        OleDbConnection database_connection = null;
        System.Reflection.Assembly exe = System.Reflection.Assembly.GetEntryAssembly();
       
        public DataTable queryDataBaseForTableInformation(string tableName)
        {
            string sSql = "";
            DataTable data_table = null;


            sSql = "SELECT * FROM " + tableName;

            OleDbDataAdapter database_adapter = new OleDbDataAdapter(sSql, database_connection);
            DataSet data_set = new DataSet();

            database_adapter.Fill(data_set);

            data_table = data_set.Tables[0];


            return data_table;

        }

        public bool connectToDatabase(string inputFileName)
        {
            string filePath = System.IO.Path.GetDirectoryName(exe.Location);

            bool connected = false;
            // Create the connection to the mme database file.
            if (inputFileName == "")
            {
                inputFileName = filePath + mmeDatabase;
            }


            string connection_string = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + inputFileName;
            // setup the connection to the database
            database_connection = new OleDbConnection(connection_string);

            database_connection.Open();
            connected = true;



            return connected;
        }

        public DataRow queryRoomDataBaseForRoomInformation(int map, int room)
        {
            DataRow dr_data = null;

            if (database_connection.State == ConnectionState.Open)
            {

                string searchRoom = "SELECT * FROM Rooms WHERE `Map Number` = " + map + " AND `Room Number` = " + room;
                OleDbDataAdapter database_adapter = new OleDbDataAdapter(searchRoom, database_connection);
                DataSet data_set = new DataSet();

                database_adapter.Fill(data_set);

                DataTable data_table = data_set.Tables[0];


                if (data_table.Rows.Count >= 1)
                {
                    dr_data = data_table.Rows[0];
                }
            }
            else
            {
                dr_data = null;
            }
            return dr_data;

        }
    }
}
