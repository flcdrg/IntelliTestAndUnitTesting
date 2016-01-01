namespace IntelliTestAndUnitTesting
{
    public class TaxService : ITaxService
    {
        public decimal GetTaxPayable(int income)
        {
            if (income > 180000)
            {
                // $180,001 and over $54,547 plus 45c for each $1 over $180,000
                income -= 180000;
                return 54547 + 0.45m * income;
            }

            if (income > 80000)
            {
                // $80,001 – $180,000 - $17,547 plus 37c for each $1 over $80,000
                income -= 80000;

                return 17547 + 0.37m * income;
            }

            if (income > 37000)
            {
                // $37,001 – $80,000 - $3,572 plus 32.5c for each $1 over $37,000
                return 3572 + 0.325m * income;
            }

            if (income > 18200)
            {
                // $18,201 – $37,000 - 19c for each $1 over $18,200
                income -= 18200;

                return 0.19m * income;
            }

            return 0;
        } 
    }
}