using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// name:Mandeep kaur(730387)
//name: Amandeep kaur(730499)
namespace DelegateAndEvents
{
    class program
    {
        static void Main(string[] args)
        {
            DelegateExercises a = new DelegateExercises();
            a.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();
    public class DelegateExercises
    {
        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {

            System.Console.WriteLine(MyDelegate.ToString());
        }
    }
}