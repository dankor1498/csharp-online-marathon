### **Question 1**

Implement ParallelUtils class that will be able to execute an operation in a parallel thread.

The constructor of ParallelUtils takes 3 parameters: 

1. The Func<T, T, TR> to define an operation that will be executed, 

2. The operand1 of type T 

3. Tperand2 of type T.

The ParallelUtils class should have public Result property of type TR where the result of the operation must be written when it's executed.

Implement method StartEvaluation that will start the evaluation (of the function passed into constructor) in a parallel thread 

Implement method Evaluate that will start the evaluation (of the function passed into constructor) in a parallel thread and wait until it's executed.

### **Question 2**

We have class MainThreadProgram. Please create three methods: Calculator, Product and Sum.

Method Sum should ask user to enter 5 numbers in form “Enter the 1 number :”, “Enter the 2 number :” etc. and calculate their sum. After that it should output the message “Sum is \<sum>”. 

Method Product should have the List of 10 int numbers and calculate their product. After that it should output the message “Product is \<product>”. 

 Calculator method should create two threads: sumThread and productThread and call them.

### **Question 3**

Please, look at the code below.
```csharp
public static void Tasks()
{
    int[] sequence_array = new int[10];

    Task[] tasks1 = new Task[3]
    {
        new Task(()=>
        {
            for (int i = 0; i < 10; i++)
            {
                sequence_array[i] = i*i;
            }
            Console.WriteLine("Calculated!");
        }),
        new Task(()=>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Bye!");
        }),
        new Task(()=>
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(sequence_array[i]);
            }
            Console.WriteLine("Bye!");
        })
    };
    Console.WriteLine("Main done !");
}
``` 
Please, refactor this code so that Tasks() gives the next output:

```
Calculated!
0
1
2
3
4
5
6
7
8
9
Bye!
0
1
4
9
16
25
36
49
64
81
Bye!
Main done!
```
### **Question 4**

Please create class MyProgram.

Create method Counter that takes one parameter of int type.

This method should have two threads. 

One of them calculates the factorial of Counter's argument (n! = 1 * 2 * ... * (n - 1) * n).

The second thread calculates the appropriate number of Fibonaci sequence (fibo(0) = 0, fibo(1) = 1, ... fibo(n) = fibo(n-1) + fibo(n-2)).

Please implement the additional methods.

Method Counter should display two messages:

"Factorial is: \<factorial>"

"Fibbonaci number is: \<fibo>".

The sequence of outputs metters.

Example:

Input: MyProgram.Counter(4);

Output:  

Factorial is: 24

Fibbonaci number is: 3

### **Question 5**

You have MyThreads class in the answer window below. Please, investigate it: there is some problem with this class.

Fix the problem.

The test starts both threads with the code:
```csharp
MyThreads.Thread1.Start();
MyThreads.Thread2.Start();
```
The goal of each thread is to make some evaluations, update m and n fields and not switch between threads while loop is executed.

You need to get an output like this:
```
Thread1 n = 0
Thread1 n = 1
Thread1 n = 2
Thread1 n = 3
Thread1 n = 4
Thread2 m = 0
Thread2 m = 1
Thread2 m = 2
Thread2 m = 3
Thread2 m = 4
Thread2 n = 5
Thread2 n = 6
Thread2 n = 7
Thread2 n = 8
Thread2 n = 9
Thread2 success!
Thread1 m = 5
Thread1 m = 6
Thread1 m = 7
Thread1 m = 8
Thread1 m = 9
Thread1 success!
```

### **Question 6**

 We have a shop. Due to the situation with coronavirus, there are limitations on the number of buyers that are allowed to be in the shop simultaneously.

There are allowed 10 users maximum in the shop.

Create a class Buyer. Objects of this class must do their shopping in separate threads.

Buyer must be derived from PersonInTheShop class. Don't create PersonInTheShop, it already exists in the same namespace.

Implement constructor for Buyer which takes a string argument - thread name. Use this name to set the name of a new thread that will be started. Start the thread in the constructor.

Every buyer does shopping in its own thread. Four methods of a base class should be called for every shopping: Enter(), SelectGroceries(), Pay(), Leave().      
