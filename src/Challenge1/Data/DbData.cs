using Challenge1.Models;

namespace Challenge1.Data;

public static class DbData
{
	public const string DbName = "XLENTDb";

	public static void AddMockData(ApplicationDbContext context)
	{
		Customer customer1 = new() { Id = 1, FirstName = "Lyn", LastName = "Gordon" };
		Customer customer2 = new() { Id = 2, FirstName = "Donald", LastName = "Duck" };
		Customer customer3 = new() { Id = 3, FirstName = "Clark", LastName = "Kent" };

		context.Add(customer1);
		context.Add(customer2);
		context.Add(customer3);

		context.SaveChanges();
	}
}