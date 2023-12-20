using Nsu.ColiseumProblem.Contracts;
using Nsu.ColiseumProblem.Contracts.Cards;

namespace ColiseumStrategy;

public class PickFirstRedCardStrategy : ICardPickStrategy
{
    public int Pick(Card[] cards)
    {
        for (var i = 0; i < cards.Length; i++)
        {
            if (cards[i].Color == CardColor.Red)
            {
                return i;
            }
        }

        return 0;
    }
}
