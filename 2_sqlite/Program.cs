// See https://aka.ms/new-console-templa te for more information

/*
 *  ADO.net
 *  Entity Framework
 **/


using System.Data.SQLite;

var connStr = "URI=file:app.db";
using var con = new SQLiteConnection(connStr);
con.Open();

using var  command = new SQLiteCommand("select * from product");
command.Connection = con;

var dr = command.ExecuteReader();
while (dr.Read())
{
    Console.WriteLine(dr["Name"] + ": " + dr["Price"]);

}


Console.WriteLine("Hello, World!");
