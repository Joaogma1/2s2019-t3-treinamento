using System;
using System.Collections.Generic;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public int IdTipoEquipamento { get; set; }
        public int IdDefeito { get; set; }
        public string Descricao { get; set; }

        public Defeito IdDefeitoNavigation { get; set; }
        public TipoEquipamento IdTipoEquipamentoNavigation { get; set; }
    }
}
