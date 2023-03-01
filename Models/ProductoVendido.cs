using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_proyecto_Final_PabloArias
{
    public class ProductoVendido
    {
        public long id;
        public int stock;
        public long idproducto;
        public long idventa;


        public long Id { get => id; set => id = value; }
        public int Stock { get => stock; set => stock = value; }
        public long Idproducto { get => idproducto; set => idproducto = value; }
        public long Idventa { get => idventa; set => idventa = value; }

        public ProductoVendido(long id, int stock, long idproducto, long idventa)
        {
            this.id = id;
            this.stock = stock;
            this.idproducto = idproducto;
            this.idventa = idventa;
        }

        public ProductoVendido()
        {
        }
    }
}
