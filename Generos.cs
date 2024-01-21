public class Generos{
        public void Genero(int n){
            
            Catalogo catalogo2 = new Catalogo();

            switch (n){

            case 1:

            Console.WriteLine("Categoria Ação: ");
            Console.WriteLine("------------------");
            Console.WriteLine();
            catalogo2.Detalhes("O CÓDIGO DE DA VINCI - Dan Brown" ,"Dan Brown",97,"Perfeição num best-seller. Um suspense divertidamente erudito, que se delicia levando os leitores numa caçada ofegante e guiando-os através de situações complicadas. The New York Times",37.77m);
            Console.WriteLine();
            Console.WriteLine(" O SENHOR DOS ANÉIS  - J.R.R Tolkien");
            Console.WriteLine(" JOGOS VORAZES - Suzanne Collins ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;

            case 2:
            
            Console.WriteLine("Categoria Romance:");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine(" BREVE ROMANCE DE SONHO - Arthur Schnitzler ");
            Console.WriteLine(" UM ROMANCE INESQUECÍVEL - Jessica Bird ");
            Console.WriteLine(" ANTES QUE O CAFÉ ESFRIE - Toshikazu Kawaguchi ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;
            
            case 3:
            
            Console.WriteLine("Categoria Literatura Infantil :");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine(" O PEQUENO PRÍNCIPE - Antoine de Saint-Exupéry  ");
            Console.WriteLine(" A BOLSA AMARELA - Lygia Bojunga");
            Console.WriteLine(" MARCELO, MARMELO, MARTELO - Ruth Rocha ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;
            
            case 4:

            Console.WriteLine("Categoria Ficção Cientifica:");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine(" DUNA - FRANK HERBERT");
            Console.WriteLine(" NEUROMANCER - DE WILLIAM GIBSON ");
            Console.WriteLine(" FUNDAÇÃO - ISAAC ASIMOV ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;

            case 5:

            Console.WriteLine("Categoria Terror:");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine(" O ESTRANHO MUNDO DE JACK - DE TIM BURTON ");
            Console.WriteLine(" O EXORCISTA - DE WILLIAM PETER BLATTY ");
            Console.WriteLine(" HELL HOUSE: A CASA INFERNAL - DE Richard Matheson ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;

            case 6:

            Console.WriteLine("Categoria Autobiografia:");
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine(" 3096 DIAS - Nataha kampusch  ");
            Console.WriteLine(" EM BUSCA DE MIM - Viola Davis ");
            Console.WriteLine(" MINHA HISTÓRIA - Michelle Obama ");
            Console.WriteLine();
            Console.WriteLine("------------------");
            Console.WriteLine();
            Console.WriteLine("Para voltar aos Generos Digite [0]");
            break;
        }
    }
}