using System;
using WebAppCRUD1.Models;
using Npgsql;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCRUD1.Datos
{
    public class UserDatos
    {
        public List<UserModel> Listar()
        {
            var oLista = new List<UserModel>();

            var con = new Conexion();

            NpgsqlCommand com = new NpgsqlCommand("fn_consultar", con.OpenCon());
            com.CommandType = CommandType.StoredProcedure;

            using (var dr = com.ExecuteReader())
            {
                while (dr.Read())
                {
                    oLista.Add(new UserModel()
                    {
                        nombre = dr["nombre"].ToString(),
                        apellidop = dr["apellidop"].ToString(),
                        apellidom = dr["apellidom"].ToString(),
                        edad = Convert.ToInt32(dr["edad"]),
                        email = dr["apellidom"].ToString(),
                        passw = dr["apellidom"].ToString(),
                        vali = Convert.ToBoolean(dr["vali"]),
                        u_id = Convert.ToInt32(dr["u_id"])
                    });
                }
            }
            return oLista;
        }

        public bool Guardar(UserModel oAlumno)
        {
            bool flag = false;
            var con = new Conexion();
            string spguardar = "CALL guardar_usuario (" + "'" + oAlumno.nombre + "','" + oAlumno.apellidop + "','" + oAlumno.apellidom + "'," + oAlumno.edad + ",'" + oAlumno.email + "','" + oAlumno.passw + "'," + "TRUE" + ")";
            NpgsqlCommand com = new NpgsqlCommand(spguardar, con.OpenCon());
            com.ExecuteNonQuery();
            flag = true;
            con.CloseCon();
            return flag;
        }

        public UserModel Obtener(int IdAlumno)
        {
            var oAlumno = new UserModel();

            var cn = new Conexion();

            NpgsqlCommand cmd = new NpgsqlCommand("fn_Obtener", cn.OpenCon());
            cmd.Parameters.AddWithValue("u_id", IdAlumno);
            cmd.CommandType = CommandType.StoredProcedure;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    oAlumno.nombre = dr["nombre"].ToString();
                    oAlumno.apellidop = dr["apellidop"].ToString();
                    oAlumno.apellidom = dr["apellidom"].ToString();
                    oAlumno.edad = Convert.ToInt32(dr["edad"]);
                    oAlumno.email = dr["apellidom"].ToString();
                    oAlumno.passw = dr["apellidom"].ToString();
                    oAlumno.vali = Convert.ToBoolean(dr["vali"]);
                    oAlumno.u_id = Convert.ToInt32(dr["u_id"]);

                }
            }
            return oAlumno;
        }

        public bool Editar(UserModel oAlumno)
        {
            bool flag = false;
            var con = new Conexion();

            string editar = "CALL user_edit ('" + oAlumno.nombre + "','" + oAlumno.apellidop + "','" + oAlumno.apellidom + "'," + oAlumno.edad + ",'" + oAlumno.email + "','" + oAlumno.passw + "'," + oAlumno.u_id + ")";
            NpgsqlCommand com = new NpgsqlCommand(editar, con.OpenCon());
            com.ExecuteNonQuery();
            flag = true;
            con.CloseCon();
            return flag;
        }

        public bool Eliminar(int u_id)
        {
            bool flag;
            var con = new Conexion();

            string sql = "CALL user_del (" + u_id + ")";
            NpgsqlCommand com = new NpgsqlCommand(sql, con.OpenCon());
            com.ExecuteNonQuery();
            flag = true;
            con.CloseCon();
            return flag;
        }

        public int Validar(string lg_email, string lg_passw)
        {
            int band = 0;
            var cn = new Conexion();

            NpgsqlCommand cmd = new NpgsqlCommand("fn_validar", cn.OpenCon());
            cmd.Parameters.AddWithValue("lg_email", lg_email);
            cmd.Parameters.AddWithValue("lg_passw", lg_passw);
            cmd.CommandType = CommandType.StoredProcedure;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    band = Convert.ToInt32(dr["bandera"]);
                }
            }
            return band;
        }

        public int Valiadmin(string lg_email, string lg_passw, bool lg_vali)
        {
            int band = 0;
            var cn = new Conexion();

            NpgsqlCommand cmd = new NpgsqlCommand("fn_admin", cn.OpenCon());
            cmd.Parameters.AddWithValue("lg_email", lg_email);
            cmd.Parameters.AddWithValue("lg_passw", lg_passw);
            cmd.Parameters.AddWithValue("lg_vali", lg_vali);

            cmd.CommandType = CommandType.StoredProcedure;

            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    band = Convert.ToInt32(dr["admin_vali"]);
                }
            }
            return band;
        }

        public bool AddCursos(CursosModel oAlumnocursos)
        {
            bool flag = false;
            var con = new Conexion();
            string spguardar = "CALL insert_course (" + "'" + oAlumnocursos.nombre_c + "','" + oAlumnocursos.descripcion + "','" + oAlumnocursos.email +  "')";
            NpgsqlCommand com = new NpgsqlCommand(spguardar, con.OpenCon());
            com.ExecuteNonQuery();
            flag = true;
            con.CloseCon();
            return flag;
        }
    }
}
