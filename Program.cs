/* Here are the conditions that your second coding project must implement:

    . Your solution must include either a do-while or while iteration.

    . Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

    . Inside the iteration block:

        Your solution must use a Console.ReadLine() statement to obtain input from the user.
        Your solution must ensure that the value entered matches one of the three role options.
        Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
        Your solution should use the ToLower() method on the input value to ignore case.
        If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
    . Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted. */

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
string? input;
string[] roles = {"Administrator", "Manager", "User"};
string inputValue = "";

while(inputValue == "")
{
    input = Console.ReadLine();
    input = input.Trim().Substring(0,1).ToUpper()+input.Trim().Substring(1).ToLower();
    
    if(roles.Any(input.Contains))
    {
        inputValue = input;
    }else{
        Console.WriteLine($"The role name that you entered, '{input}' is not valid. Enter your role name (Administrator, Manager, or User)");
        continue;
    }
}

Console.WriteLine($"Your input value ({inputValue}) has been accepted.");