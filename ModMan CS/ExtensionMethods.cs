using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS_ModMan
{
    public static class ExtensionMethods
    {
        //two basic operation on dictionaries; not implemented efficiently, but - meh - irrelevant
        public static Dictionary<string, string> DeepCopyDictionary(this Dictionary<string, string> Old)
        {
            Dictionary<string, string> myOutput = new Dictionary<string, string>();
            foreach (KeyValuePair<string, string> Entry in Old)
            {
                myOutput.Add(Entry.Key, Entry.Value);
            }
            return myOutput;
        }

        public static bool DeepCompareDictionary(this Dictionary<string, string> A, Dictionary<string, string> B)
        {
            foreach (KeyValuePair<string, string> Entry in A)
            {
                if (!B.ContainsKey(Entry.Key) || B[Entry.Key] != Entry.Value) return false;
            }
            foreach (KeyValuePair<string, string> Entry in B)
            {
                if (!A.ContainsKey(Entry.Key) || A[Entry.Key] != Entry.Value) return false;
            }
            return true;
        }

    }
}
