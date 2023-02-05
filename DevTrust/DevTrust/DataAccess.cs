using DevTrust.Models;
using DocumentFormat.OpenXml.Office2013.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DevTrust
{
    public class DataAccess
    {
        string[] streetAddresses = new string[] { "Atasehir", "Umraniye", "Umraniye", "Maltepe", "Umraniye", "Kurtkoy", "York","Uskudar","Uskudar","Umraniye","Atasehir"};
        string[] cities = new string[] { "Eskisehir", "Istanbul", "Ordu", "Ordu", "Ankara", "Bursa", "Toronto", "Istanbul","Istanbul","Tokat","Ankara" };

        string[] firstNames = new string[] { "Giray", "Eren", "Eylem", "Mehmet Ali", "Merve", "Dogancan", "Gozde", "Kuzey", "Cemre", "Ertan", "Elif" };
        string[] lastNames = new string[] { "Ucar", "Dunya", "Okumus", "Demir", "Erdogan", "Mavideniz", "Tutmez", "Tekinoglu", "Cayak", "Adsiz", "Serin" };
        string[] email = new string[] { "girayucar@gmail.com", "erendunya@yahoo.com", "eylemokumus@hotmail.com", "malidemir@gmail.com", "merveerdogan@aras.com", "dogimavi@gmail.com", "gozdetutmez@gmail.com", "kuzeytekinoglu@gmail.com", "cemrecayak@yahoo.com", "ertanadsiz@hotmail.com", "elifserin@gmail.com" };


        public List<PersonModel> GetPeople(int total = 11)
        {
            List<PersonModel> output = new List<PersonModel>();

            for (int i = 0; i < total; i++)
            {
                output.Add(GetPerson(i + 1, firstNames[i], lastNames[i], email[i], streetAddresses[i], cities[i]));
            }

            return output;
        }

        private PersonModel GetPerson(int id, string firstName, string lastName, string email, string streetAddress, string city)
        {
            PersonModel output = new PersonModel();

            output.PersonId = id;
            output.FirstName = firstName;
            output.LastName = lastName;
            output.Email = email;
            output.AddressId = id;
            output.StreetAddress = streetAddress;
            output.City = city;

            return output;
        }



    }
}
