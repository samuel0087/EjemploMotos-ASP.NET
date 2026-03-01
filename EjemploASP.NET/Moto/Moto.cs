using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Moto
    {
        public int IdMoto { get; set; }
        public string Marca {  get; set; }
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public string Color { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public bool Usado {  get; set; }
        public bool Importado { get; set; }
    }

    public class MotoNegocio
    {
        public List<Moto> listar()
        {
            List<Moto> lista = new List<Moto>();

            Moto moto1 = new Moto();
            moto1.IdMoto = 1;
            moto1.Marca = "Motomel";
            moto1.Modelo = "S2 150cc";
            moto1.Descripcion = "Moto 150 mas confiable del mercado";
            moto1.Color = "Rojo";
            moto1.FechaFabricacion = new DateTime(2023, 08, 12);
            moto1.Usado = false;
            moto1.Importado = false;

            Moto moto2 = new Moto();
            moto2.IdMoto = 2;
            moto2.Marca = "Zanella";
            moto2.Modelo = "Patagonio Shadow 250v";
            moto2.Descripcion = "Moto con mas estilo del segmento";
            moto2.Color = "Negro";
            moto2.FechaFabricacion = new DateTime(2018, 12, 09);
            moto2.Usado = true;
            moto2.Importado = false;

            Moto moto3 = new Moto();
            moto3.IdMoto = 3;
            moto3.Marca = "Royal Enfield";
            moto3.Modelo = "Hunter 350cc";
            moto3.Descripcion = "Moto naked estilo retro";
            moto3.Color = "Gris";
            moto3.FechaFabricacion = new DateTime(2026, 07, 07);
            moto3.Usado = false;
            moto3.Importado = true;

            lista.Add(moto1);
            lista.Add(moto2);
            lista.Add(moto3);

            return lista;
        }
    }
}
