namespace ListInt_Struct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListInt list = new ListInt();

          
            list.Add(10);
            list.Add(20);
            list.Add(30);

            Console.WriteLine("Arraya elave edirik ");
            list.AddRange(40, 50, 60);
            Console.WriteLine("Arrayin elementleri");
            Console.WriteLine(list); 

            Console.WriteLine("elementin olub olmadigini yoxlayiriq");
            Console.WriteLine(list.Contains(30)); // true
            Console.WriteLine(list.Contains(100)); // false

            Console.WriteLine("Arrayin cemi");
            Console.WriteLine(list.Sum()); 

            Console.WriteLine("elementi silirik");
            list.Remove(20);
            Console.WriteLine(list); 

            Console.WriteLine("Bir nece elementi silirik");
            list.RemoveRange(30, 50);
            Console.WriteLine(list); 
        }
    }
    
}
