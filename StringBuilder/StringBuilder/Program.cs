using System;

class Program
{
    static void Main()
    {
        // 1. Menfi ededleri musbete cevir
        int[] nums = { -5, 3, -2, 7 };
        nums = PositiveIntoNegative(nums);
        Console.WriteLine("Menfiden musbete: " + string.Join(", ", nums));

        // 3. Tekrarlanan characterleri sil
        Console.WriteLine("Tekrarsiz: " + RemoveDuplicates("salam"));

        // 4. Sozleri ayirmaq
        string[] sozler = BreakWords("Salam necesen Arzu");
        Console.WriteLine("Sozler: " + string.Join(" | ", sozler));

        // 5. Ilk 4 herfi qaytar
        Console.WriteLine("Ilk 4 herf: " + İlkDordHerf("Programlashdirma"));

        // 6. Email domain al
        Console.WriteLine("Domain: " + GetDomain("test@code.edu.az"));

        // 7. Yalniz herf olub olmadigini yoxla
        Console.WriteLine("Yalniz herf? 'Salam': " + YalnizHerfdir("Salam")); // true
        Console.WriteLine("Yalniz herf? 'Salam123': " + YalnizHerfdir("Salam123")); // false

        // 8. Metni formatla
        Console.WriteLine("Formatli: " + DuzeltMetni("saLAm nEceSen"));

        // 9. Fullname'den sadece adlari al
        string[] adSoyad = { "Arzu Farajova", "Ali Veliyev", "Nigar Memmedli" };
        string[] adlar = GetNames(adSoyad);
        Console.WriteLine("Adlar: " + string.Join(", ", adlar));
    }
    //1
    static int[] PositiveIntoNegative(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
                arr[i] = -arr[i];
        }
        return arr;
    }
    //3
    static string RemoveDuplicates(string input)
    {
        string result = "";
        foreach (char c in input)
        {
            if (!result.Contains(c))
                result += c;
        }
        return result;
    }
    //4
    static string[] BreakWords(string cumle)
    {
        return cumle.Split(' ');
    }
    //5
    static string İlkDordHerf(string metn)
    {
        return metn.Length >= 4 ? metn.Substring(0, 4) : metn;
    }
    //6
    static string GetDomain(string email)
    {
        int index = email.IndexOf('@');
        return index != -1 ? email.Substring(index + 1) : "";
    }
    //7
    static bool YalnizHerfdir(string metn)
    {
        foreach (char c in metn)
        {
            if (!char.IsLetter(c))
                return false;
        }
        return true;
    }
    //8
    static string DuzeltMetni(string metn)
    {
        metn = metn.ToLower();
        return char.ToUpper(metn[0]) + metn.Substring(1);
    }
    //9
    static string[] GetNames(string[] fullnames)
    {
        string[] names = new string[fullnames.Length];
        for (int i = 0; i < fullnames.Length; i++)
        {
            names[i] = fullnames[i].Split(' ')[0];
        }
        return names;
    }
}