using System;
namespace Fitness_BL.Model
{
    [Serializable]
    public class Food
    {
        public string Name { get; }
        public double Callories { get; }
        public double Proteins1 { get; }
        public double Fats1 { get; }
        public double Carbohydates { get; }

        /// <summary>
        /// Белки
        /// </summary>
        public double Proteins { get; }

        /// <summary>
        /// Жиры
        /// </summary>
        public double Fats { get; }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Carbohydrates { get; }

        /// <summary>
        /// Калории за 100 грамм продукта
        /// </summary>
        public double Calories { get; }


        public Food(string name) : this(name, 0, 0, 0, 0) { }

        public Food(string name, double callories, double proteins, double fats, double carbohydates)
        {
            Name = name;
            Callories = callories / 100;
            Proteins1 = proteins / 100;
            Fats1 = fats / 100;
            Carbohydates = carbohydates / 100;

        }

        public override string ToString()
        {
            return Name;
        }
    }
}
