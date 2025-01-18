namespace PageCounterApp.Services
{
    public class PageCountIncrementImplement : PageCountInterface
    {
        static Dictionary<string, int> page = new Dictionary<string, int>();
        
        public int IncrementPageCount(string pageName)
        {
            // initalize the dictionary key with a default value of 1
            // if the key doesnt exsist, otherwise increase the count by 1
            if (!page.ContainsKey(pageName)) 
            {
                page[pageName] = 1;
            }
            else
            {
                page[pageName]++;
            }
            return page[pageName];
        }
    }
}
