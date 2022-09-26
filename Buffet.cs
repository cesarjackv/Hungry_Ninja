class Buffet{
    public List<Food> Menu;
    
    //constructor
    public Buffet(){
        Menu = new List<Food>()
        {
            new Food("Burger", 860, false, false),
            new Food("Pizza", 1200, false, false),
            new Food("Ramen", 790, true, false),
            new Food("Ice Cream", 600, false, true),
            new Food("Mango Habanero Wings", 820, true, true),
            new Food("Chocolate Chip Cookies", 200, false, true),
            new Food("Hot Sauce", -10, true, false)
        };
    }
    
    public Food Serve(){
        Random rand = new Random();
        Food entree = Menu[rand.Next(Menu.Count())];
        return entree; 
    }
}

