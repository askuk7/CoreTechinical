public sealed class Singleton
{
    private static readonly Lazy<Singleton> instance = new(() => new Singleton());
    
    private Singleton() { }

    public static Singleton Instance => instance.Value;
}
