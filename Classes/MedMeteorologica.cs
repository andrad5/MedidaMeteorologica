using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes {

    //atributo
    public class MedidaMeteorologica {
        public double temperatura;
        public double umidade;

        public double Temperatura {
            get {
                return temperatura;
            }
            set {
                if (value >= -273.15) {
                    temperatura = value;
                }
                else {
                    Console.WriteLine("Não existe temperatura inferior ao zero absoluto");
                }
            }
        }
        public double Umidade {
            get {
                return umidade;
            }
            set {
                if (value <= 100 && value >= 0) {
                    umidade = value;
                }
                else {
                    Console.WriteLine("A umidade deve estar entre 0 e 100%");
                }
            }
        }
        public double TemperaturaFahrenheit {
            get {
                return 1.8 * temperatura + 32;
            }
            set {
                Temperatura = (value - 32) / 1.8;
            }
        }
        // Métodos
        public string ImprimaValores(string nome) {
            string saida = "";

            saida = "Medida " + nome + ": temperatura = " + Temperatura + ", temp. em Fahrenheit = "
                + TemperaturaFahrenheit + ", umidade = " + Umidade;

            return saida;
        }
        // Construtores
        public MedidaMeteorologica(double Temperatura, double Umidade) {
            this.Temperatura = Temperatura;
            this.Umidade = Umidade;
        }
        public MedidaMeteorologica() {
            // Construtor sem parâmetros, não é o contrutor padrão!!!
            Temperatura = 20;
            Umidade = 60;
        }
    }
}
