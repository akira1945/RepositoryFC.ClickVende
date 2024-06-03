using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.ClickVende.Business.DTOs
{
    public class ClientDTO
    {
        public string Nome { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Endereco { get; set; } = string.Empty;
    }
}
