using System;
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

            //Creamos un adaptador del tipo SQLDataAdapter y
            //Le indicamos el command text que utilizará para realizar la consulta
            //y el objeto sqlconnection que utiliza
            SqlDataAdapter myadap =
                new SqlDataAdapter("SELECT CustomerID, CompanyName FROM Customers", myconn);

            //Abro la conexion
            myconn.Open();
            //Cargo el contenido del result set obtenido de la base
            //de datos en el objeto datatable
            myadap.Fill(dtEmpresas);
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

            //Primero indico el CustomerID que deseo modificar
            Console.Write("Escriba el CustomerID que desea modificar: ");
            string custid = Console.ReadLine();

            //Luego me traigo una coleccion de datarows que contengan ese CustomerID
            DataRow[] rwEmpresas = dtEmpresas.Select("CustomerID = '" + custid + "'");
            if (rwEmpresas.Length != 1) //Si no encuentro nada entonces salgo
            {
                Console.WriteLine("CustomerID no encontrado");
                Console.ReadLine();
                return;
            }

            //Me traigo el primer datarow de la colección
            DataRow rowMiEmpresa = rwEmpresas[0];
            string nombreActual = rowMiEmpresa["CompanyName"].ToString();
            //Muestro en consola el nombre del CustomerID seleccionado
            Console.WriteLine("Nombre actual de la empresa: " + nombreActual);
            //Solicito que escriba un nuevo nombre
            Console.Write("Escriba el nuevo nombre: ");
            string nuevoNombre = Console.ReadLine();

            //Llamo al método BeginEdit del datarow para iniciar los cambios
            rowMiEmpresa.BeginEdit();
            //Modifico el valor del campo CompanyName
            rowMiEmpresa["CompanyName"] = nuevoNombre;
            //Finalizo la edicion llamando al método EndEdit()
            rowMiEmpresa.EndEdit();

            //Ahora creo un objeto Command que utilizare para
            //guardar los cambios en la base de datos
            SqlCommand updCommand = new SqlCommand();
            //Le indico la conexion
            updCommand.Connection = myconn;
            //Le indico la cadena TSQL
            updCommand.CommandText =
                "UPDATE Customers SET CompanyName = @CompanyName WHERE CustomerID = @CustomerID";
            //Indico los parametros que estoy utilizando.
            //Como asi tambien, el tipo de dato, la longitud del dato
            //el nombre del campo del datatable
            updCommand.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 50, "CompanyName");
            updCommand.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 5, "CustomerID");

            //Ahora adjunto el objeto updCommand al DataAdapter
            myadap.UpdateCommand = updCommand;
            //Por último llamo al método .Update del DataAdapter
            myadap.Update(dtEmpresas);
        }
    }
}
