using BDLIBRARY.Data;
using BDLIBRARY.Models;

namespace BDLIBRARY
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using LibraryContext context = new LibraryContext();

            Genero Triller = new Genero()
            {
                Description = "Este genero es de miedo y suspenso"
            };
            context.Generos.Add( Triller );

            Genero Suspenso = new Genero()
            {
                Description = "Este genero es de suspenso"
            };
            context.Generos.Add(Suspenso);

            context.SaveChanges();

            Rol Usuario = new Rol()
            {
                Name = "Usuario"
            };
            context.Roles.Add(Usuario);

            Rol Administrador = new Rol()
            {
                Name = "Administrador"
            };
            context.Roles.Add(Administrador);

            context.SaveChanges();

            Book LaBallenaAzul = new Book()
            {
               Titulo = "La ballena azul",
               Autor = "Sophies",
               Ano = new DateTime(2022, 1, 1),
               GeneroId = 1
            };
            context.Books.Add( LaBallenaAzul );

            Book Metamorfosis = new Book()
            {
                Titulo = "Metamorfosis",
                Autor = "franz kafka",
                Ano = new DateTime(1915, 1, 1),
                GeneroId = 2
            };
            context.Books.Add(Metamorfosis);

            context.SaveChanges();

            User Nico = new User()
            {
                Name = "Nico",
                Email = "enicolassancheztobar@gmail.com",
                Password = "QAZ3216*",
                RolId = 1
            };
            context.Users.Add(Nico);

            User Sofi = new User()
            {
                Name = "Sofi",
                Email = "sofipinzon@gmail.com",
                Password = "QAZ3216*",
                RolId = 2
            };
            context.Users.Add(Sofi);

            context.SaveChanges();

            Prestamo prestamo1 = new Prestamo()
            {
                Inicio = new DateTime(2024, 5, 12),
                Fin = new DateTime(2024, 6, 12),
                UserId = 1,
                BookId = 1
            };
            context.Prestamos.Add(prestamo1);

            Prestamo prestamo2 = new Prestamo()
            {
                Inicio = new DateTime(2024, 5, 12),
                Fin = new DateTime(2024, 6, 12),
                UserId = 2,
                BookId = 2
            };
            context.Prestamos.Add(prestamo2);


            context.SaveChanges();


        }
    }
}
