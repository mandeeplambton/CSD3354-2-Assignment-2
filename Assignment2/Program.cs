using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DelegatesAndEvents
{

    public class DelegateExercises
    {
        public delegate void MyDelegate();

        void Method1(int i)
        {
            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Method2);
            myDelegate();
        }
    }
}
