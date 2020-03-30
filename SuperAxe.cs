namespace WeaponShopV20
{
    public class SuperAxe : Axe
    {
         public const int InitialSuperAxeMinDamage = 100;
        public const int InitialSuperAxeMaxDamage = 100;

        #region Constructor
        public SuperAxe(string description) : base(description)
        {
            base.MinDamage = InitialSuperAxeMinDamage;
            base.MaxDamage = InitialSuperAxeMaxDamage;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Returns the damage dealt by the Axe. Also lowers the
        /// minimum and maximum damage dealt by three points.
        /// </summary>
        public override int DealDamage()
        {
            int damage = base.DealDamage();

            MinDamage = MinDamage < 3 ? 0 : MinDamage + 2;
            MaxDamage = MaxDamage < 3 ? 0 : MaxDamage + 2;

            return damage;
        }

        /// <summary>
        /// Resets the minimum and maximum damage dealt by 
        /// the Axe to its original values.
        /// </summary>
        public override void Sharpen()
        {
            MinDamage = InitialSuperAxeMinDamage;
            MaxDamage = InitialSuperAxeMaxDamage;
        } 
        #endregion
    }
}