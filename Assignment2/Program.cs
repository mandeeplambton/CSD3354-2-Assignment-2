using System;

public class Program
{
    //name: Mandeep Kaur(730387)
    //name: Amandeep Kaur(730499)
    public static void Main()
    {
        DelegateExercises delegateExercises = new DelegateExercises();
        delegateExercises.Method3();
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
        MyDelegate myDelegate = new MyDelegate(Method1);
        myDelegate();
    }
}
