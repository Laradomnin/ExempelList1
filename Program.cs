



public class Example
{
    public static void Main()
    {
        // Create the link list.
        string[] names =
            { "Adam", "Anna", "Lena", "Vasi", "Axel", "Olle" };
        LinkedList<string> namn = new LinkedList<string>(names);
        
        Display(namn, "Finns i List nu:");
        
        Console.WriteLine("Lägg till namn ange + ta bort namn - ");
        string?v = Console.ReadLine();
        while (v == "+" || v == "-")
        {
            if (v == "+")
            {
                Console.WriteLine("Ange ett namn. ");
                string input = Console.ReadLine();
                namn.AddFirst(input);
                Display(namn, "Namn som finns i listan nu ");
            }
            
            if (v == "-")
            {
                Console.WriteLine("Välj vilket namn skall tas bort från lista? ");
                string? current = Console.ReadLine();
                namn.Remove(current);
                Display(namn, "har tagits bort namnet  " + (current));
            }
            else break;
        }
        static void Display(LinkedList<string> nm, string test)
        {
            Console.WriteLine(test);
            foreach (string name in nm)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
           

        }
    }
       
}
    