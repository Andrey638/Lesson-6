// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
Console.WriteLine("введите значение b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x=0;
double y=0;

Console.WriteLine("две прямые пересекутся в точке с координатами X: {0}, Y: {1}",coordinataX(b1,k1,b2,k2),coordinataY(x,b2,k2));

double coordinataX(double b1,double k1,double b2, double k2)
{
    {
        x = (-b2 + b1)/(-k1 + k2);
        return x;
    }

}    
double coordinataY(double x,double b2, double k2)
{    
    {
        y = k2 * x + b2;
        return y;
    }

}
