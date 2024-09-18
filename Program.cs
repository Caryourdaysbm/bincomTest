 // Task 1: Declare and initialize variables
string name = "John Doe";
int age = 25;
bool isAdmin = true;

Console.WriteLine("Task 1:");          
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Is Admin: " + isAdmin + "\n");


// Task 2: Determine if a number is even or odd
Console.WriteLine("Task 2:");      
Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0){
    Console.WriteLine("Even"+ "\n");
} 
    else{
        Console.WriteLine("Odd"+ "\n");
    }
        


// Task 3: Print numbers 1 to 10 using a for loop
Console.WriteLine("Task 3:");      
Console.WriteLine("Numbers from 1 to 10: ");
for (int i = 1; i <= 10; i++){
    Console.Write(i + " ");
}
Console.WriteLine("\n\n");    




// Task 4: Declare and initialize an array and print sum and elements
Console.WriteLine("Task 4:");      
int[] numbers = { 2, 4, 6, 8, 10 };
int sum = 0;

Console.WriteLine("Array elements:");
foreach (int num in numbers){
    sum += num;
    Console.WriteLine(num);
}

Console.WriteLine("Sum of array elements: " + sum + "\n\n");




// Task 5: Method that prints a personalized greeting
Console.WriteLine("Task 5:");      
static void Greet(string name){
    Console.WriteLine("Hello, " + name + "!");
}


Greet("Alice");
    


