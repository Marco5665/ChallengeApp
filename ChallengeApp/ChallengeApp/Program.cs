// Wyniki dla liczby: 8322
// 0 => 0
// 1 => 0
// 2 => 2
// 3 => 1
// 4 => 0
// 5 => 0
// 6 => 0
// 7 => 0
// 8 => 1
// 9 => 0


int number = 8322; 
string numberAsString = number.ToString();
char[] letters = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 2;
int counter3 = 1;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 1;
int counter9 = 0;

foreach (char letter in letters)
{
    if (number == '0')
    { 
        counter0++; 
    }
    else if (number == '1')
    { 
        counter1++; 
    }
    else if (number == '2')
    { 
        counter2++; 
    }
    else if (number == '3') 
    { 
        counter3++;
    }
    else if (number == '4') 
    { 
        counter4++;
    }
    else if (number == '5') 
    { 
        counter5++;
    }
    else if (number == '6') 
    { 
        counter6++;
    }
    else if (number == '7') 
    { 
        counter7++;
    }
    else if (number == '8') 
    { 
        counter8++;
    }
    else if (number == '9') 
    { 
        counter9++; 
    }
}
Console.WriteLine("ilość poszczególnych cyfr w podanej liczbie");
Console.WriteLine("0=>" + counter0);
Console.WriteLine("1=>" + counter1);
Console.WriteLine("2=>" + counter2);
Console.WriteLine("3=>" + counter3);
Console.WriteLine("4=>" + counter4);
Console.WriteLine("5=>" + counter5);
Console.WriteLine("6=>" + counter6);
Console.WriteLine("7=>" + counter7);
Console.WriteLine("8=>" + counter8);
Console.WriteLine("9=>" + counter9);
