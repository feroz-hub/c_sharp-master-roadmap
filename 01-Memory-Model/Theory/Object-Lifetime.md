# Object Lifetime in C#

This document explains how long objects live in a C# application
and how the runtime decides when they can be removed from memory.

Understanding object lifetime is essential for:
- Memory safety
- Performance
- Avoiding memory leaks
- Understanding Garbage Collection

---

## 1. Object Creation

An object is created when:
- The `new` keyword is used
- Memory is allocated on the heap
- A reference to the object is returned

Example (conceptual):
- `new Person()` → creates an object on the heap
- A reference points to that object

At this point, the object is considered **alive**.

---

## 2. What Keeps an Object Alive?

An object remains alive as long as:
- At least one **reachable reference** points to it

Reachable means:
- The reference can be accessed by running code

Common sources of reachability:
- Local variables (on stack)
- Fields of other live objects
- Static fields

---

## 3. Stack Frames and Lifetime

When a method ends:
- Its stack frame is destroyed
- All local references inside it disappear

If those references were the **only references**:
- The object becomes **unreachable**

Unreachable does NOT mean:
- Immediately destroyed
- Immediately removed from memory

It means:
- Eligible for Garbage Collection

---

## 4. Garbage Collection (High-Level)

Garbage Collection (GC) is:
- A background process
- Managed by the CLR
- Responsible for freeing heap memory

GC removes objects that:
- Are no longer reachable
- Have no active references

Developers do NOT control exactly:
- When GC runs
- Which objects are collected

---

## 5. Important Clarification

Setting a variable to `null`:
- Removes one reference
- Does NOT delete the object

If other references exist:
- The object remains alive

GC runs only when the runtime decides it is necessary.

---

## 6. Deterministic vs Non-Deterministic Lifetime

Stack data:
- Deterministic
- Destroyed immediately when method ends

Heap objects:
- Non-deterministic
- Destroyed sometime after becoming unreachable

This distinction explains why:
- GC exists
- Developers should not rely on finalization timing

---

## 7. Common Misconceptions

Incorrect:
- “Objects are destroyed when methods end”
- “GC runs immediately”
- “Calling GC.Collect() is good practice”

Correct:
- Objects live as long as references exist
- GC timing is unpredictable
- Manual GC calls are usually harmful

---

## 8. Why Object Lifetime Matters

Understanding lifetime helps:
- Avoid memory leaks
- Prevent holding unnecessary references
- Design correct APIs
- Reason about async and static data

Many production memory issues are caused by:
- Objects staying alive longer than expected

---

## 9. Interview Explanation (Clear & Strong)

> “Objects in C# live on the heap and remain alive as long as they are reachable through references. When no references exist, they become eligible for garbage collection, which runs at a non-deterministic time.”

---

## 10. Next Step

Next, we will introduce:
- Garbage Collection internals
- Why generations exist
- How performance is affected
