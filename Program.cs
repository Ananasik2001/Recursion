// №1
// void Task1()
// {
//     Console.WriteLine("Введите значение M");
//     var M = Console.ReadLine();
//     var checkM = int.TryParse(M, out int resultM);
//     if(!checkM)
//     {
//         Console.WriteLine("Значение M не верно");
//         Task1();
//     }
//     bool checkN = false;
//     var resultN = CheckN(ref checkN, taskNumber: 1);
//     while(!checkN)
//     {
//         CheckN(ref checkN, taskNumber: 1);
//     }
//     WriteValue(resultM, resultN);
// }

// void WriteValue(int M, int N)
// {
//     if(M > N)
//     {
//         Console.Write(N + " ");
//         N++;
//         WriteValue(M, N);
//     }
//     else if(M < N)
//     {
//         Console.Write(M + " ");
//         M++;
//         WriteValue(M, N);
//     }
//     else
//     {
//         Console.WriteLine(M);
//         return;
//     }
// }

// int CheckN(ref bool checkN, int taskNumber)
// {
//     int resultN = 0;
//     Console.WriteLine("Введите значение N");
//     var N = Console.ReadLine();
//     checkN = int.TryParse(N, out resultN);
//     if (taskNumber == 1)
//     {
//         if (!checkN)
//         {
//             Console.WriteLine("Значение N не верно");
//         }
//     }
//     else if (taskNumber == 2)
//     {
//         if (!checkN && resultN < 0)
//         {
//             Console.WriteLine("Значение N не верно");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Значение N не верно");
//     }
//     return resultN;
// }

// №2 
// void Task2()
// {
//     Console.WriteLine("Введите значение M");
//     var M = Console.ReadLine();
//     var checkM = int.TryParse(M, out int resultM);
//     if (!checkM && resultM >= 0)
//     {
//         Console.WriteLine("Значение M не верно");
//         Task2();
//     }
//     bool checkN = false;
//     var resultN = CheckN(ref checkN, taskNumber: 2);
//     while (!checkN)
//     {
//         CheckN(ref checkN, taskNumber: 2);
//     }
//     var result = Ackerman(resultM, resultN);

//     Console.WriteLine("Функция Аккермана = " + result);
// }
// int Ackerman(int M, int N)
// {
//     if(M == 0)
//     {
//         return N + 1;
//     }
//     else if(N == 0)
//     {
//         return Ackerman(M - 1, 1);
//     }
//     else
//     {
//        return Ackerman(M-1, Ackerman(M, N - 1));
//     }
// }

// №3
// void Task3 ()
// {
//     Random rand = new Random();
//     int lenght = rand.Next(0, 10);
//     Console.WriteLine($"Длинна массива : {lenght}");
//     int[] mass = new int[lenght];    
//     for(int i = 0; i < lenght; i++)
//     {
//         mass[i] = rand.Next(0, 100);
//     }
//     TestWriteMass(mass);
//     Console.WriteLine();
//     WriteMass(mass, mass.Length - 1);

// }
// void TestWriteMass(int[]mass)
// {
//     Console.WriteLine();
//     for (int i = 0; i < mass.Length; i++)
//     {
//        Console.Write(mass[i] + " ");
//     }
// }
// void WriteMass(int[] mass, int index)
// {
//     if(index < 0)
//     {
//         return;
//     }
//     Console.Write(mass[index]);
//     Console.Write(" ");
//     index--;    
//     WriteMass(mass, index);
// }