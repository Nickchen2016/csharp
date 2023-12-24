/* Code project 1 - write code that validates integer input
Here are the conditions that your first coding project must implement:

. Your solution must include either a do-while or while iteration.

. Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.

. Inside the iteration block:
    Your solution must use a Console.ReadLine() statement to obtain input from the user.
    Your solution must ensure that the input is a valid representation of an integer.
    If the integer value isn't between 5 and 10, your code must use a Console.WriteLine() statement to prompt the user for an integer value between 5 and 10.
    Your solution must ensure that the integer value is between 5 and 10 before exiting the iteration.
    
. Below (after) the iteration code block: your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.*/




Console.WriteLine("Please input a integer value between 5 and 10.");
string? input;
int finalNumber = 0;
bool? validNumber;
do{
    int inputNumber = 0;
    input = Console.ReadLine();
    validNumber = int.TryParse(input, out inputNumber);

    if(validNumber == true)
    {
        if(inputNumber<5||inputNumber>10)
        {
            Console.WriteLine($"You entered {inputNumber}. Please enter a number between 5 and 10.");
            continue;
        }else{
            finalNumber = inputNumber;
        }
    }else{
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
        continue;
    }                   

}while(finalNumber==0);

Console.WriteLine($"Your input value ({finalNumber}) has been accepted.");