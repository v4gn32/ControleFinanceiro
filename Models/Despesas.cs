using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleFinanceiro.Models
{
    [Table("Despesas")]
    public class Despesa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Obrigatorio informar a descrição da divida!")] 
        public string Divida { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o vencimento!")]
        public int Vencimento { get; set; }

        [Required(ErrorMessage = "Obrigatorio informar o status!")]
        public int Status { get; set; }
    }
}
