string hello = " hello, world! Let`s just add more words and see what happens. ";

int stringLenght = hello.Length;   

//string trimmedString  = hello.Trim();


hello = hello.Trim();

char firstLetter = hello[0];

hello = hello.Replace(hello[0], char.ToUpper(hello[0]));

firstLetter = hello[0];


Console.WriteLine(firstLetter);

//int wordCounter = 0;

//for (int i = 0; i < hello.Length ; i++)
//{
//    if (char.IsWhiteSpace(hello[i]))
//{
//    wordCounter++;
//}
//}

//Console.WriteLine($"Word count in {hello}: {wordCounter + 1} words");