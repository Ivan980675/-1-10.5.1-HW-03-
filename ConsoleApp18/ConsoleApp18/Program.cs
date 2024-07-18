// Определение интерфейса для функции сложения
public interface IAdder
{
    double Add(double a, double b);
}

// Реализация интерфейса IAdder
public class Adder : IAdder
{
    public double Add(double a, double b)
    {
        return a + b;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IAdder adder = new Adder();

        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = adder.Add(num1, num2);
                Console.WriteLine($"Результат: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введено некорректное значение. Пожалуйста, введите числа.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Нажмите Enter, чтобы продолжить...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
