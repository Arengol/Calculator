using System;

namespace lr1calc
{
    
        public class Class1
        {
        public static string plus(string leftop, string rigtop)
            {
                float loperat = float.Parse(leftop);
                float rigoperat = float.Parse(rigtop);
                float result = loperat + rigoperat;
                return result.ToString();
            }
        }
    

}
