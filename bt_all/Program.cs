//b1: Tổng các số thỏa đièu kiện
Console.Write(@$"Chọn bài tập: ");
int choice = Convert.ToInt16(Console.ReadLine());
int[] nums, numA, numB;
double[] numsDouble;

switch (choice)
{
  case 1:
    long total = Method.TongLonHon([20, 81, 97, 63, 72, 11], 50);
    Console.WriteLine(@$"Kết quả: {total}");
    break;

  case 2:
    nums = [3, 1, 4, 1, 5];
    (int[] tang, int[] giam) = Method.SapXepHaiChieu(nums);
    Console.WriteLine("Kết quả: {" + @$"[{string.Join(", ", tang)}], [{string.Join(", ", giam)}]" + "}");
    break;

  case 3:
    nums = [1, 2, 2, 3, 3, 3, 1];
    Console.WriteLine(@$"Kết quả: [{string.Join(", ", Method.LoaiTrung(nums))}]");
    break;

  case 4:
    nums = [20, 15, 20, 33, 15, 20];
    Dictionary<int, int> list = Method.DemTanXuat(nums);
    Console.WriteLine("Kết quả: {" + @$"{string.Join(", ", list.Select(kvp => $"{kvp.Key}:{kvp.Value}"))}" + "}");
    break;
  case 5:
    numA = [1, 2, 3];
    numB = [3, 4, 5];
    Console.WriteLine(@$"Kết quả: [{string.Join(", ", Method.Hop(numA, numB))}]");
    break;
  case 6:
    numA = [1, 2, 3, 4];
    numB = [3, 4, 5];
    Console.WriteLine(@$"Kết quả: [{string.Join(", ", Method.Giao(numA, numB))}] ");
    break;
  case 7:
    nums = [20, 97, 81, 97, 63];
    Console.WriteLine(@$"Kết quả: {Method.LonThuHai(nums)}");
    break;
  case 8:
    numsDouble = [9, 7, 5, 4, 8.5, 6];
    Dictionary<string, int> list1 = Method.ThongKeXepLoai(numsDouble);
    Console.WriteLine("Kết quả: {" + @$"{string.Join(", ", list1.Select(kvp => $"{kvp.Key}:{kvp.Value}"))}" + "}");
    break;

  case 9:
    numA = [1, 2, 3, 1];
    numB = [1, 2, 3, 4];
    Console.WriteLine(Method.ContainsDuplicate(numA));
    Console.WriteLine(Method.ContainsDuplicate(numB));
    break;
}