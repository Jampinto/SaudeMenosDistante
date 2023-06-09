using Microsoft.Win32;
using SaudeMenosDistante.Entities;
using System.Linq;
using SaudeMenosDistante.Entities.Enum;
using System;
using System.Globalization;
using System.ComponentModel.Design;

namespace SaudeMenosDistante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIAÇÃO DE BASE DE DADOS
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            ListaUtentes listaUtentes = new ListaUtentes();
            ListaConsultas listaConsultas = new ListaConsultas();
            ListaConsultasItens listaConsultasItens = new ListaConsultasItens();
            List<EquipamentoDeServico> listaEquipamentos = new List<EquipamentoDeServico>();
            List<Equipas> listaEquipas = new List<Equipas>();
            List<ConsultasMedicas> listaConsultasMedicas = new List<ConsultasMedicas>();


            // INTRODUÇÃO DE DADOS FUNCIONARIOS
            Funcionario administrativo = new Funcionario("Feliciano Gomes", DateTime.Parse("31/07/1966"), "Rua das Camélias, Vila Real", Char.Parse("M"), "feliciano.gomes@smd.pt", "Administrativo", 900, "Equipa1"); listaFuncionarios.Add(administrativo);
            Funcionario motorista = new Funcionario("Helena Silva", DateTime.Parse("20/03/1970"), "Rua Bonsanto, Lisboa", Char.Parse("F"), "helena.silva@exemplo.pt", "Motorista", 800.00, "Equipa1"); listaFuncionarios.Add(motorista);
            Funcionario enfermeiro = new Funcionario("Tiago João", DateTime.Parse("30/10/1980"), "Rua da Cintura, Amares", Char.Parse("M"), "tiago.joao@exemplo.pt", "Enfermeiro", 1200.00, "Equipa1"); listaFuncionarios.Add(enfermeiro);
            Funcionario medico = new Funcionario("Manuel José", DateTime.Parse("20/05/1950"), "Rua da Igreja, Porto", Char.Parse("M"), "manuel.joao@exemplo.pt", "Médico", 2000, "Equipa1"); listaFuncionarios.Add(medico);
            Funcionario gestorDgs = new Funcionario("Isabel Santos", DateTime.Parse("20/05/1988"), "Rua do Pinheiro Manso, Fafe", Char.Parse("F"), "isabel.santos@exemplo.pt", "Gestor", 1600, "Equipa1"); listaFuncionarios.Add(gestorDgs);
            Funcionario administrativo2 = new Funcionario("João Gomes", DateTime.Parse("31/07/1966"), "Rua das Camélias, Vila Real", Char.Parse("M"), "feliciano.gomes@smd.pt", "Administrativo", 900, "Equipa2"); listaFuncionarios.Add(administrativo2);
            Funcionario motorista2 = new Funcionario("João Silva", DateTime.Parse("20/03/1970"), "Rua Bonsanto, Lisboa", Char.Parse("F"), "helena.silva@exemplo.pt", "Motorista", 800.00, "Equipa2"); listaFuncionarios.Add(motorista2);
            Funcionario enfermeiro2 = new Funcionario("Manuel João", DateTime.Parse("30/10/1980"), "Rua da Cintura, Amares", Char.Parse("M"), "tiago.joao@exemplo.pt", "Enfermeiro", 1200.00, "Equipa2"); listaFuncionarios.Add(enfermeiro2);
            Funcionario medico2 = new Funcionario("Tiago José", DateTime.Parse("20/05/1950"), "Rua da Igreja, Porto", Char.Parse("M"), "manuel.joao@exemplo.pt", "Médico", 2000, "Equipa2"); listaFuncionarios.Add(medico2);
            Funcionario gestorDgs2 = new Funcionario("Maria Santos", DateTime.Parse("20/05/1988"), "Rua do Pinheiro Manso, Fafe", Char.Parse("F"), "isabel.santos@exemplo.pt", "Gestor", 1600, "Equipa2"); listaFuncionarios.Add(gestorDgs2);


            //INTRODUÇÃO DADOS EQUIPAMENTOS/VIATURAS
            Frota viatura = new Frota("Viatura", "Ambulância", 1, "Mercedes", "45-GG-87", DateTime.Parse("25/11/2023"), DateTime.Parse("20/10/2024"), 4548166);
            Frota viatura2 = new Frota("Viatura", "Ambulância de emergência", 1, "Volvo", "75-OH-60", DateTime.Parse("16/05/2010"), DateTime.Parse("20/04/2024"), 123467);
            viatura.AdicionarViatura(viatura);
            viatura2.AdicionarViatura(viatura2);


            //INTRODUÇÃO DADOS EQUIPAMENTOS DE SERVIÇOS (CONSULTAS, ENFERMAGEM, INFORMÁTICA)
            EquipamentoDeServico equipamento1 = new EquipamentoDeServico("Computador", "Laptop", 4, DateTime.Parse("29/03/2023"), 1, "HP", "Informático");
            EquipamentoDeServico equipamento2 = new EquipamentoDeServico("Impressora", "Multifunções", 1, DateTime.Parse("01/04/2023"), 2, "Epson", "Informático");
            EquipamentoDeServico equipamento3 = new EquipamentoDeServico("Router", "Internet Móvel", 1, DateTime.Parse("26/04/2023"), 3, "Vodafone", "Informático");
            EquipamentoDeServico equipamento4 = new EquipamentoDeServico("Estetoscópio", "Estetoscópio profissional", 4, DateTime.Parse("05/05/2023"), 4, "Littmann", "Médico");
            EquipamentoDeServico equipamento5 = new EquipamentoDeServico("Tiras de Avaliação", "Tiras de avaliação de colesterol e glicose", 200, DateTime.Parse("05/05/2023"), 5, "Accu-Check", "Médico");
            listaEquipamentos.Add(equipamento1);
            listaEquipamentos.Add(equipamento2);
            listaEquipamentos.Add(equipamento3);
            listaEquipamentos.Add(equipamento4);
            listaEquipamentos.Add(equipamento5);


            // EQUIPAS
            Equipas equipa1 = new Equipas("Equipa1", "Amares");
            Equipas equipa2 = new Equipas("Equipa2", "Vila Verde");
            listaEquipas.Add(equipa1);
            listaEquipas.Add(equipa2);


            //LOGIN
            administrativo.Registar("adm", "smd"); //LOGIN ADMINISTRATIVO
            motorista.Registar("mot", "smd"); //LOGIN MOTORISTA
            enfermeiro.Registar("enf", "smd"); //LOGIN ENFERMEIRO
            medico.Registar("med", "smd"); //LOGIN MÉDICO
            gestorDgs.Registar("ges", "smd"); //LOGIN GESTOR DGS
            administrativo2.Registar("adm_02", "smd"); //LOGIN ADMINISTRATIVO
            motorista2.Registar("mot_02", "smd"); //LOGIN MOTORISTA
            enfermeiro2.Registar("enf_02", "smd"); //LOGIN ENFERMEIRO
            medico2.Registar("med_02", "smd"); //LOGIN MÉDICO
            gestorDgs2.Registar("ges_02", "smd"); //LOGIN GESTOR DGS



            // INTRODUÇÃO DADOS UTENTES
            Utente utente1 = new Utente("Diogo Coelho da Silva", DateTime.Parse("10/07/1990"), "Rua do Castro, Nº1", 'M', "diogo.exemplo1@exemplo.com", 123456789);
            Utente utente2 = new Utente("Tiago Santos Silva", DateTime.Parse("05/06/1980"), "Rua da Cintura, Nº2", 'M', "tiago.exemplo1@exemplo.com", 231456789);
            Utente utente3 = new Utente("Maria Coelho Santos", DateTime.Parse("04/03/1959"), "Rua da Igreja, Nº10", 'F', "maria.exemplo1@exemplo.com", 423456789);
            Utente utente4 = new Utente("Cecília Maria Antunes", DateTime.Parse("28/05/1985"), "Rua da Alegria, Nº100", 'F', "cecilia.exemplo1@exemplo.com", 283456789);
            Utente utente5 = new Utente("João António Coelho", DateTime.Parse("30/06/1996"), "Rua da Associação, Nº200", 'M', "joao.exemplo1@exemplo.com", 193456789);
            listaUtentes.Adicionar(utente1);
            listaUtentes.Adicionar(utente2);
            listaUtentes.Adicionar(utente3);
            listaUtentes.Adicionar(utente4);
            listaUtentes.Adicionar(utente5);


            // INTRODUÇÃO DADOS CONSULTAS
            Consulta consulta1 = new Consulta(1, DateTime.Parse("01/06/2023"), EstadoConsulta.Entrada, utente1);
            Consulta consulta2 = new Consulta(2, DateTime.Parse("02/06/2023"), EstadoConsulta.Entrada, utente2);
            Consulta consulta3 = new Consulta(3, DateTime.Parse("03/06/2023"), EstadoConsulta.Entrada, utente3);
            Consulta consulta4 = new Consulta(4, DateTime.Parse("04/06/2023"), EstadoConsulta.Entrada, utente3);
            Consulta consulta5 = new Consulta(5, DateTime.Parse("05/06/2023"), EstadoConsulta.Entrada, utente4);
            Consulta consulta6 = new Consulta(6, DateTime.Parse("05/06/2023"), EstadoConsulta.Entrada, utente5);
            Consulta consulta7 = new Consulta(7, DateTime.Parse("01/05/2023"), EstadoConsulta.Entrada, utente1);
            listaConsultas.Adicionar(consulta1);
            listaConsultas.Adicionar(consulta2);
            listaConsultas.Adicionar(consulta3);
            listaConsultas.Adicionar(consulta4);
            listaConsultas.Adicionar(consulta5);
            listaConsultas.Adicionar(consulta6);
            listaConsultas.Adicionar(consulta7);



            Console.WriteLine("Bem-vindo ao Saúde Menos Distante");
            Console.WriteLine("----------------------------------");
            Console.WriteLine();

            Funcionario funconline = new Funcionario("admin", DateTime.Parse("05/06/2013"), "DGS", '0', "admin@smd.pt");  // INSTANCIAÇÃO DE FUNCIONARIO PARA CRUZAR COM OS PARAMETROS DO LOGIN DE CADA FUNCIONARIO

            bool terminar = false;  //VARIAVEL PARA TERMINAR O PROGRAMA
            bool loggedIn = false;  //VARIAVEL PARA TERMINAR LOGIN

            //CONDIÇÃO PARA FECHAR PROGRAMA
            while (!terminar)
            {


                //CONDIÇÃO PARA O LOGIN
                while (!loggedIn)
                {
                    Console.WriteLine("*|LOGIN|*");
                    Console.Write("Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    funconline = listaFuncionarios.Find(x => x.ObterConta().ObterUsername() == username); //FIND UTILIZADO NA LISTA DE FUNCIONARIOS PARA OBTER O FUNCIONARIO ATRAVÉS USERNAME PELO O REGISTO DE CONTA 

                    if (funconline != null)
                    {
                        loggedIn = funconline.Login(username, password);  //CONDIÇÃO PARA INTRODUÇÃO CORRETA DOS DADOS DO LOGIN
                    }
                    else
                    {
                        Console.WriteLine("Dados incorretos!");
                        Console.WriteLine();
                    }

                }

                //ENTRADA PARA O MENU RESPECTIVO À FUNCAO DE CADA LOGIN
                while (loggedIn)
                {

                    string menu = funconline.Funcao;  //ATRIBUIÇÃO À VARIÁVEL MENU A FUNÇÃO RESPECTIVA DE CADA FUNCIONARIO

                    switch (menu)
                    {
                        case "Motorista":
                            Console.WriteLine("# Menu Motorista #");
                            Motorista();
                            break;
                        case "Enfermeiro":
                            Console.WriteLine("# Menu Enfermeiro #");
                            Enfermeiro();
                            break;
                        case "Administrativo":
                            Console.WriteLine("# Menu Administrativo #");
                            Administrativo();
                            break;
                        case "Médico":
                            Console.WriteLine("# Menu Médico #");
                            Medico();
                            break;
                        case "Gestor":
                            Console.WriteLine("# Menu Gestor DGS #");
                            Gestor();
                            break;
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                }
            }

            //MENU MOTORISTA
            void Motorista()
            {

                Console.WriteLine("Selecione a opção: \n 1) Registo diário viatura \n 2) Logout \n 3) Sair do Programa");

                string mot = Console.ReadLine();

                switch (mot)
                {
                    case "1":
                        Registo();
                        break;
                    case "2":
                        Console.WriteLine("Logout");
                        loggedIn = false;
                        break;
                    case "3":
                        Console.WriteLine("Programa encerrado");
                        loggedIn = false;
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }
            }

            //REGISTO DE DIÁRIO DE OCORRÊNCIAS DAS VIATURAS PELO MOTORISTA
            void Registo()
            {
                Console.WriteLine("Introduza a data (DD/MM/YYYY): ");
                DateTime dataregisto = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Matricula da viatura: ");
                string matricula = Console.ReadLine();
                Console.WriteLine("Introduza os kms de saida: ");
                double kmsaida = double.Parse(Console.ReadLine());
                Console.WriteLine("Introuza os kms de chegada: ");
                double kmchegada = double.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Abasteceu combustível na viatura? (S/N)");

                char resp = Char.Parse(Console.ReadLine());
                if (resp == 's' || resp == 'S')   //CONDIÇÃO PARA CASO DE ABASTECIMENTO DE COMBUSTIVEL
                {
                    Console.WriteLine("Introduza os kms ao abastecer: ");
                    double kmabastecimento = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduza os litros de abastecimento");
                    double litros = double.Parse(Console.ReadLine());
                    RegistoViatura registoTotal = new RegistoViatura(dataregisto, matricula, kmsaida, kmchegada, kmabastecimento, litros);

                    viatura.AdicionarItem(registoTotal);  //ADICIONAR O REGISTO DIÁRIO À LISTA DE VIATURAS

                    Console.WriteLine(registoTotal);
                }
                else  //CASO CONTRÁRIO EFETUA APENAS O REGISTO DIÁRIO
                {
                    RegistoViatura registoDiario = new RegistoViatura(dataregisto, matricula, kmsaida, kmchegada);

                    viatura.AdicionarItem(registoDiario); //ADICIONAR O REGISTO DIÁRIO À LISTA DE VIATURAS

                    Console.WriteLine(registoDiario);
                }
                Console.WriteLine();
                Console.WriteLine("FECHO DIÁRIO");
            }


            // MENU ADMINISTRATIVO
            void Administrativo()
            {

                Console.WriteLine("Seleciona a opção: \n 1) Registar Utente \n 2) Registar Consulta \n 3) Visualizar Utentes \n 4) Informação estatística \n 5) Gestão de Equipamento \n 6) Logout \n 7) Encerrar programa");

                string adm = Console.ReadLine();

                switch (adm)
                {
                    case "1":
                        RegistarUtente();
                        break;
                    case "2":
                        RegistarConsulta();
                        break;
                    case "3":
                        VisualizarUtente();
                        break;
                    case "4":
                        Estatisticas();
                        break;
                    case "5":
                        GestaoEquipamento();
                        break;
                    case "6":
                        Console.WriteLine("Logout");
                        loggedIn = false;
                        break;
                    case "7":
                        Console.WriteLine("Programa encerrado");
                        loggedIn = false;
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            //RELATÓRIO DAS EQUIPAS PELO GESTOR DGS
            void GestaoEquipas()
            {
                Console.WriteLine("Gestão de Equipas");
                foreach (Equipas equipa in listaEquipas)
                {                                                                           //FOREACH DAS EQUIPAS NA LISTA DE EQUIPAS
                    Console.WriteLine(equipa);                                              //COM FOREACH DOS FUNCIONARIO NA LISTA DE FUNCIONARIOS   
                    foreach (Funcionario funcionario in listaFuncionarios)                  //PARA IMPRIMIR RELATORIO DOS FUNCIONARIOS POR EQUIPAS
                    {
                        if (funcionario.Equipa == equipa.NomeEquipa)
                        {
                            Console.WriteLine(funcionario);
                        }
                    }
                }
            }

            //ENTRADA DO UTENTE PELO ADMINISTRATIVO
            void RegistarUtente()
            {
                //INSTANCIAÇÃO DO UTENTE PELO UTILIZADOR

                Console.WriteLine("#Entrada de utente: ");
                Console.WriteLine("Nome de utente: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Data nascimento (DD/MM/YYYY): ");
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine("Morada: ");
                string morada = Console.ReadLine();

                char sexo = '0';

                while (true)
                {
                    Console.WriteLine("Sexo (M/F): ");
                    sexo = Char.Parse(Console.ReadLine());
                    if (sexo != 'm' && sexo != 'f' && sexo != 'M' && sexo != 'F')
                    {
                        Console.WriteLine("Insira uma resposta válida!");
                    }
                    else
                    {
                        break;
                    }

                }
                Console.WriteLine("Email: ");
                string email = Console.ReadLine();
                Console.WriteLine("Numero de utente: ");
                int nutente = int.Parse(Console.ReadLine());

                Utente utente = new Utente(nome, data, morada, sexo, email, nutente);

                listaUtentes.Adicionar(utente);

                Console.WriteLine("UTENTE INSERIDO.");
            }

            //REGISTOS DAS CONSULTAS PELO ADMINISTRATIVO
            void RegistarConsulta()
            {
                //INSTANCIAÇÃO DA CONSULTA PELO ADMINISTRATIVO 

                EstadoConsulta estado = Enum.Parse<EstadoConsulta>("Entrada");
                DateTime moment = DateTime.Now;
                Console.WriteLine("Número de utente:");
                int nutente = int.Parse(Console.ReadLine());
                Utente utente = listaUtentes.obterListaDeutentes().Find(x => x.Nutente == nutente); //ATRAVÉS DA LIGAÇÃO AO UTENTE ANTERIORMENTE INSERIDO
                int id = listaConsultas.ObterListaDeConsultas().Count();
                Consulta consulta = new Consulta(id + 1, moment, estado, utente);  //ADICIONAR NOVO ID A CADA CONSULTA COM A FUNÇÃO COUNT - ID + 1
                listaConsultas.Adicionar(consulta);

                Console.WriteLine();
                Console.WriteLine(consulta.Estado);
                Console.WriteLine("ID: " + consulta.Id);
                Console.WriteLine("CONSULTA REGISTADA.");
            }


            // REGISTOS DOS EQUIPAMENTOS PELO ADMINISTRATIVO
            void GestaoEquipamento()
            {
                Console.WriteLine("Seleciona a opção: \n 1) Adicionar novo artigo \n 2) Adicinar quantidades de stock \n 3) Remover quantidades de stock \n 4) Visualizar Equipamentos");

                string stock = Console.ReadLine();

                switch (stock)
                {
                    case "1":
                        Adicionar();
                        break;
                    case "2":
                        IntroduzirStock();
                        break;
                    case "3":
                        RemoverStock();
                        break;
                    case "4":
                        VisualizarEquip();
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }


            // ALTERAR QUANTIDADES EQUIPAMENTOS
            void RemoverStock()
            {

                int y = 0;
                while (true)
                {
                    Console.WriteLine("Selecione o artigo que pretende remover quantidade? 0) Computador :: 1) Multifunções :: 2) Router :: 3) Estetescopio :: 4) Tiras de avaliação");

                    y = int.Parse(Console.ReadLine());

                    if (y < 0 || y > 4)   //CONDIÇÃO PARA AS RESPOSTAS DO UTILIZADOR
                    {
                        Console.WriteLine("Resposta inválida");
                    }
                    else
                    {
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Que quantidade quer remover? ");
                    int x = int.Parse(Console.ReadLine());

                    if (x > listaEquipamentos[y].Quantidade)  //CONDIÇÃO PARA NÃO DEIXAR REMOVER QUANTIDADES SUPERIORES ÀS EXISTENTES
                    {
                        Console.WriteLine("Não é possível remover as quantidades indicadas.");
                    }
                    else
                    {
                        listaEquipamentos[y].Quantidade -= x;  //REMOVER QUANTIDADES
                        break;
                    }

                }

                //VISUALIZAR LISTA DE EQUIPAMENTOS
                foreach (EquipamentoDeServico equipamento in listaEquipamentos)
                {

                    Console.WriteLine(equipamento);

                }

            }

            //INTRODUZIR QUANTIDADES DE STOCK DE EQUIPAMENTOS PELOS ADMNISTRATIVO
            void IntroduzirStock()
            {

                int y = 0;
                while (true)
                {
                    Console.WriteLine("Selecione o artigo que pretende introduzir quantidade? 0) Computador :: 1) Multifunções :: 2) Router :: 3) Estetescopio :: 4) Tiras de avaliação");

                    y = int.Parse(Console.ReadLine());

                    if (y < 0 || y > 4) //CONDIÇÃO PARA RESPOSTA DO UTILIZADOR
                    {
                        Console.WriteLine("Resposta inválida");
                    }
                    else
                    {
                        break;
                    }
                }
                Console.WriteLine("Que quantidade quer introduzir? ");
                int x = int.Parse(Console.ReadLine());
                listaEquipamentos[y].Quantidade += x;    //INCREMENTO DE QUANTIDADES A UM DOS PRODUTOS SELECIONADOS DESCRITOS NA TELA

                //VISUALIZAR ATULIZAÇÃO ÀS QUANTIDADES NOS EQUIPAMENTOS
                foreach (EquipamentoDeServico equipamento in listaEquipamentos)
                {
                    Console.WriteLine(equipamento);
                }

            }

            // ADICIONAR EQUIPAMENTOS NOVOS PELO ADMINISTRATIVO
            void Adicionar()
            {

                Console.Write("Artigo: ");
                string artigo = Console.ReadLine();

                Console.Write("Descritivo: ");
                string descritivo = Console.ReadLine();

                Console.Write("Referência: ");
                int referencia = int.Parse(Console.ReadLine());

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                Console.Write("Data de Compra (formato: dd/mm/aaaa): ");
                DateTime dataCompra = DateTime.Parse(Console.ReadLine());

                Console.Write("Fabricante: ");
                string fabricante = Console.ReadLine();

                Console.Write("Tipo: ");
                string tipo = Console.ReadLine();

                EquipamentoDeServico equipamentoDeServico = new EquipamentoDeServico(artigo, descritivo, quantidade, dataCompra, referencia, fabricante, tipo);

                listaEquipamentos.Add(equipamentoDeServico);

                Console.WriteLine();

            }


            //VISUALIZAR EQUIPAMENTOS PELO ADMNISTRATIVO
            void VisualizarEquip()
            {

                foreach (EquipamentoDeServico equipamento in listaEquipamentos)
                {

                    Console.WriteLine(equipamento);

                }

            }

            //VISUALIZAR UTENTES PELO ADMINISTRATIVO
            void VisualizarUtente()
            {
                foreach (Utente utente in listaUtentes.obterListaDeutentes())
                {
                    Console.WriteLine(utente);
                }
            }

            //MENU ENFERMEIRO
            void Enfermeiro()
            {
                Console.WriteLine("Seleciona a opção: \n 1) Consultas \n 2) Visualizar Consultas \n 3) Informação estatística \n 4) Logout \n 5) Sair do Programa");

                string enf = Console.ReadLine();

                switch (enf)
                {
                    case "1":
                        Consultas();
                        break;
                    case "2":
                        VisualizarConsultas();
                        break;
                    case "3":
                        Estatisticas();
                        break;
                    case "4":
                        Console.WriteLine("Logout");
                        loggedIn = false;
                        break;
                    case "5":
                        Console.WriteLine("Programa encerrado");
                        loggedIn = false;
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            //REGISTO DE CONSULTAS DE ENFERMAGEM PELO ENFERMEIRO
            void Consultas()
            {
                EstadoConsulta estado = Enum.Parse<EstadoConsulta>("Enfermagem");
                Console.WriteLine(estado);

                int id = listaConsultas.ObterListaDeConsultas().Count();  //CONTAGEM PARA LIGAR AO ID DA CONSULTA INICIADA PELO ADMINISTRATIVO

                Console.WriteLine("Peso(kg): ");
                int peso = int.Parse(Console.ReadLine());

                Console.WriteLine("Altura(cm): ");
                int altura = int.Parse(Console.ReadLine());

                Console.WriteLine("Glicose(mg/dL): ");
                int glicose = int.Parse(Console.ReadLine());

                char fumador = '0';

                while (true)
                {
                    Console.WriteLine("Fumador(S/N): ");
                    fumador = char.Parse(Console.ReadLine());
                    if (fumador != 'S' && fumador != 'N' && fumador != 's' && fumador != 'n')
                    {
                        Console.WriteLine("Insira uma resposta válida!");
                    }
                    else
                    {
                        break;
                    }

                }

                Console.WriteLine("Colesterol(mg/dL): ");
                int colesterol = int.Parse(Console.ReadLine());

                Console.WriteLine("PAS: ");
                int pAS = int.Parse(Console.ReadLine());

                Console.WriteLine("PAD: ");
                int pAD = int.Parse(Console.ReadLine());

                Console.WriteLine("Tem algum antecedente de saúde(S/N) ? ");
                char resp = char.Parse(Console.ReadLine());

                //VARIEDADE DE CONSTRUTORES DOS ITENS DA CONSULTA MEDIANTE DIFERENTES RESPOSTAS DE
                //ANTECEDENTES DE SAUDE E MEDICAÇÃO HABITUAL

                if (resp == 's' || resp == 'S')
                {
                    Console.WriteLine("Indique os antecedentes de saúde ? ");
                    string antecedentes = Console.ReadLine();
                    Console.WriteLine("Toma alguma medicação habitual(S/N) ?");
                    char res = char.Parse(Console.ReadLine());
                    if (res == 'S' || res == 's')
                    {
                        Console.WriteLine("Qual a medicação habitual? ");
                        string medicacao = Console.ReadLine();

                        ConsultaItens consultaItens = new ConsultaItens(id, peso, altura, glicose, fumador, colesterol, pAS, pAD, antecedentes, medicacao);
                        listaConsultasItens.Adicionar(consultaItens);
                        consultaItens.VerificacaodaTensao(pAS, pAD);

                    }
                    else
                    {
                        ConsultaItens consultaItens = new ConsultaItens(id, peso, altura, glicose, fumador, colesterol, pAS, pAD, antecedentes);
                        listaConsultasItens.Adicionar(consultaItens);
                        consultaItens.VerificacaodaTensao(pAS, pAD);

                    }
                }
                else
                {
                    ConsultaItens consultaItens = new ConsultaItens(id, peso, altura, glicose, fumador, colesterol, pAS, pAD);
                    listaConsultasItens.Adicionar(consultaItens);
                    consultaItens.VerificacaodaTensao(pAS, pAD);

                }
                Console.WriteLine();
                Console.WriteLine("CONSULTA INSERIDA!");
                Console.WriteLine();

            }


            //VISUALIZAR CONSULTAS PELO ENFERMEIRO E MÉDICO
            void VisualizarConsultas()
            {
                foreach (Consulta consulta in listaConsultas.ObterListaDeConsultas())
                {
                    foreach (ConsultaItens consultaenf in listaConsultasItens.ObterListaDeConsultasItens())
                    {
                        if (consulta.Id == consultaenf.Id)
                        {
                            Console.WriteLine($" {consulta} \n {consultaenf}");
                        }
                    }

                }

            }


            //MENU DO MÉDICO
            void Medico()
            {
                Console.WriteLine("Seleciona a opção: \n 1) Visualizar consulta de enfermagem \n 2) Prescrever terapeutica \n 3) Relatório do Rastreio \n 4) Estatísticas \n 5) Logout \n 6) Sair do programa");

                string med = Console.ReadLine();

                switch (med)
                {
                    case "1":
                        VisualizarConsultas();
                        break;
                    case "2":
                        PrescricaoMedica();
                        break;
                    case "3":
                        RelatorioRastreio();
                        break;
                    case "4":
                        Estatisticas();
                        break;
                    case "5":
                        Console.WriteLine("Logout");
                        loggedIn = false;
                        break;
                    case "6":
                        Console.WriteLine("Programa encerrado");
                        loggedIn = false;
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

            //REGISTO DA CONSULTA DE MÉDICA
            void PrescricaoMedica()
            {
                EstadoConsulta estado = Enum.Parse<EstadoConsulta>("Médico");
                Console.WriteLine(estado);
                Console.WriteLine();
                Console.WriteLine("Deseja prescrever terapêutica(S/N)? ");
                char resp = char.Parse(Console.ReadLine());

                //DIFERENTES CONSTRUTORES PARA AS RESPOSTAS ÀS CONDIÇÕES DOS IFS
                if (resp == 'S' || resp == 's')
                {
                    Console.WriteLine("Recomendação médica(exame/medicação): ");
                    string medicamento = Console.ReadLine();
                    Console.WriteLine("Dosagem: ");
                    string dose = (Console.ReadLine());
                    Console.WriteLine("Periodicidade: ");
                    string alturadoDia = Console.ReadLine();
                    int id = listaConsultas.ObterListaDeConsultas().Count();
                    ConsultasMedicas consulta = new ConsultasMedicas(id, medicamento, dose, alturadoDia);
                    listaConsultasMedicas.Add(consulta);
                }
                else
                {
                    Console.WriteLine("Recomendação médica: ");
                    string recomendacao = Console.ReadLine();
                    int id = listaConsultas.ObterListaDeConsultas().Count();
                    ConsultasMedicas consulta = new ConsultasMedicas(id, recomendacao);
                    listaConsultasMedicas.Add(consulta);
                }
                Console.WriteLine();
                Console.WriteLine("Consulta médica terminada!");
                Console.WriteLine();
                Console.WriteLine("FIM DO RASTREIO");
                Console.WriteLine();

            }

            //RELATORIO FINAL DO RASTREIO PRESENTE NO MENU DO MÉDICO
            void RelatorioRastreio()
            {
                //CRUZAMENTO DOS "ids" DA LISTA DE CONSULTAS PRODUZIDAS PELO ADMINISTRATIVO
                foreach (Consulta consulta in listaConsultas.ObterListaDeConsultas())
                {
                    //DA LISTA DAS CONSULTAS DE ENFERMAGEM PRODUZIDAS PELO ENFERMEIRO
                    foreach (ConsultaItens itens in listaConsultasItens.ObterListaDeConsultasItens())
                    {
                        //DA LISTA DA CONSULTAS MÉDICAS PRODUZIDAS PELO MÉDICO
                        foreach (ConsultasMedicas consulmed in listaConsultasMedicas)
                        {
                            if (consulta.Id == itens.Id && consulta.Id == consulmed.Id && itens.Id == consulmed.Id)
                            {
                                Console.WriteLine($"RELATÓRIO DO RASTREIO: \n {consulta} \n {itens} \n {consulmed}");
                            }
                        }

                    }
                }
            }


            //MENU DO GESTOR DA DGS
            void Gestor()
            {
                Console.WriteLine("Seleciona a opção: \n 1) Relatório de equipas \n 2) Informação estatística \n 3) Logout \n 4) Sair do Programa");

                string ges = Console.ReadLine();

                switch (ges)
                {
                    case "1":
                        GestaoEquipas();
                        break;
                    case "2":
                        Estatisticas();
                        break;
                    case "3":
                        Console.WriteLine("Logout");
                        loggedIn = false;
                        break;
                    case "4":
                        Console.WriteLine("Programa encerrado");
                        loggedIn = false;
                        terminar = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            }

            //ESTATÍTICAS ACESSÍVEIS AO ADMNISTRATIVO, MÉDICO, ENFERMEIRO E GESTOR DA DGS
            void Estatisticas()
            {
                // Escreve o número total de consultas usando a função Count
                Console.WriteLine("Contagem total de consulta: " + listaConsultas.ObterListaDeConsultas().Count());
                // Obtêm a última consulta, ordenando as consultas por data
                var ultimaConsulta = listaConsultas.ObterListaDeConsultas().OrderBy(data => data.Moment).Last();
                // Cria o dado ultima_data a partir dos dados da ultimaConsulta obtida pelo anterior
                DateTime ultima_data = new DateTime(ultimaConsulta.Moment.Year, ultimaConsulta.Moment.Month, ultimaConsulta.Moment.Day);
                Console.WriteLine("Última consulta: " + ultima_data.ToString("dd/MM/yyyy"));

                int contador = 0; // Esta variável conta as consultas do último dia
                int contador_semana = 0;  // Esta variável conta as consultas dos últimos  7 dias

                // Ínicio da contagem das consultas do último dia
                foreach (Consulta consulta in listaConsultas.ObterListaDeConsultas())
                {
                    //Uso o ToString("dd/MM/yyyy") que  é para a hora e os minutos não entrar na comparação
                    if (consulta.Moment.ToString("dd/MM/yyyy") == ultima_data.ToString("dd/MM/yyyy"))
                    {
                        contador += 1;
                    }
                }
                // Fim da contagem das consultas do último dia
                Console.WriteLine("Total de consultas do último dia: " + contador);

                // Ínicio da contagem das consultas da última semana
                for (int i = 0; i <= 7; i++)  // O ciclo for é para percorrer os 6 dias anteriores à data da última consulta e o dia da última consulta
                {
                    foreach (Consulta consulta in listaConsultas.ObterListaDeConsultas())
                    {

                        //Uso o ToString("dd/MM/yyyy") que  é para a hora e os minutos não entrar na comparação
                        if (consulta.Moment.ToString("dd/MM/yyyy") == ultima_data.AddDays(-i).ToString("dd/MM/yyyy"))
                        {
                            contador_semana += 1;
                        }
                    }
                }
                Console.WriteLine("Total de consultas da última semana: " + contador_semana);
                // Fim da contagem das consultas da última semana
            }


        }

    }
}

