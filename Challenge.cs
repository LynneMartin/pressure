namespace pressure.Models
{
  class challenges
  {
    //SECTION num will be an integer. Double it and return it. (ex 12 => 24)
    public int doubleInteger(int num)
    {
      return num * 2;
    }
    //SECTION num will be an integer. Return true if it’s even, and false if it isn’t.
    public bool isNumberEven(int num)
    {
      return num % 2 == 0;
    }
    //SECTION str will be a string, but it may not have a file extension.
    // return the file extension (with no period) if it has one, otherwise null
    public string getFileExtension(string str)
    {
      if (string.contains('.')) return null
    }
    //  or string[] strArr = str.Split('.');
    //     if(strArr.Length < 1) return null;
    //     return strArr[strArr.Length - 1];

    //SECTION arr will be an array. Return the longest string in the array
    public string longestString(string arr)
    {
      string longest = arr[0]; //0 grabs the first index
      for (int i = 0; i < arr.Length; i++)
      {
        string word = arr[i];
        if (word.Length > longest.Length)
        {
          longest = word;
        }
      }
      return longest;
    }
    //SECTION given an array return the sum of all its values
    public int arraySum(int[] arr)
    {
      int sum = 0;
      for (int i = 0; i < arr.Length; i++)
      {
        sum += arr[i];
      }
    }
  }
}