ABSTRACTION
- Abstraction is achieved by using abstract classes and interfaces
- Abstract classes cannot be instantiated
- Abstract classes can have abstract and non-abstract methods
            
            

DIFFERENCES BETWEEN ABSTRACT CLASSES AND INTERFACES
- Abstract classes can have abstract and non-abstract methods, Interfaces can have only abstract methods
- Abstract classes can have fields, Interfaces cannot have fields
- Abstract classes can have static methods, Interfaces cannot have static methods
- Abstract classes can have final methods, Interfaces cannot have final methods
- Abstract classes can have protected and private access modifiers, Interfaces can have only public access modifiers
- Abstract classes can have constructors, Interfaces cannot have constructors
- Abstract classes can have nested classes, Interfaces cannot have nested classes
- Abstract classes can have final classes, Interfaces cannot have final classes
- Abstract classes can have static classes, Interfaces cannot have static classes
- Abstract classes can have protected and private access modifiers, Interfaces can have only public access modifiers

VIRTUAL METHODS
- A virtual method is a method that is declared in a base class and is overridden in a derived class.
When you call a virtual method, the CLR determines which method to call at runtime based on the type of the object that is used to invoke the method. 
The CLR uses the type of the object to determine which method to call, not the type of the variable that is used to invoke the method.
This is called late binding.