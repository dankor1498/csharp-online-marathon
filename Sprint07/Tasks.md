### **Question 1**

Please, implement the SumOfElementsOddPositions method that returns sum of elements with odd indexes in the array of doubles

### **Question 2**

Please, implement EvaluateAggregate method that takes 

an array of doubles as the first parameter, 

a delegate that defines an aggregate behavior as the second,

a delegate that defines a condition for the index as the third parameter.

The method should return a result of an aggregate operation for the elements with indexes that satisfy the condition set by the third parameter

### **Question 3**

Please, create a method ProductWithCondition that takes a list of integers as a parameter and returns a product of elements that satisfy a condition that as passed as a second parameter.

second parameter should be a Func that takes an integer as a parameter and returns bool.

### **Question 4**

Please, create a static method GetWord takes 2 string parameters: 

first - initial string with a sequence of words separated by space 

second - a word for comparison.

The method should find the longest word in the first parameter, that is longer than the second parameter if there is one, 

otherwise, the second parameter should be the result of the search.

The method should return the part of the found word, starting from the first 'a' char. 

If there isn't 'a' char in the found word, the method should return an empty string.

### **Question 5**

Please, create Department class with public string property Name, int Id and Worker Manager.

Create constructor with string, int and Manager parameters for initializing the properties.     

Create Worker class with public int property Id, string Name, decimal Salary and Department Department.

Create constructor with string, decimal, Department parameters to initialize the properties.

Implement public Serialize method that returns string that contains serialized Worker object in json format.
Worker that is created like this 

```csharp
Worker w = new Worker("Anna", 700, new Department("Mechanics", 1, new Worker("Tom", 600, null)));
``` 
should be serialized into the next string:   

```json
{
  "Full name": "Anna",
  "Salary": 700,
  "Department": {
    "Name": "Mechanics",
    "Id": 1,
    "Manager": {
      "Full name": "Tom",
      "Salary": 600
    }
  }
}
``` 
note that Id property should not be serialized and Name property should be represented as Full name

Also, implement public static method Deserialize that takes a string as a parameter and returns a deserialized Worker object from it.

### **Question 6**

Suppose, you have classes Student and Group:

```csharp
class Student
{
    public string Name { get; set; }
    public double Rating { get; set; }
    public string GroupName { get; set; }
}

class Group
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Popularity { get; set; }
}
``` 
Please, implement the CreateGroups method that takes a list of students as a first parameter and a list of groups as a second.

The method should return a string that contains for all groups the next information:

group name, average rating and the list of students in the group in the following format   

```json
[
  {
    "group": "group_name",
    "description": "group_description",
    "rating": average_rating,
    "students": [
      {
        "FullName": "Name_of_student",
        "AvgMark": students_rating
      },
      {
        "FullName": "Ivan",
        "AvgMark": 68.34
      },
      {
        "FullName": "Oleh",
        "AvgMark": 98.34
      },
      {
        "FullName": "Katya",
        "AvgMark": 88.34
      }
    ]
  },
  ...
]
```

Tip: you can use GroupJoin to join collection with grouping. 

Use JSON serialization to generate output in the specified format.