

static string ReverseStr(string str)
{
    string result = string.Empty;
    for (var i = str.Length - 1; i >= 0; i--)
    {
        result += str[i];
    }

    return result;

}

Console.WriteLine(ReverseStr("Semed"));