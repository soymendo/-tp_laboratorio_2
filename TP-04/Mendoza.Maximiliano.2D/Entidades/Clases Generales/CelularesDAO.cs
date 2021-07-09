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
    public class CelularesDAO
    {

        private SqlConnection sqlConnection;


        public CelularesDAO()
        {
            string connection = "Server=.;DataBase=Celular;Trusted_Connection=True;";
            this.sqlConnection = new SqlConnection(connection);
        }


        public void InsertarProducto(Celular producto)
        {

            try
            {
                string command = $"INSERT INTO Celulares(Producto,Modelo,Codigo,Carcaza,Bateria,Camara,Placa)" +
                $"VALUES(@Producto,@Modelo,@Codigo,@Carcaza,@Bateria,@Camara,@Placa)";

                SqlCommand sqlCommand = new SqlCommand(command, this.sqlConnection);




                if (producto is Alcatel)
                {
                    sqlCommand.Parameters.AddWithValue("Producto", Celular.ETipoCelular.Alcatel.ToString());
                    sqlCommand.Parameters.AddWithValue("Modelo", Celular.EModelo.s1.ToString());
                }
                if (producto is Huawei)
                {
                    sqlCommand.Parameters.AddWithValue("Producto", Celular.ETipoCelular.Huawei.ToString());
                    sqlCommand.Parameters.AddWithValue("Modelo", Celular.EModelo.P9Lite.ToString());
                }

                if (producto is Nokia)
                {
                    sqlCommand.Parameters.AddWithValue("Producto", Celular.ETipoCelular.Nokia.ToString());
                    sqlCommand.Parameters.AddWithValue("Modelo", Celular.EModelo.Plus.ToString());
                }

                if (producto is Motorola)
                {
                    sqlCommand.Parameters.AddWithValue("Producto", Celular.ETipoCelular.Motorola.ToString());
                    sqlCommand.Parameters.AddWithValue("Modelo", Celular.EModelo.MotoE7.ToString());
                }

                if (producto is Samsumg)
                {
                    sqlCommand.Parameters.AddWithValue("Producto", Celular.ETipoCelular.Samsumg.ToString());
                    sqlCommand.Parameters.AddWithValue("Modelo", Celular.EModelo.Galaxy.ToString());
                }





                sqlCommand.Parameters.AddWithValue("Codigo", producto.CodigoDeBarras);
                sqlCommand.Parameters.AddWithValue("Carcaza", producto.MateriaPrima.Carcaza.ToString());
                sqlCommand.Parameters.AddWithValue("Bateria", producto.MateriaPrima.Bateria.ToString());
                sqlCommand.Parameters.AddWithValue("Camara", producto.MateriaPrima.Camara.ToString());
                sqlCommand.Parameters.AddWithValue("Placa", producto.MateriaPrima.Placa.ToString());

                this.sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null && this.sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    this.sqlConnection.Close();
                }

            }
        }

        public void Borrar(int codigo)
        {
            try
            {
                string sentencia = "DELETE FROM Celulares where Codigo=@Codigo";
                SqlCommand sqlCommand = new SqlCommand(sentencia, sqlConnection);
                sqlCommand.Parameters.AddWithValue("Codigo", codigo);
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            finally
            {
                if (sqlConnection != null && sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
            }
        }


        public List<Celular> Leer()
        {
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
                    materiaPrima.ECarcaza carcaza= (materiaPrima.ECarcaza)Enum.Parse(typeof(materiaPrima.ECarcaza),sqlDataReader["Carcaza"].ToString());
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









        public List<Celular> LeerTestUnitario()
        {
            try
            {
                string sentencia = "SELECT * FROM Celulares9";
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
