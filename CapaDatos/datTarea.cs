﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class datTarea
    {
        private readonly static datTarea _instancia = new datTarea();
        public static datTarea Instancia
        {
            get { return datTarea._instancia; }
        }
        //Lista tareas
        public List<entTarea> listarTareas(int id_req)
        {
            List<entTarea> lista = new List<entTarea>();
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaTareas", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", id_req);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entTarea p = new entTarea();
                    p.id_req = Convert.ToInt32(dr["id_req"]);
                    p.id_etapa = Convert.ToInt32(dr["id_etapa"]);
                    p.nombre_t = dr["estado"].ToString();
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado_tarea = Convert.ToInt32(dr["estado_tarea"]);
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
            return lista;
        }


        // Lista Tarea por DNI
        public List<entTarea> listarTareasDesarrollador(string dni)
        {
            List<entTarea> lista = new List<entTarea>();
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spListaTareasDni ", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_proy", dni);
                cn.Open();
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    entTarea p = new entTarea();
                    p.id_req = Convert.ToInt32(dr["id_req"]);
                    p.id_etapa = Convert.ToInt32(dr["id_etapa"]);
                    p.nombre_t = dr["estado"].ToString();
                    p.descripcion = dr["descripcion"].ToString();
                    p.estado_tarea = Convert.ToInt32(dr["estado_tarea"]);
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
            return lista;
        }

        //Inserta tarea
        public void insertaTarea(entTarea et)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInsertaTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_req", et.id_req);
                cm.Parameters.AddWithValue("@id_etapa", et.id_etapa);
                cm.Parameters.AddWithValue("@nombre_T", et.nombre_t);
                cm.Parameters.AddWithValue("@descripcion", et.descripcion);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }
        //Modifica tarea
        public void modificaTarea(entTarea et)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spEditaTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_tarea", et.id_tarea);
                cm.Parameters.AddWithValue("@id_etapa", et.id_etapa);
                cm.Parameters.AddWithValue("@nombre_t", et.nombre_t);
                cm.Parameters.AddWithValue("@descripcion", et.descripcion);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }

        // Modifica estado tarea
        public void modificaEstadoTarea(entTarea et)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spEditaTareaEstado", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_tarea ", et.id_tarea);
                cm.Parameters.AddWithValue("@estado_tarea ", et.estado_tarea);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }

        //Inhabilita tarea
        public void inhabilitaTarea(int id_tarea)
        {
            SqlCommand cm = null;
            try
            {
                SqlConnection cn = Conexion.Instancia.conexion();
                cm = new SqlCommand("spInhabilitaTarea", cn);
                cm.CommandType = System.Data.CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@id_tarea", id_tarea);
                cn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cm.Connection.Close();
            }
        }
    }
}
