using System;

namespace Program
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----- DETERMINAR A MÉDIA DO ALUNO -----");

            Console.WriteLine("Informe a 1 nota: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a 2 nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a 3 nota: ");
            int nota3 = Convert.ToInt32(Console.ReadLine());

            int media = (nota1 + nota2 + nota3) / 3;

            if (nota1 <= 10 && nota2 <= 10 && nota3 <= 10)
            {
                if (media <= 6)
                {
                    Console.WriteLine(" A nota do aluno foi: F");
                }
                else if (media >= 6 && media <= 7)
                {
                    Console.WriteLine(" A nota do aluno foi: D");
                }
                else if (media >= 7 && media <= 8)
                {
                    Console.WriteLine(" A nota do aluno foi: C");
                }
                else if (media >= 8 && media <= 9)
                {
                    Console.WriteLine(" A nota do aluno foi: B");
                }
                else if (media >= 9 && media <= 10) 
                {
                    Console.WriteLine(" A nota do aluno foi: A. Parabéns!");
                }
                   
            }
        }
    }
}