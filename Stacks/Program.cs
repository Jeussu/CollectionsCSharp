﻿namespace StacksDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //defining a new stack
            Stack<int> stack = new Stack<int>();
            //add elements to the stack using Push()
            // add elements to the stack and printing the value on top of the stack using peek
            //Peek() will return the element at the top of the stack without removing it
            stack.Push(1);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(2);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());
            stack.Push(3);
            ////remove items from a stack
            //int myStackItem = stack.Pop();
            //Console.WriteLine("Popped item : {0}", myStackItem);
            Console.WriteLine("Top value in the stack is : {0}", stack.Peek());

            while (stack.Count > 0)
            {
                //Pop() will return the elements that was remove from the stack
                Console.WriteLine("The Top value {0} was removed from the stack", stack.Pop());
                //print the stack count
                Console.WriteLine("Current stack count is: {0}", stack.Count);
            }

            int[] numbers = new int[] { 8, 2, 3, 4, 7, 6, 2 };
            // defining a new stack of int
            Stack<int> myStack = new Stack<int>();

            Console.WriteLine("the numbers in the array are :");
            //foreach number in our array
            foreach (int number in numbers)
            {
                // print it
                Console.Write(number + " ");
                //push it into our stack(add)
                myStack.Push(number);
            }

            Console.WriteLine("");
            Console.WriteLine("the numbers in reverse :");
            //as long as our stack is not empty
            while (myStack.Count > 0)
            {
                // pop it and store it in a variable
                int number = myStack.Pop();
                // print the value we popped
                Console.Write(number + " ");
            }

        }
    }
}

