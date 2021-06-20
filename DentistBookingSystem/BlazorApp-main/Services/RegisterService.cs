namespace BlazorApp.Services
{
    using BlazorApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class RegisterService : IRegisterService
    {
        private IHttpService _httpService;

        public RegisterService(IHttpService httpService)
        {
            _httpService = httpService;
        }
        public async Task<int> Create(User user)
        {
            var result = await _httpService.Post<User>("/users", user);
            return result.Id;
        }
    }
}
