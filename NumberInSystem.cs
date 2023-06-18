using System;
using System.Text.RegularExpressions;

namespace NumberOperations
{
    class NumberInSystem
    {
        private string num;
        private int numberBase;

        public NumberInSystem(string num, int numberBase)
        {
            if (!isValidNumberSystem(numberBase))
            {
                throw new ArgumentException("Число має бути більше, ніж 2 та менше, ніж 9");
            }
            else if (!isValidNumber(num, numberBase))
            {
                throw new ArgumentException("Некоректне число");
            }

            this.num = num;
            this.numberBase = numberBase;
        }

        public string getNum()
        {
            return this.num;
        }

        public int getNumberBase()
        {
            return this.numberBase;
        }


        public static bool isValidNumber(string num, int numberSystem)
        {
            Regex regex = new Regex(@"^\d+$");
            if (!regex.IsMatch(num))
            {
                return false;
            }

            foreach (char c in num)
            {

                if ((int)c - '0' >= numberSystem)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool isValidNumberSystem(int numberSystem)
        {
            return 2 <= numberSystem && numberSystem <= 9;
        }

        public static NumberInSystem operator +(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            int sumInBase10 = toBase10(secondNumber.num, secondNumber.numberBase) + toBase10(firstNumber.num, firstNumber.numberBase);
            return new NumberInSystem(fromBase10(sumInBase10, firstNumber.numberBase), firstNumber.numberBase);
        }

        public static NumberInSystem operator -(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            int diffInBase10 = toBase10(firstNumber.num, firstNumber.numberBase) - toBase10(secondNumber.num, secondNumber.numberBase);
            if (diffInBase10 < 0)
            {
                throw new ArgumentException("Перше число має бути більше, ніж друге");
            }
            return new NumberInSystem(fromBase10(diffInBase10, firstNumber.numberBase), firstNumber.numberBase);
        }

        public static NumberInSystem operator *(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            int resInBase10 = toBase10(secondNumber.num, secondNumber.numberBase) * toBase10(firstNumber.num, firstNumber.numberBase);
            return new NumberInSystem(fromBase10(resInBase10, firstNumber.numberBase), firstNumber.numberBase);
        }

        public static NumberInSystem operator /(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            int resInBase10 = toBase10(firstNumber.num, firstNumber.numberBase) / toBase10(secondNumber.num, secondNumber.numberBase);
            return new NumberInSystem(fromBase10(resInBase10, firstNumber.numberBase), firstNumber.numberBase);
        }

        public static bool operator ==(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(secondNumber.num, secondNumber.numberBase) == toBase10(firstNumber.num, firstNumber.numberBase);
        }

        public static bool operator !=(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(secondNumber.num, secondNumber.numberBase) != toBase10(firstNumber.num, firstNumber.numberBase);
        }

        public static bool operator >=(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(firstNumber.num, firstNumber.numberBase) >= toBase10(secondNumber.num, secondNumber.numberBase);
        }

        public static bool operator <=(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(firstNumber.num, firstNumber.numberBase) <= toBase10(secondNumber.num, secondNumber.numberBase);
        }

        public static bool operator <(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(firstNumber.num, firstNumber.numberBase) < toBase10(secondNumber.num, secondNumber.numberBase);
        }

        public static bool operator >(NumberInSystem firstNumber, NumberInSystem secondNumber)
        {
            return toBase10(firstNumber.num, firstNumber.numberBase) > toBase10(secondNumber.num, secondNumber.numberBase);
        }

        public static string toBase(string number, int start_base, int target_base)
        {

            int base10 = toBase10(number, start_base);
            string rtn = fromBase10(base10, target_base);
            return rtn;

        }

        public static int toBase10(string number, int start_base)
        {

            if (start_base < 2 || start_base > 9)
            {
                throw new ArgumentException("Число має бути більше, ніж 2 та менше, ніж 9");
            };

            char[] chrs = number.ToCharArray();
            int m = chrs.Length - 1;
            int n = start_base;
            int x;
            int rtn = 0;

            foreach (char c in chrs)
            {

                if (char.IsNumber(c))
                    x = int.Parse(c.ToString());
                else
                    x = Convert.ToInt32(c) - 55;

                rtn += x * (Convert.ToInt32(Math.Pow(n, m)));

                m--;

            }

            return rtn;

        }

        public static string fromBase10(int number, int target_base)
        {

            if (target_base < 2 || target_base > 9)
            {
                throw new ArgumentException("Число має бути більше, ніж 2 та менше, ніж 9");
            };

            int n = target_base;
            int q = number;
            int r;
            string rtn = "";

            while (q >= n)
            {

                r = q % n;
                q = q / n;

                if (r < 10)
                    rtn = r.ToString() + rtn;
                else
                    rtn = Convert.ToChar(r + 55).ToString() + rtn;

            }

            if (q < 10)
                rtn = q.ToString() + rtn;
            else
                rtn = Convert.ToChar(q + 55).ToString() + rtn;

            return rtn;

        }
    }
}
