using PilhaDinamica;

internal class Program
{
    private static void Main(string[] args)
    {
        PilhaLivro minhapilha = new PilhaLivro();
        int opc; 
        //Livro livro1 = new Livro("Tikinho Bola 8"); 
        //Livro livro2 = new Livro("Ventos Escaldantes");

        //minhapilha.print();
        //minhapilha.push(livro1);
        //minhapilha.push(livro2);
        ////minhapilha.print();
        //minhapilha.pop();
        //minhapilha.pop();
        //minhapilha.print();
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Principal - Pilha de Livro");
            Console.WriteLine("Opções: ");
            Console.WriteLine("1 - Inserir Livro: ");
            Console.WriteLine("2 - Remover Livro: ");
            Console.WriteLine("3 - Imprimir Pilha: ");
            Console.WriteLine("4 - Localizar Livro Especifico: ");
            Console.WriteLine("5 - Quantidade de Livros: ");
            Console.WriteLine("0 - Sair: ");
            Console.WriteLine("Informe a opção desejada! ");  
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    minhapilha.push(cadastro_livro());
                    break;
                case 2:
                    minhapilha.pop();
                    break;
                case 3:
                    minhapilha.print();
                    break;
                case 4:
                    //fazer
                    Console.WriteLine("Informe o título do livro a ser buscado: ");
                    string tituloBusca = Console.ReadLine();

                    Livro livroEncontrado = minhapilha.buscarLivro(tituloBusca);
                    if (livroEncontrado != null)
                    {
                        Console.WriteLine("Livro encontrado na pilha:");
                        Console.WriteLine(livroEncontrado);
                    }
                    else
                    {
                        Console.WriteLine("Livro não encontrado na pilha.");
                    }
                    break;
                case 5:
                    Console.WriteLine($"A quantidade de livros na pilha é: {minhapilha.quantidade()} livros");
                    break; 
                 case 0:
                    Console.WriteLine("Fim do Programa");
                    break;
                default:
                    Console.WriteLine("Opção inexistente!");
                    break;
            }
        } while (opc != 0);
    }
    static Livro cadastro_livro()
    {
        string titulo;
        Console.WriteLine("Informe o titulo do novo Livro: ");
        titulo = Console.ReadLine();
        return new Livro(titulo);
    }
}