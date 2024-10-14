# AxionBio Software Conference Oct 2024: Coding Challenge


## Coding Exercises

There are several coding tasks organized as the `Challenge` project.  
Please implement appropriate methods to pass the unit tests (check the `Tests` project).

The more tests are ✅, the better.  
🤖 Please **don't use LLM/AI helpers;** that kills the fun. 🤖 


### Is Number a Palindrome?  

**Input constraints:** `UInt64` number (`0 .. 2^64 - 1`).  
**Output examples:**

```csharp
var np = new NumberPalyndrome();
np.IsPalyndrome(12321) == True;
np.IsPalyndrome(12320) == False;
```


### Valid Parentheses

Given a string, return boolean if all the parentheses inside match general math conventions.

**Input constraints:** A string of max. 1024 ASCII chars.  
Following considered as parentheses pairs: `() [] {}`.  
**Output examples:**

```csharp
var vp = new ValidParentheses();
vp.IsValid("5 + 6 * (3 - 2 / (...))") == True;
vp.IsValid("({}[]) [{}([])]") == True;

vp.IsValid("(( [)] )") == False;
//              ^ the ] expected
vp.IsValid("(( {}[] )") == False;
//                   ^ the ) is missing
```


### Merge 2 Sorted Lists

Given two sorted arrays/lists of numbers, return a new array/list,
which contains all the members from both inputs and is sorted respectively.

**Input constraints:** two `int[]` of variable sizes; both sorted in ascending order.  
Input array length not exceed 1024 elements.   
**Output examples:**

```csharp
var lm = new ListMerger();
lm.Merge(
    new int[] { 1, 2, 3, },
    new int[] { 2, 3, 4, },
); // expected [ 1, 2, 2, 3, 3, 4 ]
```



### Maximal Depth of Binary Tree

Given a binary tree (check the class `BinaryTree\BinaryNode`),
return the number of edges between the root node and the deepest leaf node.

```
           A
        /     \
      B         C
     / \       / \
    D   E     F   G
       / \
      H   I
           \
            J

    # Deepest path: A-B-E-I-J
    # MaxDepth = 4
```


### Detect a Cycle in the Graph



### Longest Substring Without Repeating Characters



### Keys and Rooms



### Rotate List
