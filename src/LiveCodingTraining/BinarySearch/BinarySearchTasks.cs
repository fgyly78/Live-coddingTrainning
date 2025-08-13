﻿namespace LiveCodingTraining.BinarySearch;

public static class BinarySearchTasks
{
    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Условие:
    /// Дано положительное целое число n. Определите,
    /// является ли это число совершенным квадратом (то есть существует ли такое целое число k, что k² = n).
    /// Входные данные:
    /// 
    /// Одно положительное целое число n (1 ≤ n ≤ 10⁹)
    ///
    /// Выходные данные:
    ///
    /// true, если число является совершенным квадратом
    /// false, если число не является совершенным квадратом
    ///
    /// Функциональные ограничения: временная сложность log(n)
    /// </summary>
    public static bool IsPerfectSquare(int n)
    {
        if (n == 0) return false;
        int root = (int)Math.Sqrt(n);
        return root * root == n;
    }
    
    
}