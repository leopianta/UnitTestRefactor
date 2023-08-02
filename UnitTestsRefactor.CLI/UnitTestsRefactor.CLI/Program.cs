using UnitTestsRefactor.BusinessLogic.Models;
using UnitTestsRefactor.BusinessLogic.Services;
using UnitTestsRefactor.Storage.Repository;

internal class Program
{
    public static ContactRepository repository = new ContactRepository();
    public static UnitTestsRefactorService service = new UnitTestsRefactorService(repository);

    private static void Main(string[] args)
    {
        Menu();
    }

    private static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Cadastro de contatos");
        Console.WriteLine();
        Console.WriteLine("Opções:");
        Console.WriteLine("1- Listar");
        Console.WriteLine("2- Cadastrar");
        Console.WriteLine("3- Excluir");
        Console.WriteLine("");

        var opt = Console.ReadLine();

        switch (opt)
        {
            case "1":
                ListarContatos();
                break;
            case "2":
                CadastrarContato();
                break;
            case "3":
                ExcluirContato();
                break;
            default:
                Menu();
                break;
        }

        Menu();
    }

    private static void ListarContatos()
    {
        var contacts = repository.GetAll();

        Console.WriteLine("Contatos cadastrados:");
        Console.WriteLine();

        foreach (var c in contacts)
        {
            Console.WriteLine($"Nome: {c.Name}");
            Console.WriteLine($"Idade: {c.Age}");
            Console.WriteLine($"Cpf: {c.cpf}");
            Console.WriteLine();
        }
        Console.WriteLine("4- Menu inicial");

        var opt = Console.ReadLine();
        if (opt.Equals("4"))
        {
            Menu();
        }

    }

    private static void CadastrarContato()
    {
        var contact = new Contact();

        Console.WriteLine("Digite o nome:");
        contact.Name = Console.ReadLine();
        Console.WriteLine("Digite a idade:");
        contact.Age = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o cpf:");
        contact.cpf = Console.ReadLine();
        Console.WriteLine();

        service.InsertContact(contact);
    }

    private static void ExcluirContato()
    {
        Console.WriteLine("Digite o nome a ser excluído:");
        var nome = Console.ReadLine().ToLower();

        service.DeleteContactByName(nome);

        Menu();
    }
}