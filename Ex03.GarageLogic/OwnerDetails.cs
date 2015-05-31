namespace Ex03.GarageLogic
{
    /*
    * Contains owner details and vehicle status
    */

    /// <summary>
    /// The owner details.
    /// </summary>
    public class OwnerDetails
    {

        public OwnerDetails(string i_Name, string i_Number)
        {
            this.Name = i_Name;
            this.Number = i_Number;
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets the number.
        /// </summary>
        public string Number { get; private set; }

        /// <summary>
        /// The to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override string ToString()
        {
            return string.Format("Owner Name: {0}, Number: {1}", this.Name, this.Number);
        }
    }
}