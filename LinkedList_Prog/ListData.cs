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
       public void Sort_List()
       {
            Node temp = head;
            Node ele = null;
            int node = 0;
            if(temp==null)
            {
                Console.WriteLine("List is Empty");
            }
            while (temp != null)
            {
                ele = temp.next;
                while (ele != null)
                {
                    if (temp.data.CompareTo( ele.data)>0)
                    {
                        node = ele.data;
                        ele.data = temp.data;
                        temp.data = node;
                    }
                    ele = ele.next;
                }
                temp = temp.next;
            }
            Console.WriteLine("Sorted list is");
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
