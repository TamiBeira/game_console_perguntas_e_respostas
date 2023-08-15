// Jogo de pergutas e respostas
// Console.WriteLine() -> imprime as perguntas na tela
// Recolher dados e salvar na variável
// Mostrar pontuação para usuario

int pontuacao = 0;

Console.WriteLine("Sua pontuação é:" +pontuacao+ "\nQuanto é 5 + 5?\nEscreva sua resposta abaixo:");
int resp_1 = Convert.ToInt32(Console.ReadLine());

/*verifica se a resposta 1 está correta*/
if (resp_1 == 10)
{
    pontuacao++;
}
else if (pontuacao <= 0)
{
    Console.WriteLine("Você perdeu!");
}
else
{
    Console.WriteLine("Ops você errou a resposta correta é: " + 10 + "você perdeu 1 ponto.");
    pontuacao--;
}

Console.WriteLine("Sua pontuação é:" + pontuacao + "\nQuanto é 7 x 9?\nEscreva sua resposta abaixo:");
int resp_2 = Convert.ToInt32(Console.ReadLine());

/*verifica se a resposta 2 está correta*/
if (resp_2 == 63)
{
    pontuacao++;
}
else if (pontuacao <= 0)
{
    Console.WriteLine("Você perdeu!");
}
else
{
    Console.WriteLine("Ops você errou a resposta correta é: " + 10 + "você perdeu 1 ponto.");
    pontuacao--;
}

Console.WriteLine("Sua pontuação é:" + pontuacao + "\nQual é o nome do protagonista do jogo The Legend of Zelda: Breath of the Wild?\nEscreva sua resposta abaixo:");
string resp_3 = Console.ReadLine();

/*verifica se a resposta 3 está correta*/
if (resp_3 == "Link")
{
    pontuacao++;
}
else if (pontuacao <= 0)
{
    Console.WriteLine("Você perdeu!");
}
else
{
    Console.WriteLine("Ops você errou a resposta correta é: " + "Link" + "você perdeu 1 ponto.");
    pontuacao--;
}

Console.WriteLine("Sua pontuação é:" + pontuacao + "\nEm que jogo de videogame você pode encontrar um personagem chamado Mario?\nEscreva sua resposta abaixo:");
string resp_4 = Console.ReadLine();

/*verifica se a resposta 4 está correta*/
if (resp_4 == "Super Mario Bros")
{
    pontuacao++;
}
else if (pontuacao <= 0)
{
    Console.WriteLine("Você perdeu!");
}
else
{
    Console.WriteLine("Ops você errou a resposta correta é: " + "Super Mario Bros" + "você perdeu 1 ponto.");
    pontuacao--;
}



