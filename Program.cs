using System.Collections.Generic;

List<int> testScores = new List<int>();
try
{
    AddScore(testScores, 80);
    AddScore(testScores, -5);
    AddScore(testScores, 90);
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Ошибка: результат должен быть от 0 до 100");
} 
Console.WriteLine($"Сохранено результатов: {testScores.Count}");


void AddScore(List<int> scores, int score)
{
    if (score < 0 || score > 100)
    {
        throw new ArgumentOutOfRangeException(
            nameof(score), "Результат должен быть от 0 до 100");
    }

    scores.Add(score);
}