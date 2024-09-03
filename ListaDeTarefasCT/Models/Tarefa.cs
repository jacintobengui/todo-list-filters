using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace ListaDeTarefasCT.Models
{
    public class Tarefa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha a descrição!")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "Preencha a data de vencimento!")]
        public DateTime? DataVencimento { get; set; }

        [Required(ErrorMessage = "Selecione uma categoria")]
        public string CategoriaId { get; set; } = string.Empty;

        [ValidateNever]
        public Categoria Categoria { get; set; }

        [Required(ErrorMessage = "Selecione um status")]
        public string StatusId { get; set; } = string.Empty;

        [ValidateNever]
        public Status Status { get; set; }

        public bool Atrasado => StatusId == "aberto" && DataVencimento < DateTime.Now;
    }
}
