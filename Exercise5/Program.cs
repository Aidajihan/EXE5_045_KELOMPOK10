using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }
    class Program
    {
        int AIDA, FITHRIYAH, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*initializing the values of the variables REAR and FRONT to -1 to indicate that 
             * the name is initially empty,*/
            AIDA = -1;
            FITHRIYAH = -1;
        }
        public void insert(int element)
        {
            /*This statement check for the overflow condition. */
            if ((AIDA == 0 && FITHRIYAH == max - 1) || (AIDA == FITHRIYAH + 1))
            {
                Console.WriteLine("\nQueue overflow\n");
                return;
            }
            /* this following statements checks whether the queue is empty if the queue
             *  , them the value of the REAR and FRONT variabels is set to 0 */
            if (AIDA == -1)
            {
                AIDA = 0;
                FITHRIYAH = 0;
            }
            else
            {
                /* if REAR is at the last  positions of the array, them the value of
                 * REAR is set to 0 that corresponds to the first position of the array. */
                if (FITHRIYAH == max - 1)
                    FITHRIYAH = 0;
                else
                    /* if REAR is not at the last position, them its value is incremented by one. */
                    FITHRIYAH = FITHRIYAH + 1;

            }
            /* Once the position of REAR is determined, the element is added at its proper place. */
            queue_array[FITHRIYAH] = element;
        }
        public void remove()
        {
            /* Checks weather the queue is empty. */
            if (AIDA == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\n The Element deleted from the queue is : " + queue_array[AIDA] + "\n");
            /*Check if the queue has one element. */
            if (AIDA == FITHRIYAH)
            {
                AIDA = -1;
                FITHRIYAH = -1;
            }
            else
            {
                /*if the element to be deleted is the last position of the array, them the value 
                 * of FRONT is set to 0 i.e to the first element of the array. */
                if (AIDA == max - 1)
                    AIDA = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array. */
                    AIDA = AIDA + 1;

            }
        }
        public void display()
        {
            int FRONT_position = AIDA;
            int REAR_position = FITHRIYAH;
            /*checks if the queue is empty. */
            if (AIDA == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElements in the queue are .......................\n");
            if (FRONT_position <= REAR_position)
            {
                /* tranverses the queue till the last element present in an array. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "   ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /* transverse the queue till the last position of the array. */
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "     ");
                    FRONT_position++;
                }
                /* set the FRONT position to the first element of the array. */
                FRONT_position = 0;
                /* traverse the array till the last element present in the queue. */
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "     ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("MENU");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\n Enter your choice (1-4) :    ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number:   ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;

                        case '2':
                            {
                                queue.remove();

                            }
                            break;

                        case '3':
                            {
                                queue.display();
                            }
                            break;

                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option !!");
                            }
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Check for the values emtered .");
                }
            }
        }
    }
}
