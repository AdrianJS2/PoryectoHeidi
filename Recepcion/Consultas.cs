using MySql.Data.MySqlClient;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcion
{
    internal class Consultas
    {
        MySqlConnection conex;
        public void conectar()
        {
            string server = "localhost";
            string database = "recepcionDB";
            string user = "root";
            string pwd = " ";
            string cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd + ";";

            conex = new MySqlConnection(cadenaConexion);

        }
        public void cerrar()
        {
            conex.Close();
        }

        public void agregar(string nombre, string correo, string telefono, string fecha)
        {

            string consulta = "INSERT INTO `personas` (`id_nombre`, `Nombre`, `Correo`, `telefono`,`Fechas`) VALUES (NULL, '" + nombre + "', '" + correo + "', '" + telefono + "', '" + fecha + "')";
            conectar();
            conex.Open();
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            MySqlDataReader ejecuta;
            ejecuta = comando.ExecuteReader();
            cerrar();
        }

        public MySqlDataReader leer()
        {
            string consulta = "SELECT id_nombre, Nombre, Correo, telefono, Fechas FROM `personas`;";
            conectar();
            conex.Open();
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            return comando.ExecuteReader();

        }

        public MySqlDataReader busca(string buscar)
        {
            string consulta = "SELECT id_nombre, Nombre, Correo, telefono, Fechas FROM `personas` WHERE Nombre LIKE '%" + buscar + "%';";
            conectar();
            conex.Open();
            MySqlCommand comando = new MySqlCommand(consulta, conex);
            return comando.ExecuteReader();

        }

        public void modificar(int id, string nombre, string correo, string telefono, string fecha)
        {

            try
            {
                string consulta = "UPDATE `personas` SET Nombre = '" + nombre + "', Correo = '" + correo + "', telefono = '" + telefono + "', Fechas = '" + fecha + "' WHERE id_nombre = '" + id + "';'";
                conectar();
                conex.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conex);
                MySqlDataReader ejecuta;
                ejecuta = comando.ExecuteReader();
                cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

