﻿

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Console.ReadLine();

Console.WriteLine("hello from Only Write");


// Revising
int x=2;
long l=22222343434;
double d =5.54d;
float f=3.2f;
char C='H';
string text="long word";
bool Test =true;


string[] mylist =new string[2];
List<string> test= new List<string>() {"Milk","orage"};

mylist[0]="hello";
test.Add("egg");

// Console.WriteLine(Test.ToString());
Console.WriteLine(test[2]);

// IEnumerable not indexing 
IEnumerable<string> myGroceryIEnumerable = myGroceryList;

// Console.WriteLine(myGroceryIEnumerable.First());

// Multi array 
string[,] myTwoDimensionalArray = new string[,] {
    { "Apples", "Eggs" },
    { "Milk", "Cheese" }
};

Console.WriteLine(myTwoDimensionalArray[1, 1]);



static int add(int x){
return x+=1;
}


Console.WriteLine(add(5));


