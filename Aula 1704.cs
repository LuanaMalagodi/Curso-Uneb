using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int classeRpg;
            float força = 500, mana = 500;
            string classeName = "classe não escolhida";
           

            Console.WriteLine("Jogador, selecione a classe do seu personagem.");
            Console.WriteLine("1 - Guerreiro \n2 - Mago \n3 - Druida ");
            classeRpg = int.Parse(Console.ReadLine());

            switch (classeRpg)
            {
                case 1:
                    classeName = "Guerreiro";
                    força = 500 * 1.3f;
                    mana = 500 * 0.8f;
                    break;
                case 2:
                    classeName = "Mago";
                    força = 500 * 0.6f;
                    mana = 500 * 1.5f; break;
                case 3:
                    classeName = "Druida";
                    força = 500 * 0.8f;
                    mana = 500 * 1.3f; break;
                default: 
                    Console.WriteLine("Opção inválida."); break;
            }

            Console.WriteLine("Você escolheu ser {0}. Você tem {1} pontos de força e {2} pontos de mana.", classeName, força, mana);
            Console.WriteLine("Bom Jogo!");
            Console.ReadLine();


        }
    }
}
