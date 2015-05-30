namespace Diplom
{
    internal static class DBHelper
    {
        public static Context Context
        {
            get { return context ?? (context = new Context()); }
        }

   private static Context context;




    }
}
