﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BancoDigital.Model
{
    public class Correntista
    {
        public int? id { get; set; }
        public string nome { get; set; }
        public DateTime? data_nasc { get; set; }
        public string cpf { get; set; }
        public string senha { get; set; }
        public List<Conta> lista_conta { get; set; }
    }
}
