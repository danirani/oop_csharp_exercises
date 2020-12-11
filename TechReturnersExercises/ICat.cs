using System;

namespace TechReturners.Exercises
{
    
    public interface ICat
    {
        bool IsAsleep { get;}
        string Setting { get;}
        int AverageHeight { get;}
        string Eat { get;}
        void GoToSleep();
        void WakeUp();
    }

    public class Cat : ICat
    {
        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public int AverageHeight { get; set; }
        public string Eat { get; set; }  // cat's reaction after eating
    
        public void GoToSleep()
        {
            IsAsleep = true;
        }

        public void WakeUp()
        {
            IsAsleep = false;
        }
    }

    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
            IsAsleep = false;
            Setting = "domestic";
            AverageHeight = 23;
            Eat = "Purrrrrrr";
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
    }
}

