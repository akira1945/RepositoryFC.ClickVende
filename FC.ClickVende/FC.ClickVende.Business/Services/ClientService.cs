using FC.ClickVende.Business.DTOs;
using FC.ClickVende.Date.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FC.ClickVende.Business.Services
{
    public class ClientService
    {
        public void CreateClient(ClientDTO clientDto) 
        {
            var client = new Client
            {
                Nome = clientDto.Nome,
                CPF = clientDto.CPF,
                Endereco = clientDto.Endereco,
                Telefone = clientDto.Telefone,
                Email = clientDto.Email
            };

        }
    }
}
