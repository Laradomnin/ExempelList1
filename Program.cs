public class Example
{
    public static void Main()
    {
        void Display(LinkedList<string> nm, string test)
        {
            Console.WriteLine(test);
            foreach (string name in nm)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();


        }
        // Create the link list.
        string[] names =
            { "Adam", "Anna", "Lena", "Vasi", "Axel", "Olle" };
        LinkedList<string> namn = new LinkedList<string>(names);
        Display(namn, "Finns i List nu:");
        bool done = false;
        char v;
        do
        {
            Console.WriteLine("Lägg till namn ange + ta bort namn - ");
            v = Convert.ToChar(Console.ReadLine());
            


            switch (v)
            {
                case '+':

                    Console.WriteLine("Ange ett namn. ");
                    string? input = Console.ReadLine();
                    namn.AddFirst($"{input}");
                    Display(namn, "Namn som finns i listan nu ");
                    break;

                case '-':

                    Console.WriteLine("Välj vilket namn skall tas bort från lista? ");
                    string? current = Console.ReadLine();
                    namn.Remove($"{current}");
                    Display(namn, "har tagits bort namnet  " + (current));
                    break;

            }
        } while (!done);
    }
}


