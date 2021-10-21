using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure_Problems
{
     public class Node
    {
        public char data;
        public Node next;

        public Node(char data)
        {
            this.data = data;
        }
    }

    public class Stack
    {
        private Node top;

        public Stack()
        {
            this.top = null;
        }


        internal void Push(char value)
        {
            Node node = new Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} pushed to stack", value);
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Cant Delete");
                return;
            }
            Console.WriteLine("Value popped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal bool IsEmpty()
        {
            if (this.top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static void CheckParentheses()
        {
            Stack Mystack = new Stack();
            string Equation = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
            char[] NewChar = Equation.ToCharArray();

            foreach (var element in NewChar)
            {
                if (element == '(')
                {
                    Mystack.Push('(');
                }
                else if (element == ')')
                {
                    Mystack.pop();
                }
            }


            if (Mystack.IsEmpty() == true)
            {
                Console.WriteLine("\nAll parentheses are balanced");
            }
            else
                Console.WriteLine("\nAll parentheses NOT are balanced");
        }

    }
}