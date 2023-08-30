using injecaoDependencia.repository;
using injecaoDependencia.repository.iRepository;
using injecaoDependencia.services;


class program
{
    public static void Main(string[] args)
    {
         IUsuarioRepository usrepository = new UsuarioRepository();
         UsuarioServices usuarioService = new UsuarioServices(usrepository);

        usuarioService.get();
        Console.WriteLine("Iniciando...");
    }
}