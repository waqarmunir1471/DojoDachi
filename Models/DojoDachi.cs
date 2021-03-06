using System;



namespace ComputerPet.Models
{
    public class DojoDachi : Hero
    {
        public DojoDachi(string imageurl, string tagline) : base("Carl", 20, 20, 50, 3, imageurl, tagline)
        {

        }

        public override void Feed()
        {
            // if (!IsFull)
            // {
            //     if(Meals>0)
            //     {
            //         Meals-=1;
            //         var random=new Random();
            //         var amount=random.Next(5,10);
            //         Fullness+=amount;
            //     }
            
            // }
        }

        public override void Play()
        {
            // while (Energy >=5)
            // {
            //     Energy-=5;
            //     var random=new Random();
            //     var mood=random.Next(5,10);
            //     Happiness+=mood;
            // }
        }

        public override void Work()
        {
            // Energy-=5;
            // var random=new Random();
            // var dish=random.Next(1,4);
            // Meals+=dish;
        }

        public override void Sleep()
        {
            // Energy+=15;
            // Fullness-=5;
            // Happiness-=5;
        }
        public bool IsFull()
        {
            if (Fullness == 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsDead()
        {
            if (Energy <= 0 || Happiness <= 0 || Fullness<=0) {
                return true;
            } 
            else 
            {
                return false;
            }
        }

        public bool YouWon()
        {
            if (Fullness >= 100 && Happiness >= 100 && Energy >= 100) {
                return true;
            } 
            else 
            {
                return false;
            }
        }
        public void Restart()
        {
            Meals = 3;
            Happiness = 20;
            Energy = 50;
            Fullness = 20;
        }        
    }
}