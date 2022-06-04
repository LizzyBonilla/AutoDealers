using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDealers.BL
{
    public class ProductosBL
    {

        Contexto _contexto;

        public ProductosBL()
        {
            _contexto = new Contexto();
        }

        public List<Producto> ObtenerProductos()
        {
            _contexto.Productos.ToList();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "Mercedes Benz";
            producto1.Modelo = "A200";
            producto1.Color = "Blanco, Negro";
            producto1.Precio = 1799426.77;
            producto1.Existencia = 20;

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "BMW";
            producto2.Modelo = "CLS Coupé";
            producto2.Color = "Blanco, Zafiro, Negro";
            producto2.Precio = 2497426.47;
            producto2.Existencia = 30;

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "Honda";
            producto3.Modelo = "Civic";
            producto3.Color = "Blanco, Gris, Negro";
            producto3.Precio = 240690.47;
            producto3.Existencia = 25;

            var producto4 = new Producto();
            producto4.Id = 4;
            producto4.Descripcion = "Toyota";
            producto4.Modelo = "Corolla";
            producto4.Color = "Blanco, Negro, Gris, Rojo";
            producto4.Precio = 397426.47;
            producto4.Existencia = 10;

            var producto5 = new Producto();
            producto5.Id = 5;
            producto5.Descripcion = "Audi";
            producto5.Modelo = "A5 Coupé";
            producto5.Color = "Blanco, Gris, Negro";
            producto5.Precio = 1580899.47;
            producto5.Existencia = 30;

            var producto6 = new Producto();
            producto6.Id = 6;
            producto6.Descripcion = "Ford";
            producto6.Modelo = "Escape";
            producto6.Color = "Blanco, Gris, Negro, Rojo";
            producto6.Precio = 128089.60;
            producto6.Existencia = 12;

            var producto7 = new Producto();
            producto7.Id = 7;
            producto7.Descripcion = "Kia";
            producto7.Modelo = "Sorento";
            producto7.Color = "Blanco, Gris, Negro";
            producto7.Precio = 329089.90;
            producto7.Existencia = 18;

            var producto8 = new Producto();
            producto8.Id = 8;
            producto8.Descripcion = "Mitsubishi";
            producto8.Modelo = "L200";
            producto8.Color = "Blanco, Gris, Negro";
            producto8.Precio = 369170.60;
            producto8.Existencia = 20;

            var producto9 = new Producto();
            producto9.Id = 9;
            producto9.Descripcion = "Jeep";
            producto9.Modelo = "Wrangler";
            producto9.Color = "Blanco, Gris, Negro, Rojo";
            producto9.Precio = 1579269.95;
            producto9.Existencia = 8;

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);
            listadeProductos.Add(producto5);
            listadeProductos.Add(producto6);
            listadeProductos.Add(producto7);
            listadeProductos.Add(producto8);
            listadeProductos.Add(producto9);

            return listadeProductos;
        }
    }
}
