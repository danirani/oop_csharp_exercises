using System;

namespace TechReturners.Exercises
{

    public interface ICat
    {
        bool IsAsleep { get; }
        string Setting { get; }
        int AverageHeight { get; }
        string Eat { get; }
        void GoToSleep();
        void WakeUp();
        string AfterEat();
    }

    public abstract class Cat : ICat
    {
        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public int AverageHeight { get; set; }
        public string Eat { get; set; } // cat's reaction after eating

        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }

        public abstract string AfterEat();
    }

    public class DomesticCat : Cat
    {
        Random random;
        
        public DomesticCat()
        {
            IsAsleep = false;
            Setting = "domestic";
            AverageHeight = 23;
            Eat = "Purrrrrrr";

            random = new Random();
        }

        public override string AfterEat()
        {
            // generate random number between 0 and 3
            // return a smart reply one in 4 times on average.
            
            return random.Next(0, 4) == 3 ? "It will do I suppose" : Eat;
        }
    }


    public class LionCat : Cat
    {
        public LionCat()
        {
            IsAsleep = false;
            Setting = "wild";
            AverageHeight = 1100;
            Eat = "Roar!!!!";
        }
        
        public override string AfterEat()
        {
            return Eat;
        }
    }

    public class CheetahCat : Cat
    {
        public CheetahCat()
        {
            IsAsleep = false;
            Setting = "wild";
            AverageHeight = 987;
            Eat = "Zzzzzzz";
        }
        
        public override string AfterEat()
        {
            return Eat;
        }
    }
}

