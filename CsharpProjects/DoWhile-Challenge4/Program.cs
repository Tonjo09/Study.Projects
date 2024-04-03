string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;

foreach (string myString in myStrings)
{
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display each one at a time
    while (periodLocation != -1)
    {

        // first sentence is left for the first period location
        mySentence = myString.Remove(periodLocation);

        // takes remainder to right after period
        myString = myString.Substring(periodLocation + 1);




        Console.WriteLine(mySentence);
    }


}