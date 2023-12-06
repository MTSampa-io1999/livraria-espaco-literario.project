namespace atividade07
{
    internal class Program
    {
        static void DisplayBookDetails(string titulo, string autor, int paginas, string descricao, decimal preco)
        {
            Console.WriteLine($"{titulo} - {autor}");
            Console.WriteLine($"CAPA COMUM - {paginas} Páginas.");
            Console.WriteLine("");
            Console.WriteLine($"DESCRIÇÃO - {descricao}");
            Console.WriteLine("");
            Console.WriteLine($"R$ {preco}");
            Console.WriteLine("");
        }
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;

            do
            {
                string email,e1 , senha1, senha, s1;
                int sn;

                Console.Clear();
                if (x > 0)
                {
                    Console.WriteLine("Senha inválida, Tente novamente");
                    Console.WriteLine();
                }
                Console.WriteLine("BEM VINDO A LIVRARIA ESPAÇO LITERÁRIO!");
                Console.WriteLine();
                Console.WriteLine("Você possui um Login?");
                Console.WriteLine();
                Console.WriteLine("Digite [1] se ja possui e [2] para fazer um cadastro!");
                sn = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (sn)
                {
                    case 1:

                    
                        Console.Clear();
                        Console.WriteLine("Faça seu Login");
                        Console.WriteLine();
                        Console.WriteLine("Digite seu email:");
                        e1 = Console.ReadLine();
                        Console.WriteLine("Digite sua Senha:");
                        senha1 = Console.ReadLine();

                        break;

                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Faça seu Cadastro!");
                            Console.WriteLine();
                            Console.WriteLine("Digite seu email:");
                            email = Console.ReadLine();
                            Console.WriteLine("Digite sua Senha:");
                            senha = Console.ReadLine();
                            Console.WriteLine("Confirme sua senha:");
                            s1 = Console.ReadLine();

                            if(s1 == senha){
                                y = 0;
                            }
                            else{ 
                                Console.WriteLine("Senhas não coincidem, aperte enter para tentar novamente...");
                                Console.ReadLine();
                                y = 1;
                            }
                            
                        } while (y > 0);
                        break;
                        
                    default:
                        x = 1;
                        break;
                }
            } while (x > 0);

           bool VoltarAoCataLogo = false;
           
            do
            {
                
                Console.Clear();
                Console.WriteLine("SEJA BEM-VINDO AO NOSSO CATALOGO!");

                Console.WriteLine("");

                Console.WriteLine("Top 3 livros mais vendindos em nosso site");
                Console.WriteLine("");

                Console.WriteLine("1# ANTES QUE O CAFÉ ESFRIE..");
                Console.WriteLine("");
                Console.WriteLine("2# 3096 DIAS NATASHA KAMPUSCH..");
                Console.WriteLine("");
                Console.WriteLine("3# O PEQUENO PRINCIPE.. ");

                Console.WriteLine("");

                Console.WriteLine("Ficou curioso pra saber mais sobre esses livros ? Só digitar o número de algum desses TOP 3, caso queira ver os Gêneros disponiveis digite [genero], Digite [0] para voltar ao menu principal:");
                int top = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (top)
                {
                    case 0:
                        break;

                    case 1:
                        DisplayBookDetails("ANTES QUE O CAFÉ ESFRIE - Toshikazu Kawaguchi", "Toshikazu Kawaguchi", 208,
                            "Se fosse possível viajar no tempo, quem você gostaria de encontrar? ...", 27.99m);

                            
                            Console.WriteLine("Para voltar ao Catalogo Digite [0]");
                            Console.ReadLine();
                             VoltarAoCataLogo = true;
                        break;

                    case 2:
                        DisplayBookDetails("3096 DIAS - Nataha kampusch", "Nataha kampusch", 224,
                            "A impressionante história da garota que ficou em cativeiro durante oito anos, 3096 dias, narra o drama de um dos sequestros mais longos de que se tem notícia.", 61.99m);

                            Console.WriteLine("Para voltar ao Catalogo Digite [0]");
                            Console.ReadLine();
                             VoltarAoCataLogo = true;
                        break;

                    case 3:
                        DisplayBookDetails("O PEQUENO PRINCIPE - Antoine de Saint-Exupéry", "Antoine de Saint-Exupéry", 96,
                            "O Pequeno Príncipe é uma obra prima que conduz o leitor a uma viagem de descobertas pela essência humana.\n Este clássico atemporal de Antoine de Saint-Exupéry narra a história sobre o encontro de um aviador e um menino com “cabelos da cor do ouro”.\n À medida que o principezinho conta ao aviador sobre sua rotina no asteroide B 612,\n sua rosa única, o perigo dos baobás, sua raposa e os moradores de outros planetas, um novo olhar sobre a vida e o mundo é revelado.", 12.99m);

                            Console.WriteLine("Para voltar ao Catalogo Digite [0]");
                            Console.ReadLine();
                            VoltarAoCataLogo = true;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        Console.ReadLine();
                        VoltarAoCataLogo = true;
                        break;
                }
                } while (VoltarAoCataLogo);
            }
        }
    }