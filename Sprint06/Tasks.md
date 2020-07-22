### **Question 1**

Inside a class ShowPower define a static method SuperPower(). SuperPower() has two integer input parameters: number and degree. The method will  calculate the power of a given number according to degree parameter.

Note: Don't use Pow().

The method involves to yield the intermediate result of the calculation on the each iteration.

For example, when calling the method SuperPower():

```csharp
foreach(float item in SuperPower(3, 4))
{
    Console.Write($"{item} ");
}
``` 
Output: 3 9 27 81

### **Question 2**

Suppose, you have class Book:

```csharp
public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageCount { get; set; }
    
    public Book(string title, string author, int pageCount)
    {
        Title = title;
        Author = author;
        PageCount = pageCount;
    }
}
``` 

Please, implement class Library with public property Books of generic IEnumerable type that can be set only inside the class,
and public property Filter (generic predicate) that sets a condition on book. The default value of Filter: any book satisfies the condition.

The constructor of Library class takes 1 parameter for initialization Books property.

Implement GetEnumerator method that will allow to enumerate by only those books that satisfy the condition in Filter.

Do not use yields in this task.

Create  MyEnumerator class that implements IEnumerator<Book>.

The constructor of MyEnumerator takes 2 parameters: for initialization books and filter.

Implement all the necessary methods and properties in MyEnumerator.

Implement MyUtils class with public static method GetFiltered that takes generics IEnumerable and Predicate and returns list of filtered books using Library class and its enumerator.

### **Question 3**

Within the class ShowPowerRange create a static method PowerRanger() that takes in integer degree, start, finish. 

The method returns all the numbers from the range [finish, start] (inclusive and finish > 0 and start > 0) that are equal to the degree-th power of any integer.

In the case start > finish, or start < 0, or finish < 0 the method returns 0.

The method involves to yield the intermediate result on the each iteration.

For example, when calling the method PowerRanger(): 

```csharp
foreach(float item in PowerRanger(3, 1, 200))
{
    Console.Write($"{item} ");
}
``` 

Output: 1 8 27 64 125

### **Question 4**

Within the class SetOperation create methods that fulfill the basics operation with the sets: Union() - union of two sets; Intersect() - intersection of two sets; LeftDifference() - left difference of two sets; RightDifference() - right difference of two sets; Addition() - the addition to universum of the given set.

Each of these five methods is static with two input parameters of List<int> and returns List<int> as the result of appropriate operation. In the case of Addition() method the first parameter represents set, the second - universum.

You are forbidden to use System.Linq.

Note. In case of Addition() method as the universum set you may use integer numbers from any range. But the given set must be subset of this universum.

### **Question 5**

You know already what number can be called 'palindrome'. 

A number may not be a palindrome, but its heritor can be. A number's direct child is created by summing each pair of adjacent digits to create the digits of the next number.

For instance, 123312 is not a palindrome, but its next child 363 is, where: 3 = 1 + 2; 6 = 3 + 3; 3 = 1 + 2.

Within the class PalindromeSolver:

- create a static method IsPalindromeHeritor() that takes long integer parameter (given number) and returns True if the number itself is a palindrome or any of its heritors down to 2 digits is a palindrome;

- create a static method IsPalindrome() that takes generics IEnumerable (the sequence of chars that represents given number). This method returns True if the given number is palindrome and False in opposite case. This method is called from the method IsPalindromeHeritor() ;

- create a static method GetHeritor() that takes generics IEnumerable (the sequence of chars that represents given number) and returns a heritor (in a string representation) to the given number.  This method is called from the method IsPalindromeHeritor(). 

Examples

IsPalindromeHeritor(11211203) ➞ False

// 11211203 ➞ 2333 ➞ 56

IsPalindromeHeritor(31001120) ➞ True

// 31001120 ➞ 4022 ➞ 44

IsPalindromeHeritor(8677) ➞ True

// 8677 ➞ 1414 ➞ 55

IsPalindromeHeritor(33) ➞ True

// Number itself is a palindrome.

Notes

Numbers will always have an even number of digits.
A 1-digit number is trivially a palindrome.

### **Question 6**

An anagram is a word created by rearranging letters from another word. You have to solve the problem of determining if an anagram of the one given string is in the another one string. 

F.e. anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba". Since none of those anagrams are in "grab", the answer is false. A "g", "a", and "b" are in the string "grab", but they're split up by the "r". But one of the anagrams of "car"  ("cra", "rac", "rca", "acr", "arc") is in word "race".

To solve this this problem within the class AnagramSolver you have to create:

- static method IsAnagram() which takes two string parameters. This method returns True if an anagram of the first string is the substring of the second string;

- create a static method Permutations() that takes generics IEnumerable (given string) and returns generics IEnumerable collection (of an anagram strings). Note: try to use iterator. This method is called from the method IsAnagram() .

Examples:

IsAnagram("nod", "done") ➞ True

IsAnagram("bag", "grab') ➞ False

### **Question 7**

Your task is  to write a  static method IsValidName() within the class ValidNameSolver. The method determines whether a given as parameter name is valid or not. Return True if the name is valid, False otherwise.
You are free in your realization of this task. You may define enum, classes and methods as you consider. But note, that one of these additional methods must be written according to iterator pattern. 

To continue with this task, keep in mind the following definitions:

1. A term is either an initials or word.
2. initials = 1 character
3. words = 2+ characters (no dots allowed)

You have to follow next rules

1. Both initials and words must be capitalized.

2. Initials must end with a dot.

3. A name must be either 2 or 3 terms long.

4. If the name is 3 words long, you can expand the first and middle name or expand the first name only. You cannot keep the first name as an initial and expand the middle name only.

5. The last name must be a word (not an initial).


A valid name is a name written in one of the following ways:

- H. Wells
- H. G. Wells
- Herbert G. Wells
- Herbert George Wells

The following names are invalid:

- Herbert or Wells (single names not allowed)
- H Wells or H. G Wells (initials must end with dot)
- h. Wells or H. wells or h. g. Wells (incorrect capitalization)
- H. George Wells (middle name expanded, while first still left as initial)
- H. G. W. (last name is not a word)
- Herb. G. Wells (dot only allowed after initial, not word)