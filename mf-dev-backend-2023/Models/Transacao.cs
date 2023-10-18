using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2023.Models
{
    [Table ("Transacoes")]
    public class Transacao
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o tipo!")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor!")]
        public float Valor { get; set; }
    }
}