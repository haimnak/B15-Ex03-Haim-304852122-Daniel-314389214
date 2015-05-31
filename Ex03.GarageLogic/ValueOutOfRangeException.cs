namespace Ex03.GarageLogic
{
    using System;

    public class ValueOutOfRangeException : Exception
    {
        private readonly float m_MaxValue;

        private readonly float m_MinValue;

        public ValueOutOfRangeException(float i_MinValue, float i_MaxValue)
        {
            this.m_MaxValue = i_MaxValue;
            this.m_MinValue = i_MinValue;
        }

        public override string Message
        {
            get
            {
                return string.Format("Value is not in range of {0} and {1}", m_MinValue, m_MaxValue);
            }
        }
    }
}
