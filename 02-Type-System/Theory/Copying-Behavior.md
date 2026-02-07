# Copying Behavior in C#

This document explains what happens when values are copied in C#.
Copying behavior is the real difference between value types and reference types.

Understanding this prevents subtle bugs and interview mistakes.

---

## 1. What Does “Copying” Mean?

Copying happens when:
- A variable is assigned to another variable
- A value is passed to a method
- A value is returned from a method

In all cases, C# **copies something**.

The critical question is:
> What exactly is being copied?

---

## 2. Copying Value Types

When a value type is copied:
- The **entire data** is duplicated
- The two variables are completely independent

Examples of value types:
- `int`
- `double`
- `struct`
- `enum`

Changing one copy does NOT affect the other.

---

## 3. Copying Reference Types

When a reference type is copied:
- Only the **reference (address)** is copied
- The object itself is NOT duplicated

Examples of reference types:
- `class`
- `array`
- `string`
- `object`

After copying:
- Two variables
- One object
- Shared state

---

## 4. Assignment vs Mutation (CRITICAL DISTINCTION)

There are two very different operations:

### Assignment
- Changes what a variable points to
- Does NOT affect other variables

### Mutation
- Changes the object itself
- Affects all references to that object

Confusing these two is one of the most common C# mistakes.

---

## 5. Method Parameters and Copying

When a value is passed to a method:
- C# **always copies the value**

For value types:
- The data is copied

For reference types:
- The reference is copied

This is why:
- Modifying a value type inside a method does not affect the caller
- Modifying a reference type’s object does affect the caller

---

## 6. Why This Is Often Misunderstood

People often say:
> “Objects are passed by reference”

This is **incorrect**.

Correct statement:
> “References are passed by value.”

This single sentence explains most parameter-passing behavior in C#.

---

## 7. Performance Implications

Value types:
- Copying large structs can be expensive
- Small structs are efficient

Reference types:
- Copying references is cheap
- Mutating shared state can be dangerous

Choosing between value and reference types is a **design decision**, not just syntax.

---

## 8. Common Interview Traps

Trap questions often involve:
- Expecting a value type to behave like a reference type
- Expecting reassignment to affect the caller
- Assuming no copying occurs

Interviewers are testing your mental model, not your syntax.

---

## 9. Interview Explanation (Strong & Precise)

> “C# always copies values. For value types, the actual data is copied. For reference types, the reference is copied, which means multiple variables can point to the same object.”

---

## 10. Next Step

Next, we will explore:
- Boxing and unboxing
- How value types turn into reference types
- Why this affects performance and correctness
