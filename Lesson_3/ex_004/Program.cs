// На столе лежат n монеток. Некоторые из них лежат вверх решкой,
// а некоторые – гербом. Определите минимальное число монеток, которые нужно перевернуть,
// чтобы все монетки были повернуты вверх одной и той же стороной.
// 1-Решка
// 0-Орел
Console.Clear();
int n = new Random().Next(1, 10);
string coins = "";
for (int i = 1; i <= n; i++) {
    coins = coins + new Random().Next(0, 2);
}
Console.WriteLine(coins);
int coins0 = 0;
int coins1 = 0;
for (int i = 0; i < coins.Length; i++) {        
    if (coins[i] == '0') {        
        coins0++;
    }
    else {
        coins1++;
    }
}
if (coins0 > coins1) {
    Console.WriteLine($"Минимальное число монеток, которые нужно перевернуть: {coins1}.");
} else {
    Console.WriteLine($"Минимальное число монеток, которые нужно перевернуть: {coins0}.");
}
