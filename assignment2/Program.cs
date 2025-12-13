Console.WriteLine("Main Menu");
Console.WriteLine("P - print numbers");
Console.WriteLine("A - add a number");
Console.WriteLine("M - display mean of the numbers");
Console.WriteLine("S - display the smallest number");
Console.WriteLine("L - display the largest number");
Console.WriteLine("F - find a number");
Console.WriteLine("D - sort descending");
Console.WriteLine("W - sort ascending");
Console.WriteLine("C - clear the whole list");
Console.WriteLine("E - swapp 2 numbers");
Console.WriteLine("R - reverse the numbers");
Console.WriteLine("Q - quit");
List<int> numbers = [];
char selection;
do
{
    Console.Write("\nEnter your choice: ");
    selection = char.ToUpper(Console.ReadLine()[0]);
    switch (selection)
    {
        case 'P':
            if (numbers.Count == 0)
                Console.WriteLine("[] - the list is empty");
            else
                Console.WriteLine($"[{string.Join(" ", numbers)}]");
            break;
        case 'A':
            Console.Write("Enter count of numbers you want to add: ");
            int numbersToAdd = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numbersToAdd; i++)
            {
                Console.Write("Enter an integer to add to the list: ");
                int numToAdd = Convert.ToInt32(Console.ReadLine());
                bool isDuplicate = false;
                for(int j = 0; j < numbers.Count; j++)
                {
                    if(numbers[j] == numToAdd)
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (isDuplicate)
                {
                    Console.WriteLine($"{numToAdd} is already in the list, not adding duplicate.");
                    i--;
                    continue;
                }

                numbers.Add(numToAdd);
            }
            Console.WriteLine($"{string.Join(" ", numbers)} are added");
            break;
        case 'M':
            if (numbers.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
                double mean = sum / numbers.Count;
                Console.WriteLine($"The mean is: {mean}");
            }
            break;
        case 'S':
            if (numbers.Count == 0)
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            else
            {
                int smallest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if(numbers[i] < smallest)
                        smallest = numbers[i];
                }
                Console.WriteLine($"The smallest number is: {smallest}");
            }
            break;
        case 'L':
            if (numbers.Count == 0)
                Console.WriteLine("Unable to determine the largest number - list is empty");
            else
            {
                int largest = numbers[0];
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] > largest)
                        largest = numbers[i];
                }
                Console.WriteLine($"The largest number is: {largest}");
            }
            break;
        case 'F':
            Console.Write("Enter the number to find: ");
            int numToFind = Convert.ToInt32(Console.ReadLine());
            if (numbers.Count == 0)
            {
                Console.WriteLine("the list is empty");
            }
            else
            {
                bool found = false;
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (numbers[i] == numToFind)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                {
                    Console.WriteLine($"{numToFind} is in the list");
                }
                else
                {
                    Console.WriteLine($"{numToFind} is not in the list");
                }
            }
            break;
        case 'C':
            numbers.Clear();
            Console.WriteLine("List cleared");
            break;
        case 'R':
            for(int i = 0; i < numbers.Count / 2; i++)
            {
                int temp = numbers[i];
                numbers[i] = numbers[numbers.Count - 1 - i];
                numbers[numbers.Count - 1 - i] = temp;
            }
            Console.WriteLine("List reversed");
            break;
        case 'E':
            Console.Write("Enter the first number to swap: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number to swap: ");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            int firstIndex = -1;
            int secondIndex = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == firstNum)
                {
                    firstIndex = i;
                }
                if (numbers[i] == secondNum)
                {
                    secondIndex = i;
                }
            }
            if (firstIndex == -1 || secondIndex == -1)
            {
                Console.WriteLine("One or both numbers not found in the list, cannot swap.");
            }
            else
            {
                int temp = numbers[firstIndex];
                numbers[firstIndex] = numbers[secondIndex];
                numbers[secondIndex] = temp;
                Console.WriteLine($"Swapped {firstNum} and {secondNum}");
            }
            break;
        case 'D':
            if (numbers.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                for(int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] < numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        i = -1;
                    }
                }
                Console.WriteLine($"[{string.Join(" ", numbers)}] sorted in descending order");
            }
            break;
        case 'W':
            if (numbers.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                        i = -1;
                    }
                }
                Console.WriteLine($"[{string.Join(" ", numbers)}] sorted in ascending order");
            }
            break;
        case 'Q':
            Console.WriteLine("Goodbye!");
            break;
        default:
            Console.WriteLine("Unknown selection, please try again");
            break;
    }
} while (selection != 'Q');