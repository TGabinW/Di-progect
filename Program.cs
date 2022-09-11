Console.WriteLine("Введите первый цвет для смешивания");
string fc = Console.ReadLine();
Console.WriteLine("Введите второй цвет для смешивания");
string sc = Console.ReadLine();
string Red = "Красный";
string Blue = "Синий";
string Yello = "Желтый";
string Purpule = Red + Blue;
string Orange = Red + Yello;
string Green = Yello + Blue;
if (fc + sc == Purpule)
    Console.WriteLine("У вас получился фиолетовый");
else if (fc + sc == Orange)
    Console.WriteLine("У вас получился оранжевый");
else if (fc + sc == Green)
    Console.WriteLine("У вас получился зелёный");
else if (fc == sc)
    Console.WriteLine($"У вас получился {fc}");
else
    Console.WriteLine("Ошибка цвета");