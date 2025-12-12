using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Senai___10._12
{
    public class Perfis
    {
        public int SomaRealista { get; set; }
        public int SomaInvestigativo { get; set; }
        public int SomaArtístico { get; set; }
        public int SomaSocial { get; set; }
        public int SomaEmpreendedor { get; set; }
        public int SomaConvencional { get; set; }


        public void Tabela()
        {
            Console.WriteLine("");
            Console.WriteLine("                Pontuação:");
            Console.WriteLine("=========================================");
            Console.WriteLine($"1 - Perfil Realista:         {SomaRealista}");
            Console.WriteLine($"2 - Perfil Investigativo:    {SomaInvestigativo}");
            Console.WriteLine($"3 - Perfil Artístico:        {SomaArtístico}");
            Console.WriteLine($"4 - Perfil Social:           {SomaSocial}");
            Console.WriteLine($"5 - Perfil Empreendedor:     {SomaEmpreendedor}");
            Console.WriteLine($"6 - Perfil Convencional:     {SomaConvencional}");
            Console.WriteLine("");

        }

        public void VerificarPerfil(int[] vetorSomas, string nome)
        {


            int maior = 0;


            for (int i = 0; i < vetorSomas.Length; i++)
            {
                if (vetorSomas[i] > maior)
                {
                    maior = vetorSomas[i];


                }

            }
            List<int> perfisEmpate = new List<int>();

            for (int i = 0; i < vetorSomas.Length; i++)
            {
                if (vetorSomas[i] == maior)
                    perfisEmpate.Add(i + 1);
            }

            Console.WriteLine("==================================");
            Console.WriteLine($"Maior pontuação: {maior}");
Console.WriteLine("");
Console.WriteLine($"Parabéns {nome}!");

            for (int i = 0; i < perfisEmpate.Count; i++)
            {
                int pos = perfisEmpate[i];

                if (pos == 1)
                {

                    Console.WriteLine($"O seu perfil é o Realista");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine(" - Mecânica - - Eletricidade - - Automação - - Usinagem -");
                    Console.WriteLine("");

                }
                else if (pos == 2)
                {
                    Console.WriteLine($"O seu perfil é o Investigativo");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine("- Tecnologia da Informação - - Eletroeletrônica - - Manutenção -");
                    Console.WriteLine("");
                }
                else if (pos == 3)
                {
                    Console.WriteLine($"O seu perfil é o Artístico");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine("- Design de Produto - - Impressão 3D - - Comunicação Visual -");
                    Console.WriteLine("");
                }
                else if (pos == 4)
                {
                    Console.WriteLine($"O seu perfil é o Social");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine("- Segurança do Trabalho - - Educação - - Saúde Ocupacional -");
                    Console.WriteLine("");
                }
                else if (pos == 5)
                {
                    Console.WriteLine($"O seu perfil é o Empreendedor");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine("- Gestão - - Vendas Técnicas - - Logística -");
                    Console.WriteLine("");
                }
                else if (pos == 6)
                {
                    Console.WriteLine($"O seu perfil é o Convencional");
                    Console.WriteLine("");
                    Console.WriteLine("Cursos que combinam com você: ");
                    Console.WriteLine("-  Administração - - Controle de Qualidade - - Planejamento -");
                    Console.WriteLine("");
                }
            }

        }
    }
}