using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class RegistoViatura
    {

        // PROPRIEDADES
        public DateTime DataRegisto { get; set; }
        public string Matricula { get; set; }

        public double KmAbastecer { get; set; }

        public double KmSaida { get; set; }

        public double KmChegada { get; set; }

        public double Litros { get; set; }

        // CONSTRUTORES

        public RegistoViatura(DateTime dataregisto, string matricula, double kmchegada, double kmsaida)
        {
            DataRegisto = dataregisto;
            Matricula = matricula;
            KmChegada = kmchegada;
            KmSaida = kmsaida;
        }

        public RegistoViatura(DateTime dataregisto, string matricula, double kmchegada, double kmsaida, double kmabastecer, double litros)
        {
            DataRegisto = dataregisto;
            Matricula = matricula;
            KmChegada = kmchegada;
            KmSaida = kmsaida;
            KmAbastecer = kmabastecer;
            Litros = litros;
        }

        //MÉTODOS
        public double RegistoDiário() //CALCULO DE KM'S PERCORRIDOS
        {
            return KmSaida - KmChegada;
        }


        public override string ToString()
        {
            return ("#REGISTO DIÁRIO" +
                "\n" + "Matricula: " + Matricula +
                "\n" + "Data: " + DataRegisto.ToString("dd/MM/yyyy")
                + "\n" + "Kms de saida: " + KmSaida +
                "\n" + "Kms de chegada: " + KmChegada
                + "\n" + "Kms percorridos: " + RegistoDiário().ToString("F2", CultureInfo.InvariantCulture)
                +"\n" + "#REGISTO ABASTECIMENTO: " 
                + "\n" + "Kms ao abastecer: "
                +"\n" + "Kms: " + KmAbastecer + 
                "\n" + "Litros de abastecimento" +
                "\n" + "Litros: " + Litros);
        }
    }
}
