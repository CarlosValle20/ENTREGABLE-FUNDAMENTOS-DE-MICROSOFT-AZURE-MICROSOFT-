using System;
using System.Data;

namespace webCinestar_WebForms_202620.Models
{
    public class Cine
    {
        public int id { get; set; }
        public string RazonSocial { get; set; }
        public int Salas { get; set; }
        public int idDistrito { get; set; }
        public string Direccion { get; set; }
        public string Telefonos { get; set; }
        public string Detalle { get; set; }

        public Cine() { }

        public Cine(DataRow dr)
        {
            id = int.Parse(dr["id"].ToString());
            RazonSocial = dr["RazonSocial"].ToString();
            Salas = int.Parse(dr["Salas"].ToString());
            idDistrito = int.Parse(dr["idDistrito"].ToString());
            Direccion = dr["Direccion"].ToString();
            Telefonos = dr["Telefonos"].ToString();
            Detalle = dr["Detalle"].ToString();
        }
    }
}