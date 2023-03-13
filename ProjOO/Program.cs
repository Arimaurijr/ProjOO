internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Pessoa p = new Pessoa();
        Pessoa p2 = new Pessoa();
        Console.WriteLine("Infomme seu nome: ");
        p.DefinirNome(Console.ReadLine());
        Console.WriteLine("Seja bem vindo a orientação a objetos, " + p.RetornarNome());

        Console.WriteLine("Infomme seu nome: ");
        p2.DefinirNome(Console.ReadLine());
        Console.WriteLine("Seja bem vindo a orientação a objetos, " + p2.RetornarNome());
        */

        Pessoa pessoa1 = new Pessoa();

        Console.WriteLine("Digite seu primeiro nome: ");
        pessoa1.SetNome(Console.ReadLine());

        Console.WriteLine("Digite o seu sobrenome: ");
        pessoa1.SetSobenome(Console.ReadLine());

        pessoa1.ImprimirNomeCompleto();
        Console.WriteLine();
        Console.WriteLine(pessoa1.ImprimirNomeComp());


    }
}

public class Pessoa 
{
    string _nome;
    string _sobrenome;
  

    public Pessoa() { }

    public void SetNome(string nome)
    {
        this._nome = nome; 
    }

    public string GetNome()
    {
        return this._nome;
        //this = se quem ogjeto chamou
    }

    public string GetSobrenome()
    {
        return this._sobrenome;
    }

    public void SetSobenome(string Sobrenome)
    {
        this._sobrenome = Sobrenome;
    }

    public void ImprimirNomeCompleto()
    {
        Console.WriteLine(this._nome + " " + this._sobrenome);
    }

    public string ImprimirNomeComp()
    {
        string mensagem = "Seu nome completo é " + this._nome + " " + this._sobrenome;
        return mensagem;
    }
    /*
    public string ImpressaoConsole()
    {
        return Console.WriteLine("Seu nome completo: " + this._nome + " " + this._sobrenome);
    }
    */
}