# References in C#

This document explains what references are, how they behave,
and why understanding them is essential for writing correct C# code.

References are one of the most misunderstood concepts in C#.

---

## 1. What Is a Reference?

A reference is:
- A value
- That points to an object in memory
- Not the object itself

In C#, variables that refer to objects store references,
not the actual object data.

A reference behaves similarly to:
- A memory address
- A pointer (conceptually, not syntactically)

---

## 2. References Are Values

This is a critical rule:

> A reference itself is a value.

This means:
- References can be copied
- References can be passed to methods
- Copying a reference does NOT copy the object

Multiple references can point to the same object.

---

## 3. Passing References to Methods

When an object is passed to a method:
- The reference is copied
- Both caller and callee refer to the same object

This explains why:
- Mutating an object inside a method affects the caller
- Reassigning the reference does NOT affect the caller

---

## 4. Reference Reassignment vs Object Mutation

Two very different operations:

- Reassigning a reference  
  → Changes what the variable points to  
  → Does NOT affect other references

- Mutating an object  
  → Changes the object itself  
  → Affects all references to that object

Confusing these two leads to subtle bugs.

---

## 5. Reference Equality vs Value Equality (Preview)

Two references can:
- Point to the same object
- Point to different objects with identical data

Reference equality checks:
- Whether two references point to the same object

Value equality checks:
- Whether two objects represent the same value

This distinction is critical and will be explored deeply later.

---

## 6. References and Lifetime

An object remains alive on the heap as long as:
- At least one reference to it exists

Once all references are gone:
- The object becomes eligible for garbage collection

Removing a reference does not immediately destroy the object.

---

## 7. Common Misconceptions

Incorrect:
- “Objects are passed by reference”
- “Passing an object copies it”
- “Setting a variable to null deletes the object”

Correct:
- References are passed by value
- Only the reference is copied
- Objects are cleaned up by GC later

---

## 8. Why References Matter in Real Applications

Understanding references helps:
- Avoid unintended side effects
- Write safer APIs
- Design immutable objects
- Reason about async behavior

Most production bugs involving data corruption
are reference-related bugs.

---

## 9. Interview Explanation (Clear and Short)

> “In C#, references are values that point to objects on the heap. When an object is passed to a method, the reference is copied, not the object. Mutating the object affects all references, but reassigning a reference does not.”

---

## 10. Next Step

Next, we will focus on:
- Object lifetime
- Reachability
- How garbage collection decides what stays alive
