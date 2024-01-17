using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Models
{
    public class Nokia : Smartphones
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base ( numero, modelo, imei, memoria)
        {}

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"instalando aplicativo: {nome}");
        }
    }
}