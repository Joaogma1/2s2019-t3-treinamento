using System;
using System.Collections.Generic;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class Defeito
    {
        public Defeito()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public string NomeDefeito { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
