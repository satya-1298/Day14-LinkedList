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
            Console.WriteLine(data);
        }
        public void Reverse(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else

            {
                Node temp = head;
                head = node;
                head.next = temp;

            }
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
