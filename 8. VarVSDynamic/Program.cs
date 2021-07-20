using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace VarVSDynamic
{
    // Dynamic apresenta o benefício de poder se transformar em qualquer tipo de variável a qualquer momento durante a execução da aplicação.
    // Entretando, não tem intellisense (não difere letras maiúsculas e minículas para atributos).
    // Tipos dinamicos aceitam quaisquer atributos (se foram setados como objetos) mesmo que esses atributos nao existam.
    // O VS 'desiste' da variável e deixa a aplicação fazer o que bem entender com a tipagem dela.
    // Camufla bugs que só poderão ser encontrados em tempo de execução.
    // DYNAMIC = NON STATIC TYPED & WEAK TYPED
    // VAR = STATIC TYPED & STRONG TYPED

    // Quando Dynamic é preciso?
    // Quando se está usando coisas fora do C# e conversando com eles (Ex: outras linguagem de programação)

    public class Program
    {
        static void Main(string[] args)
        {
            dynamic testDynamic = new Person();
            var testVar = new Person();

            var myItem = new { Seila = "T", Q = "U" };

            testDynamic.FirstName = "Matheus";
            testDynamic.LastName = "Falcirolli";

            testVar.FirstName = "Luke";
            testVar.LastName = "Skywalker";

            double Money = 50.5;
            decimal MyMoney = 10.5M;

            testDynamic.SayHello();
            testVar.SayHello();

            Console.WriteLine($"{myItem.Seila} {myItem.Q}");
            Console.ReadLine();

            Program p = new Program();
            AccessDemo demo = new AccessDemo();

        }

        public string GetMessage()
        {
            return "Teste";
        }
    }
}
