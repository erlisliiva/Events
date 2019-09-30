using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class PersonProcessor
    {
        public static int CreatePerson(int personFK, bool isBusiness, string firstName, 
            string lastName, string personalCode, string payingMethod, string info)
        {
            PersonModel data = new PersonModel
            {
                PersonFK = personFK,
                IsBusiness = isBusiness,
                FirstName = firstName,
                LastName = lastName,
                PersonalCode = personalCode,
                PayingMethod = payingMethod,
                Info = info

            };

            string sql = @"insert into dbo.Person (PersonFK, IsBusiness, FirstName, LastName, PersonalCode, PayingMethod, Info)
                            values (@PersonFK, @IsBusiness, @FirstName, @LastName, @PersonalCode, @PayingMethod, @Info);";

            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<PersonModel> LoadPersons()
        {
            string sql = @"select PersonId, IsBusiness, FirstName, LastName, PersonalCode, PayingMethod, Info
                            from dbo.Person;";

            return SqlDataAccess.LoadData<PersonModel>(sql);
        }

        public static List<PersonModel> LoadEventPersons(int id)
        {
            string sql = $"select PersonId, IsBusiness, FirstName, LastName, PersonalCode, PayingMethod, Info from dbo.Person where PersonFK = {id};";

            return SqlDataAccess.LoadData<PersonModel>(sql);
        }
    }
}
