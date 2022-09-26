Buffet buffet = new Buffet();

Ninja Rock_Lee = new Ninja();

while(!Rock_Lee.IsFull){
    Rock_Lee.Eat(buffet.Serve());
}

if(Rock_Lee.IsFull){
    Rock_Lee.Eat(buffet.Serve());
}