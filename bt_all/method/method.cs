public class Method
{
  public static long TongLonHon(int[] nums, int moc)
  {
    long total = 0;
    foreach (int number in nums)
    {
      total += number > moc ? number : 0;
    }
    return total;
  }

  public static (int[] tang, int[] giam) SapXepHaiChieu(int[] nums)
  {
    //tạo ra 1 vùng nhớ mới
    int[] numsTang = (int[])nums.Clone();

    Array.Sort(numsTang);

    //sort ngược lại
    int[] numsGiam = numsTang.Reverse().ToArray();

    return (numsTang, numsGiam);
  }

  public static int[] LoaiTrung(int[] nums)
  {
    HashSet<int> list = new HashSet<int>();
    List<int> result = new List<int>();

    foreach (int i in nums)
    {
      if (list.Add(i))
      {
        result.Add(i);
      }
    }

    return result.ToArray();
  }

  public static Dictionary<int, int> DemTanXuat(int[] nums)
  {
    Dictionary<int, int> list = new Dictionary<int, int>();

    foreach (int i in nums)
    {
      if (list.ContainsKey(i))
      {
        list[i]++;
      }
      else
      {
        list[i] = 1;
      }
    }
    return list;
  }

  public static int[] Hop(int[] a, int[] b)
  {
    int[] c = a.Concat(b).ToArray();
    c = LoaiTrung(c);
    return c;
  }

  public static int[] Giao(int[] a, int[] b)
  {
    HashSet<int> setB = b.ToHashSet();
    List<int> result = new List<int>();

    foreach (int x in a.Distinct())
    {
      if (setB.Contains(x))
      {
        result.Add(x);
      }
    }
    return result.ToArray();
  }

  public static int LonThuHai(int[] nums)
  {

    (int[] tang, int[] giam) = SapXepHaiChieu(LoaiTrung(nums));
    return giam[1];
  }

  public static Dictionary<string, int> ThongKeXepLoai(double[] nums)
  {
    Dictionary<string, int> list = new Dictionary<string, int>();
    list.Add("Giỏi", 0);
    list.Add("Khá", 0);
    list.Add("Trung Bình", 0);
    list.Add("Yếu", 0);
    foreach (double i in nums)
    {
      if (i >= 8)
      {
        list["Giỏi"]++;
      }
      else if (i >= 6.5)
      {
        list["Khá"]++;
      }
      else if (i >= 5)
      {
        list["Trung Bình"]++;
      }
      else
      {
        list["Yếu"]++;
      }
    }
    return list;
  }

  public static bool ContainsDuplicate(int[] nums)
  {
    bool flag = false;
    HashSet<int> list = new HashSet<int>();

    foreach (int number in nums)
    {
      if (!list.Add(number)) { flag = true; break; }
    }
    return flag;
  }

}