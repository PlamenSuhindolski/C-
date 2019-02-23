using System;
/*write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
Example 1:

program	user
Please choose a type:	
1 --> int	
2 --> double	
3 --> string	3
Please enter a string:	hello
hello*	
Example 2:

program	user
Please choose a type:	
1 --> int	
2 --> double	2
3 --> string	
Please enter a double:	1.5
2.5
 */
class PlayWithIntDoubleAndString
{
    static void Main(string[] args)
    {
        Console.WriteLine("PLease choose a type:\n1-int 2-double 3-string");
        int n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 2:
                Console.WriteLine("Vuvedi stoinost:");
                double m = double.Parse(Console.ReadLine());
                Console.WriteLine(m+1);
                break;
            case 3:
                Console.WriteLine("Vuvedi stoinost:");
                string p = Console.ReadLine();
                Console.WriteLine("{0}*",p);
                break;
        }
    }
}

