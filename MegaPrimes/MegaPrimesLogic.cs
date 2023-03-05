namespace MegaPrimes
{

    // MegaPrime = prime + individual digits are prime e. 53
    // Create a function(int max) returns list OR int array of megaprimes

    //Algorthim
    //1. Create list for primes,
    //2. Create list for megaprimes
    //3. Iterate through numbers one to max 
    //4. Check number is prime, if prime add to primes list
    //5. Iterate through primes list
    //6. Split each prime number into a int array
    //7. Check if each digit is prime
    //8. Add it the list of megaprimes

    public class MegaPrimesLogic
    {
        public static List<int> GetMegaPrimes(int max)
        {
            List<int> primeNumbers = new List<int>();
            List<int> megaPrimeNumbers = new List<int>();

            primeNumbers = FindPrimeNumbers(max);
            megaPrimeNumbers = FindMegaPrimeNumbers(primeNumbers);

            return megaPrimeNumbers;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        private static bool IsMegaPrime(int number)
        {

            int[] numberDigits = SplitNumber(number);

            for (int i = 0; i < numberDigits.Length; i++)
            {
                if (!IsPrime(numberDigits[i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static int[] SplitNumber(int number)
        {
            return number.ToString().ToCharArray().Select(d => int.Parse(d.ToString())).ToArray();
        }

        private static List<int> FindPrimeNumbers(int max)
        {
            List<int> primes = new List<int>();

            for (int i = 0; i <= max; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        private static List<int> FindMegaPrimeNumbers(List<int> primeNumbers)
        {
            List<int> megaPrimeNumbers = new List<int>();

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                if (IsMegaPrime(primeNumbers[i]))
                {
                    megaPrimeNumbers.Add(primeNumbers[i]);
                }
            }

            return megaPrimeNumbers;
        }
    }
}

