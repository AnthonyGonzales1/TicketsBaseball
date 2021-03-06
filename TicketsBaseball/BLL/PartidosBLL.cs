﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data;

namespace TicketsDeportivos.BLL
{
    public class PartidosBLL
    {
        public static bool Guardar(Partido partido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Partidos.Add(partido) != null)
                {
                    contexto.SaveChanges();
                    contexto.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.Partidos.Find(Id);
                if (eliminar != null)
                {
                    contexto.Entry(eliminar).State = EntityState.Deleted;
                    if (contexto.SaveChanges() > 0)
                    {
                        contexto.Dispose();
                        paso = true;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Partido partido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(partido).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Partido Buscar(int id)
        {
            Partido partido = new Partido();
            Contexto contexto = new Contexto();
            try
            {

                partido = contexto.Partidos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return partido;
        }

        public static void AumentarCantidad(List<PartidoDetalle> detalles)
        {
            foreach (var item in detalles)
            {
                var partido = BLL.PartidosBLL.Buscar(item.Id);

                partido.CantidadDisponible += item.CantidadDisponible;
                BLL.PartidosBLL.Modificar(partido);
            }
        }

        public static void RebajarCantidad(List<PartidoDetalle> detalles)
        {
            foreach (var item in detalles)
            {
                var partido = BLL.PartidosBLL.Buscar(item.Id);
                
                partido.CantidadDisponible -= item.CantidadDisponible;
                BLL.PartidosBLL.Modificar(partido);
            }
        }

        public static List<Partido> GetList(Expression<Func<Partido, bool>> parti)
        {
            List<Partido> partidos = new List<Partido>();
            Contexto contexto = new Contexto();
            try
            {
                partidos = contexto.Partidos.Where(parti).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return partidos;
        }
    }
}