using System.ComponentModel.DataAnnotations;

namespace webapicarros.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo nome deve conter no máximo 50 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo tipo é obrigatório.")]
        [MaxLength(50, ErrorMessage = "O campo tipo deve conter no máximo 50 caracteres")]
        public string Tipo { get; set; }

        [Required(ErrorMessage = "O campo ano é obrigatório.")]
        [MaxLength(4, ErrorMessage = "O campo ano deve conter entre 2 e 4 caracteres")]
        [MinLength(2, ErrorMessage = "O campo ano deve conter entre 2 e 4 caracteres")]
        public string Ano { get; set; }

        [Required(ErrorMessage = "O campo valor é obrigatório.")]
        [MaxLength(15, ErrorMessage = "O campo valor deve conter entre 4 e 15 caracteres")]
        [MinLength(4, ErrorMessage = "O campo valor deve conter entre 4 e 15 caracteres")]
        public string Valor { get; set; }

        [Required(ErrorMessage = "A campo cor é obrigatório.")]
        [MaxLength(20, ErrorMessage = "O campo cor deve conter no máximo 20 caracteres")]
        public string Cor { get; set; }
    }
}