namespace Lesson3Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age;

            Console.Write("Введите свой возраст: ");
            while (!int.TryParse(Console.ReadLine(), out age) || age < 0 || age > 200)
            {
                Console.WriteLine("Введен неверный возраст, попробуйте еще раз");
                Console.Write("Введите свой возраст: ");
            }

            string ageCategory = age switch
            {
                >= 0 and <= 2 => "Ваша возрастная группа: младенец",
                >= 3 and <= 12 => "Ваша возрастная группа: ребёнок",
                >= 13 and <= 17 => "Ваша возрастная группа: подросток",
                >= 18 and <= 59 => "Ваша возрастная группа: взрослый",
                _ => "Ваша возрастная группа: пожилой"
            };
            Console.WriteLine(ageCategory);

            string isEven = (age % 2 == 0) ? "Возраст является четным числом" : "Возраст является нечетным числом";
            Console.Write(isEven);

        }
    }
}
