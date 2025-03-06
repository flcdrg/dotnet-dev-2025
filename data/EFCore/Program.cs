// See https://aka.ms/new-console-template for more information

using EFCore;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Connecting to database");

await using var db = new AdventureWorksContext();

while (true)
{
    var addresses = await db.Addresses
        .AsNoTracking()
        .ToListAsync();

    foreach (var address in addresses)
    {
        Console.WriteLine(address.AddressLine1);
    }

    Console.WriteLine();
}