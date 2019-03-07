﻿using System;
namespace DelegateAndEvents
{
    //name: Mandeep kaur(730387)
    //name: amandeep kaur(730499)

    public class Program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
        }
    }

    public class DelegateExercises
    {
        public delegate int MyDelegate();

        void Method1()
        {
            System.Console.WriteLine("MyDelegate");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
          
            myDelegate();
        }

    }
}