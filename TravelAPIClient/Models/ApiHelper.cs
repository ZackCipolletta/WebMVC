using System.Threading.Tasks;
using RestSharp;

namespace TravelAPIClient.Models
{
  public class ApiHelper
  {
    public static async Task<string> GetAll()
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async Task<string> Get(int id)
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations/{id}", Method.Get);
      RestResponse response = await client.GetAsync(request);
      return response.Content;
    }

    public static async void Post(string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      await client.PostAsync(request);
    }

    public static async void Put(int id, string newDestination)
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations/{id}", Method.Put);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newDestination);
      await client.PutAsync(request);
    }

    public static async void Delete(int id)
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations/{id}", Method.Delete);
      request.AddHeader("Content-Type", "application/json");
      await client.DeleteAsync(request);
    }
    
      [HttpPost(Name = "Post")]
        public static async void PostNewUser(string newApplicationUser)
    {
      RestClient client = new RestClient("http://localhost:5114/");
      RestRequest request = new RestRequest($"api/destinations", Method.Post);
      request.AddHeader("Content-Type", "application/json");
      request.AddJsonBody(newApplicationUser);
      await client.PostAsync(request)
    }
  }
}