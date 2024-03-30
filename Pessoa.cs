using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


    public class Pessoa
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, ErrorMessage = "O nome não pode ter mais de 100 caracteres.")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A idade é obrigatória.")]
    [Range(1, 120, ErrorMessage = "A idade deve estar entre 1 e 120.")]
    public int Idade { get; set; }

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF não é válido.")]
    public string CPF { get; set; }
}
