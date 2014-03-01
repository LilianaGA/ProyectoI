using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica1.Models
{
    public class Reco
    {
        public int id_recomendaciones { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public string comentario { get; set; }
    }
}