using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uss1
{
    class Game
    {
    private Score scoreTracker; // Добавьте поле для объекта Score

    public Game()
    {
        scoreTracker = new Score(); // Инициализируйте объект Score
    }

    public void Start()
    {
        // Остальной код метода Start...

        // Получение имени игрока
        Console.Write("Sisestage oma nimi: ");
        string name = Console.ReadLine();

        // Получение результата игрока
        Console.Write("Sisestage oma tulemus: ");
        int score = Convert.ToInt32(Console.ReadLine());

        // Добавление результата игрока
        scoreTracker.AddScore(score);

        // Сохранение результатов
        scoreTracker.SaveScore();

        Console.WriteLine("Mäng on lõppenud. Jätkamiseks vajutage mis tahes klahvi.");
        Console.ReadKey();
    }

    // Остальной код класса Game...
}

        
        
    }

}
