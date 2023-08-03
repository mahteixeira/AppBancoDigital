using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace BancoDigital.Model
{
    public class Conta
    {
        public int? id { get; set; }
        public int numero { get; set; }
        public string tipo { get; set; }
        public string senha { get; set; }
        public int id_correntista { get; set;}
        public double saldo { get; set; }
        public double limite { get; set; }
    }
}
