using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto.Capadedatos
{
    internal class nacionalidades
    {
        public static readonly string connectionString = "
            ";

        public  DataTable ListaNacionalidades()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarNacionalidadesAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }
        public DataTable ListaIdiomas()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarIdiomaAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }
        public DataTable ListaGeneros()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarGenerosAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }
        public DataTable ListaArtistas()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarArtistasAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }
        public DataTable ListaCargarDisqueraAlbum()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarAlbumDisquerasAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }
        public DataTable ListaCargarTemaAlbum()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarAlbumTemaAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }

        public DataTable ListaCargarUsuarios()
        {
            DataTable Tabla = new DataTable();
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                try
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("ListarUsuariosAsc", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlDataReader LeerFilas = cmd.ExecuteReader();
                        Tabla.Load(LeerFilas);
                        LeerFilas.Close();
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
            return Tabla;
        }

    }
}
    

