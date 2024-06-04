using Microservices.Tutorial.CQRS.Example.Models;

namespace Microservices.Tutorial.CQRS.Example.DbContexts
{
    //Ef core db context yerine kullanılacak olan sınıf (temsili)
    public static class ApplicationDbContext
    {
        public static List<Product> Products { get; set; } = new List<Product>();
    }
}
