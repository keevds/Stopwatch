static void Menu(){
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    Console.WriteLine(data);
}
``
// static void Start(int time){
//     int currenTime = 0;

//     while(currenTime != 20){
//         Console.Clear();
//         currenTime++;
//         Console.WriteLine(currenTime);
//         Thread.Sleep(1000);
//     }
//     Console.Clear();
//     Console.WriteLine("Stopwatch finalizado");
//     Thread.Sleep(2500);
    

// }

// Start(20);
Menu();