string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString = "";

for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display each one at a time
    while (periodLocation != -1)
    {

        // sentence is left for the first period location
        mySentence = myString.Remove(periodLocation);

        // extract remainder to right after period
        myString = myString.Substring(periodLocation + 1);

        // remove leading white-space from myString
        myString = myString.TrimStart();

        // update period
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString;
    Console.WriteLine(mySentence);
}