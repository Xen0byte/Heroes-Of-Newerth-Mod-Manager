using System.Collections.Generic;

namespace CS_ModMan
{
    public static class ExtensionMethods
    {
        //two basic operation on dictionaries; not implemented efficiently, but - meh - irrelevant
        public static Dictionary<string, string> DeepCopyDictionary(this Dictionary<string, string> Old)
        {
            var myOutput = new Dictionary<string, string>();
            foreach (var Entry in Old) myOutput.Add(Entry.Key, Entry.Value);
            return myOutput;
        }

        public static bool DeepCompareDictionary(this Dictionary<string, string> A, Dictionary<string, string> B)
        {
            foreach (var Entry in A)
                if (!B.ContainsKey(Entry.Key) || B[Entry.Key] != Entry.Value)
                    return false;
            foreach (var Entry in B)
                if (!A.ContainsKey(Entry.Key) || A[Entry.Key] != Entry.Value)
                    return false;
            return true;
        }
    }
}