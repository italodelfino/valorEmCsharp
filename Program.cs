
using static System.Console;
public class Program
{
    static void Demo1()
    {
        int a = 2;
        Adicionar20(a);
        WriteLine($"O valor da variável a é: {a}");
    }
    static void Adicionar20(int a)
    {
        a = a + 20;
    }
    
    static void trocarNome(Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento ="1234";

        trocarNome(p1, "José");

        WriteLine($"O novo Nome é : {p1.Nome}");
    }


}



