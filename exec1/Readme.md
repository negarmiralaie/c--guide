#### int32 --> int
#### int64 --> long 
#### string --> holds several characters --> it's a reference type --> stored data in heap(slower) (only stores the address of the sting in heap, inside stack) --> immutable(not changeable) --> if you change a character in a string, it wil create a new object and previous object will remain in heap until garbage collector frees its space  -->  "  "
#### char --> holds only one character --> it's a value type --> stores data in stack(faster) --> mutable( ==> less memory usage ) --> ' '
#### use StringBuilder when you want to make changes to your string several times...

```cs
// This is a good case to use StringBuilder rather than string --> if you use sting it will create 10000 instances of a string 

string testString = "";
for (int i=0; i < 10000; i++) {
  string += "test val";
}

StringBuilder testStringBuilder = new new StringBuilder();
for (int i= 0; i<10000; i++) {
  testStringBuilder.Append("test val");
}
```


* Accessing data in heap is slower than stack since in stack data is stored directly without the need to store the address...
* Data stored in heap is managed by Garbage Collector --> when object is no more used, its space wil be freed
* Data store in stack will be freed automatically after the function calling it has finished.
```cs
long bigNum = 900000L; // --> if you miss L it will define it as int32
decimal money = 14.9M;
// Note the importance of L and M to denote the exact type

string name = "ab";
char letter = 'a';
char letterWrong = 'abbbbb'; // --> error
// note quotes

string textAge = "-23";
int age = Convert.ToInt32(textAge); // --> 23

string textAgeWrong = "-23h";
int ageWrong = Convert.ToInt32(textAgeWrong); // --> throws an exception error


string textBigNumber = "-90000000"; // --> does not need L since we explicitly define the type in next line
long bigNumber = Convert.ToInt64(textBigNumber);

string textNegative = "-55.2";
double negative = Convert.ToDouble(textNegative);

string textPrecision = "5.0000001";
float precision = Convert.ToSingle(textPrecision);

string a = "aaaaa";
a += "bbb"; // --> "aaaabbb"

a -= "a" // --> error

char b = "b";
b += "c"; // --> sums unicode codes of b and c

int i = 0;
Console.WriteLine(i++);  // --> firs display previous value of i (0) then then adds 1 to it --> 0
Console.WriteLine(i);   // --> since value of i has incremented by 1 value in previous value, here it displays 1 --> 1
Console.WriteLine(++i); // --> first increases value of i and then displays it --> 2



var ab; // --> error

const int vat = 20;
const double percentVat = vat / 100D;  // --> to make it a decimal

// store phone numbers as a string <= if you store numbers starting with 0, 0s at the beginning will be omitted also you may not want to do math on it...


```


#### Choosing weather to use var for declaring a variable or int for example is juts for readability purposes and does not differ for the compiler.... 


#### Field = Property
#### Method = Operation
#### Instantiation -> creating an object of a class
#### Object -> somehow an entity -> book, person
#### Using setters and getters -> implement validation(in setter), 
#### 4 cores of oop:
1. Inheritance
2. Polymorphism
3. Encapsulation
4. Abstraction

#### Encapsulation: Hiding information --> avoid chainging data unwantedly and determine specific access for data of that class from outside --> access modifiers ++ setters ans getters ++ are a tool that is used in encapsulation 
#### Inheritance ->
  Person(superclass)
    * Student(subclass)
    * Employee(superclass)
      * Programmer(subclass)
      * Writer(subclass)
#### Polymorphism -> Person has a DisplayInfo method, Student inherits that method from Person but reimplements that in a different way --> use override keyword before writing type of response when overriding the method in the child class and virtual in superclass

#### Static --> takes only 1 place in memory and while run time no other place on memory it will take.... e.x: Date.Current() --> If you do not declare a function using static, you won't be able to call that without newing it bc it won't recognize the function
```cs
int[] numbers = new int[3];

for(int i = 0; i < numbers.Length; i++) {
  Console.Write("Enter a number: ");
  numbers[i] = Convert.ToInt32(Console.ReadLine());
}


static int[] CreateArray() {
  int[] numbers = new int[3] {
    0, 1, 2
  }
}
// 
```


#### accessing by reference: pointer --> int *p = $x; --> address of x is stored in p --> why would we use pointers? bc we may want to change the value of a variable in another function but if we pass it by value to that function, its value won't change so we pass it by reference so that we get access to its address and we can change it...
```cs
int *px = &x; // --> px is a pointer to the address of x.... it holds the address of x
int y = *px;  // --> now y holds the address of x


struct Person {
  public string name;
  public int age;
}

void updateStruct(Person *p, int age) {
  p->age = age;
}

unsafe void main() {
  Person lowLevel;
  lowLevel.name = "sdsdsdsd";
  lowLevel.age = 10;  
  updateStruct(&lowLevel, 100)
}
```

#### dynamic memory allocation: when we create a new array or object using "new" keyword(and strings), dynamic allocation in heap happens --> this way garbage collection will do the memory management --> since they are stored in heap, accessing them is muh slower than statically created variables-->.

#### static memory allocation: local variables in methods are stored in stack and have static memory allocation --> they will be removed automatically from stack once they are finished executing the code --> this happens for data types like int, bool float etc

```cs
int[] dynamicArray = new int[10]; // --> dynamic allocation in heap
Person person = new Person(); // --> dynamic allocation in heap
```

#### class vs struct vs record: class(reference type), struct(value type), 


#### reference type: we pass a reference to that object
#### : we pass a copy of that value
```cs
var location1 = new GeoPoint() { Lat = 37.2, Long = -120 }
var location2 = location1; // --> pass by value --> location1 and location2 are 2 different objects that just look the same 

location2.Lat = 47; // --> only value of location2 changes... <= pass by value

Console.WriteLine(Equals(location1, location2)); // --> true --> bc it is comparing their types and their values

public struct Geopoint {
  public double Lat { gte; set; }
  public Long { get; set; }
}

// ------------------------------------------

var person1 = new Person("aaaa", "bbbb");
var person2 = person1; // --> pass by reference --> they both point/refer to the same object in memory 

person2.FirstName = "newww"; // --> value of person1 and person2 both change <= pass by reference 

Console.WriteLine(Equals(person1, person2)); // --> false --> bc it is comparing the reference not the value


class Person(string FirstName, string LastName) {
  public string FirstName { get; set; } = FirstName;
  public string LastName { get; set; } = LastName;
}

```
#### when to use struct over class?
1. when if it's immutable(since struct is a value type, if you change its value it wil create a copy of it and does not change itself)
2. if the instance of it is short lived(since structs ar stored in stack and their space will be freed once their execution is done)
3. if it represents a single value like a primitive type
4. if its instance size is smaller than 16 bytes 
5. if it is not boxed frequently

* Reference types are stored in heap while value types are stored in stack