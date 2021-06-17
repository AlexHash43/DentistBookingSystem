using DentistBookingSystem.DataAccess.Entities;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DentistBookingSystem.ApplicationServices.API.Domain.Models
{

    public class User
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserRoles Role { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateRegistered { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }


        public List<string> ListOfAppointmentsReason{ get; set; }
    }
}
