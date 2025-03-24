namespace DesignPatterns.Singleton;

public class JuiceExtractor
{
    private int _power;
    private int _time;

    private JuiceExtractor(int power, int time)
    {
        _power = power;
        _time = time;
    }
    private static JuiceExtractor _instance;
    public static JuiceExtractor Shared { get; } = _instance ??= new JuiceExtractor(100,2);
}