using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Digite o nome do contato")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} tamanho deve ser entre {2} e {1}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Digite o endereço de e-mail do contato")]
        [EmailAddress(ErrorMessage = "Entre com um e-mail valido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a data de nascimento")]
        [Display(Name = " Data de nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Digite o celular do contato")]
        [Phone(ErrorMessage = "Entre com o número de calular valido!")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "Digite o sexo")]
        public string Sexo { get; set; }
    }
}
