using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cocult
{
    /// <summary>
    /// команда для нахождения периметра или площади квадрата
    /// </summary>
    class ComandSquare : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandSquare()
        {
            NameComand = "квадрат";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Square sq = new Square(App.ToParametrs(data));

            App.listEnteredShapes.Add(sq);

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            int comand = Convert.ToInt32(Console.ReadLine());

            if (comand == 1) Console.WriteLine($"S = {sq.S()}");
            else if (comand == 2) Console.WriteLine($"P = {sq.P()}");
        }
    }
    /// <summary>
    /// команда для нахождения периметра или площади прямоугольника
    /// </summary>
    class ComandRectangle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandRectangle()
        {
            NameComand = "прямоугольник";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Rectangle sq = new Rectangle(App.ToParametrs(data));

            App.listEnteredShapes.Add(sq);

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            int comand = Convert.ToInt32(Console.ReadLine());

            if (comand == 1) Console.WriteLine($"S = {sq.S()}");
            else if (comand == 2) Console.WriteLine($"P = {sq.P()}");
        }
    }
    /// <summary>
    /// команда для нахождения периметра или площади прямоугольника
    /// </summary>
    class ComandTringle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandTringle()
        {
            NameComand = "треугольник";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Triangle sq = new Triangle(App.ToParametrs(data));

            App.listEnteredShapes.Add(sq);

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            int comand = Convert.ToInt32(Console.ReadLine());

            if (comand == 1) Console.WriteLine($"S = {sq.S()}");
            else if (comand == 2) Console.WriteLine($"P = {sq.P()}");
        }
    }
    /// <summary>
    /// команда для нахождения периметра или площади прямоугольника
    /// </summary>
    class ComandCircle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
         public string NameComand { get; set; }

        public ComandCircle()
        {
            NameComand = "круг";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute( string data)
        {
            Console.Clear();
            Circle sq = new Circle(App.ToParametrs(data));

            App.listEnteredShapes.Add(sq);

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            int comand = Convert.ToInt32(Console.ReadLine());

            if (comand == 1) Console.WriteLine($"S = {sq.S()}");
            else if (comand == 2) Console.WriteLine($"P = {sq.P()}");
        }
    }
    /// <summary>
    /// команда для нахождения периметра или площади прямоугольника
    /// </summary>
    class ComandPolygon : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPolygon()
        {
            NameComand = "многоугольник";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Polygon sq = new Polygon(App.ToParametrs(data));

            App.listEnteredShapes.Add(sq);

            Console.WriteLine("Вы желаете найти S(1) или P(2)");

            int comand = Convert.ToInt32(Console.ReadLine());

            if (comand == 1) Console.WriteLine($"S = {sq.S()}");
            else if (comand == 2) Console.WriteLine($"P = {sq.P()}");
        }
    }
    /// <summary>
    /// команда для нахождения суммы периметров всех введенных фигур
    /// </summary>
    class ComandAllP : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandAllP()
        {
            NameComand = "сумма_периметров_всех_введенных_фигур";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех P = {App.listEnteredShapes.PType<Figure>()}");
        }
    }
    /// <summary>
    /// команда для нахождения суммы площади всех введенных фигур
    /// </summary>
    class ComandAllS : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandAllS()
        {
            NameComand = "сумма_площадей_всех_введенных_фигур";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S = {App.listEnteredShapes.SType<Figure>()}");
        }
    }
    /// <summary>
    /// команда для вывода всех введенных фигур
    /// </summary>
    class ComandPrintEnteredShape : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintEnteredShape()
        {
            NameComand = "вывод_всех_введенных_фигур";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Введенные фигуры:\n  {App.listEnteredShapes.ToString()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы площадей всех введенных квадратов квадратов
    /// </summary>
    class ComandPrintSumSSquare : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumSSquare()
        {
            NameComand = "вывод_суммы_площадей_всех_введенных_квадратов";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S квадратов = {App.listEnteredShapes.SType<Square>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы площадей всех введенных кругов
    /// </summary>
    class ComandPrintSumSCircle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumSCircle()
        {
            NameComand = "вывод_суммы_площадей_всех_введенных_кругов";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S кругов = {App.listEnteredShapes.SType<Circle>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы площадей всех введенных прямоугольников
    /// </summary>
    class ComandPrintSumSRectangle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumSRectangle()
        {
            NameComand = "вывод_суммы_площадей_всех_введенных_прямоугольников";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S прямоугольников = {App.listEnteredShapes.SType<Rectangle>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы площадей всех введенных треугольников
    /// </summary>
    class ComandPrintSumSTriangle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumSTriangle()
        {
            NameComand = "вывод_суммы_площадей_всех_введенных_треугольников";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумма всех S треугольников = {App.listEnteredShapes.SType<Triangle>()}");
        }
    }

    /// <summary>
    /// команда для вывода суммы площадей всех введенных многоугольников
    /// </summary>
    class ComandPrintSumSPolygon : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

    public ComandPrintSumSPolygon()
    {
        NameComand = "вывод_суммы_площадей_всех_введенных_многоугольников";
    }

    /// <summary>
    /// метод выполнения команды
    /// </summary>
    /// <param name="data">параметры задания</param>
    public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная площадь многоугольников - {App.listEnteredShapes.SType<Polygon>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы периметров всех введенных квадратов
    /// </summary>
    class ComandPrintSumPSquare : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }
    public ComandPrintSumPSquare()
    {
        NameComand = "вывод_суммы_периметров_всех_введенных_квадратов";
    }

    /// <summary>
    /// метод выполнения команды
    /// </summary>
    /// <param name="data">параметры задания</param>
    public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров квадратов - {App.listEnteredShapes.PType<Square>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы периметров всех введенных кругов
    /// </summary>
    class ComandPrintSumPCircle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPCircle()
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_кругов";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров кругов - {App.listEnteredShapes.PType<Circle>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы периметров всех введенных прямоугольников
    /// </summary>
    class ComandPrintSumPRectangle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPRectangle()
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_прямоугольников";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров прямоугольников - {App.listEnteredShapes.PType<Rectangle>()}");
        }
    }
    /// <summary>
    /// команда для вывода суммы периметров всех введенных треугольников
    /// </summary>
    class ComandPrintSumPTriangle : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPTriangle()
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_треугольников";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров треугольников - {App.listEnteredShapes.PType<Triangle>()}");
        }
    }

    /// <summary>
    /// команда для вывода суммы периметров всех введенных многоугольников
    /// </summary>
    class ComandPrintSumPPolygon : IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandPrintSumPPolygon()
        {
            NameComand = "вывод_суммы_периметров_всех_введенных_многоугольников";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Console.WriteLine($"Сумарная периметров многоугольников - {App.listEnteredShapes.PType<Polygon>()}");
        }
    }
    /// <summary>
    /// команда для выхода из приложения
    /// </summary>
    class ComandExit: IComand
    {
        /// <summary>
        /// имя команды
        /// </summary>
        public string NameComand { get; set; }

        public ComandExit()
        {
            NameComand = "выход";
        }

        /// <summary>
        /// метод выполнения команды
        /// </summary>
        /// <param name="data">параметры задания</param>
        public void Execute(string data)
        {
            Console.Clear();
            Environment.Exit(0);
            Console.WriteLine($"Программа завершена!");
        }
    }
}
