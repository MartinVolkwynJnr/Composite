Definition
Compose objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly.

Composite: when and where you would use it
The Composite design pattern is an in-memory data structures with groups of objects, each of which contain individual items or other groups. A tree control 
is a great example of a Composite pattern. The nodes of the tree either contain an individual object (leaf node) or a group of objects (a subtree of nodes).
All nodes in the Composite pattern share a common interface which supports individual items as well as groups of items. This common interface greatly facilitates 
the design and construction of recursive algorithms that iterate over each object in the Composite collection.

Fundamentally, the Composite pattern is a collection that you use to build trees and directed graphs. It is used like any other collection, such as, arrays, list,
stacks, dictionaries, etc.


.NET optimized sample code
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features. The composite pattern is a great candidate for generics
and you will find these used throughout this example. A generic TreeNode<T> was created (TreeNode(Of T) in VB). This is an open type which has the ability to accept 
any type parameter. The TreeNode has a generic constraint in which type T must implement the IComparable<T> interface (IComparable(Of T) in VB). The class named Shape
does implement this generic interface so that comparisons can be made between shape objects. This facilitates the process of adding and removing shapes from the list 
of tree nodes. This code demonstrates much of the power that generics offer to .NET developers.

