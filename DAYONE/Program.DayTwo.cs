namespace DayOne;

public partial class Program
{
    public static string IntegerBreak(int n)
    {
        IList<int> ?valuesLess = new List<int>();
        IList<int>? multipleList = new List<int>();
        for(int i =1; i<n; i++) 
            valuesLess.Add(i);
        
        int currentIndexValue = 0;
        
        for (int i = 0; i < valuesLess.Count; i++)
        {
            
        }

        
        return String.Join(',',valuesLess);
    }
}