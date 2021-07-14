using System;
using System.Collections.Generic;

#nullable disable

namespace senai_CZBooks_webApi.Domains
{
    public partial class Livro
    {
        public Livro()
        {
            Generos = new HashSet<Genero>();
        }

        public int IdLivro { get; set; }
        public int? IdAutor { get; set; }
        public int? IdInstituicao { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Categoria { get; set; }
        public DateTime? DataPublicacao { get; set; }
        public string Sinopse { get; set; }

        public virtual Autor IdAutorNavigation { get; set; }
        public virtual Instituicao IdInstituicaoNavigation { get; set; }
        public virtual ICollection<Genero> Generos { get; set; }
    }
}
