﻿namespace BlazorApp.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using BlazorApp.Models;

    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<IEnumerable<User>> GetAll(string name, string surname);
        Task<User> GetMe();

    }
}