namespace MethodsExercise
{
    public class Program
    {
        static int Sum(params int[] result)
        {
            int total = 0;
            foreach (int i in result) 
            {
                total += i;
            }
            return total;
        }
        //You can of course apply this logic to the rest of them
        static int Mult(int x, int y) 
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
        static int Sub(int x, int y)
        {
            return x - y;
        }

        static string Story()
        {
            Console.WriteLine("Whats a funny name?");
            string name = Console.ReadLine();
            Console.WriteLine("Whats a scary animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("Whats a small number?");
            string number = Console.ReadLine();
            Console.WriteLine("Whats your favorite food?");
            string food = Console.ReadLine();
            Console.WriteLine("Whats a common household object?");
            string obj = Console.ReadLine();
            return ($"You hear a thunderous roar blasting out from the depth of the cave; your body won't let" +
                $" you enter but as you hear the shouting for your name approaching behind you, \"{name}!\" " +
                $"you hesitantly step into the darkess. \nAs your eyes adjest to the darkness you are surprised to find an adorable, {number} inch tall, {animal}." +
                $" \"Hey little guy\" you hold out your hand. RAAAAAAWWWRRRRR, a defening rawr booms from the depth of the cave, the mom. As you step back your heel is stopped by a rock" +
                $" and you stumble backwards. Out of the shadows the Momma {animal} walks bipedal like an anthropomorphized cartoon. \"Im gonna finish you like left over {food}\" She screams" +
                $" with a scary low voice. Quickly you grab the nearest {obj}, flinging it at her and running out the cavern.");
        }

        static void Main(string[] args)
        {
            Console.Write(Sum(14, 23, 34, 2));
            Console.Write(Mult(14, 23));
            Console.Write(Divide(14, 23));
            Console.Write(Sub(14, 23));
            Console.WriteLine(Story());
        }
    }
}
