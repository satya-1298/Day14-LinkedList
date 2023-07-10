using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
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
       public void Remove(int value)
       {
            int count = 0;
            int found = 0;
            Node prev=null;
            Node temp = head;

            if (head == null)
            {
                Console.WriteLine("Empty");
                
            }
            if (temp.data.Equals(value))
            {
                head = temp.next;
                temp = null;
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data == value)
                    {
                        break;
                    }
                    prev = temp;

                    temp = temp.next;

                }
                if (temp == null)
                {
                    return;
                }
                prev.next = temp.next;


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
