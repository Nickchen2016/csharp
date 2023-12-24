/* Here are the conditions that your third coding project must implement:

    . your solution must use the following string array to represent the input to your coding logic: (Line 20)

    . Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

    . Your solution must include an outer foreach or for loop that can be used to process each string element in the array. The string variable that you'll process inside the loops should be named myString.

    . In the outer loop, your solution must use the IndexOf() method of the String class to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

    . Your solution must include an inner do-while or while loop that can be used to process the myString variable.

    . In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are processed.

    . In the inner loop, your solution must not display the period character.

    . In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to process the string information. */


string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = -1;

foreach(string i in myStrings)
{
    string myString = i;
    periodLocation = i.IndexOf(".");
    do{
        if(periodLocation>-1)
        {
            Console.WriteLine(myString.Substring(0,periodLocation).TrimStart());
            myString = myString.Substring(periodLocation+2);
            periodLocation = myString.IndexOf(".");
        }else{
            Console.WriteLine(myString);
            myString = "";
        }

    }while(myString != "");
}

// int[] myArray = new int[2] {3,5};

// foreach(int i in myArray)
// {
// int myNumber = i;
//     do
//     {
//         if(myNumber>1){
//             Console.WriteLine($"Here is my number > 1: {myNumber}");
//             myNumber--;
//         }else{
//             Console.WriteLine($"Here is my number < 1: {myNumber}");
//             myNumber--;
//         }
//     }while(myNumber!=0);

// }

