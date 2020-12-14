using System.Collections;
using System.Collections.Generic;
namespace RemoveDuplicates1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(5);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(1);
            list.AddLast(5);
            list.AddLast(7);
            list.AddLast(3);

            foreach (var item in list)
              System.Console.WriteLine(item);

            list = RemoveDuplicate(list);

            System.Console.WriteLine("Result");

            foreach (var item in list)
              System.Console.WriteLine(item);
        }
    

        public static LinkedList<int> RemoveDuplicate (LinkedList<int> list){
            Hashtable buffer = new Hashtable();
            LinkedList<int> listResult = new LinkedList<int>();
            if(list.Count <= 1){
              return list;
            }

            LinkedListNode<int> node = list.First;
            LinkedListNode<int> nodePrevious = null;
            LinkedListNode<int> nodeNext = null;


            while ( node != null ) {
              if ( !buffer.ContainsKey(node.Value) ){
                buffer.Add(node.Value, 1);
              }else {
                nodePrevious = node.Previous;
                nodeNext =  node.Next;
                if (nodeNext != null) {
                  list.Remove(node.Next);
                  list.AddAfter(nodePrevious, nodeNext);
                }
                list.Remove(node);
                node = nodePrevious;
              }
             
              node = node.Next;
            }
            return list;
        }
    }
}
