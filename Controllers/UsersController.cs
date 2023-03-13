namespace DemoMicroService.Controllers;

using Microsoft.AspNetCore.Mvc;
using DemoMicroService.Models;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{

    [HttpGet(Name = "GetUsersController")]
    public IEnumerable<User> Get()
    {
        using var db = new UserContext();
        var users = db.Users.ToList();
        return users.ToArray();
    }
   
    [HttpPost(Name = "PostUsersController")]
    public IEnumerable<User> Post(User user)
    {
        using var db = new UserContext();
        var userInserted = new User { name = user.name, BirthDate = new DateTime(), BaseSalary = 4000 };
        db.Add(userInserted);
        db.SaveChanges();
        yield return userInserted;
    }
}