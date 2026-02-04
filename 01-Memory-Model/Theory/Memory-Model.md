## 🧠 Memory Model in C#

### What this document is

This document explains **how memory works in C# at a conceptual level**.
Understanding this is critical for:

* Correct program behavior
* Performance
* Async & threading correctness
* Interview explanations

This is not about hardware memory.
This is about **how the CLR manages memory for a C# program**.

---

## 1. What “Memory Model” Means in C#

The C# memory model answers three core questions:

1. Where does data live when my program runs?
2. How long does that data live?
3. Who is responsible for cleaning it up?

In C#, memory is mainly divided into **two logical areas**:

* Stack
* Heap

---

## 2. Stack (Short-Lived, Fast Memory)

The **stack** is used for:

* Method execution
* Local variables
* Method parameters
* References to objects

Key characteristics:

* Very fast
* Limited size
* Automatically cleaned up
* Data exists only for the duration of a method call

When a method finishes execution, its stack frame is destroyed immediately.

---

## 3. Heap (Long-Lived, Managed Memory)

The **heap** is used for:

* Objects created using `new`
* Arrays
* Objects that need to live beyond a single method call

Key characteristics:

* Larger than stack
* Slower than stack
* Memory is managed by the Garbage Collector (GC)
* Object lifetime is non-deterministic

Objects stay on the heap as long as they are **reachable**.

---

## 4. Variables vs Objects (Critical Distinction)

A common misconception is that variables live on the heap.

**Correct model:**

* Variables live on the stack
* Objects live on the heap
* Variables that refer to objects store only a **reference**

A reference is a value that points to an object’s location in memory.

Copying a reference does **not** copy the object.

---

## 5. Value Types vs Reference Types (High-Level)

Value types:

* Examples: `int`, `double`, `struct`
* Store actual data
* Copied by value

Reference types:

* Examples: `class`, `array`
* Store references to objects
* Copying passes the address, not the object

This difference affects:

* Performance
* Mutability
* Side effects
* API design

---

## 6. Object Lifetime

Stack data:

* Created when a method starts
* Destroyed when the method ends
* Deterministic lifetime

Heap objects:

* Created when allocated
* Live as long as references exist
* Cleaned by Garbage Collector later

Developers do not directly control when GC runs.

---

## 7. Key Rule to Remember (Interview Critical)

> **C# always passes values. Sometimes those values are references.**

This rule explains most C# memory behavior.

---

## 8. Why This Matters in Real Applications

Understanding memory model helps prevent:

* Unexpected side effects
* Performance issues
* Async bugs
* Incorrect assumptions in interviews

Every advanced C# topic builds on this foundation.

---

## 9. One-Minute Interview Explanation

> “In C#, method execution data lives on the stack, while objects are allocated on the heap. Variables store either values or references. When a method ends, stack data is removed immediately, but heap objects are cleaned later by garbage collection when no references remain.”

---

## 10. Next Topics

Next, we will dive deeper into:

* Stack frames
* Method calls
* Step-by-step execution