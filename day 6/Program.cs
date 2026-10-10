// int a =Convert.ToInt32(Console.ReadLine());
// int b =Convert.ToInt32(Console.ReadLine());
// int c =Convert.ToInt32(Console.ReadLine());
// int FindMin(int a, int b, int c)
// {
//     int min=int.MaxValue;
//     int max=int.MinValue;
//     if(a<min) min=a;
//     if(b<min) min=b;
//     if(c<min) min=c;

//     if(a>max) max=a;
//     if(b>max) max=b;
//     if(c>max) max=c;

//     if(a!=max && a!=min) return a;
//     if(b!=max && b!=min) return b;
//     if(c!=max && c!=min) return c;
// }
// int d=FindMin(a,b,c);
// Console.WriteLine(d);

// bool PosNeg(int a, int b)
// {
//     return a>0 && b>0 || a<0 && b<0;
// }

// int a =Convert.ToInt32(Console.ReadLine());
// int cnt=0;
// for (int i = 0; i < n; i++)
// {
//     cnt++;
// }
// for(int i=0; i<(cnt-1) /2 ; i++)
// {
//     a/=10;
// }
// Console.WriteLine(a%10);

// string a =Console.ReadLine();
// char[] chars =a.ToCharArray();
// Array.Reverse(chars);
// string rev=new string(chars);
// if(rev==a) Console.WriteLine("Yes");
// else Console.WriteLine("No");

// int Power(int a, int b)
// {
//     if(b==0) return 1;
//     return a*Power(a, b-1);
// }
// Console.WriteLine(Power(5,3));

// int Sum (int a)
// {
//     if(a<10) return a;
//     return a%10+Sum(a/10);
// }
// Console.WriteLine(Sum(9));

// string a =Console.ReadLine();
// char[] chars =a.ToCharArray();
// Array.Reverse(chars);
// string rev=new string(chars);
// Console.WriteLine(rev);


// int  Fibonaci(int a)
// {
//   if (a <= 1) return 0; 
//     if (a == 2) return 1;
//     return Fibonaci(a - 1) + Fibonaci(a - 2);
// }
// int a =Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= a; i++)
// {
//     Console.Write(Fibonaci(i)+" ");
// }


// //Home task
// int a=Convert.ToInt32(Console.ReadLine());
// int cnt=0;
// int odd=0;
// int even=0;
// int zero=0;
// int sum=0;
// int Number(int a)
// {
//     if(a<=0) return 0;
//      sum+=a%10;
//     if(a%10%2==0)
//     {
//         cnt++;
//         even++;
//     }
//     else
//     {
//         cnt++;
//         odd++;
//     }
//     if (a % 10 == 0)
//     {
//         cnt++;
//         zero++;
//     }
//     return Number(a/10);

// }
// Console.WriteLine(Number(a));
// Console.WriteLine("Raqam: "+cnt);
// Console.WriteLine("Toq: "+odd);
// Console.WriteLine("Juft: "+even);
// Console.WriteLine("Zero: "+zero);
// Console.WriteLine("Sum of digits: "+sum);



// int a =Convert.ToInt32(Console.ReadLine());
// char CheckGrade(int a)
// {
//     if(a>=90 && a<=100) return 'A';
//     if(a>=80 && a<=89) return 'B';
//     if(a>=70 && a<=79) return 'C';
//     if(a>=60 && a<=69) return 'D';
//     if( a<=59) return 'F';
//     else return '!';
// }
// Console.WriteLine("Grade: "+CheckGrade(a));

// int a =Convert.ToInt32(Console.ReadLine());
// int[] ints =new int[a];
// int even=0;
// int odd=0;
// int max=int.MinValue;
// int min=int.MaxValue;
// int zero=0;
// int sum=0;
// int neg=0;
// int pos=0;
// for(int i=0; i<=a-1; i++)
// {
//     ints[i]=Convert.ToInt32(Console.ReadLine());
//     if(ints[i]%2==0) even++;
//     else odd++;
//     if(ints[i]>0) pos++;
//     else neg++;
//     if(ints[i]==0) zero++;
//     if(ints[i]>max) max=ints[i];
//     if(ints[i]<min) min=ints[i];
// }
// Console.WriteLine("Negative: "+neg);
// Console.WriteLine("Positive: "+pos);
// Console.WriteLine("Zero: "+zero);
// Console.WriteLine("Even: "+even);
// Console.WriteLine("Odd: "+odd);
// Console.WriteLine("Max: "+max);
// Console.WriteLine("Min: "+min);
// Console.WriteLine("Sum of digits: "+sum);


// int a  = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[a];
// for(int i=0; i<=a-1; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
// }
// for(int i=0; i<=a-1; i++)
// {
//     if(i%2==0 || i==0) Console.Write(arr[i]+" ");
// }


// int a =Convert.ToInt32(Console.ReadLine());
// int[] arr =new int[a];
// int max=int.MinValue;
// for(int i=0; i<a; i++)
// {
//     arr[i]=Convert.ToInt32(Console.ReadLine());
//     if(arr[i]>max) max=arr[i];
// }
// int max1=int.MinValue;
// for(int i=0; i<a; i++)
// {
//    if(arr[i]==max) arr[i]=0;
//    if(arr[i]>max1) max1=arr[i];
// }
// System.Console.WriteLine("Second max number: "+max1);


// Console.Write("From = ");
//         int a = int.Parse(Console.ReadLine());
        
//         Console.Write("To = ");
//         int b = int.Parse(Console.ReadLine());

//         for (int i = a; i <= b; i++)
//         {
            
//             for (int j = 1; j <= b; j++)
//             {
//                 Console.WriteLine($"{i}x{j}= {i * j}");
//             }
//         }
// System.Console.Write("First number: ");
// int a=Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Operation: ");
// char op=Convert.ToChar(Console.ReadLine());
// System.Console.Write("Second number: ");
// int b=Convert.ToInt32(Console.ReadLine());

// int Sum(int a, int b)
// {
//     return a+b;
// }
// int Sub(int a, int b)
// {
//     return a-b;
// }
// int Mul(int a, int b)
// {
//     return a*b;
// }

// int Dev(int a, int b)
// {
//     return a/b;
// }
// if (op == '+')
// {
//   System.Console.WriteLine( $"{a} + {b} = "+ Sum(a,b));
// }
// else if (op == '-')
// {
//     System.Console.WriteLine($"{a} - {b} = "+Sub(a,b));
// }
// else if (op == '*')
// {
//    System.Console.WriteLine($"{a} * {b} = "+ Mul(a,b));
// }
// else if (op == '/')
// {
//    System.Console.WriteLine($"{a} / {b} = "+ Dev(a,b));
// }
// else System.Console.WriteLine("!!!!!!!!!!!  None operation found  !!!!!!!!!!!");



// int  Fibonaci(int a)
// {
//   if (a <= 1) return 0; 
//     if (a == 2) return 1;
//     return Fibonaci(a - 1) + Fibonaci(a - 2);
// }
// int a =Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i <= a; i++)
// {
//     Console.Write(Fibonaci(i)+" ");
// }




// int Power(int a, int b)
// {
//     if(b==0) return 1;
//     return a*Power(a, b-1);
// }
// Console.WriteLine(Power(5,3));
