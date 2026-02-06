public class Fraction
{
    private int _top;
    private int _bot;



    public Fraction()
    {
        _top = 1;
        _bot = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _top = 1;
    }

    public Fraction(int top, int bot)
    {
        _top = top;
        SetBot(bot);
    }

    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBot()
    {
        return _bot;
    }

    public void SetBot(int bot)
    {
        if (bot != 0){
            _bot = bot;
        }
        else
        {
            _bot = 1;
        }
    }

    // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

    public string GetFractionString()
    {
        return ($"{_top}/{_bot}");
    }

    public double GetDecimalValue()
    {
        return (double)_top/(double)_bot;
        
    }
}