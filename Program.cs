using System;

class Program
{
    static void Main(string[] args)
    {
        int pontuacao = 0;

        void VerificarResposta(string respostaCorreta, string respostaUsuario)
        {
            if (string.Equals(respostaUsuario, respostaCorreta, StringComparison.OrdinalIgnoreCase))
            {
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Ops, você errou! A resposta correta é: " + respostaCorreta);
                if (pontuacao > 0)
                {
                    pontuacao--;
                }
            }
        }

        Console.WriteLine("Jogo de Perguntas e Respostas");
        Console.WriteLine("Sua pontuação é: " + pontuacao);

        Console.Write("Quanto é 5 + 5?\nEscreva sua resposta abaixo: ");
        int resp_1 = Convert.ToInt32(Console.ReadLine());
        VerificarResposta("10", resp_1.ToString());

        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.Write("Quanto é 7 x 9?\nEscreva sua resposta abaixo: ");
        int resp_2 = Convert.ToInt32(Console.ReadLine());
        VerificarResposta("63", resp_2.ToString());

        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.Write("Qual é o nome do protagonista do jogo The Legend of Zelda: Breath of the Wild?\nEscreva sua resposta abaixo: ");
        string resp_3 = Console.ReadLine();
        VerificarResposta("Link", resp_3);

        Console.WriteLine("Sua pontuação é: " + pontuacao);
        Console.Write("Em que jogo de videogame você pode encontrar um personagem chamado Mario?\nEscreva sua resposta abaixo: ");
        string resp_4 = Console.ReadLine();
        VerificarResposta("Super Mario Bros", resp_4);

        Console.WriteLine("Sua pontuação final é: " + pontuacao);
    }
}
