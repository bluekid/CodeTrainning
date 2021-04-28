using System;

namespace DataStructTraining
{
    public class LinkedList
    {
        public Node _first = null;
        public Node _last = null;

        public Node Add( int data )
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = null;

            if ( _first == null )
                _first = newNode;

            if ( _last != null )
                _last.next = newNode;

            _last = newNode;

            return newNode;
        }

        public void Remove( int data )
        {
            Node prevNode = _first;
            Node curNode = _first;

            while ( curNode != null )
            {
                if ( curNode.data == data )
                {
                    prevNode.next = curNode.next;

                    Console.WriteLine( "data : " + curNode.data + " 가 삭제 되었습니다." );

                    curNode = null;
                    break;
                }

                prevNode = curNode;
                curNode = curNode.next;
            }
        }

        public void PrinitAllData()
        {
            Console.WriteLine( "LinkedList 데이터 리스트" );

            Node curNode = _first;

            while ( curNode != null )
            {
                Console.WriteLine( "data = " + curNode.data );

                curNode = curNode.next;
            }
        }
    }

    public class Node
    {
        public int data = -999;
        public Node next = null;
    }
}