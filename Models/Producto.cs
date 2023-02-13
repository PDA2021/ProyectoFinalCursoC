using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_proyecto_Final_PabloArias
{
    public class Producto
    {

        public long id;
        public string descripciones;
        public decimal costo;
        public decimal precioVenta;
        public int stock;
        public long IdUsuario;


        public long Id { get => id; set => id = value; }
        public string Descripciones { get => descripciones; set => descripciones = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public decimal PrecioVenta { get => precioVenta; set => precioVenta = value; }
        public int Stock { get => stock; set => stock = value; }
        public long IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }

        public Producto(long id, string descripciones, decimal costo, decimal precioVenta, int stock, long idUsuario)
        {
            this.id = id;
            this.descripciones = descripciones;
            this.costo = costo;
            this.precioVenta = precioVenta;
            this.stock = stock;
            IdUsuario = idUsuario;
        }

        public Producto()
        {
        }
    }

}

