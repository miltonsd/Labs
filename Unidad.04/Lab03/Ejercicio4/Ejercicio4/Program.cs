﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un objeto DataTable llamado Empresas
            DataTable dtEmpresas = new DataTable("Empresas");
            //Al objeto DataTable le agrego dos datacolumns del tipo string
            dtEmpresas.Columns.Add("CustomerID", typeof(string));
            dtEmpresas.Columns.Add("CompanyName", typeof(string));

            //Creamos un objeto SQLConnection
            SqlConnection myconn = new SqlConnection();
            //Indicamos el Connection String que utilizará
            myconn.ConnectionString =
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";

            //Creo un objeto SQLCommand
            SqlCommand mycomando = new SqlCommand();
            //Le indico la cadena TSQL que utilizará
            mycomando.CommandText = "SELECT CustomerID, CompanyName FROM Customers";
            //Indico el objeto connection que utilizará
            mycomando.Connection = myconn;

            //Creamos un adaptador del tipo SQLDataAdapter y
            //Le indicamos el command text que utilizará para realizar la consulta
            //y el objeto sqlconnection que utiliza
            SqlDataAdapter myadap =
                new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            //Abro la conexion
            myconn.Open();
            //Creo un objeto DataReader y ejecuto el método
            //ExecuteReader del objeto mycomando
            SqlDataReader mydr = mycomando.ExecuteReader();
            //Cargo los datos en el datatable utilizando el objeto DataReader
            dtEmpresas.Load(mydr);
            //Cierro la conexion
            myconn.Close();

            //Recorro la lista de empresas obtenidas
            //y lo muestro en consola
            Console.WriteLine("Listado de Empresas: ");
            foreach (DataRow rowEmpresa in dtEmpresas.Rows)
            {
                string idempresa = rowEmpresa["CustomerID"].ToString();
                string nombreempresa = rowEmpresa["CompanyName"].ToString();
                Console.WriteLine(idempresa + " - " + nombreempresa);
            }
            Console.ReadLine();
        }
    }
}
