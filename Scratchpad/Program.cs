// See https://aka.ms/new-console-template for more information
string tester = "Test!";
List<string> ArStr = new List<string>();
char[] ArCha = tester.ToCharArray();
//Console.WriteLine($"__{ArCha[0]}__") ;
Console.WriteLine($"__{ArStr.Count}__");
ArStr.Add("2");
Console.WriteLine($"__{ArStr.Count}__");