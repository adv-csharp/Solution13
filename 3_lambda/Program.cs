using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;



var arr = new int[] { 1, 2, 3, 4, 5 };
//arr.Select(x => x * 2);
//arr.Select(x => x * x);
//arr.Select(x => x + 10);

//var result = new List<int>();
//foreach (var a in arr)
//{
//    result.Add(a * 2);
//}

MySelect(arr);


List<int> MySelect(int[] arr)
{
    var result = new List<int>();
    foreach (var a in arr)
    {
        result.Add(a * 2);
    }
    return result;
}

MySelect2(arr, x => x * 2);



List<int> MySelect2(int[] arr,  Func<int, int> func)
{
    var result = new List<int>();
    foreach (var a in arr)
    {
        result.Add(func(a));
    }
    return result;
}
// Func -> Action




Console.WriteLine("Hello, World!");