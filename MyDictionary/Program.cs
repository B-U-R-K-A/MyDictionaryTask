using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string,int> myDictionary = new MyDictionary<string,int>();
            myDictionary.Add(18,"Burak");
            myDictionary.Add(17,"Burhan");
            myDictionary.Add(17,"Abdullah");


            Console.Write("İsim Değeri Sayısı: " + myDictionary.CountS + " Yaş Değeri Sayısı: " + myDictionary.CountI);

          

            Console.ReadKey();
        }

        class MyDictionary<S,I>
        {

            S[] _arrayS;
            S[] _tempArrayS;
            I[] _arrayI;
            I[] _tempArrayI;


            public MyDictionary()
            {

                _arrayS = new S[0];
                _arrayI = new I[0];
            }
            public void Add(I holderI,S holderS)
            {
                _tempArrayS = _arrayS;
                _tempArrayI = _arrayI;
            
                _arrayS = new S[_arrayS.Length + 1];
                _arrayI = new I[_arrayI.Length + 1];

                for (int i = 0; i < _tempArrayS.Length; i++)
                {
                    _arrayS[i] = _tempArrayS[i];
                }
                for (int i = 0; i < _tempArrayI.Length; i++)
                {
                    _arrayI[i] = _tempArrayI[i];
                }
               
                _arrayS[_arrayS.Length - 1] = holderS;
                _arrayI[_arrayI.Length - 1] = holderI;

            }
            public int CountS
            {
                get { return _arrayS.Length; }
            }
            public int CountI
            {
                get { return _arrayI.Length; }
            } 
        }
    }
}
