class Ninja
{
    private int calorieIntake;
    public List<Food> FoodHistory;
    
    // add a constructor
    public Ninja(){
        calorieIntake = 0;
        FoodHistory = new List<Food>();
    }
    // add a public "getter" property called "IsFull"
    public bool IsFull{
        get{
            return calorieIntake > 1200;
        }
    }
    // build out the Eat method
    public void Eat(Food item){
        if(IsFull == false){
            calorieIntake += item.Calories;
            FoodHistory.Add(item);
            Console.WriteLine($"The ninja just ate {item.Name}!");
            if (item.IsSweet){
                Console.WriteLine($"MMMMMmmmmm, I love {item.Name}! Tasty!");
            }
            if (item.IsSpicy){
                Console.WriteLine($"AHHHhhh, Yes!!! This {item.Name} is overflowing with the Flames Of Youth!!!");
            }
        }else{
            Console.WriteLine("Ninja: \"Man I'm pooped!\"");
        }
    }
}

