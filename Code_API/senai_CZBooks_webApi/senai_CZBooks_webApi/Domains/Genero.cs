using System;
using System.Collections.Generic;

#nullable disable

namespace senai_CZBooks_webApi.Domains
{
    public partial class Genero
    {
        public int IdGenero { get; set; }
        public int? IdLivro { get; set; }
        public string Tipo { get; set; }

        public virtual Livro IdLivroNavigation { get; set; }
    }
}
