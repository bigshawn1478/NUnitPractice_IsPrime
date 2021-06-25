using System;

namespace NUnitPractice
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            if (candidate == 2)
            {
                return true;
            }

            throw new NotImplementedException("Please create a test first.");
        }
    }
}
