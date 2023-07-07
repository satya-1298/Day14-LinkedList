using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_Prog
{
    public class ListData
    {
        public Node head;
        public void Add(int data)
        {
           Node node = new Node(data);
            if(head==null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null) 
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
        }
        public int Search(int value)
        {
           // int count = 0;
            int found = 0;
            Node temp = head;   
            if(head==null)
            {
                Console.WriteLine("List is Empty");
                
            }
            int count = 0;
            while (temp != null)
            {
                count++;
                if(temp.data==value)
                {
                    Console.WriteLine("The Element is in Position "+count);
                    found++;
                   
                }
                temp = temp.next;
                
            }
            if(found==1)
            {
                Console.WriteLine("Found the element {0}", value);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            return count;
            
            
        }

        public void Display()
        {
            Node temp= head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
            }
            while(temp != null) 
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
    }
}
