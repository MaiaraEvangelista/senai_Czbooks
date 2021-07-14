using System;
using System.Collections.Generic;

#nullable disable

namespace senai_CZBooks_webApi.Domains
{
    public partial class Instituicao
    {
        public Instituicao()
        {
            Livros = new HashSet<Livro>();
        }

        public int IdInstituicao { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public TimeSpan? HorarioAbertura { get; set; }
        public TimeSpan? HorarioFechamento { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }
    }
}
