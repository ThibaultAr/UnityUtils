# UnityUtils
Utility methods for unity which are not in unity shell.

Feel free to take what you need :)

## Methods
### Math
*`int 	mod (int a, 	int b)`*

*`float 	mod (float a, 	float b)`*

Modulo where negative return at top, useful for Array/Lists.

Examples
```
mod(1, 	3)  => 1
mod(3, 	3)  => 0
mod(-1, 3)  => 2
mod(-2, 3)  => 1
```

### GameObject
*`GameObject FirstChildWithTag(GameObject Parent, string tag)`*

Search the first child of *`Parent`* with a specific *`tag`*.

*`List<GameObject> FindChildWithTag(GameObject Parent, string tag)`*
Search all children of *`Parent`* with a specific *`tag`*.
