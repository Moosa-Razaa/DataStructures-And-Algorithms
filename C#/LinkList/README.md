#### Linked List
---

`LinkedListBase` contains all the most prominent methods used in Lists. 

I've implemented the abstract class to a concrete class `NumericList` in order to demonstrate how to implement `LinkedListBase`.

If you want to implement a __reference type__ as the type of the class then you can implement it like:

```c#
class NewImplementation<T> : LinkedListBase<T> where T : class, new()
{
    //Here you can implement the abstract methods.
}
```