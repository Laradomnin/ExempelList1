



public class Example
{
    public static void Main()
    {

        string[] names =
        { "Adam", "Anna", "Lena", "Vasi", "Axel", "Olle" };
        LinkedList<string> namn = new LinkedList<string>(names);


        static void Display(LinkedList<string> nm, string test)
        {
            Console.WriteLine(test);
            foreach (string name in nm)
            {
                Console.Write(name + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Display(namn, "Finns i List nu:");

            Console.WriteLine("Ange + för att lägga till ett namn eller - för att ta bort ett namn");
            string v;
            v = Console.ReadLine();
            switch (v)
            {
                case "+":
                    Console.WriteLine("Ange ett namn. ");
                    string? input = Console.ReadLine();
                    namn.AddFirst(input);
                    Display(namn, "Namn som finns i listan nu ");
                    break;

                    case "-":
                    Console.WriteLine("Välj vilket namn skall tas bort från lista? ");
                    string? input2 = Console.ReadLine();
                    namn.Remove(input2);
                    Display(namn, "har tagits bort namnet  " + (input));
                    break;
            }

            {
               
              
            }
            


            }
        }

 }

 