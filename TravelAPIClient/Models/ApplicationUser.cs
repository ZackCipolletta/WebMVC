using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json;

namespace TravelAPIClient.Models
{
  public class ApplicationUser : IdentityUser
  {
    public string password { get; set; }
    public string userName { get; set; }
public static void Post(ApplicationUser applicationUser)
{
    string jsonApplicationUser = JsonConvert.SerializeObject(applicationUser);
    ApiHelper.Post("account/login", jsonApplicationUser);
}
  }
}