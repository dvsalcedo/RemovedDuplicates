using System;
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
            list.AddLast(3);

            foreach (var item in list)
              System.Console.WriteLine(item);

            list = RemoveDuplicate(list);

            System.Console.WriteLine("Result");

            foreach (var item in list)
              System.Console.WriteLine(item);
        }
    

        public static LinkedList<int> RemoveDuplicate (LinkedList<int> list){
            Dictionary<int, int> buffer = new Dictionary<int,int>();
            LinkedList<int> listResult = new LinkedList<int>();
            if(list.Count <= 1)
              return list;
            
            foreach (var item in list)
            {
              if ( !buffer.ContainsKey(item) ){
                buffer.Add(item, 1);
                listResult.AddLast(item);
              }
            }

            return listResult;
        }
    }
}
