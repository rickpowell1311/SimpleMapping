namespace SimpleMapping
{
    public interface IPopulatableFrom<T>
    {
        void Populate(T source);
    }
}
