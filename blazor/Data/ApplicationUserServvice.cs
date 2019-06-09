using System.Net.Http;
using System.Threading.Tasks;
using blazor.Helpers;
using blazor.Models;
namespace blazor.Data
{
    public class ApplicationUserService
    {
        public ApplicationUserService(DataAccess Data)
        {
            _dataAccess = Data;
        }
        private DataAccess _dataAccess { get; set; }


        public async Task<HttpResponseMessage> CreateUser(ApplicationUserModel model){
              var result = await _dataAccess.HttpClient.PostAsync("/ApplicationUser",
              new StringContent(model.ToString()) );
              return result;
        }


        

    }
}