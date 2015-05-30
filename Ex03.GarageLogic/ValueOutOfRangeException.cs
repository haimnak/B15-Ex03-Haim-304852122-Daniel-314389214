// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValueOutOfRangeException.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex03.GarageLogic
{
    using System;

    public class ValueOutOfRangeException : Exception
    {
        private float MaxValue;

        private float MinValue;
    }
}
