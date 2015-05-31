namespace Ex03.GarageLogic
{
    public enum eLicenseType
    {
        A = 1,
        A2 = 2,
        AB = 3,
        B1 = 4
    }

    public class Motorcycle : Vehicle
    {
        private readonly eLicenseType r_LicenseType;

        private readonly int r_HP;

        public Motorcycle(eLicenseType i_LicenseType, int i_HP)
        {
            this.r_LicenseType = i_LicenseType;
            this.r_HP = i_HP;
        }

        public eLicenseType LicenseType
        {
            get
            {
                return this.r_LicenseType;
            }
        }

        public int HP
        {
            get
            {
                return this.r_HP;
            }
        }
    }
}
