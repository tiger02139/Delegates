namespace Delegates
{
    public class Planet//<T> where T : new()
    {
        public T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        //public string ReturnTypeName()
        //{
        //    return typeof(T).ToString();
        //}
    }
}
