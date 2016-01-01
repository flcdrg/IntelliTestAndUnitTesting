using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Spatial;
using System.Linq;

namespace IntelliTestAndUnitTesting
{
    class PeopleRepository : IPeopleRepository
    {
        public IList<string> GetDistinctNames()
        {
            using (var context = new MyDbContext())
            {
                var q = from p in context.Person_People select p.FirstName;

                var names = q.Distinct()
                    .OrderBy(x => x)
                    .ToList();

                return names;
            }
        }

        public IList<Person_Person> GetPeopleByFirstName(string firstName)
        {
            using (var context = new MyDbContext())
            {
                var q = from p in context.Person_People where p.FirstName == firstName select p;

                var names = q.Distinct()
                    .Include( x=> x.Person_BusinessEntity)
                    .Include(x => x.Person_BusinessEntity.Person_BusinessEntityAddresses)
                    .OrderBy(x => x.LastName)
                    .ToList();

                return names;
            }
        }

        public DbGeography GetPersonGeography(string firstName)
        {
            using (var context = new MyDbContext())
            {
                var q = from p in context.Person_People
                    where p.FirstName == firstName
                    select p.Person_BusinessEntity.Person_BusinessEntityAddresses;

                var address = q.First().First();

                return address.Person_Address.SpatialLocation;
            }
        }
    }
}