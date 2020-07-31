### **Question 1**

Suppose we have a class named Calc which has a method Seq
generating n-th member of a certain number sequence (starting from 1).

Define a class named CalcAsync. In this class:

Write an asynchronous static method PrintSeqAsync taking integer parameter n,
that prints out the following:
"Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
Use void as return type.

### **Question 2**

Suppose we have a class named Calc which has a method Seq
generating n-th member of a certain number sequence (starting from 1).

Define a class named CalcAsync. In this class:

Write an asynchronous static method TaskPrintSeqAsync taking integer parameter n,
that prints out the following:
"Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
Use Task as return type

Implement an extention method named PrintStatusIfChanged
which takes, as parameters, a task along with its previous status,
prints out the status if it was changed, and updates the old one (given by the parameter).

Implement an extention method named TrackStatus which takes, as a parameter, a task,
and continuously checks a status of the task, and prints out its status if changed.

### **Question 3**

Suppose we have a class named Calc which has a method Seq
generating n-th member of a certain number sequence (starting from 1).

Define a class named CalcAsync. In this class:

Write an asynchronous static method SeqAsync taking integer parameter n,
that returns n-th member of the sequence.
Use Task<> as a return type.

Write an asynchronous static method PrintSeqElementsConsequentlyAsync
taking integer parameter quant,
which calls SeqAsync method for each integer number i from 1 to quant
and prints the result as follows:
"Seq[X] = Y", where X is i, Y is the i-th sequence member.

Write an asynchronous static method PrintSeqElementscaInParallelAsync
taking integer parameter quant,
which does the same as previous one, except of the way of calling SeqAsync method.
Each call of this method should be performed so that
it would run in parallel, not waiting for previous one.
After the last member is received, the results should be printed as described before.

Write the auxiliary method GetSeqAsyncTasks that will be used in the previous one.
This method should take integer parameter n and return an array of Task<> objects.
Each of those tasks should be responsible for geting one sequence member.

### **Question 4**

Suppose we have a class named Calc which has a method Seq
generating n-th member of a certain number sequence (starting from 1).

Define a class named CalcAsync. In this class:

Write an asynchronous stream called SeqStreamAsync taking integer parameter n,
that returns a collection of n tuples
consisting of a number i (from 1 to n) and i-th member of the sequence.

Write an asynchronous static method PrintStream
taking an asynchronous stream of tuples consisting of 2 integer numbers,
which prints the collection as follows:
"Seq[X] = Y", where X is the first item of a tuple, Y is the second one.

### **Question 5**

Suppose we have a class named Calc which has a method Seq
generating n-th member of a certain number sequence (starting from 1).

Define a class named CalcAsync. In this class:

Write an asynchronous static method PrintSpecificSeqElementsAsync
taking an array of integers as a patameter,
which performs a calculation of apropriate sequence member
according to each number in the input array
and prints out the result as follows:
"Seq[X] = Y", where X is a number from input array, Y is the corresponding sequence member.
Each calculation shoul be performed in a separate task.
After last calculation is performed, the list of found exceptions should be printed.

The method Seq generates appropriate exception for non-positive input parameter.