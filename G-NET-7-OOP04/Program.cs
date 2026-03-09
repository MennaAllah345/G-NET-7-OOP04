using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions
            #region Q1:
            //--> Static Binding(Early Binding):
            //* Happens at compile time.
            //* The method call is resolved by the compiler before the program runs.
            //* It is usually used with method overloading and static methods.
            //* It is faster because the method to be executed is already known at compile time.

            //--> Dynamic Binding(Late Binding):
            //* Happens at runtime.
            //* The method call is resolved while the program is running.
            //* It is used with method overriding and virtual methods.
            //* It allows polymorphism because the method that gets executed depends on the object's actual type.
            #endregion

            #region Q2:
            //--> Method Overloading:
            //* Happens when multiple methods have the same name but different parameters (different number, type, or order)..
            //* Occurs within the same class.
            //* It is resolved at compile time(static binding).
            //* It is used to increase the flexibility of methods.

            //==> Method Overriding:
            //* Happens when a derived class provides a specific implementation of a method that is already defined in the base class.
            //* The method in the base class must be declared as virtual, abstract, or override.
            //* It occurs between a base class and a derived class.
            //* It is resolved at runtime(dynamic binding).
            //* It is used to achieve runtime polymorphism.
            #endregion

            #region Q3:
            // The main keywords used for method overriding in C# are:

                //virtual
                //Used in the base class to declare a method that can be overridden in a derived class.

                //override
                //Used in the derived class to provide a new implementation of the virtual method.

                //abstract
                //Declares a method in an abstract class without implementation, and it must be overridden in derived classes.

                //sealed
                //Used with an overridden method to prevent further overriding in derived classes.
            #endregion

           #endregion



        }
    }
}
