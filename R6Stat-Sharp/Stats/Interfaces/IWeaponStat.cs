namespace R6Stats.Stats.Interfaces
{
    /// <summary>
    /// Represent the use stats for a weapon
    /// </summary>
    public interface IWeaponStat
    {
        /// <summary>
        /// Category of the weapon
        /// </summary>
        string Category { get; }

        /// <summary>
        /// Number of kills the player got with this weapon
        /// </summary>
        int Kills { get; }

        /// <summary>
        /// Number of times the player died while using this weapon
        /// </summary>
        int Deaths { get; }

        /// <summary>
        /// Kill/Death ratio achieved while using this weapon
        /// </summary>
        double KD { get; }

        /// <summary>
        /// Headshots scored with this weapon
        /// </summary>
        int HeadShots { get; }

        /// <summary>
        /// Ratio of Headshots to the total number of kills
        /// </summary>
        double HSPercentage { get; }

        /// <summary>
        /// Number of times the player equiped this weapon
        /// </summary>
        int TimesChosen { get; }

        /// <summary>
        /// Number of bullets fired from this weapon
        /// </summary>
        int BulletsFired { get; }

        /// <summary>
        /// Number of bullets which hit an opponent that is fired from this gun.
        /// </summary>
        int BulletsHit { get; }
    }
}
