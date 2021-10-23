using System;

using A3.Eggs;

namespace A3.Birds
{
	abstract class Bird
	{
		public static Random Rand = new Random(1);
		public abstract Egg[] LayEggs(int numEggs);

        protected Egg GetEgg(double minSize, double maxSize, double brokenChance, Egg.Colors color)
        {
            var range = maxSize - minSize;
            var size = Math.Round(minSize + range * Rand.NextDouble(), 1);
            if (Rand.NextDouble() <= brokenChance)
                return new BrokenEgg(size, color);
            return new Egg(size, color);
        }

    }

    class Chicken : Bird
    {
        public override Egg[] LayEggs(int numEggs)
        {
            var eggs = new Egg[numEggs];
            for (var i = 0; i < numEggs; i++)
                eggs[i] = GetEgg(2, 4, .25, Egg.Colors.brown);
            return eggs;
        }
    }

    class Ostrich : Bird
    {
        public override Egg[] LayEggs(int numEggs)
        {
            var eggs = new Egg[numEggs];
            for (var i = 0; i < numEggs; i++)
                eggs[i] = GetEgg(10, 15, .45, Egg.Colors.speckled);
            return eggs;
        }
    }
}
