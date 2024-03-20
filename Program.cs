using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Exceptions;
using HelloWorld.Model; // importando classe HelloModelo de HelloWorld.Model


namespace HelloWorld
{ // namespace é equivalente ao package em java
    class Program
    {
        public static void Main(String[] args)
        {
            // HelloModel model = new(); // ou new HelloModel()
            // Console.WriteLine("Hello " + model.Name);
            // Console.Read(); // espera o user digitar algo para seguir a execução

            // var name = "Guilherme";
            // if (name == "Guilherme")
            // {
            //     Console.WriteLine("Hello Guilherme");
            // } 
            // else 
            // {
            //     Console.WriteLine("Hello unknow person");
            // }

            // Console.WriteLine(name);

            // int value = 10;
            // value += 1;
            // Console.WriteLine(value);
            // double doubleValue = 10.5;

            // string[] list = {"Guilherme", "Heloisa"};
            // foreach (var item in list) 
            // {
            //     Console.WriteLine(item);
            // }

            // throw new PersonalizedException("Error message!"); // throwing exception

            // try
            // {
            //     throw new PersonalizedException("Error message");
            // }
            // catch (Exception)
            // {
            //     Console.WriteLine("Exception found!");
            // }
            // finally
            // {
            //     Console.WriteLine("End try catch");
            // }

            // string[] values = {"a", "b", "c"};
            // IList<string> list = new List<string>();
            // list.Add("Guilherme");
            // list.Add("Heloisa");
            // list.Insert(1, "Billy");
            // list.Add("Rafael");
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("--------------------");

            // list.Remove("Rafael");
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("--------------------");

            // list.RemoveAt(1);
            // foreach (var item in list)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine("--------------------");

            // Console.WriteLine(list.IndexOf("Heloisa"));


            IDictionary<string, string> dict = new Dictionary<string, string>();
            dict["person1"] = "Heloisa";
            dict["person2"] = "Guilherme";
            dict["person3"] = "Rafael";

            foreach (KeyValuePair<string, string> item in dict)
            {
                string key = item.Key;
                string value = item.Value;
                Console.WriteLine(key + " : " + value);
            }





        }
    }
}
