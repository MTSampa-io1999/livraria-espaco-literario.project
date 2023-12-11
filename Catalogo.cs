public class Catalogo{
    public void DisplayBookDetails(string titulo, string autor, int paginas, string descricao, decimal preco)
        {
            Console.WriteLine($"{titulo} - {autor}");
            Console.WriteLine($"CAPA COMUM - {paginas} Páginas.");
            Console.WriteLine("");
            Console.WriteLine($"DESCRIÇÃO - {descricao}");
            Console.WriteLine("");
            Console.WriteLine($"R$ {preco}");
            Console.WriteLine("");
        }
}


