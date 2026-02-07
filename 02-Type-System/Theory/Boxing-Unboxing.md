# Boxing and Unboxing in C#

This document explains what boxing and unboxing are,
why they exist, and why they matter for performance and correctness.

Boxing is one of the most common hidden performance problems in C#.

---

## 1. What Is Boxing?

Boxing happens when:
- A value type is converted to a reference type
- Typically to `object` or an interface

When boxing occurs:
- A new object is created on the heap
- The value type’s data is copied into that object
- A reference to the boxed object is returned

Boxing always involves:
- Heap allocation
- Copying data

---

## 2. Simple Conceptual Example

Conceptually:

- Value type exists (e.g., `int`)
- It needs to be treated as an `object`
- CLR wraps it inside an object on the heap

This wrapped object is called a **boxed value**.

---

## 3. What Is Unboxing?

Unboxing is the reverse operation.

Unboxing happens when:
- A boxed value is converted back to a value type

During unboxing:
- The value is copied out of the object
- The reference itself is discarded

Unboxing does NOT remove the boxed object immediately.
Garbage Collection handles that later.

---

## 4. Boxing Is a Copy (Important)

Boxing creates a **copy** of the value type.

This means:
- Changes to the original value type do NOT affect the boxed value
- Changes to the boxed value do NOT affect the original value

They are completely independent.

---

## 5. Common Boxing Scenarios

Boxing commonly occurs when:
- Assigning a value type to `object`
- Passing a value type to a method expecting `object`
- Using non-generic collections
- Calling virtual methods on value types via interfaces

Many boxing operations are **implicit** and easy to miss.

---

## 6. Why Boxing Is Dangerous

Boxing causes:
- Heap allocations
- Extra garbage collection pressure
- Hidden performance costs

In high-performance or frequently executed code,
boxing can become a serious issue.

---

## 7. Why Boxing Exists at All

Boxing exists to:
- Allow value types to work with APIs designed for reference types
- Maintain backward compatibility
- Support polymorphism with value types

It is a trade-off, not a flaw.

---

## 8. Avoiding Boxing

Modern C# avoids boxing by:
- Using generics
- Using generic collections
- Avoiding `object` parameters where possible

Designing APIs with generics reduces boxing significantly.

---

## 9. Common Misconceptions

Incorrect:
- “Boxing just stores a reference”
- “Boxing does not allocate memory”
- “Unboxing deletes the object”

Correct:
- Boxing allocates on the heap
- Boxing copies data
- GC handles boxed objects later

---

## 10. Interview Explanation (Clear & Strong)

> “Boxing occurs when a value type is converted to a reference type, causing the value to be copied into a new object on the heap. Unboxing copies the value back out. Boxing introduces heap allocation and should be avoided in performance-critical code.”

---

## 11. Next Step

Next, we will explore:
- Type identity
- `object`, `dynamic`, and runtime type behavior
- How the CLR identifies and compares types
