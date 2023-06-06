using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SaudeMenosDistante.Entities
{
    internal class ConsultaItens
    {
        //Atributos
        public int Id { get; set; }
        public int Peso { get; set; }

        public int Altura { get; set; }

        public int Glicose { get; set; }

        public char Fumador { get; set; }

        public int Colesterol { get; set; }

        public int PAS { get; set; }

        public int PAD { get; set; }

        public string PressaoArterial { get; set; }

        public string Antecedentes { get; set; }

        public string MedicacaoHabitual { get; set; }


        //Construtores

        public ConsultaItens()
        {

        }



        public ConsultaItens(int id, int peso, int altura, int glicose, char fumador, int colestrol, int pAS, int pAD)
        {
            Id = id;
            Peso = peso;
            Altura = altura;
            Glicose = glicose;
            Fumador = fumador;
            Colesterol = colestrol;
            PAS = pAS;
            PAD = pAD;
        }

        public ConsultaItens(int id, int peso, int altura, int glicose, char fumador, int colestrol, int pAS, int pAD, string antecendentes, string medicacaohabitual)
        {
            Id = id;
            Peso = peso;
            Altura = altura;
            Glicose = glicose;
            Fumador = fumador;
            Colesterol = colestrol;
            PAS = pAS;
            PAD = pAD;
            Antecedentes = antecendentes;
            MedicacaoHabitual = medicacaohabitual;
        }

        public ConsultaItens(int id, int peso, int altura, int glicose, char fumador, int colestrol, int pAS, int pAD, string antecendentes)
        {
            Id = id;
            Peso = peso;
            Altura = altura;
            Glicose = glicose;
            Fumador = fumador;
            Colesterol = colestrol;
            PAS = pAS;
            PAD = pAD;
            Antecedentes = antecendentes;
        }


        public string VerificacaodaTensao(int pAS, int pAD)
        {
            PAS = pAS;
            PAD = pAD;

            if (PAS < 120 && PAD < 80)
            {
                return PressaoArterial = "Óptima";
            }
            else if ((PAS >= 120 && PAS <= 129) || (PAD >= 80 && PAD <= 84))
            {
                return PressaoArterial = "Normal";
            }
            else if ((PAS >= 130 && PAS <= 139) || (PAD >= 85 && PAD <= 89))
            {
                return PressaoArterial = "Normal-Alta(1)";
            }
            else if ((PAS >= 140 && PAS <= 159) || (PAD >= 90 && PAD <= 99))
            {
                return PressaoArterial = "HTA Grau I";
            }
            else if ((PAS >= 160 && PAS <= 179) || (PAD >= 100 && PAD <= 109))
            {
                return PressaoArterial = "HTA Grau II";
            }
            else if (PAS >= 180 || PAD >= 110)
            {
                return PressaoArterial = "HTA Grau III";
            }
            else if (PAS >= 140 && PAD < 90)
            {
                return PressaoArterial = "Hipertensão Sistólica isolada (2)";
            }
            else
            {
                return PressaoArterial = "Valores inválidos";
            }

            

        }

        public override string ToString()
        {
            if (Antecedentes != null)
            {
                if (MedicacaoHabitual != null)
                {
                    return "#ENFERMARIA" + "\n" + "ID: " + Id + "\n" + "Peso(kg): " + Peso + "\n" + "Altura(cm): " + Altura + "\n" + "Glicose(mg/dL): " + Glicose + "\n" + "Colesterol(mg/dL):" + Colesterol + "\n"
                + "Fumador: " + Fumador + "\n" + "PAS: " + PAS + "\n" + "PAD: " + PAD + "\n" + "Pressão arterial(mmHg): " + PressaoArterial + "\n" + "Antecedentes de Saúde: " + Antecedentes + "\n"
                + "Medicação habitual: " + MedicacaoHabitual;
                }
                else
                {
                    return "#ENFERMARIA" + "\n" + "ID: " + Id + "\n" + "Peso(kg): " + Peso + "\n" + "Altura(cm): " + Altura + "\n" + "Glicose(mg/dL): " + Glicose + "\n" + "Colesterol(mg/dL):" + Colesterol + "\n"
                + "Fumador: " + Fumador + "\n" + "PAS: " + PAS + "\n" + "PAD: " + PAD + "\n" + "Pressão arterial(mmHg): " + PressaoArterial + "\n" + "Antecedentes de Saúde: " + Antecedentes;
                }
            }
            else
            {
                return "#ENFERMARIA" + "\n" + "ID: " + Id + "\n" + "Peso(kg): " + Peso + "\n" + "Altura(cm): " + Altura + "\n" + "Glicose(mg/dL): " + Glicose + "\n" + "Colesterol(mg/dL):" + Colesterol + "\n"
                + "Fumador: " + Fumador + "\n" + "PAS: " + PAS + "\n" + "PAD: " + PAD + "\n" + "Pressão arterial(mmHg): " + PressaoArterial;
            }
            
            

        }


    }
}
