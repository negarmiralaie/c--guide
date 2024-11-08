#### Field = Property
#### Method = Operation
#### Static --> takes only 1 place in memory and while run time no other place on memory it will take
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