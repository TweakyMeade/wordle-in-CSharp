char[] inputWord = "gehff".ToCharArray();
char[] trueWord = "heoff".ToCharArray();
List<string> inputList=charArrayToStringList(inputWord);
List<string> trueList= charArrayToStringList(trueWord);
List<string> correctLettersUsed = new List<string>();
List<string> wrongLettersUsed = new List<string>();

List<string> charArrayToStringList(char[] inputCharArray)
{
    List<string> stringList = new List<string>();
    foreach (char c in inputCharArray) { stringList.Add(c.ToString()); }
    return stringList;
}

string correctPlacementCheccker()
{
    string correctPlacementOutput = "";
    for (int i = 0; i < trueList.Count; i++)
    {
        if (inputList[i] == trueList[i]) { correctPlacementOutput += trueList[i]; }
        else if (trueList.Contains(inputList[i])) { correctLettersUsed.Add(inputList[i]); correctPlacementOutput += "0"; }
        else { wrongLettersUsed.Add(inputList[i]); correctPlacementOutput += "_"; }
    }

    return correctPlacementOutput;
}

void print()
{
    Console.WriteLine(correctPlacementCheccker());
    Console.WriteLine($"input:{inputWord}\ntrue:{trueWord}\ninputList:{inputList}\ncorrectLettersUsed:{correctLettersUsed}\nwrongLettersUsed:{wrongLettersUsed} ");
}

void charPrint(List<string> x)
{

    foreach (string i in x) { Console.Write(i.ToString()); }

}

print();
Console.WriteLine("correctLettersUsed");
charPrint(correctLettersUsed);
Console.WriteLine("\nwrongLettersUsed");
charPrint(wrongLettersUsed);

