﻿using System.ComponentModel.DataAnnotations;

namespace MeuPrimeiroBackend.Models
{
    public class item
    {
        public int ItemID { get; set; }
                    
        [Required, StringLength(20)]

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int DanoMaximo { get; set; }

        public int DanoMinimo { get; set; }

        public int Durabilidade { get; set; }
    }
}