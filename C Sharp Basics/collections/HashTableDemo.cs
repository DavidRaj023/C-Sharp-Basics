using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Basics.collections
{
    public class HashTableDemo
    {
        public static void getHashTableDemo()
        {
            var hashTable = new Hashtable();

            hashTable.Add("Name", "David");
            hashTable.Add("Dob", DateTime.Now);
            hashTable.Add("Mobile Numbner", 9578821821);

            foreach(DictionaryEntry data in hashTable)
            {
                Console.WriteLine("{0}: {1}", data.Key, data.Value);
            }
        }
    }
}
