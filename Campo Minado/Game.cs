using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_Minado
{
    class Game
    {

        Functions f = new Functions();

        private int[,] campo = new int[8, 10];

        private int[,] moves = new int[8, 10];

        private int casasEncontradas;
        public int numBombas;

        public int bombasEncontradas;

        public void Win()
        {
            f.centralizar("          ____            ____            ____          ");
            f.centralizar("         /....\\          /....\\          /....\\         ");
            f.centralizar(" .-.    |::::::|    .-. |::::::|    .-. |::::::|        ");
            f.centralizar(" | |    |::::::|    | | |::::::|    | | |::::::|        ");
            f.centralizar(" | |    (`:'':')    | | (`:'':')    | | (`:'':')        ");
            f.centralizar(" | |   _--|__|--__  | |.--|__|--__  | |_--|__|--__      ");
            f.centralizar(" | |  |   ________|_|_|_  ________|_|_|_  ________|_____");
            f.centralizar(" | | /    |            |  |            |  |            |");
            f.centralizar(" | |/  /  |            |  |            |  |            |");
            f.centralizar(" |_| |/|  |            |  |            |  |            |");
            f.centralizar("(===)| |  |  E  A  B   |  |  E  A  B   |  |  E  A  B   |");
            f.centralizar("`==='  |`-|            |`-|            |`-|            |");
            f.centralizar(" | |   |`-|            |`-|            |`-|            |");
            f.centralizar(" |_|   |  |            |  |            |  |            |");
            f.centralizar("       |  |            |  |            |  |            |");
            f.centralizar("       |  |            |  |            |  |            |");
            f.centralizar("       |`-|            |`-|            |`-|            |");
            f.centralizar("       |__|            |__|            |__|            |");
            f.centralizar("       /_ |            |_ |            |_ |            |");
            f.centralizar("      |___`-__________-'__`-__________-'__`-__________-'");
            f.centralizar("");
            f.centralizar("Parabens você se demonstrou digno para entrar no EAB");
            f.centralizar("(ESQUADRÃO ANTI-BOMBAS)");
        }
        public void Lose()
        {
            Console.Clear();
            f.centralizar("VOCÊ PERDEU");
            f.centralizar("");
            f.centralizar("     _.-^^---....,,--       ");
            f.centralizar(" _--                  --_  ");
            f.centralizar("<                        >)");
            f.centralizar("|                         | ");
            f.centralizar(" \\._                   _./  ");
            f.centralizar("    ```--. . , ; .--'''       ");
            f.centralizar("          | |   |             ");
            f.centralizar("       .-=||  | |=-.   ");
            f.centralizar("       `-=#$%&%$#=-'   ");
            f.centralizar("          | ;  :|     ");
            f.centralizar(" _____.,-#%&$@%#&#~,._____");
            f.centralizar("");
            f.centralizar("ESC OU ENTER PARA RETORNAR AO MENU");
        }

        public void iniciarCampo()
        { 
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    campo[y, x] = 0;
                }
            }
        }

        public void colocarBombas()
        {
            Random random = new Random();
            int y;
            int x;
            int bombasColocadas = 0;
            while (bombasColocadas < numBombas)
            {
                y = random.Next(0, 7);
                x = random.Next(0, 9);

                if (campo[y, x] == 0)
                {
                    campo[y, x] = -1;
                    bombasColocadas++;
                }
            }
            bombasEncontradas = 0;
        }

        public void iniciarMoves()
        {
            casasEncontradas = 0;
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    moves[y, x] = 0;
                }
            }
        }

        public void MostrarTudo()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    moves[y, x] = 1;
                }
            }
            DrawField();
        }

        public void Dicas()
        {
            for (int y = 0; y < 8; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    if (campo[y, x] == -1)
                    {
                        /* | -1 -1 | -1 0 | -1 1
                         * | 0 -1  |  0 0 | 0 1 
                         * | 1 -1  | 1 0  | 1 1
                         */

                        // -1 -1
                        if (y - 1 >= 0 && x - 1 >= 0)
                        {
                            if (campo[y - 1, x - 1] != -1)
                            {
                                campo[y - 1, x - 1] += 1;
                            }

                        }

                        // -1 0
                        if (y - 1 >= 0)
                        {
                            if (campo[y - 1, x] != -1)
                            {
                                campo[y - 1, x] += 1; ;
                            }
                        }

                        //-1 1
                        if (y - 1 >= 0 && x + 1 <= 9)
                        {
                            if (campo[y - 1, x + 1] != -1)
                            {
                                campo[y - 1, x + 1] += 1;
                            }
                        }

                        // 0 -1
                        if (x - 1 >= 0)
                        {
                            if (campo[y, x - 1] != -1)
                            {
                                campo[y, x - 1] += 1;
                            }
                        }

                        // 0 1
                        if (x + 1 <= 9)
                        {
                            if (campo[y, x + 1] != -1)
                            {
                                campo[y, x + 1] += 1;
                            }
                        }

                        // 1 -1
                        if (y + 1 <= 7 && x - 1 >= 0)
                        {
                            if (campo[y + 1, x - 1] != -1)
                            {
                                campo[y + 1, x - 1] += 1;
                            }

                        }

                        // 1 0
                        if (y + 1 <= 7 && x + 1 >= 0)
                        {
                            if (campo[y + 1, x] != -1)
                            {
                                campo[y + 1, x] += 1;
                            }
                        }

                        // 1 1
                        if (y + 1 <= 7 && x + 1 <= 9)
                        {
                            if (campo[y + 1, x + 1] != -1)
                            {
                                campo[y + 1, x + 1] += 1;
                            }
                        }
                    }
                }
            }
        }


        public void DrawField()
        {
            Console.Clear();

            f.centralizar("╔═╦═╦═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╦═══╗");
            f.centralizar("╠═╬═╣ A ║ B ║ C ║ D ║ E ║ F ║ G ║ H ║ I ║ J ║");
            f.centralizar("╠═╩═╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");

            string linha = "";

            for (int y = 0; y < 8; y++)
            {
                linha = "";
                for (int x = 0; x < 10; x++)
                {
                    if (x == 0)
                    {
                        linha = "║ " + (y + 1) + " ";
                    }

                    if (moves[y, x] == 0)
                    {
                        linha = linha + "║   ";
                    }

                    else if (moves[y, x] == 1 && campo[y, x] == -1)
                    {
                        linha = linha + "║ * ";
                    }

                    else if (moves[y, x] == 2)
                    {
                        linha = linha + "║ ! ";
                    }

                    else
                    {
                        linha = linha + "║ " + campo[y, x] + " ";
                    }

                    if (x == 9)
                    {
                        linha = linha + "║";
                    }
                }

                f.centralizar(linha);

                if (y < 7)
                {
                    f.centralizar("╠═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╬═══╣");
                }

                else
                {
                    f.centralizar("╚═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╩═══╝");
                }
            }
            f.centralizar("╔═════════════════════╗");
            f.centralizar("║ BOMBAS RESTANTES " + (numBombas - bombasEncontradas).ToString().PadLeft(2) + " ║");
            f.centralizar("╚═════════════════════╝");
        }

        int cursorX = -17;
        int cursorY = 3;
        int posX = 0;
        int posY = 0;
        //Altura começa em 3 e vai somando 2
        //Largura começa em -17 e vai somando 4

        public bool Move()
        {

            DrawField();

            ConsoleKeyInfo keyPress;
            bool teste = true;

            do
            {
                Console.SetCursorPosition(Console.WindowWidth / 2 + cursorX, cursorY);
                keyPress = Console.ReadKey(true);
                switch (keyPress.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (cursorX < 17)
                        {
                            cursorX += +4;
                            posX++;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (cursorX > -17)
                        {
                            cursorX -= 4;
                            posX--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (cursorY > 3)
                        {
                            cursorY -= 2;
                            posY--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (cursorY < 17)
                        {
                            cursorY += 2;
                            posY++;
                        }
                        break;

                    case ConsoleKey.Enter:
                        
                        if (moves[posY, posX] == 0)
                        {
                            if (campo[posY, posX] == -1)
                            {

                                MostrarTudo();
                                System.Threading.Thread.Sleep(3000);
                                Lose();

                                while (true)
                                {
                                    keyPress = Console.ReadKey(true);
                                    
                                    if (keyPress.Key == ConsoleKey.Enter || keyPress.Key == ConsoleKey.Escape)
                                    {
                                        break;
                                    }
                                }

                                return false;
                            }
                            casasEncontradas++;
                            moves[posY, posX] = 1;
                            teste = false;
                            if(casasEncontradas == 80 - numBombas)
                            {
                                Console.Clear();
                                Win();
                                while(true)
                                {
                                    keyPress = Console.ReadKey(true);
                                    if (keyPress.Key == ConsoleKey.Enter || keyPress.Key == ConsoleKey.Escape)
                                    {
                                        break;
                                    }
                                }
                                return false;
                            }
                        }
                        break;

                    case ConsoleKey.Spacebar:
                        if (moves[posY, posX] == 0)
                        {
                            moves[posY, posX] = 2;
                            teste = false;
                            bombasEncontradas++;
                        }
                        else if (moves[posY, posX] == 2)
                        {
                            moves[posY, posX] = 0;
                            teste = false;
                            bombasEncontradas--;
                        }
                        break;

                    case ConsoleKey.Escape:
                        return false;
                        break;
                }
            } while (teste);
            return true;
        }
    }
}
