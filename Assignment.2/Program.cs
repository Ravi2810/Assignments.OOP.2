using System;
using System.Collections.Generic;


namespace Assignment2
{
	class Program
	{
		public static void Main(string[] args)
		{
			ParticleMovement particleMover = new ParticleMovement(GetMovementRange());
			while (true)
			{
				Console.Write("0 for base movement only\n1 if a magnetic field is present\n" +
							  "2 if a gravitational field is present\n3 for both fields\n");
				char key = Console.ReadKey().KeyChar;

				if (key != '0' && key != '1' && key != '2' && key != '3') return;

				particleMover.MagneticField = (key == '1' || key == '3') ? 1.75M : 1M;
				particleMover.GravitationalField = (key == '2' || key == '3') ? 2 : 0;

				Console.WriteLine($"\nParticle with a movement range of {particleMover.MovementRange} units" +
								  $" moved a total distance of {particleMover.DistanceMoved} units.\n");
			}
		}

		public static int GetMovementRange()
		{
			Random random = new Random(1);
			return random.Next(1, 7) + random.Next(1, 7) + random.Next(1, 7);
		}

	}

	public class ParticleMovement
	{
		private int movementRange;
		/// <summary>
		/// MovementRange getter setter
		/// </summary>
		public int MovementRange
		{
			get
			{
				return movementRange;
			}

			set
			{
				movementRange = value;
				CalculateDistance();
			}
		}

		private int gravitationalField;
		/// <summary>
		/// GravitationalField getter setter
		/// </summary>
		public int GravitationalField
		{
			get
			{
				return gravitationalField;
			}
			set
			{
				gravitationalField = value;
				CalculateDistance();
			}
		}

		private decimal magneticField;
		/// <summary>
		/// MagneticField getter setter
		/// </summary>
		public decimal MagneticField
		{
			get
			{
				return magneticField;
			}
			set
			{
				magneticField = value;
				CalculateDistance();
			}
		}

		public int Distance { get; private set; }

		public ParticleMovement(int movementRange)
		{
			MovementRange = movementRange;
			CalculateDistance();
		}

		public const int BASE_MOVEMENT = 3;
		public int DistanceMoved;

		public void CalculateDistance()
		{
			DistanceMoved = (int)(MovementRange * (MagneticField)) + BASE_MOVEMENT + GravitationalField;
		}
	}
}
