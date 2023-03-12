using System.Text;

namespace HT11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            GenericArray<int> array = new GenericArray<int>();

            array.AddElement(10);
            array.AddElement(20);
            array.AddElement(30);
            array.AddElement(40);
            array.AddElement(50);
            array.AddElement(60);
            array.AddElement(70);
            array.AddElement(80);
            array.AddElement(90);
            array.AddElement(100);
            array.AddElement(110);
            array.AddElement(120);

            array.GetElement(0);
            array.GetElement(9);
            array.GetElement(10);

            array.CountElements();

            Console.WriteLine("-------------------------------------------------------");

            GenericArray<string> array1 = new GenericArray<string>();

            array1.AddElement("orange");
            array1.AddElement("watermelon");
            array1.AddElement("melon");
            array1.AddElement("peach");
            array1.AddElement("pear");
            array1.AddElement("nuts");
            array1.AddElement("cucumber");
            array1.AddElement("tomato");
            array1.AddElement("potato");
            array1.AddElement("onion");
            array1.AddElement("cabbage");

            array1.GetElement(3);
            array1.GetElement(8);
            array1.GetElement(12);


            array1.CountElements();

            Console.WriteLine("-------------------------------------------------------");

            Console.WriteLine("Наибольшое число из введенных: " + MaxNumber<int>.MaxValue(78, 34, 69));
            Console.WriteLine("Наибольшое число из введенных: " + MaxNumber<double>.MaxValue(13.3, 34.42, 6.139));

        }
    }
}