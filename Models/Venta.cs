using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_proyecto_Final_PabloArias
{
   public class Venta
    {
        public long id;
        public string comentarios;
        public long idusuario;


        public long Id { get => id; set => id = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public long Idusuario { get => idusuario; set => idusuario = value; }

        public Venta(long id, string comentarios, long idusuario)
        {
            this.id = id;
            this.comentarios = comentarios;
            this.idusuario = idusuario;
        }

        public Venta()
        {
        }
    }
}
