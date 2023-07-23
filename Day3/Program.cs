public class Day3
{
    public static void Main()
    {
        string firstRucksack, secondRucksack, thirdRucksack;
        string items = "";
        int total = 0;
        bool found;
        while ((firstRucksack = Console.ReadLine()) != string.Empty)
        {
            //firstRucksack = line.Substring(0, line.Length / 2);
            secondRucksack = Console.ReadLine();
            thirdRucksack = Console.ReadLine();
            foreach (char c in firstRucksack)
            {
                found = false;
                foreach (char c2 in secondRucksack)
                {
                    if (c == c2 && !found)
                    {
                        foreach (char c3 in thirdRucksack) {
                            if (c == c3 && !found)
                            {
                                items += c;
                                found = true;
                                break;
                            }
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                if (found) 
                { 
                    break; 
                }
            }
        }

        for(int i=0; i<items.Length; i++)
        {
            if (char.IsLower(items[i])) {
                total += items[i] - 96;
            } else if (char.IsUpper(items[i]))
            {
                total += items[i] - 38;
            }
        }

        Console.WriteLine($"{items}: {total}");
    }
}