#define CONTRACTS_FULL
using System.Diagnostics.Contracts;

namespace IntelliTestAndUnitTesting
{
    public class CompositeService
    {
        private readonly ITaxService _taxService;

        public CompositeService(ITaxService taxService)
        {
            _taxService = taxService;
        }

        public string Execute(string message, int income)
        {
            // Contract.Requires(message != null);

            if (message.Contains("Not"))
                message += " *** ";

            return $"{message} {_taxService.GetTaxPayable(income):C0}";
        }
    }
}