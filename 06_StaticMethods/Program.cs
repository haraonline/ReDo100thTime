namespace _06_StaticMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //static methods of a class cannot access static members unless they are also static
            //static methods of a class cannot access instance members of the class
            //static methods are generally used to perform operations that do not require access to instance members
            //static methods are generally of utility type
            //we can however pass the instance of the class to the static method as an argument to access instance members of the class ...
            //... but this is not recommended since it is not the purpose of static methods
        }
    }
}