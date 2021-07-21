using System;

namespace ControlableAccess
{
    class Program
    {
        [Flags]
        public enum Controlable
        {
            Balance = 1, // 2^0
            thirthpartyCall = 2, // 2^1     
            chargeCalculation = 4, // 2^2
            LimiteCalculation = 8, // 2^3 
            MCC = 16// 2^4  
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Scheme 1 has access of modify? =>  " + IsControled(24, Controlable.thirthpartyCall));          
            Console.WriteLine("Scheme 2 has access of modify? =>  " + IsControled(18, Controlable.LimiteCalculation));          
            Console.WriteLine("Scheme 3 has access of chargeCalculation ? =>  " + IsControled(24, Controlable.chargeCalculation));          
        }

        public static Boolean IsControled(long accessCount, Enum flag)
        {
            return ((Convert.ToUInt64(accessCount) & Convert.ToUInt64(flag)) == Convert.ToUInt64(flag));
        }
    }
}
