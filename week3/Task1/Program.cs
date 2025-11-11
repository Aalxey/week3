namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operator obj = new Operator();
            obj.add();
            obj.subtract();
            obj.multiply();
            obj.divide();
            obj.OddEvenFinder(8);
        }
    }
}
