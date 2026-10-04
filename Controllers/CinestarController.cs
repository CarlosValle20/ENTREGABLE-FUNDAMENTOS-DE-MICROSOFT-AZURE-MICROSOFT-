using System.Data;
using System.Collections.Generic;
using webCinestar_WebForms_202620.Models;

namespace webCinestar_WebForms_202620.Controllers
{
    public class CinestarController
    {
        Db db = new Db("cnCineStar");

        internal DataTable getCines()
        {
            db.Sentencia("sp_getCines");
            return db.getDataTable();
        }

        internal DataTable getCine(string id)
        {
            db.Sentencia("sp_getCine " + id);
            return db.getDataTable();
        }

        internal DataTable getCineTarifas(string id)
        {
            db.Sentencia("sp_getCineTarifas " + id);
            return db.getDataTable();
        }

        internal DataTable getCinePeliculas(string id)
        {
            db.Sentencia("sp_getCinePeliculas " + id);
            return db.getDataTable();
        }

        internal DataTable getPeliculas(string id)
        {
            db.Sentencia("sp_getPeliculas " + id);
            return db.getDataTable();
        }

        internal DataTable getPelicula(string id)
        {
            db.Sentencia("sp_getPelicula " + id);
            return db.getDataTable();
        }
        internal List<Cine> getCinesList()
        {
            db.Sentencia("sp_getCines");
            DataTable dt = db.getDataTable();
            if (dt == null) return null;

            List<Cine> cines = new List<Cine>();
            foreach (DataRow dr in dt.Rows)
                cines.Add(new Cine(dr));

            return cines;
        }

        internal List<Pelicula> getPeliculasList(string id)
        {
            db.Sentencia("sp_getPeliculas " + (id == "cartelera" ? 1 : 2));
            DataTable dt = db.getDataTable();
            if (dt == null) return null;

            List<Pelicula> peliculas = new List<Pelicula>();
            foreach (DataRow dr in dt.Rows)
                peliculas.Add(new Pelicula(dr));

            return peliculas;
        }
    }
}