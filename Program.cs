using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var name = "Guilherme";
            if (name == "Guilherme")
            {
                Console.WriteLine("Hello Guilherme");
            } else 
            {
                Console.WriteLine("Hello unknow person");
            }
            Console.WriteLine(name);
            int value = 10;
            value += 1;
            Console.WriteLine(value);
            double doubleValue = 10.5;
        }
    }
}
