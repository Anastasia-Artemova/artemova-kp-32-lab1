public class Task1
{
    public static void Main(string [] args){
        double x, y, z, a, b;
        bool check;

        Console.Write("Enter any number for x ");
        check = double.TryParse(Console.ReadLine(), out x);
        if(!check || x % 180 == 0){
            while(!check || x % 180 == 0){
                Console.Write("Provided input was incorrect. Try again entering any number for x ");
                check = double.TryParse(Console.ReadLine(), out x);
            }
        }
        
        Console.Write("Enter any number for y ");
        check = double.TryParse(Console.ReadLine(), out y);
        if(!check || y == 0){
            while(!check || y == 0){
                Console.Write("Provided input was incorrect. Try again entering any number for y ");
                check = double.TryParse(Console.ReadLine(), out y);
            }
        }
        
        Console.Write("Enter any number for z ");
        check = double.TryParse(Console.ReadLine(), out z);
        if(!check || z == 0){
            while(!check || z == 0){
                Console.Write("Provided input was incorrect. Try again entering any number for x ");
                check = double.TryParse(Console.ReadLine(), out z);
            }
        }


        a = 1 / (2 * Math.Sin(Math.PI + x)) + Math.Pow(Math.Sin((x + y) / z), 2);
        b = Math.Cos(Math.Pow(a, 2) * x) / (2 * y * z);

        Console.Write("a = " + a + "; b = " + b + "\n");

    }
    
}
