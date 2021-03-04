using System;
using System.Collections.Generic;
using System.Text;

namespace retoP1.list
{
    public class Node
    {
        private int data;
        private Node previous;
        private Node Next;

        public Node(int data)
        {
            this.data = data;
        }

        public int getDato()
        {
            return data;
        }

        public void setDato(int data)
        {
            this.data = data;
        }

        public Node getPrevious()
        {
            return previous;
        }

        public void setPrevious(Node previous)
        {
            this.previous = previous;
        }

        public Node getNext()
        {
            return Next;
        }

        public void setNext(Node next)
        {
            Next = next;
        }
    }
}
