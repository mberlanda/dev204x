using System;

namespace ModuleSixUbuntu {
    // Declaring an Interface
    public interface IBeverage
    {
        // Methods, properties, events, and indexers go here.
        // To define a method, you specify the name of the method, the return type, and any parameters:
        int GetServingTemperature(bool includesMilk);
        // To define a property, you specify the name of the property, the type of the property, and the property accessors:
        bool IsFairTrade { get; set; }
        // To define an event, you use the event keyword, followed by the event handler delegate, followed by the name of the event:
        // event EventHandler OnSoldOut;
        // To define an indexer, you specify the return type and the accessors:
        // string this[int index] { get; set; }
    }
    public interface ILoyaltyCardHolder
    {
        int TotalPoints { get; }
        int AddPoints(decimal transactionValue);
        void ResetPoints();
    }

    // Implementing an Interface
    public class Customer : ILoyaltyCardHolder
    {
        private int totalPoints;
        public int TotalPoints
        {
            get { return totalPoints; }
        }
        public int AddPoints(decimal transactionValue)
        {
            int points = Decimal.ToInt32(transactionValue);
            totalPoints += points;
            return totalPoints;
        }
        public void ResetPoints()
        {
            totalPoints = 0;
        }
    }

    // Implementing an Interface Explicitly
    public class Coffee : IBeverage
    {
        private int servingTempWithoutMilk { get; set; }
        private int servingTempWithMilk { get; set; }
        int IBeverage.GetServingTemperature(bool includesMilk)
        {
            if(includesMilk)
            {
                return servingTempWithMilk;
            }
            else
            {
                return servingTempWithoutMilk;
            }
        }
        bool IBeverage.IsFairTrade { get; set; }
        // Other non-interface members.
    }
}