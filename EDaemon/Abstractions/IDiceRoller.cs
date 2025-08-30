namespace EDaemon.Abstractions
{
    public interface IDiceRoller
    {
        RollResult D3(int quantity = 1, int modifier = 0);
        RollResult D6(int quantity = 1, int modifier = 0);
        RollResult D10(int quantity = 1, int modifier = 0);
        RollResult D100(int quantity = 1, int modifier = 0);
    }
}
