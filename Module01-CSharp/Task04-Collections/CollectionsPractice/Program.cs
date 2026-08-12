// ============================================
// Task 1.4 - Arrays & Collections
// ============================================

Console.WriteLine("======================================");
Console.WriteLine("       COLLECTIONS PRACTICE");
Console.WriteLine("======================================");


// ============================================
// 1. ARRAY
// ============================================

int[] scores = { 80, 85, 90, 95, 88 };

Console.WriteLine();
Console.WriteLine("ARRAY");
Console.WriteLine("-----");

Console.WriteLine($"First score : {scores[0]}");
Console.WriteLine($"Third score : {scores[2]}");
Console.WriteLine($"Total scores: {scores.Length}");

foreach (int score in scores)
{
    Console.WriteLine($"Score: {score}");
}


// ============================================
// 2. LIST<T>
// ============================================

List<int> scoresList = new List<int>();

scoresList.Add(80);
scoresList.Add(85);
scoresList.Add(90);

Console.WriteLine();
Console.WriteLine("LIST<T>");
Console.WriteLine("-------");

Console.WriteLine($"Number of scores: {scoresList.Count}");

scoresList.Add(95);

Console.WriteLine($"After adding 95: {scoresList.Count} scores");

scoresList.Remove(85);

Console.WriteLine($"After removing 85: {scoresList.Count} scores");

foreach (int score in scoresList)
{
    Console.WriteLine($"Score: {score}");
}


// ============================================
// 3. DICTIONARY<TKey, TValue>
// ============================================

Dictionary<string, int> employeeScores = new Dictionary<string, int>();

employeeScores["Hari"] = 90;
employeeScores["Ravi"] = 85;
employeeScores["John"] = 95;

Console.WriteLine();
Console.WriteLine("DICTIONARY<TKey, TValue>");
Console.WriteLine("------------------------");

Console.WriteLine($"Hari's score: {employeeScores["Hari"]}");
Console.WriteLine($"Ravi's score: {employeeScores["Ravi"]}");

foreach (var employee in employeeScores)
{
    Console.WriteLine($"{employee.Key} -> {employee.Value}");
}


// ============================================
// 4. HASHSET<T>
// ============================================

HashSet<string> departments = new HashSet<string>();

departments.Add("Engineering");
departments.Add("HR");
departments.Add("Finance");
departments.Add("Engineering");

Console.WriteLine();
Console.WriteLine("HASHSET<T>");
Console.WriteLine("----------");

Console.WriteLine($"Number of unique departments: {departments.Count}");

foreach (string department in departments)
{
    Console.WriteLine(department);
}

Console.WriteLine();
Console.WriteLine(
    $"Engineering exists: {departments.Contains("Engineering")}"
);

Console.WriteLine(
    $"Sales exists: {departments.Contains("Sales")}"
);


// ============================================
// 5. WORD FREQUENCY COUNTER
// ============================================

Console.WriteLine();
Console.WriteLine("WORD FREQUENCY COUNTER");
Console.WriteLine("----------------------");

string paragraph =
    "dotnet is powerful dotnet is fast dotnet is cross platform " +
    "dotnet is powerful and dotnet is fast";


// Convert the paragraph into individual words.

string[] wordsArray = paragraph
    .ToLower()
    .Split(
        ' ',
        StringSplitOptions.RemoveEmptyEntries
    );


// Store the words in a List<T>.

List<string> words = new List<string>(wordsArray);

Console.WriteLine();
Console.WriteLine($"Total words: {words.Count}");


// Create a HashSet to identify unique words.

HashSet<string> uniqueWords = new HashSet<string>(words);

Console.WriteLine($"Unique words: {uniqueWords.Count}");


// Create a Dictionary to store:
// word -> number of occurrences

Dictionary<string, int> wordFrequency =
    new Dictionary<string, int>();

foreach (string word in words)
{
    if (wordFrequency.ContainsKey(word))
    {
        wordFrequency[word]++;
    }
    else
    {
        wordFrequency[word] = 1;
    }
}


// Sort the dictionary by frequency in descending order.

var sortedWords = wordFrequency
    .OrderByDescending(item => item.Value)
    .ThenBy(item => item.Key);


Console.WriteLine();
Console.WriteLine("WORD FREQUENCY");
Console.WriteLine("--------------");

foreach (var item in sortedWords)
{
    Console.WriteLine($"{item.Key,-12} : {item.Value}");
}


// ============================================
// 6. COLLECTION SUMMARY
// ============================================

Console.WriteLine();
Console.WriteLine("======================================");
Console.WriteLine("       COLLECTION SUMMARY");
Console.WriteLine("======================================");

Console.WriteLine($"Array elements       : {scores.Length}");
Console.WriteLine($"List elements        : {scoresList.Count}");
Console.WriteLine($"Dictionary entries   : {employeeScores.Count}");
Console.WriteLine($"Unique departments   : {departments.Count}");
Console.WriteLine($"Total words          : {words.Count}");
Console.WriteLine($"Unique words         : {uniqueWords.Count}");

Console.WriteLine();
Console.WriteLine("Task 1.4 completed.");
