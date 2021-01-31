using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<Key,Value>
    {
        Key[] ArrayKeys;
        Key[] TempKeys;
        Value[] arrayValues;
        Value[] TempValues;
        public MyDictionary()
        {
            ArrayKeys = new Key[0];
            arrayValues = new Value[0];
        }
        public void Add (Key K ,Value V)
        {
            TempKeys = ArrayKeys;
            TempValues = arrayValues;
            ArrayKeys = new Key[ArrayKeys.Length + 1];
            arrayValues = new Value[arrayValues.Length + 1];
            for (int i = 0; i < TempKeys.Length; i++)
            {
                ArrayKeys[i] = TempKeys[i];

            }
            for (int i = 0; i < TempValues.Length; i++)
            {
                arrayValues[i] = TempValues[i];

            }
            ArrayKeys[ArrayKeys.Length - 1] = K;
            arrayValues[arrayValues.Length - 1] = V;
            Console.WriteLine("ID  : "  + ArrayKeys[ArrayKeys.Length - 1]   +  " Şehir :" + arrayValues[arrayValues.Length-1] +"  "+     "Havuza Eklenmiştir");
            Console.WriteLine("");

            for (int i = 0; i < arrayValues.Length; i++)
            {
                 Console.WriteLine("Id  : "  +ArrayKeys[i] + "---" +  "Şehir :"  +arrayValues[i]);
        
            }
            Console.WriteLine("");
            Console.WriteLine("");

        }

    }
}
