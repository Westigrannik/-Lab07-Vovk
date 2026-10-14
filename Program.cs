// 1.1

// string[] days = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вc"};

// for (int i = days.Length-1; i >= 0; i--){
//     Console.WriteLine($"{i}: {days[i]}");
// }

// 1.2

// double[] days = {11, -1.2, -5, 42, -24, 1, 2};

// foreach (double i in days){
//     Console.Write($"{i} ");
// }

// 2

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int sum = 0;
// int count = 0;
// foreach (int i in prices){
//     sum+=i;
//     if (i > 100){
//         count++;
//     }
// }
// Console.WriteLine($"{sum}, {sum/prices.Length}, {count}");

// 3

// int[] prices = { 120, 45, 300, 80, 15, 210 };
// int min = prices[0];
// int max = prices[0];
// int high = 0;
// for (int i = 0; i < prices.Length; i++){
//     if (prices[i] < min){
//         min = prices[i];
//     }
//     if (prices[i] > max){
//         high = i;
//     }
//     }
// Console.WriteLine($"{min}, {high}");

// 4

// int[] balance = { 100, -50, 20, -5, 0, 75 };

// for (int i = 0; i < balance.Length; i++){
//     if (balance[i] < 0){
//         balance[i] = 0;
//     }
// }

// foreach (int i in balance){
//     Console.Write(i + " ");
// }

// 5

// int count = 0;
// int[] numbers = new int[5];
// for (int i = 0; i <= numbers.Length-1; i++){
//     Console.WriteLine("Напишите число");
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n%2==0) count++;
//     numbers[i] = n;
// }

// for (int i = numbers.Length-1; i >= 0; i--){
//     Console.Write($"{numbers[i]} ");
// }
// Console.WriteLine($"\n{count}");

// 6

// Console.WriteLine("Напишите имя");
// string[] names = {"jarona", "Игорь", "Мария", "Олег", "Ольга"}; // Программа не распознаёт русские символы
// int count = 0;
// string name = Console.ReadLine();
// foreach (string i in names){
//     if (i == name) {
//         break;
//         }
//     count++;

// }

// if (count <= 4) Console.WriteLine(count);
// else Console.WriteLine("Не найдено");

int[] grades = [2, 3, 4, 5, 4, 3, 2, 5];
double sum = 0;
int max = grades[0];
int min = grades[0];
int count2 = 0;
int count5 = 0;
foreach (int i in grades){
    sum+=i;
    if (i == 2) count2++;
    if (i == 5) count5++;
    if (max < i) max = i;
    if (min > i) min = i;

    Console.Write(i + " ");
}
double sr = sum/grades.Length;
Console.WriteLine($"Средняя: {sr}");
Console.WriteLine($"Макс: {max} Мин: {min}");
Console.WriteLine($"Двойки: {count2}, Пятёрки: {count5}");
if (sr >= 4.5) Console.WriteLine($"Отличник");
else if (sr >= 3.5) Console.WriteLine($"Хорошист");
else if (sr >= 2.5) Console.WriteLine($"Есть над чем поработать");
else Console.WriteLine($"Плохо");

// int[] arr = [ 1, 2, 3, 4, 5, 6 ];
// for (int i = 0; i<=arr.Length/2-1; i++){
//     int f = arr[i];
//     int l = arr[arr.Length-1-i];
//     arr[i] = l;
//     arr[arr.Length-1-i] = f;
// }
// foreach (int i in arr){
//     Console.Write(i + " ");
// }