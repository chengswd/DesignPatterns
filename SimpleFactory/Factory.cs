namespace DesignPatterns.SimpleFactory;

public class Factory
{
    public static Apple CreateApple()
    {
        return new Apple();
    }

    public static Pear CreatePear()
    {
        return new Pear();
    }
}