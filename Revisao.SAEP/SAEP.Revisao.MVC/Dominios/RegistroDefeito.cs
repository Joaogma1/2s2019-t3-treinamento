using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class RegistroDefeito
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe a data do defeito")]
        [DataType(DataType.Date)]
        public DateTime DataRegistro { get; set; }
        [Required(ErrorMessage ="Informe o equipamento")]
        public int IdTipoEquipamento { get; set; }
        [Required(ErrorMessage ="Informe o defeito")]
        public int IdDefeito { get; set; }
        [Required(ErrorMessage ="Informe a descrição do defeito")]
        public string Descricao { get; set; }

        public Defeito IdDefeitoNavigation { get; set; }
        public TipoEquipamento IdTipoEquipamentoNavigation { get; set; }
    }
}
