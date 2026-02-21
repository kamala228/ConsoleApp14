string user = "12345*100";

int posChoice = 0;

string numberOne = "";
string numberTwo = "";

for (int i = 0; i < user.Length; i++)
{
    if (user[i] == '*' || user[i] == '+' || user[i] == '-' || user[i] == '/')
    {
        posChoice = i;
    }
}

for (int i = 0; i < posChoice; i++)
{
    if (user[i] == '1' || user[i] == '2' || user[i] == '3' || user[i] == '4' || user[i] == '5' || user[i] == '6' || user[i] == '7' || user[i] == '8' || user[i] == '9' || user[i] == '0')
    {
        numberOne += user[i];
    }
    else
    {
        Console.WriteLine("В першій половині не число ");
        break;
    }
    if (i == posChoice -1)
    {
        for (int j = posChoice + 1; j < user.Length; j++)
        {
            if (user[j] == '1' || user[j] == '2' || user[j] == '3' || user[j] == '4' || user[j] == '5' || user[j] == '6' || user[j] == '7' || user[j] == '8' || user[j] == '9' || user[j] == '0')
            {
                numberTwo += user[j];
            }
            else
            {
                Console.WriteLine("В другій половині не число ");
                break;
            }
            if (j == user.Length-1)
            {
                if (user[posChoice] == '+')
                {
                    Console.WriteLine($"{numberOne} + {numberTwo} = {Convert.ToInt32(numberOne) + Convert.ToInt32(numberTwo)}");
                }
                else if (user[posChoice] == '-')
                {
                    Console.WriteLine($"{numberOne} - {numberTwo} = {Convert.ToInt32(numberOne) - Convert.ToInt32(numberTwo)}");
                }
                else if (user[posChoice] == '*')
                {
                    Console.WriteLine($"{numberOne} * {numberTwo} = {Convert.ToInt32(numberOne) * Convert.ToInt32(numberTwo)}");
                }
                else if (user[posChoice] == '/')
                {
                    Console.WriteLine($"{numberOne} / {numberTwo} = {Convert.ToInt32(numberOne) / Convert.ToInt32(numberTwo)}");
                }
            }
        }
    }
}