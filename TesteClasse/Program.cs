using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;

//Oficial -- 
namespace TesteClasse {
    class Program {
        static void Main(string[] args) {
            MedidaMeteorologica met1 = new MedidaMeteorologica();
            met1.Temperatura = 25;
            met1.Umidade = 60;
            Console.WriteLine(met1.ImprimaValores("met1"));

            MedidaMeteorologica met2 = new MedidaMeteorologica();
            met2.Temperatura = -500;
            met2.Umidade = 150;
            Console.WriteLine(met2.ImprimaValores("met2"));

            MedidaMeteorologica met3 = new MedidaMeteorologica(35, 20);
            Console.WriteLine(met3.ImprimaValores("met3"));

            MedidaMeteorologica met4 = new MedidaMeteorologica();
            met4.TemperaturaFahrenheit = 95;
            met4.Umidade = 15;
            Console.WriteLine(met4.ImprimaValores("met4"));


            Console.ReadKey();
        }
    }
}
