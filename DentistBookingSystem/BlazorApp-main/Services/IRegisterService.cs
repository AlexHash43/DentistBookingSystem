namespace BlazorApp.Services
{
    using BlazorApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public interface IRegisterService
    {
        Task<int> Create(User user);
    }
}
