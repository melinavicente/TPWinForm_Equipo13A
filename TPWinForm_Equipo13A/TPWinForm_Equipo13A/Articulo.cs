using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TPWinForm_Equipo13A
{
    internal class Articulo
    {
        /*
        - id
        - codigo
        - nombre
        - descripcion
        - marca(Marca)
        - categoria(Categoria)
        - precio
        - listaImagenes(List<Imagen>) 
        */
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        /*
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public List<Imagen> ListaImagenes { get; set; } = new List<Imagen>();
         */



    }
}
