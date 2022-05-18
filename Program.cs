bool jogando = true;

bool reiniciar()
{
    if (Console.ReadKey().Key == ConsoleKey.R)
    {
        return true;
    }
    return false;
}

do
{

    int jogador = 1, x = 0, y = 0, t = 0;
    int[,] tabuleiro = new int[3, 3];

    bool ganhou()
    {

        if (tabuleiro[0, 0] != 0)
        {
            if (tabuleiro[0, 0] == tabuleiro[1, 0] && tabuleiro[0, 0] == tabuleiro[2, 0]) return true;
            if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[0, 0] == tabuleiro[2, 2]) return true;
            if (tabuleiro[0, 0] == tabuleiro[0, 1] && tabuleiro[0, 0] == tabuleiro[0, 2]) return true;
        }
        if (tabuleiro[1, 1] != 0)
        {
            if (tabuleiro[1, 1] == tabuleiro[0, 1] && tabuleiro[1, 1] == tabuleiro[2, 1]) return true;
            if (tabuleiro[1, 1] == tabuleiro[2, 0] && tabuleiro[1, 1] == tabuleiro[0, 2]) return true;
            if (tabuleiro[1, 1] == tabuleiro[1, 0] && tabuleiro[1, 1] == tabuleiro[1, 2]) return true;
        }
        if (tabuleiro[2, 2] != 0)
        {
            if (tabuleiro[2, 2] == tabuleiro[1, 2] && tabuleiro[2, 2] == tabuleiro[0, 2]) return true;
            if (tabuleiro[2, 2] == tabuleiro[2, 1] && tabuleiro[2, 2] == tabuleiro[2, 0]) return true;
        }
        return false;
    }

    bool empatou()
    {
        for (int y = 0; y < 3; y++)
        {
            for (int x = 0; x < 3; x++)
            {
                if (tabuleiro[x, y] == 0) return false;
            }
        }
        return true;
    }

    do
    {
        Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[1, 0]} | {tabuleiro[2, 0]} ");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {tabuleiro[0, 1]} | {tabuleiro[1, 1]} | {tabuleiro[2, 1]} ");
        Console.WriteLine($"-----------");
        Console.WriteLine($" {tabuleiro[0, 2]} | {tabuleiro[1, 2]} | {tabuleiro[2, 2]} ");
        do
        {
            Console.WriteLine("Digite a cordenada horizontal");
            x = int.Parse(Console.ReadLine()) - 1;
        } while (x < 0 || x > 2);
        do
        {
            Console.WriteLine("Digite a cordenada vertical");
            y = int.Parse(Console.ReadLine()) - 1;
        } while (y < 0 || y > 2);

        if (tabuleiro[x, y] == 0)
        {
            tabuleiro[x, y] = jogador;
            if (jogador == 1)
            {
                jogador = 2;
            }
            else
            {
                jogador = 1;
            }

            if (ganhou())
            {
                t = 1;
            }
            if (empatou())
            {
                t = 2;
            }

        }

        Console.Clear();

        if (t == 1)
        {
            if (jogador == 1)
            {
                jogador = 2;
            }
            else
            {
                jogador = 1;
            }

            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[1, 0]} | {tabuleiro[2, 0]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {tabuleiro[0, 1]} | {tabuleiro[1, 1]} | {tabuleiro[2, 1]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {tabuleiro[0, 2]} | {tabuleiro[1, 2]} | {tabuleiro[2, 2]} ");
            Console.WriteLine(" ");
            Console.WriteLine($"Jogador {jogador} ganhou!");
        }

        if (t == 2)
        {
            Console.WriteLine($" {tabuleiro[0, 0]} | {tabuleiro[1, 0]} | {tabuleiro[2, 0]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {tabuleiro[0, 1]} | {tabuleiro[1, 1]} | {tabuleiro[2, 1]} ");
            Console.WriteLine($"-----------");
            Console.WriteLine($" {tabuleiro[0, 2]} | {tabuleiro[1, 2]} | {tabuleiro[2, 2]} ");
            Console.WriteLine(" ");
            Console.WriteLine($"Empate :(");
        }

    } while (t == 0);

    Console.WriteLine("");
    Console.WriteLine("Aperte R para jogar novamente ou aperte outra tecla para sair");

    if (reiniciar())
    {
        jogando = true;
    }
    else
    {
        jogando = false;
    }

    Console.Clear();
} while (jogando);