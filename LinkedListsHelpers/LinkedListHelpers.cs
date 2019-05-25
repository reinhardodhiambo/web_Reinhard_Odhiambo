using System;
using System.Collections.Generic;

namespace LinkedLists
{
    public class LinkedListHelpers
    {
        Node head;

        /*Node for the Linked List*/
        class Node
        {
            public char count;
            public Node next;
            public Node(char d)
            {
                count = d; next = null;
            }
        }

        public void deletePlusTwoDuplicates()
        {
            /*Reference to head*/
            Node current = head;

            /* Pointer to store the next  
            pointer of a node to be deleted*/
            Node next_node;
            /* Check if list is empty */
            if (head == null)
                return;

            /*Dictionary for storing occurrence count*/
            IDictionary<char, int> dict = new Dictionary<char, int>();

            /* Traverse linkekd list */
            dict.Add(current.count, 1);
            while (current != null)
            {
                if (current.next != null)
                {
                    Console.WriteLine(" " + current.next.count);
                    if (dict.ContainsKey(current.next.count))
                    {
                        if (dict[current.next.count] > 1)
                        {
                            Console.WriteLine("Removed: " + current.next.count + "Count: " + dict[current.next.count]);
                            next_node = current.next.next;
                            current.next = null;
                            current.next = next_node;
                            printList();
                        }
                        else
                        {
                            if (current != null)
                                Console.WriteLine("Contains: " + current.next.count + " Count: " + dict[current.next.count]);
                            dict[current.next.count] = dict[current.next.count] + 1;
                            current = current.next;
                        }


                    }
                    else
                    {
                        /*Adding new item to the dictionary*/
                        dict.Add(current.next.count, 1);
                        current = current.next;
                    }
                }
                else
                {
                    current = current.next;
                }

            }
        }

        /* Utility functions */

        /* Inserts a new Node at front of the list. */
        public void push(char new_data)
        {
            /* 1 & 2: Allocate the Node & 
                    Put in the data*/
            Node new_node = new Node(new_data);

            /* 3. Make next of new Node as head */
            new_node.next = head;

            /* 4. Move the head to point to new Node */
            head = new_node;
        }

        /* Function to print linked list */
        void printList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.count + " ");
                temp = temp.next;
            }
            Console.WriteLine();
        }
    }
}
