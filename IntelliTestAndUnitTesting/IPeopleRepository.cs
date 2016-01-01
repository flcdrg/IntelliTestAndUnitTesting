using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace IntelliTestAndUnitTesting
{
    public interface IPeopleRepository
    {
        IList<string> GetDistinctNames();

        IList<Person_Person> GetPeopleByFirstName(string firstName);
        DbGeography GetPersonGeography(string firstName);
    }
}