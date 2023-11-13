#nullable enable

namespace Library
{
    public class Singleton<T> where T : new()
    {
        private static T? instance;

        public static T Instance
        {
            get
            {
                instance ??= new T();
                return instance;
            }
        }
    }
}
