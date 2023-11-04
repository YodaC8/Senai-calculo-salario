using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static string setNome()
        {
            Console.WriteLine("Por favor insira o nome do usuário");
            return Console.ReadLine();
        } 
        public static double setSalario()
        {
            Console.WriteLine("Por favor insira o salário atual do usuário");
            return Convert.ToDouble(Console.ReadLine());
        } 
        public static double setPercentual()
        {
            Console.WriteLine("Por favor insira o percentual de reajuste");
            return Convert.ToDouble(Console.ReadLine());
        }
        public static double setSalarioBruto(double salarioUsuario,double percentualReajuste)
        {
            return salarioUsuario + (salarioUsuario * (percentualReajuste / 100));
        }
     
        public static double setSalarioFG(double salarioBruto)
        {
            return salarioBruto - (salarioBruto * (0.075));
        }
        public static double setSalarioINSS(double salariofg)
        {
            return salariofg - (salariofg * (0.075));
        }
        public static double setSalarioIR(double salarioinss)
        {
            double salarioir;
            
                if (salarioinss > 1900 || salarioinss < 2800);
            {
                salarioir = 7.5;
            } 

            if (salarioinss > 2800 || salarioinss < 3700);
            {
                salarioir = 15;
            }

            if (salarioinss > 3700 || salarioinss < 4600);
            {
                salarioir = 22;
            }

            if (salarioinss > 4600 );
            {
                salarioir = 27;
            }
            
            return salarioir;
        }
        public static double setSalarioFinal(double salarioir,double salarioinss)
        {
            double salarioFinal;
            return salarioFinal = salarioinss -= (salarioinss * (salarioir / 100));
        }

        static void Main(string[] args)
        {

            string nomeUsuario;
            double salarioBruto;
            double salarioUsuario;
            double percentualReajuste;
            double salarioFG;
            double salarioINSS;
            double salarioFinal;
            double salarioIR;

            nomeUsuario         = setNome();
            salarioUsuario      = setSalario();
            percentualReajuste  = setPercentual();
            salarioBruto        = setSalarioBruto(salarioUsuario, percentualReajuste);
            salarioFG           = setSalarioFG(salarioBruto);
            salarioINSS         = setSalarioINSS(salarioFG);
            salarioIR           = setSalarioIR(salarioINSS);
            salarioFinal        = setSalarioFinal(salarioIR, salarioINSS);

            Console.WriteLine("O Salário final é de {0}",salarioFinal);

            Console.ReadLine();
        }

    }
}

//salariofg -= (salarioBruto * (7,5 / 100))
//salarioinss -= (salariofg * (7,5 / 100))
//salarioir -= (salarioinss * (porcentagemir / 100))
//public static double conta()
//{
//    return (7, 5 / 100);
//}
//salarioINSS = setSalarioINSS();
//salarioIR = setSalarioIR();
