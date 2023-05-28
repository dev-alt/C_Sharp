namespace Infix_to_Postfix
{
    internal class Program
    {
        //program created by Andrew Logan (9957173)
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Welcome to the Infix to Postfix Converter!");
            Console.WriteLine("-----------------------------------------------");
            Console.ResetColor();
            Console.WriteLine("Enter an infix arithmetic expression (containing single-digit integers only):");
            string infixExpression = Console.ReadLine();
            string postfixExpression = Conversion(infixExpression);
            Console.WriteLine("Postfix expression: " + postfixExpression);

            Console.ReadKey();
        }

        static string Conversion(string infixExpression)
        {
            // push a left parenthesis onto the stack
            Stack<char> stack = new Stack<char>();
            stack.Push('(');

            // append a right parenthesis to the end of the infix expression
            infixExpression += ')';

            // initialize an empty postfix expression
            string postfixExpression = "";

            // loop through the infix expression from left to right
            foreach (char c in infixExpression)
            {
                if (char.IsDigit(c))
                {
                    // if the current character is a digit, append it to postfix
                    postfixExpression += c;
                }
                else if (c == '(')
                {
                    // if the current character is a left parenthesis, push it onto the stack
                    stack.Push(c);
                }
                else if (IsOperator(c))
                {
                    // if the current character is an operator, pop operators from the stack while they have equal or higher precedence than the current operator, and append them to postfix
                    while (OpPrecedence(stack.Peek()) >= OpPrecedence(c))
                    {
                        postfixExpression += stack.Pop();
                    }
                    // push the current operator onto the stack
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    // if the current character is a right parenthesis, pop operators from the stack and append them to postfix until a left parenthesis is at the top of the stack
                    while (stack.Peek() != '(')
                    {
                        postfixExpression += stack.Pop();
                    }
                    // pop the left parenthesis from the stack
                    stack.Pop();
                }
            }

            return postfixExpression;
        }

        static bool IsOperator(char c)
        {
            // check if the character is an operator
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        static int OpPrecedence(char c)
        {
            // return the precedence of the operator
            if (c == '+' || c == '-')
            {
                return 1;
            }
            else if (c == '*' || c == '/')
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
    }
}