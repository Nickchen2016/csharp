
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