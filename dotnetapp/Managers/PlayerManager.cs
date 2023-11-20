using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dotnetapp.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
 
 
namespace dotnetapp.Managers
{
    public class PlayerManager
    {
        // Write your fuctions here...
        // DisplayAllPlayers
        // AddPlayer
        // EditPlayer
        // DeletePlayer
        // ListPlayers
        // FindPlayer
        // DisplayAllPlayers
 
        string conStr = "server=localhost; database=PlayerDb; uid=sa; password=examlyMssql@123";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        string str;
        SqlCommandBuilder build;
 
        public PlayerManager()
        {
            con = new SqlConnection(conStr);
            str = "select * from Player";
            da = new SqlDataAdapter(str, con);
            ds = new DataSet();
            build = new SqlCommandBuilder(da);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            da.Fill(ds, "dtPlayers");
        }
 
        public void DisplayAllPlayers()
        {
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }
        }
 
        public void AddPlayer()
        {
            // DataRow row = ds.Tables[0].NewRow();
            // row[1] = e.Name;
            // row[2] = e.Age;
            // row[3] = e.Category;
            // row[4] = e.BiddingPrice;
            // ds.Tables[0].Rows.Add(row);
            // da.Update(ds.Tables[0]);
        }
 
        public void EditPlayer(int id, Player e)
        {
            DataRow? row = ds.Tables[0].Rows.Find(id);
            if (row != null)
            {
                row[1] = e.Name;
                row[2] = e.Age;
                row[3] = e.Category;
                row[4] = e.BiddingPrice;
                da.Update(ds.Tables[0]);
                Console.WriteLine("Row updated");
            }
            else Console.WriteLine("Not found");
        }
 
        public void DeletePlayer(int id)
        {
            DataRow? row = ds.Tables[0].Rows.Find(id);
            if (row != null)
            {
                row.Delete();
                da.Update(ds.Tables[0]);
                Console.WriteLine("Row deleted");
            }
            else Console.WriteLine("Not found");
        }
 
        public void ListPlayers()
        {
 
        }
 
        public void FindPlayer(int id)
        {
            DataRow? row = ds.Tables[0].Rows.Find(id);
            if (row != null)
            {
                Console.WriteLine(row[0] + " " + row[1] + " " + row[2] + " " + row[3] + " " + row[4]);
            }
            else Console.WriteLine("Not found");
        }
 
 
        public void AddPlayerToDatabase(Player e)
        {
            DataRow row = ds.Tables[0].NewRow();
            row[1] = e.Name;
            row[2] = e.Age;
            row[3] = e.Category;
            row[4] = e.BiddingPrice;
            ds.Tables[0].Rows.Add(row);
            da.Update(ds.Tables[0]);
        }
    }
}