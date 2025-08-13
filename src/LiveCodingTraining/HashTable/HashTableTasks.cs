namespace LiveCodingTraining.HashTable;

public static class HashTableTasks
{
    /// <summary>
    /// ИСПОЛЬЗОВАНО НА СОЗВОНЕ
    /// Проверяет, являются ли две строки изоморфными.
    /// 
    /// Две строки изоморфны, если символы в одной строке можно заменить на символы 
    /// в другой строке, сохраняя порядок символов. Каждый символ в первой строке 
    /// должен соответствовать ровно одному символу во второй строке и наоборот.
    /// 
    /// Примеры:
    /// Вход: s = "egg", t = "add" → Выход: true
    /// Объяснение: e→a, g→d. Символ 'e' всегда соответствует 'a', 'g' всегда соответствует 'd'
    /// 
    /// Вход: s = "foo", t = "bar" → Выход: false  
    /// Объяснение: 'o' должен соответствовать и 'a' и 'r', что невозможно
    /// 
    /// Вход: s = "paper", t = "title" → Выход: true
    /// Объяснение: p→t, a→i, p→t, e→l, r→e
    /// 
    /// Вход: s = "ab", t = "aa" → Выход: false
    /// Объяснение: 'a' и 'b' не могут оба соответствовать 'a'
    /// </summary>
    public static bool IsIsomorphic(string s, string t)
    {
        if (s.Length != t.Length) return false;

        var map = new Dictionary<char, char>();
        var mapped = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (map.ContainsKey(c1))
            {
                if (map[c1] != c2)
                    return false;
            }
            else
            {
                if (mapped.Contains(c2))
                    return false;

                map[c1] = c2;
                mapped.Add(c2);
            }
        }

        return true;
    }
}