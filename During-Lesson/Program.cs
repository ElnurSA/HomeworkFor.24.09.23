

//static string ReverseStr(string str)
//{
//    string result = string.Empty;
//    for (var i = str.Length - 1; i >= 0; i--)
//    {
//        result += str[i];
//    }

//    return result;

//}

//Console.WriteLine(ReverseStr("Semed"));

//static string UpperStringFirstChar(string str) => char.ToUpper(str[0]) + str.Substring(1);

//Console.WriteLine(UpperStringFirstChar("ali"));



//static string FirstElementToUpper(string str)
//{

//    char[] charArray = str.ToCharArray();

//    var firstChar = charArray[0].ToString().ToUpper();

//    charArray[0] = Convert.ToChar(firstChar);

//    string result = string.Empty;

//    foreach(char item in charArray)
//    {
//        result += item;
//    }

//    return result;

//}

//Console.WriteLine(FirstElementToUpper("semed"));


//using System.Text;

//StringBuilder stringBuilder = new StringBuilder("Azer");

//stringBuilder.Append("baycan");

//Console.WriteLine(stringBuilder);


//int[] ages = { 12, 13, 55 };

//int[] ages2 = new int[5];

//int[] ints = new int[5] { 1, 2, 3, 4, 5 };


//int[] nums = { 1, 2, 3, 4, 5, 6 };

//Console.WriteLine(nums.Length);

//foreach(var item in nums)
//{
//    Console.WriteLine(item);
//}


//var result = nums.Sum(x => x);

//Console.WriteLine(result);

//var result = nums.Rank;

//Array.Sort(nums);

//Array.Reverse(nums);

//var newArr = nums.Clone() as int[];

//int[] newArr = { 1, 2, 3 };

//var source = new[] { "Ally", "Bishop", "Billy" };
//var target = new string[4];

//source.CopyTo(target, 0);

//foreach(var item in target)
//{
//    Console.WriteLine(item);
//}

//int[] nums = { 10, 2, 3, 4, 5, 6, 10, 11, 12, 12 };

//int[] newArr = { 1, 2, 3, 7 };

//int count = newArr.Length;

//Array.Resize(ref newArr, nums.Length + newArr.Length);

//nums.CopyTo(newArr, count);

//foreach (var item in newArr)
//{
//    Console.WriteLine(item);
//}


//static int[] CopyToArray(int[] destination, int[] source)
//{
//    int destinationLength = destination.Length;
//    Array.Resize(ref destination, source.Length + destination.Length);
//    source.CopyTo(destination, destinationLength);
//    return destination;
//}


//int[] arr1 = { 2, 3, 4, 5 };

//int[] arr2 = { 100, 200, 300 };

//var result = CopyToArray(arr1, arr2);

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}


//int[] numbers = { 2, 3, 4, 5, 6, 1};


//var result = Array.Exists(numbers, x => x == 1);

//var result = Array.Find(numbers, x => x == 1);

//var result = Array.FindAll(numbers, x => x == 1);

//var result = Array.FindIndex(numbers, x => x == 1);

//int[] arr = new int[2];
//Array.Fill(arr, 2);

//foreach(int item in arr)
//{
//    Console.WriteLine(item);
//}



//using During_Lesson;

//int[] numbers = { 2, 3, 4, 5, 6, 1 };

//var result = numbers.OrderBy(m => m);
//var result = numbers.OrderByDescending(m => m);

//var result = numbers.FirstOrDefault(m => m == 3);

//var result = numbers.Contains(5);

//var result = numbers.Min();

//var result = numbers.Where(x => x % 2 == 0).Sum(m=>m);
//Console.WriteLine(result);

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}

//foreach(var item in result)
//{
//    Console.WriteLine(item);
//}


//var result = numbers.Where(x => x % 2 == 0).ToArray();


//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//string name1 = "Tunzale";
//string surname1 = "Memmedova";
//string email = "tunzale@gmail.com";

//string name2 = "Arzu";
//string surname2 = "Kerimova";
//string email2 = "arzu@gmail.com";

//string name3 = "Ilham";
//string surname3 = "Abasli";
//string email3 = "ilham@gmail.com";




//var stu1 = new
//{
//    name = "Tunzale",
//    surname = "Memmedova",
//    email = "tunzale@gmail.com"
//};

//var stu2 = new
//{
//    name = "Arzu",
//    surname = "Kerimova",
//    email2 = "arzu@gmail.com"
//};

//var stu3 = new
//{
//    name = "Ilham",
//    surname = "Abasli",
//    email = "ilham@gmail.com"
//};

//Console.WriteLine(stu3.name + " " + stu3.surname);



//Student stu1 = new Student();
//stu1.name = "Tofig";
//stu1.surname = "Nesibli";
//stu1.email = "tofig@gmail.com";
//stu1.age = 18;

//Student stu2 = new Student();

//stu2.name = "Omer";
//stu2.surname = "Elesgerli";
//stu2.email = "omer@gmail.com";
//stu2.age = 15;

//stu1.GetFullName();
//stu1.GetFullData()

//stu2.GetFullName();
//stu2.GetFullData();


//Calculate calculate = new();

//int sum = calculate.Sum(10, 15);

//Console.WriteLine(sum);