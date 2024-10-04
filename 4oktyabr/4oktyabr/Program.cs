#region tapsiriq1
int[] ededler = { 1, 2, 3, 8, 5, 6, 7 };
Console.WriteLine(ededler.Max());
#endregion


#region tapsiriq1
int[] nums = { 101, 45, 28, 65, 800 };
int max = nums[0];

for (int i = 1; i < nums.Length; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}

Console.WriteLine(max);
#endregion


#region tapsiriq2
int[] nums = { 1, 0, 3, 4, 5, 10 };
int sum = 0;
for (int i = 0; i < nums.Length; i++)
{
    sum += nums[i];

}
Console.WriteLine(sum);
#endregion

#region tapsiriq3
string[] array = { "ev", "ish", "nurana" };

for (int i = 0; i < array.Length; i++)
{

    if (array[i].Length >= 4)
    {
        Console.WriteLine(array[i]);
    }

}
#endregion








