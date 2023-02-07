using DevTrust.Models;
using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace DevTrust
{
    public interface IDataAccessService
    {
        List<PersonModel> GetPeople(int total = 11);
    }
    public class DataAccessService : IDataAccessService
    {
        private readonly string[] _streetAddresses = new string[] { "Atasehir", "Umraniye", "Umraniye", "Maltepe", "Umraniye", "Kurtkoy", "York","Uskudar","Uskudar","Umraniye","Atasehir"};
        private readonly string[] _cities = new string[] { "Eskisehir", "Istanbul", "Ordu", "Ordu", "Ankara", "Bursa", "Toronto", "Istanbul","Istanbul","Tokat","Ankara" };

        private readonly string[] _firstNames = new string[] { "Giray", "Eren", "Eylem", "Mehmet Ali", "Merve", "Dogancan", "Gozde", "Kuzey", "Cemre", "Ertan", "Elif" };
        private readonly string[] _lastNames = new string[] { "Ucar", "Dunya", "Okumus", "Demir", "Erdogan", "Mavideniz", "Tutmez", "Tekinoglu", "Cayak", "Adsiz", "Serin" };
        private readonly string[] _email = new string[] { "girayucar@gmail.com", "erendunya@yahoo.com", "eylemokumus@hotmail.com", "malidemir@gmail.com", "merveerdogan@aras.com", "dogimavi@gmail.com", "gozdetutmez@gmail.com", "kuzeytekinoglu@gmail.com", "cemrecayak@yahoo.com", "ertanadsiz@hotmail.com", "elifserin@gmail.com" };


        public List<PersonModel> GetPeople(int total = 11)
        {
            List<PersonModel> output = new List<PersonModel>();

            for (int i = 0; i < total; i++)
            {
                output.Add(GetPerson(i + 1, _firstNames[i], _lastNames[i], _email[i], _streetAddresses[i], _cities[i]));
            }

            return output;
        }

        private PersonModel GetPerson(int id, string firstName, string lastName, string email, string streetAddress, string city)
        {
            return new PersonModel
            {
                PersonId = id,
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                AddressId = id,
                StreetAddress = streetAddress,
                City = city
            };
        }

        public class Startup
        {
            public void ConfigureServices(IServiceCollection services)
            {
                services.AddTransient<IDataAccessService, DataAccessService>();
            }
        }

    }
}
