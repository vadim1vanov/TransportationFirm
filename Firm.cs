using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace FirmTranspLAB2
{
    /// <summary>
    /// основной класс программы
    /// </summary>
    public class Firm
    {
        private double money;
        private int mas;
        private string? firmName;
        private int countCar;
        private int countWorker;
        private string? carBrand;
        private int countTransp;
        static public int countObjects;

        public static int CountObjects { get { return countObjects; } }

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

            while (true)
            {
                if (fieldWrite.Length == 0) return "Введите название поля!";
                switch (fieldWrite)
                {
                    case "Money":
                        return $"Цена автомобиля через метод: {Money}";
                    case "money":
                        return $"Цена автомобиля через метод: {Money}";
                    case "Mas":
                        return $"Значение массы через метод: {Mas}";
                    case "mas":
                        return $"Значение массы через метод: {Mas}";
                    case "FirmName":
                        return $"Название фирмы через метод: {FirmName}";
                    case "firmName":
                        return $"Название фирмы через метод: {FirmName}";
                    case "CountCar":
                        return $"Количество автомобилей через метод: {CountCar}";
                    case "countCar":
                        return $"Количество автомобилей через метод: {CountCar}";
                    case "CountWorker":
                        return $"Количество работников через метод: {CountWorker}";
                    case "countWorker":
                        return $"Количество работников через метод: {CountWorker}";
                    case "CarBrand":
                        return $"Бренд автомобилей через метод: {CarBrand}";
                    case "carBrand":
                        return $"Бренд автомобилей через метод: {CarBrand}";
                    case "CountTransp":
                        return $"Количество перевозок в год через метод: {CountTransp}";
                    case "countTransp":
                        return $"Количество перевозок в год через метод: {CountTransp}";

                    default:
                        return "Введите название поля корректно!";
                }
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
            Form1 form1 = new Form1();
            if (field.Length == 0) return "Введите название поля!";
            switch (field) {
                case "money":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return DoubleToHex(doubleValue, 16);
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "Money":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return DoubleToHex(doubleValue, 16);
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                
                case "mas":
                    int intValue = Convert.ToInt32(value);
                    Mas = intValue;
                    return "Mas: " + Convert.ToString(intValue, 16);
                case "Mas":
                    intValue = Convert.ToInt32(value);
                    Mas = intValue;
                    return "Mas: " + Convert.ToString(intValue, 16);
                case "countWorker":
                    intValue = Convert.ToInt32(value);
                    CountWorker = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
                case "CountWorker":
                    intValue = Convert.ToInt32(value);
                    CountWorker = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
                case "countCar":
                    intValue = Convert.ToInt32(value);
                    CountCar = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
                case "CountCar":
                    intValue = Convert.ToInt32(value);
                    CountCar = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
                case "countTransp":
                    intValue = Convert.ToInt32(value);
                    CountTransp = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
                case "CountTransp":
                    intValue = Convert.ToInt32(value);
                    CountTransp = intValue;
                    return "CountWorker: " + Convert.ToString(intValue, 16);
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
            string pattern = "[+-]?([0-9]*)?(,?[0-9])";
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
            switch(fieldOpt){
                case "Money":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return Money.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "money":
                    if (CheckOnDouble(value))
                    {
                        double doubleValue = Convert.ToDouble(value);
                        Money = doubleValue;
                        return Money.ToString();
                    }
                    
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "Mas":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        Mas = intValue;
                        return Mas.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "mas":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        Mas = intValue;
                        return Mas.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "FirmName":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        FirmName = strValue;
                        return FirmName;
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "firmName":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        FirmName = strValue;
                        return FirmName;
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "CountWorker":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountWorker = intValue;
                        return CountWorker.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "countWorker":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountWorker = intValue;
                        return CountWorker.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "CountCar":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountCar = intValue;
                        return CountCar.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "countCar":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountCar = intValue;
                        return CountCar.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "CarBrand":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        CarBrand = strValue;
                        return CarBrand;
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "carBrand":
                    if (CheckOnString(value))
                    {
                        string strValue = value;
                        CarBrand = strValue;
                        return CarBrand;
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "CountTransp":
                    if (CheckOnInt(value))
                    {
                        int intValue = Convert.ToInt32(value);
                        CountTransp = intValue;
                        return CountTransp.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                case "countTransp":
                    if (CheckOnInt(value))
                    { 
                        int intValue = Convert.ToInt32(value);
                        CountTransp = intValue;
                        return CountTransp.ToString();
                    }
                    else return "Введите значение корректно в соответствии с типом данных!";
                default:
                    return "Введите название поля!";
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
}
