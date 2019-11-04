using System;
using System.Collections.Generic;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class TipoEquipamento
    {
        public TipoEquipamento()
        {
            RegistroDefeito = new HashSet<RegistroDefeito>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<RegistroDefeito> RegistroDefeito { get; set; }
    }
}
