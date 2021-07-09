using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;


using Entidades.Clases_Generales;
using Entidades.Interfaces;
using Entidades.Clases_Especializadas;
using Entidades.Exepciones;



namespace Entidades.Clases_Generales
{
    public static class Extensora
    {
        private static SqlConnection sqlConnection;
        public static List<Celular> MostrarBD(this CelularesDAO C)
        {
            string connection = "Server=.;DataBase=Celular;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connection);


            try
            {
                string sentencia = "SELECT * FROM Celulares";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                List<Celular> productos = new List<Celular>();
                Alcatel al;
                Huawei hu;
                Nokia no;
                Motorola mo;
                Samsumg sam;

                while (sqlDataReader.Read())
                {

                    string tipo = sqlDataReader["Producto"].ToString();


                    int codigo = Convert.ToInt32(sqlDataReader["Codigo"]);
                    //     (tuEnumerado)Enum.Parse(typeof(tuEnumerado), reader["Titulo"].ToString()),
                    materiaPrima.ECarcaza carcaza = (materiaPrima.ECarcaza)Enum.Parse(typeof(materiaPrima.ECarcaza), sqlDataReader["Carcaza"].ToString());
                    materiaPrima.EBateria bateria = (materiaPrima.EBateria)Enum.Parse(typeof(materiaPrima.EBateria), sqlDataReader["Bateria"].ToString());
                    materiaPrima.ECamara camara = (materiaPrima.ECamara)Enum.Parse(typeof(materiaPrima.ECamara), sqlDataReader["Camara"].ToString());
                    materiaPrima.EPlaquetaElectronica placa = (materiaPrima.EPlaquetaElectronica)Enum.Parse(typeof(materiaPrima.EPlaquetaElectronica), sqlDataReader["Placa"].ToString());

                    //Celular producto = new Celular(codigo, carcaza, bateria, camara, placa);

                    if (tipo == "Alcatel")
                    {

                        al = new Alcatel(codigo, carcaza, bateria, camara, placa);
                        productos.Add(al);
                    }

                    if (tipo == "Huawei")
                    {
                        hu = new Huawei(codigo, carcaza, bateria, camara, placa);
                        productos.Add(hu);
                    }

                    if (tipo == "Nokia")
                    {
                        no = new Nokia(codigo, carcaza, bateria, camara, placa);
                        productos.Add(no);
                    }

                    if (tipo == "Motorola")
                    {
                        mo = new Motorola(codigo, carcaza, bateria, camara, placa);
                        productos.Add(mo);
                    }

                    if (tipo == "Samsumg")
                    {
                        sam = new Samsumg(codigo, carcaza, bateria, camara, placa);
                        productos.Add(sam);
                    }
                    //productos.Add(producto);
                }
                return productos;
            }
            catch (Exception ex)
            {
                throw new BaseDeDatosException("Ocurrió un error al tratar de leer la lista de celulares de la Base de Datos.", ex);
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }


        }
    }
}
