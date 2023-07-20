using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _02ReflectionBinding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Nashik03-04-2023\DOTNET\08DemoReflection\Calculator.DLL\bin\Debug\Calculator.DLL.dll";

            Assembly assembly = Assembly.LoadFrom(path);

            Console.WriteLine("Details of {0}", assembly.FullName);
            Console.WriteLine("----------------------------------------");

            Type[] types = assembly.GetTypes();
            object dynamicallyCreatedObject = null;
            foreach (Type type in types)
            {
                Console.WriteLine("Creating instance of {0}", type.Name);
                dynamicallyCreatedObject = assembly.CreateInstance(type.FullName);

                MethodInfo[] allMethods = type.GetMethods();
                foreach (MethodInfo method in allMethods)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Calling {0} method", method.Name);
                    Console.WriteLine("----------------------------------------");

                    ParameterInfo[] allParams = method.GetParameters();

                    object[] parametersToBePassed = new object[allParams.Length];
                    for (int i = 0; i < allParams.Length; i++)
                    {
                        ParameterInfo parameter = allParams[i];
                        Console.WriteLine("Enter value of Type {0} for Parameter name = {1}",
                                                        parameter.ParameterType, parameter.Name);
                        string dataEntered = Console.ReadLine();
                        parametersToBePassed[i] = Convert.ChangeType(dataEntered, parameter.ParameterType);
                    }
                    //BindingFlags - tells extra info about method, its a Enum,
                    //we can pass multipple values to a single parameter by sepertating them with | i.e pipe operator.
                    //so all 3 values of BindingFlags - seperated by pipe operators 
                    //goes to a method as a overriden? and binds method
                    object result = type.InvokeMember(method.Name,
                                                     BindingFlags.Public |
                                                     BindingFlags.Instance |
                                                     BindingFlags.InvokeMethod,
                                                     null,
                                                     dynamicallyCreatedObject,
                                                     parametersToBePassed);

                    Console.WriteLine("Result of {0} is {1}", method.Name, result);
                   
                    Console.WriteLine("----------------------------------------");
                }
            }

        }
    }
}
