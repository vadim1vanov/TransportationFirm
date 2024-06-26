﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;




namespace FirmTranspLAB2
{
    /// <summary>
    /// основной класс программы
    /// </summary>
    public class Firm : IComparable<Firm>
    {
        private double money;
        private int mas;
        private string? firmName;
        private int countCar;
        private int countWorker;
        private string? carBrand;
        private int countTransp;
        static public int countObjects;


        public int CompareTo(Firm other)
        {
            // Сравнение по количеству автомобилей
            return CountCar.CompareTo(other.CountCar);
        }


        public double Money
        {
            get { return money; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Некорректное значение!");
                }
                else { money = value; }
            }
        }

        public int Mas
        {
            get { return mas; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Некорректная масса");
                }
                else { mas = value; }
            }
        }

        public string? FirmName
        {
            get { return firmName; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Введите корректную массу");
                }
                else { firmName = value; }
            }
        }

        public int CountCar
        {
            get { return countCar; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное число автомобилей");
                }
                else if(value < 50)
                {
                    throw new NewException("Мало автомобилей!", value);
                }
                else { countCar = value; }
            }
        }

        public int CountWorker
        {
            get { return countWorker; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное число работников");
                }
                else { countWorker = value; }
            }
        }

        public string? CarBrand
        {
            get { return carBrand; }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Введите корректное название бренда");
                }
                else { carBrand = value; }
            }
        }

        public int CountTransp
        {
            get { return countTransp; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Введите корректное число перевозок");
                }
                else { countTransp = value; }
            }
        }

        /// <summary>
        /// конструктор по умолчанию
        /// </summary>
        public Firm()
        {
            countObjects++;
            Console.WriteLine("Конструктор по умолчанию");
        }

        /// <summary>
        /// конструктор с одним параметром
        /// </summary>
        /// <param name="FirmName">параметр конструктора, определяющий название фирмы</param>
        public Firm(string FirmName)
        {
            countObjects++;
            this.FirmName = FirmName;
        }

        /// <summary>
        /// конструктор с двумя параметрами
        /// </summary>
        /// <param name="CarBrand">параметр конструктора, определяющий бренд автомобилей</param>
        /// <param name="CountCar">параметр конструктора, определяющий количество автомобилей</param>
        public Firm(string CarBrand, int CountCar)
        {
            countObjects++;
            this.CarBrand = CarBrand;
            this.CountCar = CountCar;
        }

        /// <summary>
        /// конструктор с количеством параметров равным количеству полей
        /// </summary>
        /// <param name="Money">параметр конструктора, определяющий цену автомобиля</param>
        /// <param name="Mas">параметр конструктора, определяющий массу автомобиля</param>
        /// <param name="FirmName">параметр конструктора, определяющий название фирмы</param>
        /// <param name="CountCar">параметр конструктора, определяющий количество автомобилей</param>
        /// <param name="CountWorker">параметр конструктора, определяющий количество работников</param>
        /// <param name="CarBrand">параметр конструктора, определяющий бренд автомобилей</param>
        /// <param name="CountTransp">параметр конструктора, определяющий количество грузоперевозок в год</param>
        public Firm(double Money, int Mas, string FirmName, int CountCar,
        int CountWorker, string CarBrand, int CountTransp)
        {
            countObjects++;
            this.Money = Money;
            this.Mas = Mas;
            this.FirmName = FirmName;
            this.CountCar = CountCar;
            this.CountWorker = CountWorker;
            this.CarBrand = CarBrand;
            this.CountTransp = CountTransp;
        }

        /// <summary>
        /// Переопределенный метод ToString() для всего класса в целом
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Money + ", " + this.Mas + ", " + this.FirmName + ", " + this.CountCar + ", " +
            this.CountWorker + ", " + this.CarBrand + ", " + this.CountTransp + " ";
        }

        /// <summary>
        /// метод выводит значение выбранного поля
        /// </summary>
        /// <param name="fieldWrite">параметр метода, определяющий какое поле будет выведено</param>
        /// <returns></returns>
        public string writeFunc(string fieldWrite)
        {
                switch (fieldWrite)
                {
                    case "Цена автомобиля":
                        return $"Цена автомобиля через метод: {Money}";
                    case "Масса автомобиля":
                        return $"Значение массы через метод: {Mas}";
                    case "Название фирмы":
                        return $"Название фирмы через метод: {FirmName}";
                    case "Количество автомобилей":
                        return $"Количество автомобилей через метод: {CountCar}";
                    case "Количество работников":
                        return $"Количество работников через метод: {CountWorker}";
                    case "Бренд автомобилей":
                        return $"Бренд автомобилей через метод: {CarBrand}";
                    case "Количество грузоперевозок":
                        return $"Количество перевозок в год через метод: {CountTransp}";
                    default:
                        return "Выберите поле!";
                } 
        }
        

        /// <summary>
        /// функция представляет значение числового поля в шестнадцатеричном значении
        /// </summary>
        /// <param name="field">параметр метода, определяющий поле, которое будет конвертировано</param>
        /// <param name="value">параметр метода, определяющий значение поля, которое будет конвертировано</param>
        /// <returns></returns>
        public string hexNumber(string field, string value)
        {
            if(CheckOnDouble(value) == true)
            {
                
                if (Convert.ToDouble(value) < 0) return "Введите корректное значение!";
            }
            if(CheckOnInt(value) == true)
            {
                if (Convert.ToInt32(value) < 0) return "Введите корректное значение!";
            }
            switch (field) {
                case "Цена автомобиля":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return DoubleToHex(doubleValue, 16);
                    }
                    else return "Введите корректное значение!";
                case "Масса автомобиля":
                    if (CheckOnInt(value))
                    {
                        int intValue1 = Convert.ToInt32(value);
                        Mas = intValue1;
                        return "Масса автомобиля: " + Convert.ToString(intValue1, 16);
                    }
                    else return "Введите корректное значение!";
                case "Количество работников":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountWorker = intValue;
                        return "Количество работников: " + Convert.ToString(intValue, 16);
                    }
                    else return "Введите корректное значение!";
                case "Количество автомобилей":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountCar = intValue;
                        return "Количество автомобилей: " + Convert.ToString(intValue, 16);
                    }
                    else return "Введите корректное значение!";
                case "Количество грузоперевозок":
                    if (CheckOnInt(value))
                    { 
                        int intValue = Convert.ToInt32(value);
                        CountTransp = intValue;
                        return "Количество грузоперевозок: " + Convert.ToString(intValue, 16);
                    }
                    else return "Введите корректное значение!";
                default:
                    return "Введите название поля корректно!";
            }
        }

        /// <summary>
        /// метод конвертирует double значение в шестнадцатеричную систему счисления
        /// </summary>
        /// <param name="value">параметр метода, определяющий значение, которое будет конвертировано</param>
        /// <param name="maxDecimals">параметр метода, определяющий до скольки знаков после запятой будет вестись конвертация</param>
        /// <returns></returns>
        internal static string DoubleToHex(double value, int maxDecimals)
        {
            string result = string.Empty;
            if (value < 0)
            {
                result += "-";
                value = -value;
            }
            if (value > ulong.MaxValue)
            {
                result += double.PositiveInfinity.ToString();
                return result;
            }
            ulong trunc = (ulong)value;
            result += trunc.ToString("X");
            value -= trunc;
            if (value == 0)
            {
                return result;
            }
            result += ".";
            byte hexdigit;
            while ((value != 0) && (maxDecimals != 0))
            {
                value *= 16;
                hexdigit = (byte)value;
                result += hexdigit.ToString("X");
                value -= hexdigit;
                maxDecimals--;
            }
            return result;
        }

        /// <summary>
        /// метод CheckOnDouble проверяет входные данные на тип Double
        /// </summary>
        /// <param name="value">параметр метода, который проверяется на Double</param>
        /// <returns></returns>
        public bool CheckOnDouble(String? value)
        {
            char point = '.';
            if (value == null) return false;
            if (value.IndexOf(point) != -1) { return false; }
            string pattern = "^([0-9]*)?(,?[0-9]*)$";
            while (!Regex.IsMatch(value, pattern))
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// метод CheckOnInt проверяет входные данные на тип Int
        /// </summary>
        /// <param name="value">параметр метода, который проверяется на Int</param>
        /// <returns></returns>
        public bool CheckOnInt(String? value)
        {
            string pattern = "^\\d+$";
            if (value == null) return false;
            while (!Regex.IsMatch(value, pattern))
            {
                return false;
            }
            return true;
        }


        /// <summary>
        /// метод проверяет входные данные на тип string
        /// </summary>
        /// <param name="value">параметр метода, который проверяется на String</param>
        /// <returns></returns>
        public bool CheckOnString(String? value)
        {
            string pattern = "^[a-zA-Zа-яА-Я]*$";
            if(value == null) return false;
            while (!Regex.IsMatch(value, pattern))
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// метод ChangeField изменяет значения полей класса Firm
        /// </summary>
        /// <param name="fieldOpt">параметр метода ChangeField, определяющий какое поле будет изменено</param>
        /// <param name="value">параметр метода ChangeField, определяющий значение выбранного поля </param>
        /// <returns></returns>
        public string ChangeField(string fieldOpt, string value)
        {
            if (fieldOpt.Length == 0) return "Введите название поля!";
            switch(fieldOpt){
                case "Цена автомобиля":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return Money.ToString();
                    }
                    else return "Введите корректное значение!";
                case "Масса автомобиля":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        Mas = intValue;
                        return Mas.ToString();
                    }
                    else return "Введите корректное значение!";
                case "Название фирмы":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        FirmName = strValue;
                        return FirmName;
                    }
                    else return "Введите корректное значение!";
                case "Количество работников":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountWorker = intValue;
                        return CountWorker.ToString();
                    }
                    else return "Введите корректное значение!"; 
                case "Количество автомобилей":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountCar = intValue;
                        return CountCar.ToString();
                    }
                    else return "Введите корректное значение!";
                case "Бренд автомобилей":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        CarBrand = strValue;
                        return CarBrand;
                    }
                    else return "Введите корректное значение!";
                case "Количество грузоперевозок":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountTransp = intValue;
                        return CountTransp.ToString();
                    }
                    else return "Введите корректное значение!";
                default:
                    return "Выберите поле!";
                }
            }
    }

    /// <summary>
    /// вызов неуправляемого кода
    /// </summary>
    public class Win32
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr MessageBox(int hWnd, String text, String caption, uint type);
    }


    /// <summary>
    /// переопределение исключения InvalidCastException
    /// </summary>
    class InvalidCastException : SystemException
    {
        public object Value { get; }
       
        public InvalidCastException(string message, object value) 
            : base(message)
        {
            Value = value;
        }
    }

    /// <summary>
    /// создание собственного класса исключения
    /// </summary>
    class NewException : Exception
    {
        public int Value { get; }
        public NewException(string message, int val) 
            : base(message) 
        {
            Value = val;
        }
    }


   
    //Лаба 3 

    public delegate void NewCollectionChanged(object sender, EventArgs e);
    class NewCollection
    {
        Random rand = new Random();
        public Stopwatch stopwatch = new Stopwatch();
        public event NewCollectionChanged Notify;
        public Stack stack = new Stack();
        public Stack stack2 = new Stack();
        public Stack stack3 = new Stack();
        const int n = 100_000;
        public int[] array = new int[n];
        public Firm[] firmsArray = new Firm[n];
        public Stack<Firm> firmsStack = new Stack<Firm>();
        public int[] array2 = new int[n];
        Firm firm = new Firm("Tesla");
        Firm firm2 = new Firm("Skoda", 15000);
        Firm firm1 = new Firm(14000, 2000, "TOYOTAAA", 5000, 15000, "Skoda", 3650);

        public string PushArrayTest()
        {
            Firm[] firmsForPush = new Firm[n];
            for (int i = 0; i < n; i++)
            {
                firmsForPush[i] = new Firm($"{i + 1}");
            }
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                firmsArray[i] = firmsForPush[i];
            }
            stopwatch.Stop();
            return $"Mc 1: {stopwatch.ElapsedMilliseconds}";
        }
        public string PushStackTest()
        {
            Firm[] firmsForPush = new Firm[n];
            for (int i = 0; i < n; i++)
            {
                firmsForPush[i] = new Firm($"{i + 1}");
            }
            stopwatch.Reset(); 
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                firmsStack.Push(firmsForPush[i]);
            }
            stopwatch.Stop();
            return $"Mc 2: {stopwatch.ElapsedMilliseconds}";
        }

        public string RandomSelectTest()
        {
            stopwatch.Reset();
            stopwatch.Start();
            for (int i = 0; i < n; i++)
            {
                int index = rand.Next(0, n); // случайная выборка
                array2[i] = array[index];
            }
            stopwatch.Stop();
            return $"Mc 3: {stopwatch.ElapsedMilliseconds}";
        }


        public string MyCollection()
        {
            stack.Push(firm.ToString());
            stack.Push(firm1.ToString());
            stack.Push(firm2.ToString());
            string result = "";
            foreach (var item in stack)
            {
                result += $"Elem in stack: {item}\n";
            }
            return result;
        }

        /// <summary>
        /// функция добавляет элемент в стек
        /// </summary>
        /// <param name="s">аргумент, который будет добавлен в стек</param>
        /// <returns></returns>
        public string PushCollect(string s)
        {
            stopwatch.Start();
            stack.Push(s);
            Notify?.Invoke(this, EventArgs.Empty);
            stopwatch.Stop();
            return $"Mc: {stopwatch.ElapsedMilliseconds}";

        }
        
       
        /// <summary>
        /// функция извлекает первый элемент из стека 
        /// </summary>
        /// <returns></returns>
        public object Pop()
        {
            if (stack.Count > 0)
            {
                stack.Pop();
                Notify?.Invoke(this, EventArgs.Empty);
                string result = "";
                foreach (var item in stack)
                {
                    result += $"Elem in stack: {item}\n";

                }
                return result;
            }
            else return "Стек пуст!";
        }

        
        public void CollectionChange(EventArgs e)
        {
            Notify?.Invoke(this, e);
        }
    }

    class CollectionListeners
    {
        NewCollection collection;
        public CollectionListeners(NewCollection collection)
        {
            this.collection = collection;
            collection.Notify += CollectionHandler;
        }
        
        public void CollectionHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Изменение в Stack: ", "Событие", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
        }
    }

    //Лаба 4


    // Обобщенный класс CollectionType<T>
    class CollectionType<T> : LinkedList<T> where T : IComparable<T>
    {
        public CollectionType() : base() { }

        public void AddItem(T item)
        {
            AddLast(item);
        }

        public void RemoveItem(T item)
        {
            Remove(item);
        }
    }

   


    //Лаба 5


    // Прототип
    public abstract class CarPrototype : ICloneable
    {
        public abstract object Clone();
    }

    // Конкретная реализация прототипа
    public class Car : CarPrototype
    {
        public decimal Money { get; set; }
        public double Mas { get; set; }
        public string FirmName { get; set; }
        public int CountCar { get; set; }
        public int CountWorker { get; set; }
        public string CarBrand { get; set; }
        public int CountTransp { get; set; }

        public Car(decimal money, double mas, string firmName, int countCar, int countWorker, string carBrand, int countTransp)
        {
            Money = money;
            Mas = mas;
            FirmName = firmName;
            CountCar = countCar;
            CountWorker = countWorker;
            CarBrand = carBrand;
            CountTransp = countTransp;
        }

        public override object Clone()
        {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Money: {Money}, Mas: {Mas}, FirmName: {FirmName}, CountCar: {CountCar}, CountWorker: {CountWorker}, CarBrand: {CarBrand}, CountTransp: {CountTransp}";
        }
    }


    //Лаба6


    // Абстракция
    abstract class Car1
    {
        protected ICarManufacturer carManufacturer;

        public Car1(ICarManufacturer manufacturer)
        {
            carManufacturer = manufacturer;
        }

        public abstract string ShowDetails();
    }

    // Реализация абстракции - автомобиль CarA
    class CarA : Car1
    {
        public CarA(ICarManufacturer manufacturer) : base(manufacturer)
        {
        }

        public override string ShowDetails()
        {
            return carManufacturer.ProduceCar("Car A");
        }
    }

    // Реализация абстракции - автомобиль CarB
    class CarB : Car1
    {
        public CarB(ICarManufacturer manufacturer) : base(manufacturer)
        {
        }

        public override string ShowDetails()
        {
            return carManufacturer.ProduceCar("Car B");
        }
    }

    // Интерфейс реализации
    interface ICarManufacturer
    {
        string ProduceCar(string carName);
    }

    // Реализация интерфейса - производитель автомобилей ManufacturerA
    class ManufacturerA : ICarManufacturer
    {
        public string ProduceCar(string carName)
        {
            return $"Производитель {carName}";
        }
    }

    // Реализация интерфейса - производитель автомобилей ManufacturerB
    class ManufacturerB : ICarManufacturer
    {
        public string ProduceCar(string carName)
        {
            return $"Производитель {carName}";
        }
    }




    interface IFirm
    {
        string ShowInformation();
    }

    class Firma : IFirm
    {
        protected int Money;
        protected int Mas;
        protected string FirmName;
        protected int CountCar;
        protected int CountWorker;
        protected string CarBrand;
        protected int CountTransp;

        public Firma(int money, int mas, string firmName, int countCar, int countWorker, string carBrand, int countTransp)
        {
            Money = money;
            Mas = mas;
            FirmName = firmName;
            CountCar = countCar;
            CountWorker = countWorker;
            CarBrand = carBrand;
            CountTransp = countTransp;
        }

        public virtual string ShowInformation()
        {
            return $"Firm: {FirmName}";
        }
    }

    class MoneyAttribute : IFirm
    {
        private int _money;

        public MoneyAttribute(int money)
        {
            _money = money;
        }

        public string ShowInformation()
        {
            return $"Money: {_money}";
        }
    }





    //Лаба 7


    // Интерфейс стратегии для вычисления характеристик автомобиля
    interface ICarCalculationStrategy
    {
        string CalculateAndDisplay(int money, int mas, int countCar, int countWorker, string firmName, string carBrand, int countTransp);
    }

    // Конкретная стратегия для вычисления суммы денег и массы автомобиля
    class PriceAndMassCalculationStrategy : ICarCalculationStrategy
    {
        public string CalculateAndDisplay(int money, int mas, int countCar, int countWorker, string firmName, string carBrand, int countTransp)
        {
            return $"Price: {money}, Mas: {mas}";
        }
    }

    // Конкретная стратегия для вычисления количества автомобилей и работников
    class CountCarAndWorkerCalculationStrategy : ICarCalculationStrategy
    {
        public string CalculateAndDisplay(int money, int mas, int countCar, int countWorker, string firmName, string carBrand, int countTransp)
        {
           return $"Count of cars: {countCar}, Count of workers: {countWorker}";
        }
    }

    // Контекст, использующий различные стратегии для вычислений
    class CarContext
    {
        private ICarCalculationStrategy _strategy;

        public void SetStrategy(ICarCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public string CalculateAndDisplay(int money, int mas, int countCar, int countWorker, string firmName, string carBrand, int countTransp)
        {
            return _strategy.CalculateAndDisplay(money, mas, countCar, countWorker, firmName, carBrand, countTransp);
        }
    }



}
