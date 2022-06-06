Console.WriteLine("Please enter your array length");

int integer = Int32.Parse(Console.ReadLine());
Console.WriteLine("Please enter your words");
string[] name = new string[integer];
for (int i = 0; i < name.Length; i++)
{
    string input = Console.ReadLine();
    name[i] = input;
    

}

Console.WriteLine("please enter a character");

char characterSearch = Console.ReadKey().KeyChar;
int counter = 0;
int wordcounter = 0;

for (int i = 0; i < name.Length; i++)
{
    wordcounter += name[i].Length;
    for (int j = 0; j < name[i].Length; j++)
    {

        if (name[i][j] == characterSearch)
        {
            counter++;

        }


    }

}

double total = Math.Round((double)counter / (double)wordcounter * 100);


Console.WriteLine($"\nThe letter {characterSearch} appears {counter} time{(counter > 1 ? 's' : "")} in the array. {(total > 25 ? "This letter makes up more than 25% of the total number of characters." : "")}");