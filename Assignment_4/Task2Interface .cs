using System;

// Make sure to uncomment the ToString methods when you are ready!

namespace A4.Task2Interface
{
	interface ICarryPassengers
	{
		public abstract string CarryPassengers();
	}
	class Ship
	{
		public double Displacement { get; }

		public Ship(double displacement)
		{
			Displacement = displacement;
		}

		public override string ToString() => $"A ship that displaces {Displacement} tons of water"; 
	}

	class CruiseShip : Ship, ICarryPassengers
	{
		private int numPassengers;

		public CruiseShip(double displacement, int numPassengers) : base(displacement)
		{
			this.numPassengers = numPassengers;
		}
		public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a Caribbean Cruise";
		}

		public override string ToString() => CarryPassengers();
	}

	class BigRig
	{
		public int NumTires;

		public BigRig(int numTires)
		{
			NumTires = numTires;
		}

		public override string ToString() => $"A vehicle with {NumTires} tires"; 
	}

	class TourBus : BigRig, ICarryPassengers
	{
		private int numPassengers;
		public TourBus(int numTires, int numPassengers) : base(numTires)
		{
			this.numPassengers = numPassengers;
		}
		public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a cross country tour.";
		}
		public override string ToString() => CarryPassengers();
	}
}
