using System;

namespace Recommendation_System
{
    class Doubly_LinkedList
    {
        public string[] str_name;
        public int[] str_price;
        public int[] str_capacity;
        public string[] str_ingredient;

        // Structure of a Node 
        public class Node
        {
            public string name;
            public int price;
            public int capacity;
            public string ingredients;
            public Node next;
            public Node prev;
        };
        Node start;
        //Node temp;

        // Function to insert at the end 
        public void insertEnd(string Name, int price, int capacity, string ingredients)
        {
            Node new_node;

            // If the list is empty, create a single node 
            // circular and doubly list 
            if (start == null)
            {
                new_node = new Node();
                new_node.name = Name;
                new_node.price = price;
                new_node.capacity = capacity;
                new_node.ingredients = ingredients;
                new_node.next = new_node.prev = new_node;
                start = new_node;
                return;
            }

            // If list is not empty 

            /* Find last node */
            Node last = (start).prev;

            // Create Node dynamically 
            new_node = new Node();
            new_node.name = Name;
            new_node.price = price;
            new_node.capacity = capacity;
            new_node.ingredients = ingredients;
            // Start is going to be next of new_node 
            new_node.next = start;

            // Make new node previous of start 
            (start).prev = new_node;

            // Make last preivous of new node 
            new_node.prev = last;

            // Make new node next of old last 
            last.next = new_node;
        }

        public void display_next(int n)
        {
            int i = 0;
            str_name = new string[n];
            str_price = new int[n];
            str_capacity = new int[n];
            str_ingredient = new string[n];

            Node temp = start;
            do
            {
                str_name[i] = temp.name;
                str_price[i] = temp.price;
                str_capacity[i] = temp.capacity;
                str_ingredient[i] = temp.ingredients;
                i++;
                temp = temp.next;

            } while (temp.next != start);
            str_name[i] = temp.name;
            str_price[i] = temp.price;
            str_capacity[i] = temp.capacity;
            str_ingredient[i] = temp.ingredients;
        }

    }
}
