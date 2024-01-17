using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio3.Models
{
    public abstract class Smartphones
    {

        public Smartphones(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }


        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }


        public void Ligar(){
            Console.WriteLine("Ligando.....");
        }

        public void ReceberLigacao(){
            Console.WriteLine("Recebendo Ligação.....");
        }

        public abstract void InstalarAplicativo(string nome);

    }
}