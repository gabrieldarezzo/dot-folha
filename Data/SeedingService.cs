namespace DemoMicroService.Data;

using System;
using DemoMicroService.Models;

public class SeedingService
{
    public SeedingService _context;

    // public SeedingService(UserContext context)
    // {
    //     // _context = context;
    // }

    // public static implicit operator SeedingService(UserContext v)
    // {
    //     throw new NotImplementedException();
    // }

    public void Seed() {
        using var db = new UserContext();
        if( 
            db.Users.Any() 
            // || db.Users.Seller() 
        ) {
            return; 
        }

        db.Add(new User { name = "Gabriel", BirthDate = new DateTime(1992, 6, 10), BaseSalary = 4000 });
        db.Add(new User { name = "Roberto", BirthDate = new DateTime(1997, 4, 22), BaseSalary = 9000 });
        db.Add(new User { name = "Rodrigo", BirthDate = new DateTime(1970, 1, 26), BaseSalary = 12000 });        
        db.SaveChanges();
    }
}