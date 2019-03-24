using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campo_Minado
{
    class Screens
    {
        Functions f = new Functions();
        Program p = new Program();
        Game g = new Game();

        ConsoleColor corPrincipal = ConsoleColor.Blue;
        ConsoleColor corSecundaria = ConsoleColor.White;

        public void inicio_1()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____                              ___  ____                 _       ");
            f.centralizar("/  __ \\                             |  \\/  (_)               | |      ");
            f.centralizar("| /  \\/ __ _ _ __ ___  _ __   ___   | .  . |_ _ __   __ _  __| | ___  ");
            f.centralizar("| |    / _` | '_ ` _ \\| '_ \\ / _ \\  | |\\/| | | '_ \\ / _` |/ _` |/ _ \\ ");
            f.centralizar("| \\__/\\ (_| | | | | | | |_) | (_) | | |  | | | | | | (_| | (_| | (_) |");
            f.centralizar(" \\____/\\__,_|_| |_| |_| .__/ \\___/  \\_|  |_/_|_| |_|\\__,_|\\__,_|\\___/ ");
            f.centralizar("                      | |                                             ");
            f.centralizar("                      |_|                                             ");
            f.centralizar("");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("╔═══════════╗");
            f.centralizar("║ NOVO JOGO ║");
            f.centralizar("╚═══════════╝");
            Console.ForegroundColor = corSecundaria;
            f.centralizar("");
            f.centralizar("CONFIGURAÇÕES");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("COMO JOGAR");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("SAIR");
        }

        public void inicio_2()
        {
            Console.Clear();

            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____                              ___  ____                 _       ");
            f.centralizar("/  __ \\                             |  \\/  (_)               | |      ");
            f.centralizar("| /  \\/ __ _ _ __ ___  _ __   ___   | .  . |_ _ __   __ _  __| | ___  ");
            f.centralizar("| |    / _` | '_ ` _ \\| '_ \\ / _ \\  | |\\/| | | '_ \\ / _` |/ _` |/ _ \\ ");
            f.centralizar("| \\__/\\ (_| | | | | | | |_) | (_) | | |  | | | | | | (_| | (_| | (_) |");
            f.centralizar(" \\____/\\__,_|_| |_| |_| .__/ \\___/  \\_|  |_/_|_| |_|\\__,_|\\__,_|\\___/ ");
            f.centralizar("                      | |                                             ");
            f.centralizar("                      |_|                                             ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("NOVO JOGO");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("╔═══════════════╗");
            f.centralizar("║ CONFIGURAÇÕES ║");
            f.centralizar("╚═══════════════╝");
            Console.ForegroundColor = corSecundaria;
            f.centralizar("");
            f.centralizar("COMO JOGAR");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("SAIR");
        }

        public void inicio_3()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____                              ___  ____                 _       ");
            f.centralizar("/  __ \\                             |  \\/  (_)               | |      ");
            f.centralizar("| /  \\/ __ _ _ __ ___  _ __   ___   | .  . |_ _ __   __ _  __| | ___  ");
            f.centralizar("| |    / _` | '_ ` _ \\| '_ \\ / _ \\  | |\\/| | | '_ \\ / _` |/ _` |/ _ \\ ");
            f.centralizar("| \\__/\\ (_| | | | | | | |_) | (_) | | |  | | | | | | (_| | (_| | (_) |");
            f.centralizar(" \\____/\\__,_|_| |_| |_| .__/ \\___/  \\_|  |_/_|_| |_|\\__,_|\\__,_|\\___/ ");
            f.centralizar("                      | |                                             ");
            f.centralizar("                      |_|                                             ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("NOVO JOGO");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("CONFIGURAÇÕES");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("╔════════════╗");
            f.centralizar("║ COMO JOGAR ║");
            f.centralizar("╚════════════╝");
            Console.ForegroundColor = corSecundaria;
            f.centralizar("");
            f.centralizar("SAIR");
            f.centralizar("");
        }

        public void inicio_4()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____                              ___  ____                 _       ");
            f.centralizar("/  __ \\                             |  \\/  (_)               | |      ");
            f.centralizar("| /  \\/ __ _ _ __ ___  _ __   ___   | .  . |_ _ __   __ _  __| | ___  ");
            f.centralizar("| |    / _` | '_ ` _ \\| '_ \\ / _ \\  | |\\/| | | '_ \\ / _` |/ _` |/ _ \\ ");
            f.centralizar("| \\__/\\ (_| | | | | | | |_) | (_) | | |  | | | | | | (_| | (_| | (_) |");
            f.centralizar(" \\____/\\__,_|_| |_| |_| .__/ \\___/  \\_|  |_/_|_| |_|\\__,_|\\__,_|\\___/ ");
            f.centralizar("                      | |                                             ");
            f.centralizar("                      |_|                                             ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("NOVO JOGO");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("CONFIGURAÇÕES");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("COMO JOGAR");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("╔══════╗");
            f.centralizar("║ SAIR ║");
            f.centralizar("╚══════╝");
            Console.ForegroundColor = corSecundaria;
        }

        string color1 = "  AZUL  ";
        string color2 = " BRANCO ";

        public void config_1()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____              __ _                                          ");
            f.centralizar("/  __ \\            / _(_)                                         ");
            f.centralizar("| /  \\/ ___  _ __ | |_ _  __ _ _   _ _ __ __ _  ___ ___   ___ ___ ");
            f.centralizar("| |    / _ \\| '_ \\|  _| |/ _` | | | | '__/ _` |/ __/ _ \\ / _ / __|");
            f.centralizar("| \\__/| (_) | | | | | | | (_| | |_| | | | (_| | (_| (_) |  __\\__ \\");
            f.centralizar(" \\____/\\___/|_| |_|_| |_|\\__, |\\__,_|_|  \\__,_|\\___\\___/ \\___|___/");
            f.centralizar("                          __/ |                                   ");
            f.centralizar("                         |___/                                    ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("NUMERO DE BOMBAS");
            f.centralizar("  ╔══════╗  ");
            f.centralizar($"< ║  {numeroDeBombas.ToString().PadLeft(2)}  ║ >");
            f.centralizar("  ╚══════╝  ");
            Console.ForegroundColor = corSecundaria;
            f.centralizar("");
            f.centralizar("COR PRINCIPAL");
            f.centralizar("");
            f.centralizar($"{color1}");
            f.centralizar(" ");
            f.centralizar("");
            f.centralizar("COR SECUNDARIA");
            f.centralizar("");
            f.centralizar($"{color2}");
            f.centralizar("");
        }

        public void config_2()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____              __ _                                          ");
            f.centralizar("/  __ \\            / _(_)                                         ");
            f.centralizar("| /  \\/ ___  _ __ | |_ _  __ _ _   _ _ __ __ _  ___ ___   ___ ___ ");
            f.centralizar("| |    / _ \\| '_ \\|  _| |/ _` | | | | '__/ _` |/ __/ _ \\ / _ / __|");
            f.centralizar("| \\__/| (_) | | | | | | | (_| | |_| | | | (_| | (_| (_) |  __\\__ \\");
            f.centralizar(" \\____/\\___/|_| |_|_| |_|\\__, |\\__,_|_|  \\__,_|\\___\\___/ \\___|___/");
            f.centralizar("                          __/ |                                   ");
            f.centralizar("                         |___/                                    ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("NUMERO DE BOMBAS");
            f.centralizar("");
            f.centralizar($"{numeroDeBombas.ToString().PadLeft(2)}");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("");
            f.centralizar("COR PRINCIPAL");
            f.centralizar("  ╔══════════╗  ");
            f.centralizar($" < ║ { color1} ║ > ");
            f.centralizar("  ╚══════════╝  ");
            f.centralizar("");
            Console.ForegroundColor = corSecundaria;
            f.centralizar("COR SECUNDARIA");
            f.centralizar("");
            f.centralizar($"{color2}");
            f.centralizar("");
        }

        public void config_3()
        {
            Console.Clear();
            Console.ForegroundColor = corSecundaria;
            f.centralizar(" _____              __ _                                          ");
            f.centralizar("/  __ \\            / _(_)                                         ");
            f.centralizar("| /  \\/ ___  _ __ | |_ _  __ _ _   _ _ __ __ _  ___ ___   ___ ___ ");
            f.centralizar("| |    / _ \\| '_ \\|  _| |/ _` | | | | '__/ _` |/ __/ _ \\ / _ / __|");
            f.centralizar("| \\__/| (_) | | | | | | | (_| | |_| | | | (_| | (_| (_) |  __\\__ \\");
            f.centralizar(" \\____/\\___/|_| |_|_| |_|\\__, |\\__,_|_|  \\__,_|\\___\\___/ \\___|___/");
            f.centralizar("                          __/ |                                   ");
            f.centralizar("                         |___/                                    ");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("NUMERO DE BOMBAS");
            f.centralizar("");
            f.centralizar($"{numeroDeBombas.ToString().PadLeft(2)}");
            f.centralizar("");
            f.centralizar("");
            f.centralizar("COR PRINCIPAL");
            f.centralizar("");
            f.centralizar($"{color1}");
            f.centralizar("");
            f.centralizar("");
            Console.ForegroundColor = corPrincipal;
            f.centralizar("COR SECUNDARIA");
            f.centralizar("  ╔══════════╗  ");
            f.centralizar($"< ║ {color2} ║ >");
            f.centralizar("  ╚══════════╝  ");
        }

        public void comoJogar()
        {
            Console.Clear();
            f.centralizar(" _____                           ___                        ");
            f.centralizar("/  __ \\                         |_  |                       ");
            f.centralizar("| /  \\/ ___  _ __ ___   ___       | | ___   __ _  __ _ _ __ ");
            f.centralizar("| |    / _ \\| '_ ` _ \\ / _ \\      | |/ _ \\ / _` |/ _` | '__|");
            f.centralizar("| \\__/| (_) | | | | | | (_) | /\\__/ | (_) | (_| | (_| | |   ");
            f.centralizar(" \\____/\\___/|_| |_| |_|\\___/  \\____/ \\___/ \\__, |\\__,_|_|   ");
            f.centralizar("                                            __/ |           ");
            f.centralizar("                                           |___/            ");
            f.centralizar("");
            f.centralizar("O seu objetivo é liberar todos os espaços sem pisar em nenhuma bomba");
            f.centralizar("Para isso os numeros indicam o numero de Bombas envolta do proprio");
            f.centralizar("Para isso use:");
            f.centralizar("Setas para se Movimentar");
            f.centralizar("Enter para abrir a casa");
            f.centralizar("Espaço para marcar/desmarcar possiveis bombas");
            f.centralizar("Esc para voltar");
        }   


        int numeroDeBombas = 10;
        int coresPrinc = 0;
        int coresSec = 5;
        
        /* 0- Azul
         * 1- Vermelho
         * 2- Roxo
         * 3- Verde
         * 4- Amarelo
         * 5- Branco
         */ 

        public void iniciarJogo()
        {
            Functions f = new Functions();
            Game g = new Game();
            int tela = 1;

            Console.CursorVisible = false;
            while (true)
            {
                switch (tela)
                {
                    case 1:
                        inicio_1();
                        break;
                    case 2:
                        inicio_2();
                        break;
                    case 3:
                        inicio_3();
                        break;
                    case 4:
                        inicio_4();
                        break;
                  }
                ConsoleKeyInfo keyPress = Console.ReadKey(true);
                if (keyPress.Key == ConsoleKey.UpArrow && tela > 1)
                {
                    tela--;
                }
                else if (keyPress.Key == ConsoleKey.DownArrow && tela < 4)
                {
                    tela++;
                }
                else if (keyPress.Key == ConsoleKey.Enter)
                {
                    break;
                }
            }

            if (tela == 1)
            {
                Console.CursorVisible = true;

                g.numBombas = numeroDeBombas;
                g.iniciarCampo();
                g.colocarBombas();
                g.Dicas();
                g.iniciarMoves();

                bool game = true;
                while (game)
                {
                    game = g.Move();
                }
                g.MostrarTudo();

                iniciarJogo();
            }

            else if (tela == 2)
            {
                int telaConfig = 1;

                while (true)
                {
                    switch (telaConfig)
                    {
                        case 1:
                            config_1();
                            break;
                        case 2:
                            config_2();
                            break;
                        case 3:
                            config_3();
                            break;
                    }

                    ConsoleKeyInfo keyPress = Console.ReadKey(true);
                    if (keyPress.Key == ConsoleKey.UpArrow && telaConfig > 1)
                    {
                        telaConfig--;
                    }
                    else if (keyPress.Key == ConsoleKey.DownArrow && telaConfig < 3)
                    {
                        telaConfig++;
                    }
                    else if (keyPress.Key == ConsoleKey.RightArrow && telaConfig == 1)
                    {
                        numeroDeBombas++;
                    }
                    else if (keyPress.Key == ConsoleKey.LeftArrow && telaConfig == 1)
                    {
                        numeroDeBombas--;
                    }
                    else if (keyPress.Key == ConsoleKey.RightArrow && telaConfig == 2 && coresPrinc < 5)
                    {
                        coresPrinc++;
                        switch(coresPrinc)
                        {
                            case 0:
                                color1 = "  AZUL  ";
                                corPrincipal = ConsoleColor.Blue;
                                break;
                            case 1:
                                color1 = "VERMELHO";
                                corPrincipal = ConsoleColor.DarkRed;
                                break;
                            case 2:
                                color1 = "  ROXO  ";
                                corPrincipal = ConsoleColor.DarkMagenta;
                                break;
                            case 3:
                                color1 = " AMARELO";
                                corPrincipal = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                color1 = "  VERDE ";
                                corPrincipal = ConsoleColor.Green;
                                break;
                            case 5:
                                color1 = " BRANCO ";
                                corPrincipal = ConsoleColor.White;
                                break;
                        }

                    }
                    else if (keyPress.Key == ConsoleKey.LeftArrow && telaConfig == 2 && coresPrinc > 0)
                    {
                        coresPrinc--;
                        switch (coresPrinc)
                        {
                            case 0:
                                color1 = "  AZUL  ";
                                corPrincipal = ConsoleColor.Blue;
                                break;
                            case 1:
                                color1 = "VERMELHO";
                                corPrincipal = ConsoleColor.DarkRed;
                                break;
                            case 2:
                                color1 = "  ROXO  ";
                                corPrincipal = ConsoleColor.DarkMagenta;
                                break;
                            case 3:
                                color1 = " AMARELO";
                                corPrincipal = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                color1 = "  VERDE ";
                                corPrincipal = ConsoleColor.Green;
                                break;
                            case 5:
                                color1 = " BRANCO ";
                                corPrincipal = ConsoleColor.White;
                                break;
                        }
                    }

                    else if (keyPress.Key == ConsoleKey.RightArrow && telaConfig == 3 && coresSec < 5)
                    {
                        coresSec++;
                        switch (coresSec)
                        {
                            case 0:
                                color2 = "  AZUL  ";
                                corSecundaria = ConsoleColor.Blue;
                                break;
                            case 1:
                                color2 = "VERMELHO";
                                corSecundaria = ConsoleColor.DarkRed;
                                break;
                            case 2:
                                color2 = "  ROXO  ";
                                corSecundaria = ConsoleColor.DarkMagenta;
                                break;
                            case 3:
                                color2 = " AMARELO";
                                corSecundaria = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                color2 = "  VERDE ";
                                corSecundaria = ConsoleColor.Green;
                                break;
                            case 5:
                                color2 = " BRANCO ";
                                corSecundaria = ConsoleColor.White;
                                break;
                        }
                    }

                    else if (keyPress.Key == ConsoleKey.LeftArrow && telaConfig == 3 && coresSec > 0)
                    {
                        coresSec--;
                        switch (coresSec)
                        {
                            case 0:
                                color2 = "  AZUL  ";
                                corSecundaria = ConsoleColor.Blue;
                                break;
                            case 1:
                                color2 = "VERMELHO";
                                corSecundaria = ConsoleColor.DarkRed;
                                break;
                            case 2:
                                color2 = "  ROXO  ";
                                corSecundaria = ConsoleColor.DarkMagenta;
                                break;
                            case 3:
                                color2 = " AMARELO";
                                corSecundaria = ConsoleColor.DarkYellow;
                                break;
                            case 4:
                                color2 = "  VERDE ";
                                corSecundaria = ConsoleColor.Green;
                                break;
                            case 5:
                                color2 = " BRANCO ";
                                corSecundaria = ConsoleColor.White;
                                break;
                        }
                    }
                    else if (keyPress.Key == ConsoleKey.Escape)
                    {
                        iniciarJogo();
                        break;

                    }
                }
            }

            else if(tela == 3)
            {
                comoJogar();
                ConsoleKeyInfo keyPress;
                while (true)
                {
                    keyPress = Console.ReadKey(true);

                    if(keyPress.Key == ConsoleKey.Escape)
                    {
                        iniciarJogo();
                    }
                    
                }
            }
        }

        
    }
}
