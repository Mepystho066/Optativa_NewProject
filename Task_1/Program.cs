// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using Task;

namespace Task
{
    class IntInput{
        bool control = false, control2 = true, exitControl = true;
        string?num = null;
        string exit = "q";
        int value = 0;
        List<int> values = new List<int>();
        public (List<int> num, bool exitControl) Retrun(int len=1){
            values.Clear();
            try
            {  
                while(len-->0){
                    while (control2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Ingresar un numero #{len}");
                        num = Console.ReadLine();
                        control = int.TryParse(num, out value);    
                        if(control){
                            values.Add(value);
                            control2 = false;
                        }
                        else if(exit.Equals(num)){
                            /// Para solucionar el problema que me generar al no poder acceder a la lista 
                            values.Add(value);
                            exitControl =false;
                            control2 = false;
                        }
                        
                    }
                    control2 = true;
                }
                return (values,exitControl);
            }
            catch (System.Exception)
            { 
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"Error Entrada de datos incorrecta");
                throw;
            }
            
        }
    }
    class PositivePower
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numero elevado al cuadrado");
      
                IntInput intInput = new IntInput();
                bool whileControl = true ;
                while (whileControl)
                {
                    var input = intInput.Retrun();
                    int num = input.num[0];
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Ingreso:{num} => Resultado: {Math.Pow(num, 2)}");
                    whileControl = input.exitControl;  
                }
            }
    }

    class DoubleOrTriple
    {
        public void Run()
        {
            IntInput intInput = new IntInput();      
            bool whileControl = true ;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Doble o triple");    
                while (whileControl)
                { 
                    var input = intInput.Retrun(2) ;
                    int num = input.num[0],num2 = input.num[1]; 
                        if (num > num2) {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Ingreso:{num},{num2} => Resultado: {num*2}");
                        }
                        else{
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"Ingreso:{num},{num2} => Resultado: {num2*3}");
                        }  
                        whileControl = input.exitControl;
                } 
                 
        }
    }
    class RootOrSquare
    {
        public void Run()
        {
            IntInput intInput = new IntInput();
            bool whileControl = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Raiz o cuadrado");
            while (whileControl)
            {
                    var input = intInput.Retrun();
                    int num = input.num[0];
                    if (num > 0) {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Ingreso:{num} => Resultado: {Math.Sqrt(num)}");
                    }
                    else {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Ingreso:{num} => Resultado: { Math.Pow(num,2)}");
                    }
                    whileControl = input.exitControl;
            }    
        }
    }
    class CirclePerimeter
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Perimetro del circulo");
                IntInput intInput1 = new IntInput();
                bool whileControl = true ;
                while (whileControl)
                {
                    var input = intInput1.Retrun();
                    int num = input.num[0];
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Ingreso:{num} => Resultado: {Math.PI * Math.Pow(num,2):N2}");
                    whileControl = input.exitControl ;
                }
        }
    }
 class MidweekDay
    {
        public void Run()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Dias laborables : Rango de 1 a 7");
                bool whileControl = true ;
                IntInput intInput = new IntInput(); 
                string[] days = {"","Lunes","Martes","Miercoles","Jueves","Viernes","Número fuera de rango laboral","Número fuera de rango laboral"};
                int value = 0; 
                while (whileControl)
                {
                    var input = intInput.Retrun();
                    int num = input.num[0];
                    if ((1<= value)&(value >=7)) {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"Ingreso:{num} => Resultado: {days[value]}");
                    } 
                    whileControl =false;
                }
            }
            
        }
    }
    class TaxCalator
    {
        public void Run()
        {
                IntInput intInput = new IntInput();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Impuesto de sueldo");
                bool whileControl = true ;
    
                while (whileControl)
                {
                        var input = intInput.Retrun();
                        int num = input.num[0];
                        if (num > 12000){
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine( $"Ingreso:{num} => Resultado: {num* 0.15}");
                        }
                        else{ 
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine( $"Ingreso:{num} => Resultado: No debe impuestos");
                        }
                        whileControl = input.exitControl;
                }
                  
            }
    }
    class RemainderFinder(){
        public void Run(){
            IntInput intInput = new IntInput();
            bool whileControl = true;
            while (whileControl)
            {
                var input = intInput.Retrun(2);
                int num = input.num[0],num2 = input.num[1];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Buscador de Restos");
                if (num2 != 0){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"Ingresos:{num},{num2} => Resultado: {num%num2}");
                }
                if (num2 == 0){
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Error divicion por 0");
                }
                whileControl = input.exitControl;
            }
        }

    }
     class SumOfEvens(){
        public void Run(){
            IntInput intInput = new IntInput();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Numeros pares");
                int value = 0; 
                for(int i = 1; i <=50 ;i++){
                    if ((i%2)==0) value+=i;
                }
                Console.ForegroundColor = ConsoleColor.DarkYellow;            
                Console.WriteLine($"Resultado: {value}");
        }
    }
     class FractionDifference(){
        public void Run(){
            IntInput intInput = new IntInput();
            bool whileControl = true;
            while (whileControl)
            {
                var input = intInput.Retrun(4);
                int num = input.num[0], num2 = input.num[1], num3 = input.num[2], num4 = input.num[3];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Diferencia factores");
                
                if ((num != 0) && (num2!=0) && (num3!=0) && (num4!= 0) ) {
                    int a =  (num*num4-num3*num2); 
                    int b = (num2*num4);
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if (a==0) Console.WriteLine($"Ingresos:{num}/{num2},{num3}/{num4} => Resultado: 0");
                    else Console.WriteLine($"Ingresos:{num}/{num2},{num3}/{num4} => Resultado: {a}/{b}");
                }  
                whileControl = input.exitControl;
            }
        }

    }

     class stringLenth(){
        public void Run(){
            IntInput intInput = new IntInput();
            bool whileControl = true;
            string?value =null;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Longitud de palabra");
            while (whileControl)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ingresar palabra");
                value = Console.ReadLine(); 
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Ingreso: \"{value}\" => Resultado: {value.Length}");
                if (value.Equals("q"))whileControl = false;
            }
        }

    }

    class AverageOfFour
    {
        public void Run()
        {
                IntInput intInput = new IntInput();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Promedio");
                bool whileControl = true ;
                while (whileControl)
                {
                        var input = intInput.Retrun(4);
                        int num = input.num[0], num2 = input.num[1], num3 = input.num[2], num4 = input.num[3];
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Ingresos:{num},{num2},{num3},{num4} => Resultado: {(num+num2+num3+num4)/4}");
                        whileControl = input.exitControl ;
                }
                  
            }
    }

    class SmallestOfFive
    {
        public void Run()
        {
                IntInput intInput = new IntInput();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Promedio");
                bool whileControl = true ;
                while (whileControl)
                {
                        var input = intInput.Retrun(5);
                        int min = input.num.Min();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Ingresos:{input.num[0]},{input.num[1]},{input.num[2]},{input.num[3]},{input.num[4]} => Resultado: {min}");
                        whileControl = input.exitControl ;
                }
                  
            }
    }
    /// <summary>
    ///  Organizar las que tienen entrada de texto para para que no tenga encuenta las
    ///  que tienen caracteres especiales ni numeros
    /// </summary>
    class VowelCounter(){
        public void Run(){
            IntInput intInput = new IntInput();
            bool whileControl = true;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vocales");
            string?value = null;
            while (whileControl)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Ingresar palabra");
                value = Console.ReadLine(); 
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                
                char [] control = {'a','e','i','o','u'};
                int vowel = 0; 
                foreach (char item in value.ToCharArray())
                {   
                    foreach(char cont in control){
                        if (item == cont){
                            vowel ++; 
                        }
                    }
                }
                Console.WriteLine($"Ingreso: \"{value}\" => Resultado: {vowel}");
                if (value.Equals("q")) whileControl = false;
            }
        }

    } 
    class FactorialFinder
    {
        public void Run()
        {
                IntInput intInput = new IntInput();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Factorial");
                bool whileControl = true ;
    
                while (whileControl)
                {
                        var input = intInput.Retrun();
                        int num = input.num[0];
                        double value = 0; 
                        for (int i = num; i > 0 ; i--) {value+= i; }
                        Console.WriteLine( $"Ingreso:{num} => Resultado: {value}");
                        whileControl = input.exitControl;
                }
            }
    }
    class InRangeValidator (){
        public void Run(){
            IntInput intInput = new IntInput();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Factorial");
            bool whileControl = true ;

            while (whileControl)
            {
                    var input = intInput.Retrun();
                    int num = input.num[0];
                    double value = 0; 
                    if((num >=10) &&(num<=20)){
                        Console.WriteLine( $"Ingreso:{num} => Resultado: Está en el rango");        
                    }
                    else{
                        Console.WriteLine( $"Ingreso:{num} => Resultado: Está fuera del rango");
                    }
                    whileControl = input.exitControl;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IntInput intInput = new IntInput();
    
            bool control = true;
            while (control)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Selecciona un tipo");
                var input = intInput.Retrun();
                int value = input.num[0];
                //if(true) 
                //    Console.WriteLine("No es un valor correcto");
            
                switch (value)
                {
                    
                    case 0: 
                        control = false;
                    break;
                    case 1: 
                        PositivePower positivePower = new PositivePower();
                        positivePower.Run();
                    break;
                     case 2: 
                         DoubleOrTriple doubleOrTriple = new DoubleOrTriple();
                         doubleOrTriple.Run();
                     break;
                     case 3: 
                         RootOrSquare rootOrSquare = new RootOrSquare();
                         rootOrSquare.Run();
                     break;
                     case 4: 
                         CirclePerimeter circlePerimeter = new CirclePerimeter();
                         circlePerimeter.Run();
                     break;
                    case 5: 
                        MidweekDay midweekDay = new MidweekDay();
                        midweekDay.Run();
                    break;
                    case 6: 
                        TaxCalator taxCalator = new TaxCalator();
                        taxCalator.Run();
                    break;
                    case 7: 
                        RemainderFinder remainderFinder = new RemainderFinder();
                        remainderFinder.Run();
                    break;
                    case 8: 
                        SumOfEvens sumOfEvens = new SumOfEvens();
                        sumOfEvens.Run();
                    break;
                    case 9: 
                        FractionDifference fractionDifference = new FractionDifference();
                        fractionDifference.Run();
                    break;
                    case 10: 
                        stringLenth stringLenth = new stringLenth();
                        stringLenth.Run();
                    break;
                    case 11: 
                        AverageOfFour averageOfFour = new AverageOfFour();
                        averageOfFour.Run();
                    break;
                    case 12: 
                        SmallestOfFive smallestOfFive = new SmallestOfFive();
                        smallestOfFive.Run();
                    break;
                    case 13: 
                        VowelCounter vowelCounter = new VowelCounter();
                        vowelCounter.Run();
                    break;
                    case 14: 
                        FactorialFinder factorialFinder = new FactorialFinder();
                        factorialFinder.Run();
                    break;
                    case 15: 
                        InRangeValidator inRangeValidator = new InRangeValidator();
                        inRangeValidator.Run();
                    break;
                    default:
                        Console.WriteLine("Error en la entrada ");
                        break;
                }
            
            }

        }

    }

