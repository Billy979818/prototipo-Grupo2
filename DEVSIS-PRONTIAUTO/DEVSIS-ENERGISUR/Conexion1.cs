using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using DEVSIS_ENERGISUR.prontiautoDataSetTableAdapters;

namespace DEVSIS_ENERGISUR
{
    class Conexion1
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public Conexion1()
        {
            try
            {
                cn = new SqlConnection("Data Source=EDISON-LAPTOP;Initial Catalog=prontiauto;Persist Security Info=True;User ID=sa;Password=123456");
                cn.Open();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se conecto a la base:" + ex.ToString());
                cn.Close();
            }
        }
        public string InsertarCliente(string nombres, int cedula, string fecha_na, string celular, string direccion, string email)
        {
            //cn.Open();
            string salida = "conexion exitosa";
            MessageBox.Show("Cliente registrado exitosamente");
            try
            {
                cmd = new SqlCommand("Insert into CLIENTES(NOMBRES,CEDULA,FECHA_NAC,CELULAR,DIRECCION,EMAIL)VALUES('" + nombres + "'," + cedula + ",'" + fecha_na + "'," +
                    "'" + celular + "','" + direccion + "','" + email + "')", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "No se conecto: " + ex.ToString();
                cn.Close();
            }
            return salida;
        }

        public int personaRegistrada(int cedula)
        {
            //cn.Open();
            int contador = 0;
            try
            {
                cmd = new SqlCommand("select *from CLIENTES WHERE CEDULA =" + cedula + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente ya se encuentra registrado" + ex.ToString());
            }
            return contador;
        }

            public void mostrarN(string nombres, DataGridView datos)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM CLIENTES WHERE NOMBRES = '"+nombres+"'",cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("El cliente no se encuentra registrado en el sistema");
            }
        }
        public void mostrarC(int cedula, DataGridView datos)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM CLIENTES WHERE CEDULA = " + cedula + "", cn);
                dt = new DataTable();
                da.Fill(dt);
                datos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no se encuentra registrado en el sistema");
                cn.Close();
            }
        }
    }
}

    
