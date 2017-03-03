### QuickStart ###

To map an object to another, implement IMappableTo<TTarget>

```
using SimpleMapping;

public class Obj : IMappableTo<TargetObj>
{
    public TargetObj Map(Obj obj)
    {
        // map properties...
    }
}
```

Then use it...

```
using SimpleMapping;

public class MyClass
{
    public void MyMethod(Obj obj)
    {
        // Can map type Obj here...
        var target = obj.Map();
    }
}
```

In some instances, the assembly containing the target type may reference the assembly containing the source type, so mapping like this isn't possible. You can do the reverse process by populating the target:

```
using SimpleMapping;

public class TargetObj : IPopulatableFrom<Obj>
{
    public void Populate(Obj source)
    {
        // Map properties from source
    }
}
```

Then use it...

```
using SimpleMapping;

public class MyClass
{
    public void MyMethod(Obj source)
    {
        // Can populate targetObj after instansiation
        var targetObj = new TargetObj();
        targetObj.PopulateFrom(source);
    }
}
```
