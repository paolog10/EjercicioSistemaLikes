namespace SistemaLikes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] namesLike = new string[] {  };
            //string[] namesLike = new string[] { "Peter" };
            //string[] namesLike = new string[] { "Jacob", "Alex" };
            //string[] namesLike = new string[] { "Max", "Jhon", "Mark" };
            string[] namesLike = new string[] { "Alex", "Jacob", "Mark", "Max" };

            SistemaLike(namesLike);
            Console.ReadKey();
        }
        static void SistemaLike(string[] array)
        {
            switch (array.Length)
            {
                case 0:
                    Console.WriteLine("No one like this");
                    break;
                case 1:
                    Console.WriteLine($"{array[0]} like this");
                    break;
                case 2:
                    Console.WriteLine($"{array[0]} and {array[1]} like this");
                    break;
                case 3:
                    Console.WriteLine($"{array[0]}, {array[1]} and {array[2]} like this");
                    break;
                case >= 4:
                    Console.WriteLine($"{array[0]}, {array[1]} and {array.Length - 2} others like this");
                    break;
                default:
                    break;
            }
        }
    }
}
