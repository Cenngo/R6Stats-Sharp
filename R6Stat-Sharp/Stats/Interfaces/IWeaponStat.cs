namespace R6Stat_Sharp.Stats
{
    public interface IWeaponStat
    {
        string Category { get; }
        int Kills { get; }
        int Deaths { get; }
        double KD { get; }
        int HeadShots { get; }
        double HSPercentage { get; }
        int TimesChosen { get; }
        int BulletsFired { get; }
        int BulletsHit { get; }
    }
}
