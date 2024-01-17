using Desafio3.Models;

Nokia n1 = new Nokia(numero: "11-5555-5555", modelo: "Z-900", imei: "sla", memoria: 16);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("waze");

Console.WriteLine($"Esse celular é um nokia, numero: {n1.Numero}");
