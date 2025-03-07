// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Task
{
      class PositivePower
    {
        public string Run()
        {
            Console.WriteLine("Numero elevado al cuadrado");
            try
            {
                bool whileControl = true ;
                string?num = null;
                double power = 0 ;
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero");
                    num = Console.ReadLine();
                    int value = 0; 
                    bool control = int.TryParse(num,out value);
                    power = Math.Pow(value, 2);
                    if (control) whileControl = false ;
                }
                return $"Ingreso:{num}=>Resultado:{power}";    
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            
        }
    }

    class DoubleOrTriple
    {
        public string Run()
        {
            bool whileControl = true ;
            string?num = null, num2 = null;
            int value = 0,value2 = 0, total = 0; 
            Console.WriteLine("Doble o triple");
            try
            {
                
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero 1");
                    num = Console.ReadLine();
                    Console.WriteLine("Ingresar un numero 2");
                    num2 = Console.ReadLine();
                    bool control = int.TryParse(num,out value) && int.TryParse(num2,out value2);
                  
                    if (!control) continue ;
                    else{
                        if (value > value2) {
                            total = value *2;
                        }
                        else{
                            total = value2*3;
                        }  
                        whileControl = false;
                    }

                } 
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            return $"Ingreso:{num},{num2}=>Resultado:{total}";
        }
    }

    class RootOrSquare
    {
        public string Run()
        {
            Console.WriteLine("Raiz o cuadrado");
            try
            {
                bool whileControl = true ;
                string?num = null;
                double power = 0 ;
                int value = 0; 
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero");
                    num = Console.ReadLine();
                    bool control = int.TryParse(num,out value);
                    
                    if (control)
                        if (value > 0) {
                            power = Math.Sqrt(value) ;
                        }
                        else {
                            power = Math.Pow(value,2);
                        }
                        
                        whileControl = false ;
                }
                return $"Ingreso:{num}=>Resultado:{power}";    
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            
        }
    }

    class CirclePerimeter
    {
        public string Run()
        {
            Console.WriteLine("Perimetro del circulo");
            try
            {
                bool whileControl = true ;
                string?num = null;
                double power = 0 ;
                int value = 0; 
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero");
                    num = Console.ReadLine();
                    bool control = int.TryParse(num,out value);
                    power = (Math.PI * Math.Pow(value,2));
                    if (control) whileControl = false ;
                }
                return $"Ingreso:{num}=>Resultado:{power}";    
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            
        }
    }


 class MidweekDay
    {
        public string Run()
        {
            Console.WriteLine("Dias laborables");
            try
            {
                bool whileControl = true ;
                string?num = null;
                string[] days = {"Número fuera de rango laboral","Lunes","Martes","Miercoles","Jueves","Viernes","Número fuera de rango laboral","Número fuera de rango laboral"};
                int value = 0; 
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero");
                    num = Console.ReadLine();
                    bool control = int.TryParse(num,out value)  && ((1<= value)&(value >=7));
                    if (control) whileControl =false;
                }
                return $"Ingreso:{num}=>Resultado:{days[value]}";    
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            
        }
    }

    class TaxCalator
    {
        public string Run()
        {
            Console.WriteLine("Dias laborables");
            try
            {
                bool whileControl = true ;
                string?num = null;
                string[] days = {"Número fuera de rango laboral","Lunes","Martes","Miercoles","Jueves","Viernes","Número fuera de rango laboral","Número fuera de rango laboral"};
                int value = 0; 
                while (whileControl)
                {
                    Console.WriteLine("Ingresar un numero");
                    num = Console.ReadLine();
                    bool control = int.TryParse(num,out value)  && ((1<= value)&(value >=7));
                    if (control) whileControl =false;
                }
                return $"Ingreso:{num}=>Resultado:{days[value]}";    
            }
            catch (System.Exception)
            {
                return $"Error, agrega un numero valor no valido" + $"Error generado {System.Exception.ReferenceEquals}";
                throw;
            }
            
        }
    }















    class Program
    {
        static void Main(string[] args)
        {
            string?date = null;
            int value =0;
            bool control = true;
            while (control)
            {
                Console.WriteLine("Selecciona un tipo");
                date =  Console.ReadLine();
                control = int.TryParse(date,out value);
                //if(true) 
                //    Console.WriteLine("No es un valor correcto");
            
                switch (value)
                {
                    
                    case 0: 
                        control = false;
                    break;
                    case 1: 
                        PositivePower positivePower = new PositivePower();
                        Console.WriteLine(positivePower.Run());
                    break;
                    case 2: 
                        DoubleOrTriple doubleOrTriple = new DoubleOrTriple();
                        Console.WriteLine(doubleOrTriple.Run());
                    break;
                    case 3: 
                        RootOrSquare rootOrSquare = new RootOrSquare();
                        Console.WriteLine(rootOrSquare.Run());
                    break;
                    case 4: 
                        CirclePerimeter circlePerimeter = new CirclePerimeter();
                        Console.WriteLine(circlePerimeter.Run());
                    break;
                    case 5: 
                        MidweekDay midweekDay = new MidweekDay();
                        Console.WriteLine(midweekDay.Run());
                    break;
                    //case 6: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 7: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 8: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 9: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 10: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 11: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 12: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 13: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 14: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    //case 15: 
                    //    CirclePerimeter circlePerimeter = new CirclePerimeter();
                    //    Console.WriteLine(circlePerimeter.Run());
                    //break;
                    default:
                        Console.WriteLine("......");
                        break;
                }
            
            }

        }

    }








}