namespace WeaponShopV20
{
    public class Sword : Weapon
    {
        public const int InitialSwordMinDamage = 30;
        public const int InitialSwordMaxDamage = 60;

        #region Constructor
        public Sword(string description) : base(description, InitialSwordMinDamage, InitialSwordMaxDamage)
        {
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the damage dealt by the Sword. Also lowers the
        /// minimum and maximum damage dealt by three points.
        /// </summary>
        public override int DealDamage()
        {
            int damage = base.DealDamage();

            MinDamage = MinDamage < 3 ? 0 : MinDamage - 4;
            MaxDamage = MaxDamage < 3 ? 0 : MaxDamage - 4;

            return damage;
        }

        /// <summary>
        /// Resets the minimum and maximum damage dealt by 
        /// the Sword to its original values.
        /// </summary>
        public void Sharpen()
        {
            MinDamage = InitialSwordMinDamage;
            MaxDamage = InitialSwordMaxDamage;
        } 
        #endregion
    }
}