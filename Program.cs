using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        //  Bài 1.1 
        Console.WriteLine("    ++++++               ++++     ++++ ");
        Console.WriteLine(" +++++++++++        +++++++++++++++++ ");
        Console.WriteLine(" ++++     ++++    +++++++++++++++++++ ");
        Console.WriteLine(" ++++                ++++     ++++ ");
        Console.WriteLine(" ++++               ++++    ++++ ");
        Console.WriteLine(" ++++     ++++    ++++++++++++++++ ");
        Console.WriteLine("  ++++++++++++   +++++++++++++++++ ");
        Console.WriteLine("   +++++++++    ++++    ++++");


        // Bài 1.2
        Console.Write("Nhap ma nhan vien: ");
        int codeNV = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap ten nhan vien: ");
        String name = Console.ReadLine();
        Console.Write("Nhap ngay sinh cua nhan vien: ");
        String date = Console.ReadLine();
        Console.Write("Nhap dai chi cua nhan vien: ");
        String address = Console.ReadLine();
        Console.Write("Nhap sdt cua nhan vien: ");
        int phone = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap email cua nhan vien: ");
        String email = Console.ReadLine();
        Console.WriteLine("Thong tin cua nhan vien: ma-{0}, name-{1}, date-{2}, address-{3}, phone-{4}, email-{5}", codeNV, name, date, address, phone, email);

    }
}