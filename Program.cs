using System;

class Program
{
    static void Main(string[] args)
    {
        int pontuacao = 5;
        int acertos = 0;
        int erros = 0;
        Random random = new Random();
        bool ultimaChance = false;

        void VerificarResposta(int respostaCorreta, int respostaUsuario)
        {
            if (respostaUsuario == respostaCorreta)
            {
                pontuacao++;
                acertos++;
            }
            else
            {
                pontuacao--;
                erros++;

                if (pontuacao == 0 && !ultimaChance)
                {
                    Console.WriteLine("Você tem apenas mais uma chance!");
                    pontuacao = 1;
                    ultimaChance = true;
                }
                else if (pontuacao <= 0)
                {
                    Console.WriteLine("Sua pontuação é zero. Fim do jogo.");
                    Environment.Exit(0);
                }
            }
        }

        Console.WriteLine("Jogo de Tabuada");
        Console.WriteLine("Sua pontuação é: " + pontuacao);

        while (true) // Loop infinito
        {
            int num1 = random.Next(1, 11); // Gera um número entre 1 e 10
            int num2 = random.Next(1, 11); // Gera um número entre 1 e 10

            Console.Write($"Quanto é {num1} x {num2}?\nEscreva sua resposta abaixo: ");
            int respostaUsuario = Convert.ToInt32(Console.ReadLine());

            VerificarResposta(num1 * num2, respostaUsuario);
            Console.WriteLine("Sua pontuação é: " + pontuacao);
        }
    }
}
