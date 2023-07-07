namespace OpenClosedPrinciple_After
{
    public interface ILevelUpBonusPolicy
    {
        bool AppliesTo(int level);
        int GetBonusHealth();
        int GetBonusMana();
    }

    public class _2_A_LevelTwoBonusPolicy : ILevelUpBonusPolicy
    {
        public bool AppliesTo(int level) => level == 2;
        public int GetBonusHealth() => 20;
        public int GetBonusMana() => 1;
    }

    public class _2_A_LevelThreeBonusPolicy : ILevelUpBonusPolicy
    {
        public bool AppliesTo(int level) => level == 3;

        public int GetBonusHealth() => 30;
        public int GetBonusMana() => 1;
    }
}