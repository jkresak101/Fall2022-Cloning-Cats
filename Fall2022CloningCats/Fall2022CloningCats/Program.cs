using Fall2022CloningCats;


//Cloning Cats
//Objects in C#
//"Equality"
// == operator works (equality operator)


//Object references. Reference Types vs Value Types

//Variable -> container for an object.

var Dez = new Cat();
var newDez = Dez; // we now have 2 variables referring to the same object.
//this is different than having two instances of these objects
Dez.Name = "Destructicon";
Console.WriteLine(Dez.Name);
Console.WriteLine(newDez.Name);

//this is an example of value types
var num1 = 15;
var num2 = num1;

num1 = 47;
Console.WriteLine(num1);
Console.WriteLine(num2); // based on previous example, we expect num2 to be the value 47

//Reference Types vs Value Types
//reference type stores a reference to some kid of value in memory
//these, for the most part, will be all classes we creat and more complex objects

// Value Type stores the actual value in memory, these are the primitive types we've been using
//bool, int, string, char, etc.


//Cloning Objects
Console.WriteLine("Cloned Objects");
var Hammy = new Cat("Hammy", 5, false);
var newHammy = (Cat)Hammy.Clone();
Hammy.Name = "Thiccie";
Console.WriteLine(Hammy.Name);
Console.WriteLine(newHammy.Name); // unlike our original example, these two lines will print differnt names


// == operator works (equality operator)
var Alani = new Cat("Alani", 2, false);
var AlaniClone = (Cat)Alani.Clone();
Console.WriteLine(Alani == AlaniClone); // comparing the location in memory of these two objects
Console.WriteLine(Alani.Equals(AlaniClone)); // based on our definition it should be true
//var anotherNum = 29;
//var anotherNumClone = anotherNum;
//Console.WriteLine(anotherNum == anotherNumClone);



//Interfaces that support the above ideas





//overloading operators

