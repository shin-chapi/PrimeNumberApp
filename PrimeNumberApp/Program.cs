// See https://aka.ms/new-console-template for more information
Console.WriteLine("数値を入力してください");
Console.WriteLine("数値分の素数を出力します");
int primeNumber = int.Parse(Console.ReadLine());

List<int> list = new List<int>();

int count = 0;
int num = 2;
int num2 = 2;

//素数を判定して素数の場合は抜ける

     while(primeNumber != count)
    {
        if (num == 2 || num == 3)
    {
        list.Add(num);
        num++;
        count++;
        continue;

    }

        if (num % num2 == 0)
        {
         if(num == num2)
        {
            count++;
            list.Add(num);

        }
            num++;
            num2 = 2;
            
            

        }
        else
        {
            num2++;
            
    }
        
    }

Console.WriteLine("素数は");
for (var i = 0; i < list.Count; i++)
{
    Console.WriteLine( list[i]);
}





