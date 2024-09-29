//start main
string userInput = ""; //priming
while(userInput != "4"){
    DisplayMenu();
    userInput = GetUserInput(); //update
    RoutEm(userInput);
}
//end main

static void DisplayMenu(){
    System.Console.WriteLine("Choose an Option to Display4:\n 1. Plain Pizza \n 2. Cheese Pizza \n 3. Pepperoni Pizza \n 4. Exit");
}

static string GetUserInput(){
  return Console.ReadLine();
}

static void RoutEm(string userInput){
    switch(userInput){
        case "1":
        DisplayPlainPizza();
        break;
        case "2":
        DisplayCheesePizza();
        break;
        case "3":
        DisplayPeperoniPizza();
        break;
        case "4":
        SayBye();
        break;
        default:
        DisplaerrorMessage();
        break;
    }
}

static void DisplayPlainPizza(){
Random random = new Random();
int randomRows= random.Next(8,13);
for(int i = 0; i< randomRows; i++){
    for(int j = 0; j< randomRows ; j++){
        if(j< i){
            System.Console.Write("* ");
        }else{
            System.Console.Write(" ");
        }
    }
    System.Console.WriteLine();
    }
}


static void DisplayCheesePizza(){
    Random random = new Random();
int randomRows= random.Next(8,13);
for(int i = 0; i< randomRows; i++){
    for(int j = 0; j< randomRows ; j++){
        if(j< randomRows- i -1){
            System.Console.Write("");
        }else if(i == randomRows -1 || j == randomRows - i -1 || j== randomRows -1){
            System.Console.Write("* ");
        }else{
            System.Console.Write("# ");
        }
    }
    System.Console.WriteLine();
}
}

static void DisplayPeperoniPizza(){
    Random random = new Random();
int randomRows= random.Next(8,13);
for(int i = 0; i< randomRows; i++){
    for(int j = 0; j< randomRows ; j++){
        if(j< randomRows- i -1){
            System.Console.Write("");
        }else if(i == randomRows -1 || j == randomRows - i -1 || j== randomRows -1){
            System.Console.Write("* ");
        }else if(random.Next(0,5) == 0){
            System.Console.Write("[]");
        }else{
            System.Console.Write("# ");
        }
    }
    System.Console.WriteLine();
}
}


static void SayBye(){
    System.Console.WriteLine("GoodBye!");
     pause();
}

static void pause(){
    System.Console.WriteLine("Press any key to continue`");
    Console.ReadKey();
}

static void DisplaerrorMessage(){
    System.Console.WriteLine("Invalid Menu Option");
        pause();
}