namespace TestLibrary
{
    /// <summary>
    /// Предоставляет набор математических операций, таких как сложение, вычитание, умножение, деление,
    /// возведение в степень и вычисление квадратного корня.
    /// </summary>
    public class MathLibrary
    {
        /// <summary>
        /// Преобразует строку в число типа double.
        /// </summary>
        /// <param name="input">Строка для преобразования.</param>
        /// <returns>Число типа double, полученное из строки.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если строка не является допустимым числом.</exception>
        private static double ParseStringToDouble(string input)
        {
            if (!double.TryParse(input, out double result))
                throw new ArgumentException("Invalid string input.");
            return result;
        }

        /// <summary>
        /// Складывает два целых числа.
        /// </summary>
        /// <param name="a">Первое слагаемое.</param>
        /// <param name="b">Второе слагаемое.</param>
        /// <returns>Сумма двух чисел.</returns>
        public static double Add(int a, int b) => a + b;

        /// <summary>
        /// Складывает два числа с плавающей точкой.
        /// </summary>
        /// <param name="a">Первое слагаемое.</param>
        /// <param name="b">Второе слагаемое.</param>
        /// <returns>Сумма двух чисел.</returns>
        public static double Add(double a, double b) => a + b;

        /// <summary>
        /// Складывает два числа, представленных в виде строк.
        /// </summary>
        /// <param name="a">Первое слагаемое в виде строки.</param>
        /// <param name="b">Второе слагаемое в виде строки.</param>
        /// <returns>Сумма двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если одна из строк не является допустимым числом.</exception>
        public static double Add(string a, string b) => Add(ParseStringToDouble(a), ParseStringToDouble(b));

        /// <summary>
        /// Вычитает одно целое число из другого.
        /// </summary>
        /// <param name="a">Уменьшаемое.</param>
        /// <param name="b">Вычитаемое.</param>
        /// <returns>Разность двух чисел.</returns>
        public static double Subtract(int a, int b) => a - b;

        /// <summary>
        /// Вычитает одно число с плавающей точкой из другого.
        /// </summary>
        /// <param name="a">Уменьшаемое.</param>
        /// <param name="b">Вычитаемое.</param>
        /// <returns>Разность двух чисел.</returns>
        public static double Subtract(double a, double b) => a - b;

        /// <summary>
        /// Вычитает одно число из другого, представленных в виде строк.
        /// </summary>
        /// <param name="a">Уменьшаемое в виде строки.</param>
        /// <param name="b">Вычитаемое в виде строки.</param>
        /// <returns>Разность двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если одна из строк не является допустимым числом.</exception>
        public static double Subtract(string a, string b) => Subtract(ParseStringToDouble(a), ParseStringToDouble(b));

        /// <summary>
        /// Умножает два целых числа.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <returns>Произведение двух чисел.</returns>
        public static double Multiply(int a, int b) => a * b;

        /// <summary>
        /// Умножает два числа с плавающей точкой.
        /// </summary>
        /// <param name="a">Первый множитель.</param>
        /// <param name="b">Второй множитель.</param>
        /// <returns>Произведение двух чисел.</returns>
        public static double Multiply(double a, double b) => a * b;

        /// <summary>
        /// Умножает два числа, представленных в виде строк.
        /// </summary>
        /// <param name="a">Первый множитель в виде строки.</param>
        /// <param name="b">Второй множитель в виде строки.</param>
        /// <returns>Произведение двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если одна из строк не является допустимым числом.</exception>
        public static double Multiply(string a, string b) => Multiply(ParseStringToDouble(a), ParseStringToDouble(b));

        /// <summary>
        /// Делит одно целое число на другое.
        /// </summary>
        /// <param name="dividend">Делимое.</param>
        /// <param name="divisor">Делитель.</param>
        /// <returns>Частное двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если делитель равен нулю.</exception>
        public static double Divide(int dividend, int divisor)
        {
            if (divisor == 0) throw new ArgumentException("Cannot divide by zero.");
            return dividend / divisor;
        }

        /// <summary>
        /// Делит одно число с плавающей точкой на другое.
        /// </summary>
        /// <param name="dividend">Делимое.</param>
        /// <param name="divisor">Делитель.</param>
        /// <returns>Частное двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если делитель равен нулю.</exception>
        public static double Divide(double dividend, double divisor)
        {
            if (divisor == 0) throw new ArgumentException("Cannot divide by zero.");
            return dividend / divisor;
        }

        /// <summary>
        /// Делит одно число на другое, представленных в виде строк.
        /// </summary>
        /// <param name="dividend">Делимое в виде строки.</param>
        /// <param name="divisor">Делитель в виде строки.</param>
        /// <returns>Частное двух чисел.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если одна из строк не является допустимым числом или делитель равен нулю.</exception>
        public static double Divide(string dividend, string divisor)
        {
            double dividendNum = ParseStringToDouble(dividend);
            double divisorNum = ParseStringToDouble(divisor);
            return Divide(dividendNum, divisorNum);
        }

        /// <summary>
        /// Возводит число в указанную степень.
        /// </summary>
        /// <param name="baseValue">Основание степени.</param>
        /// <param name="exponent">Показатель степени.</param>
        /// <returns>Результат возведения в степень.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если основание равно 0, а показатель степени неположителен.</exception>
        public static double Power(double baseValue, double exponent)
        {
            if (baseValue == 0 && exponent <= 0)
                throw new ArgumentException("0 cannot be raised to a non-positive power.");

            double result = 1;
            for (int i = 0; i < Math.Abs(exponent); i++)
                result *= baseValue;

            return exponent > 0 ? result : 1 / result;
        }

        /// <summary>
        /// Возводит целое число в целую степень.
        /// </summary>
        /// <param name="baseValue">Основание степени.</param>
        /// <param name="exponent">Показатель степени.</param>
        /// <returns>Результат возведения в степень.</returns>
        public static double Power(int baseValue, int exponent) => Power((double)baseValue, exponent);

        /// <summary>
        /// Возводит число, представленное в виде строки, в степень, также представленную в виде строки.
        /// </summary>
        /// <param name="baseValue">Основание степени в виде строки.</param>
        /// <param name="exponent">Показатель степени в виде строки.</param>
        /// <returns>Результат возведения в степень.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если одна из строк не является допустимым числом.</exception>
        public static double Power(string baseValue, string exponent)
        {
            double baseNum = ParseStringToDouble(baseValue);
            double exponentNum = ParseStringToDouble(exponent);
            return Power(baseNum, exponentNum);
        }

        /// <summary>
        /// Вычисляет квадратный корень числа.
        /// </summary>
        /// <param name="value">Число, из которого нужно извлечь корень.</param>
        /// <returns>Квадратный корень числа.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если число отрицательное.</exception>
        public static double SqrtLogic(double value)
        {
            if (value < 0)
                throw new ArgumentException("Square root of a negative number is not defined.");

            if (value == 0) return 0;

            double guess = value / 2;
            const double tolerance = 1e-6;
            int maxIterations = 1000;

            for (int iterations = 0; iterations < maxIterations; iterations++)
            {
                double nextGuess = 0.5 * (guess + value / guess);
                if (Math.Abs(nextGuess - guess) < tolerance)
                    return nextGuess;
                guess = nextGuess;
            }

            return guess;
        }

        /// <summary>
        /// Вычисляет квадратный корень целого числа.
        /// </summary>
        /// <param name="value">Целое число, из которого нужно извлечь корень.</param>
        /// <returns>Квадратный корень числа.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если число отрицательное.</exception>
        public static double Sqrt(int value) => SqrtLogic(value);

        /// <summary>
        /// Вычисляет квадратный корень числа, представленного в виде строки.
        /// </summary>
        /// <param name="value">Число в виде строки, из которого нужно извлечь корень.</param>
        /// <returns>Квадратный корень числа.</returns>
        /// <exception cref="ArgumentException">Выбрасывается, если строка не является допустимым числом или число отрицательное.</exception>
        public static double Sqrt(string value) => SqrtLogic(ParseStringToDouble(value));
    }
}