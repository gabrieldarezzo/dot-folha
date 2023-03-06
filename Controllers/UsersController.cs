using Microsoft.AspNetCore.Mvc;

namespace DemoMicroService.Controllers;

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
        var userInserted = new User { name = user.name };
        db.Add(userInserted);
        db.SaveChanges();
        yield return userInserted;
    }
}