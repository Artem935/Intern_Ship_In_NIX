namespace Transport.DisplayConsole
{
    [Serializable]
    internal class DataVerification
    {
        public void Erore(string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(s);
            Console.WriteLine("=========================\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void Complete(string s)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(s);
            Console.WriteLine("=========================\n");
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public int CorrectDataInt(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    int Choice = int.Parse(Console.ReadLine());
                    if (Choice >= 0)
                        return Choice;
                    else
                        Erore("Write natural number!");
                }
                catch (Exception)
                {
                    Erore("Write number!");
                }
            }
        }
        public float CorrectDataFLoat(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    float Choice = float.Parse(Console.ReadLine());
                    if (Choice >= 0)
                        return Choice;
                    else
                        Erore("Write natural number!");
                }
                catch (Exception)
                {
                    Erore("Write number!");
                }
            }
        }
        public decimal CorrectDataDecimal(string s)
        {
            while (true)
            {
                try
                {
                    Console.Write(s);
                    decimal Choice = decimal.Parse(Console.ReadLine());
                    if (Choice >= 0)
                        return Choice;
                    else
                        Erore("Write natural number!");
                }
                catch (Exception)
                {
                    Erore("Write number!");
                }
            }
        }

        public string CorrectDataString(string s)
        {
            while (true)
            {
                Console.Write(s);
                string choice = Console.ReadLine();
                if (!string.IsNullOrEmpty(choice) && choice != " ")
                    return choice;
                else
                    Erore("Write not empty string");
            }
        }
    }
}
