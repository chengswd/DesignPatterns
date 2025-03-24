namespace DesignPatterns.Factory;

public class PearFactory: IFactory
{
    public Fruit CreateFruit()
    {
        return new Pear();
    }
}