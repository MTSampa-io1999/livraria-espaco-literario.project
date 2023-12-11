namespace atividade07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0,y = 0,z = 0;
            string email, senha, senha1, s1, email1;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("BEM VINDO A LIVRARIA ESPAÇO LITERÁRIO!");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Por Favor, Faça um Cadastro para ter acesso ao nosso Catalogo!");
            Console.WriteLine();
            Console.WriteLine("Aperte qualquer botão para continuar");
            Console.ReadLine();
            Console.Clear();
            
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Faça seu Cadastro!");
                Console.WriteLine("-------------------------------------------");
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
                    Console.WriteLine("Senhas não coincidem, aperte enter para tentar" +
                        "novamente...");
                    Console.ReadLine();
                    y = 1;
                }
            } while (y > 0);

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Faça seu Login");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Digite seu email:");
                email1 = Console.ReadLine();
                Console.WriteLine("Digite sua Senha:");
                senha1 = Console.ReadLine();

                if (senha1 == senha)
                {
                    z = 0;
                }
                if(email == email1)
                {
                    z = 0;
                }
                else
                {
                    Console.WriteLine("Senhas ou Email não coincidem, aperte enter para tentar" +
                        "novamente...");
                    Console.ReadLine();
                    z = 1;
                }
            } while (z > 0);
            
            bool VoltarAoCataLogo = false;
            int n;
           
            do{

                Catalogo Catalogo1 = new Catalogo();
                
                Console.Clear();
                Console.WriteLine("SEJA BEM-VINDO AO NOSSO CATALOGO!");
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine();
                Console.WriteLine("Top 3 livros mais vendindos em nosso site");
                Console.WriteLine();
                Console.WriteLine("[1] ANTES QUE O CAFÉ ESFRIE..");
                Console.WriteLine();
                Console.WriteLine("[2] 3096 DIAS NATASHA KAMPUSCH..");
                Console.WriteLine();
                Console.WriteLine("[3] O PEQUENO PRINCIPE.. ");
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Ficou curioso pra saber mais sobre esses livros ?");
                Console.WriteLine();
                Console.WriteLine("Digitar o número de algum desses TOP 3");
                Console.WriteLine();
                Console.WriteLine("Digite [4] caso queira ver os Gêneros disponiveis");
                Console.WriteLine();
                Console.WriteLine("Digite [0] para encerrar o sistema:");

                int catalogo = Int32.Parse(Console.ReadLine());
                Console.Clear();

                switch (catalogo)
                {
                    case 0:
                        VoltarAoCataLogo = false;
                        break;

                    case 1:

                        do
                        {
                            Catalogo1.DisplayBookDetails("ANTES QUE O CAFÉ ESFRIE - Toshikazu Kawaguchi", "Toshikazu Kawaguchi", 208,
                                "Se fosse possível viajar no tempo, quem você gostaria de encontrar? ...", 27.99m);

                            Console.WriteLine("Digite [1] para comprar o produto!, Para voltar ao Catalogo Digite [0]");
                            n = Int32.Parse(Console.ReadLine());

                            switch (n)
                            {
                                case 0:
                                    x = 0;
                                    VoltarAoCataLogo = true;
                                    break;
                                case 1:
                                    Console.WriteLine("Opção Ainda em Desenvolvimento. Tente outra Opção. Aperte qualquer botão para continuar");
                                    Console.ReadLine();
                                    Console.Clear();
                                    x = 1;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Tente novamente. Aperte qualquer botão para continuar");
                                    Console.ReadLine();
                                    Console.Clear();
                                    x = 1;
                                    break;
                            }
                        } while (x > 0);
                            break;
                        
                    case 2:

                        do { 
                        Catalogo1.DisplayBookDetails("3096 DIAS - Nataha kampusch", "Nataha kampusch", 224,
                            "A impressionante história da garota que ficou em cativeiro durante oito anos, 3096 dias, narra o drama de um dos sequestros mais longos de que se tem notícia.", 61.99m);

                        Console.WriteLine("Digite [1] para comprar o produto!, Para voltar ao Catalogo Digite [0]");
                        n = Int32.Parse(Console.ReadLine());

                        switch (n)
                        {
                            case 0:
                                x = 0;
                                VoltarAoCataLogo = true;
                                break;
                                case 1:
                                    Console.WriteLine("Opção Ainda em Desenvolvimento. Tente outra Opção. Aperte qualquer botão para continuar");
                                    Console.ReadLine();
                                    Console.Clear();
                                    x = 1;
                                    break;
                            default:
                                Console.WriteLine("Opção inválida. Tente novamente. Aperte qualquer botão para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                x = 1;
                                break;
                        }
                } while (x > 0) ;
                break;

                    case 3:

                        do { 
                        Catalogo1.DisplayBookDetails("O PEQUENO PRINCIPE - Antoine de Saint-Exupéry", "Antoine de Saint-Exupéry", 96,
                            "O Pequeno Príncipe é uma obra prima que conduz o leitor a uma viagem de descobertas pela essência humana.\n Este clássico atemporal de Antoine de Saint-Exupéry narra a história sobre o encontro de um aviador e um menino com “cabelos da cor do ouro”.\n À medida que o principezinho conta ao aviador sobre sua rotina no asteroide B 612,\n sua rosa única, o perigo dos baobás, sua raposa e os moradores de outros planetas, um novo olhar sobre a vida e o mundo é revelado.", 12.99m);

                            Console.WriteLine("Digite [1] para comprar o produto!, Para voltar ao Catalogo Digite [0]");
                        n = Int32.Parse(Console.ReadLine());

                        switch (n)
                        {
                            case 0:
                                x = 0;
                                VoltarAoCataLogo = true;
                                break;
                                case 1:
                                    Console.WriteLine("Opção Ainda em Desenvolvimento. Tente outra Opção. Aperte qualquer botão para continuar");
                                    Console.ReadLine();
                                    Console.Clear();
                                    x = 1;
                                    break;
                                default:
                                Console.WriteLine("Opção inválida. Tente novamente. Aperte qualquer botão para continuar");
                                Console.ReadLine();
                                Console.Clear();
                                x = 1;
                                break;
                        }
                } while (x > 0) ;
                break;

                case 4:
                
                break;

                    default:
                        Console.WriteLine("Opção inválida. Tente novamente. Aperte qualquer botão para continuar");
                        Console.ReadLine();
                        VoltarAoCataLogo = true;
                        break;
                }
            } while (VoltarAoCataLogo);
        }
    }
}