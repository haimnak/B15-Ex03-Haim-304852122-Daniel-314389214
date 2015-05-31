namespace Ex03.GarageLogic
{
    public enum eColor
    {
        Green,
        Black,
        White,
        Red
    }

    public enum eNumOfDoors
    {
        Two,
        Three,
        Four,
        Five
    }

    public abstract class Car : Vehicle
    {
        /*
         * Constructs a vehicle
         */
        protected Car(eNumOfDoors i_NumOfDoors, eColor i_Color)
        {
            NumOfDoors = i_NumOfDoors;
            Color = i_Color;
        }

        public eNumOfDoors NumOfDoors { get; private set; }

        public eColor Color { get; private set; }
    }
}
