# Stack vs Heap in C#

This document explains how the stack and heap work together
during method execution in a C# application.

Understanding this is critical for:
- Debugging
- Performance reasoning
- Async and threading correctness
- Interview explanations

---

## 1. Method Calls and the Stack

When a method is called in C#, a **stack frame** is created.

A stack frame contains:
- Method parameters
- Local variables
- Return address

Each method call adds a new stack frame on top of the stack.

When the method finishes execution:
- Its stack frame is removed
- All local data is destroyed immediately

This process is deterministic.

---

## 2. Nested Method Calls

If a method calls another method:
- The first method’s stack frame remains
- A new stack frame is added for the second method

Execution always happens at the **top** of the stack.

When the inner method returns:
- Its frame is removed
- Execution continues in the previous method

---

## 3. Stack Behavior Summary

- Stack grows with method calls
- Stack shrinks with method returns
- Stack follows Last-In, First-Out (LIFO)

This behavior explains why:
- Deep recursion can cause stack overflow
- Local variables are not shared between methods

---

## 4. Heap Interaction During Method Execution

When a method creates an object:
- The object is allocated on the heap
- A reference to that object is stored in the stack frame

Only the reference is placed on the stack, not the object itself.

---

## 5. Reference Flow Example (Conceptual)

- Method A creates an object
- A reference to the object is stored in A’s stack frame
- Reference is passed to Method B
- Both methods point to the same heap object

The object remains alive as long as at least one reference exists.

---

## 6. Stack vs Heap Responsibilities

Stack is responsible for:
- Execution flow
- Temporary data

Heap is responsible for:
- Object storage
- Long-lived data

They work together but serve different purposes.

---

## 7. Common Misconceptions

Incorrect:
- “Objects live on the stack”
- “Passing an object copies it”
- “Heap memory is freed when method ends”

Correct:
- Objects live on the heap
- References are copied
- Heap memory is managed by GC

---

## 8. Why This Matters

Understanding stack vs heap helps:
- Predict program behavior
- Avoid unintended side effects
- Reason about memory and performance
- Answer interview questions confidently

---

## 9. Interview Explanation (Simple)

> “Each method call creates a stack frame that holds local data and references. Objects are allocated on the heap, and only references are stored on the stack. When methods return, stack frames are destroyed, but heap objects live until garbage collected.”

---

## 10. Next Step

Next, we will focus specifically on:
- References
- How reference passing works
- Why changes propagate across methods
