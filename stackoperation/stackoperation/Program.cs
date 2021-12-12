using System;

namespace StackQueueOperation
{
    //+++ Start Stack class +++++
    internal class Stack
    {
        static readonly int MAX = 1000;
        int top;
        int[] stack = new int[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public Stack()
        {
            top = -1;
        }
        internal bool Push(int data)
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }
            else
            {
                int value = stack[top--];
                return value;
            }
        }

        internal void Peek()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
                Console.WriteLine("The topmost element of Stack is : {0}", stack[top]);
        }

        internal void PrintStack()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }
            else
            {
                Console.WriteLine("Items in the Stack are :");
                for (int i = top; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
    }
    //++++++++++++++++++++++++++++++++++++++++ End Stack class +++++++++++++++

    //+++ Start Queue class +++++
    public class Queue
    {
        private static int front, rear, capacity;
        private static int[] queue;

        public Queue(int c)
        {
            front = rear = 0;
            capacity = c;
            queue = new int[capacity];
        }

        // function to insert an element
        // at the rear of the queue
        public void queueEnqueue(int data)
        {
            // check queue is full or not
            if (capacity == rear)
            {
                Console.Write("\nQueue is full\n");
                return;
            }

            // insert element at the rear
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }

        // function to delete an element
        // from the front of the queue
        public void queueDequeue()
        {
            // if queue is empty
            if (front == rear)
            {
                Console.Write("\nQueue is empty\n");
                return;
            }

            // shift all the elements from index 2 till rear
            // to the right by one
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];
                }

                // store 0 at rear indicating there's no element
                if (rear < capacity)
                    queue[rear] = 0;

                // decrement rear
                rear--;
            }
            Console.WriteLine("Dequeue Successfully");
            return;
        }

        // print queue elements
        public void queueDisplay()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            // traverse front to rear and print elements
            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} <-- ", queue[i]);
            }
            return;
        }

        // print front of queue
        public void queueFront()
        {
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            Console.Write("\nFront Element is: {0}", queue[front]);
            return;
        }
    }
    //+++ End Queue class +++++
    //++++++++++++++++++++++++++++++++++ End Classes +++++++++++++++++++++++

    //++++Driver codes section++++
    class Program
    {
        static void Main(string[] args)
        {
            string ext = "";
            do
            {
                Console.Clear();
                Console.WriteLine("================ Welcome! to StackQueue Operation ===========");
                Console.WriteLine();
                Console.WriteLine("1. Stack Operation");
                Console.WriteLine("2. Queue Operation");
                Console.WriteLine();
                Console.Write("Please select Operation to perform: ");
                int mychoice = Convert.ToInt32(Console.ReadLine());
                switch (mychoice)
                {
                    case 1:
                        //==========================Stack Driver code========================
                        Console.WriteLine("++++++++++++ Welcome to Stack Operations +++++++++++++");
                        Stack myStack = new Stack();
                        string x = "";
                        Console.WriteLine("\nHow many element you want to push to satck?");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= num; i++)
                        {
                            Console.WriteLine("Enter the element " + i);
                            int element = Convert.ToInt32(Console.ReadLine());
                            myStack.Push(element);
                        }
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("++++++++++++ Welcome to Stack Operations +++++++++++++");
                            Console.WriteLine();
                            Console.WriteLine("1. Print Stack");
                            Console.WriteLine("2. Push more Element");
                            Console.WriteLine("3. Pop Element");
                            Console.WriteLine("4. Peek Stack");
                            Console.WriteLine();
                            Console.WriteLine("Select operation to perform");
                            int select = Convert.ToInt32(Console.ReadLine());
                            switch (select)
                            {
                                case 1:
                                    myStack.PrintStack();
                                    break;
                                case 2:
                                    Console.WriteLine("How many element you want to push to satck?");
                                    int m = Convert.ToInt32(Console.ReadLine());
                                    for (int i = 1; i <= m; i++)
                                    {
                                        Console.WriteLine("Enter the element " + i);
                                        int element = Convert.ToInt32(Console.ReadLine());
                                        myStack.Push(element);
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("The Pop element is: " + myStack.Pop());
                                    break;
                                case 4:
                                    myStack.Peek();
                                    break;
                                default:
                                    Console.WriteLine("Oops!... Selection out range!!..choose btw 1 and 4");
                                    break;
                            }
                            Console.Write("Do you want to perform more stack operation?..Enter Y for Yes, any key to exit: ");
                            x = Console.ReadLine();
                        } while (x == "Y" || x == "y");
                        // ===========End of Stack Driver==============
                        break;
                    case 2:
                        //======================Queue Dirver code=========================
                        Console.WriteLine("++++++++++++ Welcome to Queue Operations +++++++++++++");
                        //Create a queue of capacity 
                        Console.WriteLine("\nWhat is the capacity(size) of your queue?");
                        int size = Convert.ToInt32(Console.ReadLine());
                        Queue myqueue = new Queue(size);
                        string ex = "";
                        Console.Clear();
                        //// inserting elements in the queue
                        //Console.WriteLine("Now let enter some element in the Queue..How many element you want to Enqueue this time?");
                        //int n = Convert.ToInt32(Console.ReadLine());
                        //if (n > size)
                        //{
                        //    Console.WriteLine("Oops!..Capacity of the queue can not hold that");
                        //}
                        //else
                        //{
                        //    for (int i = 1; i <= n; i++)
                        //    {
                        //        Console.WriteLine("Enter the element " + i);
                        //        int element = Convert.ToInt32(Console.ReadLine());
                        //        myqueue.queueEnqueue(element);
                        //    }
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("++++++++++++ Welcome to Queue Operations +++++++++++++");
                                Console.WriteLine();
                                Console.WriteLine("1. Print Queue");
                                Console.WriteLine("2. Enqueue Element");
                                Console.WriteLine("3. Dequeue Element");
                                Console.WriteLine("4. Peek Front Element");
                                Console.WriteLine();
                                Console.WriteLine("Select operation to perform");
                                int select = Convert.ToInt32(Console.ReadLine());
                                switch (select)
                                {
                                    case 1:
                                        // print Queue elements
                                        myqueue.queueDisplay();
                                        break;
                                    case 2:
                                        // Insert Queue elements
                                        Console.WriteLine("Enter the element to enqueue.");
                                        int NewElement = Convert.ToInt32(Console.ReadLine());
                                        myqueue.queueEnqueue(NewElement);
                                        Console.WriteLine("After Equeuing, New Queue is:");
                                        myqueue.queueDisplay();
                                        break;
                                    case 3:
                                        // Delecting Queue elements
                                        myqueue.queueDequeue();
                                        Console.WriteLine("After Dequeuing, New Queue is:");
                                        myqueue.queueDisplay();
                                        break;
                                    case 4:
                                        // Displaying Queue front element
                                        myqueue.queueFront();
                                        break;
                                    default:
                                        Console.WriteLine("Oops!... Selection out range!!..choose btw 1 and 4");
                                        break;
                                }
                                Console.Write("\n\nDo you want to perform more stack operation?..Enter Y for Yes, any key to exit: ");
                                ex = Console.ReadLine();

                            } while (ex == "Y" || ex == "y");
                        //}
                        break;
                    default:
                        Console.WriteLine("Oops!... Selection out range!!..choose btw 1 and 2");
                        break;
                }
                Console.Write("\n\nDo you want to Choose btw Stack or Queue Operation..Enter Y for Yes, any key to exit: ");
                ext = Console.ReadLine();
            } while (ext == "Y" || ext == "y");

        }
    }
}