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
        //public List<UserModel> Listar()
        //{
        //    var oLista = new List<UserModel>();

        //    var con = new Conexion();

        //    NpgsqlCommand com = new NpgsqlCommand("fn_Consultar", con.OpenCon());
        //    com.CommandType = CommandType.StoredProcedure;

        //    using (var dr = com.ExecuteReader())
        //    {
        //        while (dr.Read())
        //        {
        //            oLista.Add(new UserModel()
        //            {

        //                IdAlumno = Convert.ToInt32(dr["id_alumno"]),
        //                Nombre = dr["nombre"].ToString(),
        //                Ciudad = dr["ciudad"].ToString(),
        //                Edad = Convert.ToInt32(dr["edad"].ToString())
        //            });
        //        }
        //    }
        //    return oLista;
        //}

        public bool Guardar(UserModel oAlumno)
        {
            bool flag = false;
            var con = new Conexion();

            string spguardar = "CALL guardar_usuario (" + oAlumno.nombre + ",'" + oAlumno.apellidop + "','" + oAlumno.apellidom + "'," + oAlumno.edad + "'," + oAlumno.email + "'," + oAlumno.passw + ")";
            NpgsqlCommand com = new NpgsqlCommand(spguardar, con.OpenCon());
            com.ExecuteNonQuery();
            flag = true;
            con.CloseCon();
            return flag;
        }

    //    public UserModel Obtener(int IdAlumno)
    //    {
    //        var oAlumno = new UserModel();

    //        var cn = new Conexion();

    //        NpgsqlCommand cmd = new NpgsqlCommand("fn_Obtener", cn.OpenCon());
    //        cmd.Parameters.AddWithValue("id_alumno", IdAlumno);
    //        cmd.CommandType = CommandType.StoredProcedure;

    //        using (var dr = cmd.ExecuteReader())
    //        {
    //            while (dr.Read())
    //            {
    //                oAlumno.IdAlumno = Convert.ToInt32(dr["id_alumno"]);
    //                oAlumno.Nombre = dr["nombre"].ToString();        
    //                oAlumno.Ciudad = dr["ciudad"].ToString();
    //                oAlumno.Edad  = Convert.ToInt32(dr["edad"]);
    //            }
    //        }
    //        return oAlumno;
    //    }

    //    public bool Editar(UserModel oAlumno)
    //    {
    //        bool flag = false;
    //        var con = new Conexion();

    //        string editar = "CALL sp_Editar (" + oAlumno.IdAlumno + ",'" + oAlumno.Nombre + "','" + oAlumno.Ciudad + "'," + oAlumno.Edad + ")";
    //        NpgsqlCommand com = new NpgsqlCommand(editar, con.OpenCon());
    //        com.ExecuteNonQuery();
    //        flag = true;
    //        con.CloseCon();
    //        return flag;
    //    }

    //    public bool Eliminar(int idAlumno)
    //    {
    //        bool flag;
    //        var con = new Conexion();

    //        string sql = "CALL sp_Eliminar (" + idAlumno + ")";
    //        NpgsqlCommand com = new NpgsqlCommand(sql, con.OpenCon());
    //        com.ExecuteNonQuery();
    //        flag = true;
    //        con.CloseCon();
    //        return flag;
    //    }

    //    public int Validar(string l_usuario, string l_passw)
    //    {
    //        int band = 0;
    //        var cn = new Conexion();

    //        NpgsqlCommand cmd = new NpgsqlCommand("fn_validar", cn.OpenCon());
    //        cmd.Parameters.AddWithValue("p_usuario", l_usuario);
    //        cmd.Parameters.AddWithValue("p_passw", l_passw);
    //        cmd.CommandType = CommandType.StoredProcedure;

    //        using (var dr = cmd.ExecuteReader())
    //        {
    //            while (dr.Read())
    //            {
    //                band = Convert.ToInt32(dr["bandera"]);
    //            }
    //        }
    //        return band;
    //    }
    }
}
