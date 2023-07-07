"Inline Function" is a refactoring technique that's essentially the reverse of "(106) Extract Function". With "Inline Function", if a function's body is as clear as its name, you replace calls to the function with the function's content, and then remove the function itself. 

This can be a way to remove unnecessary indirection and improve performance in some cases.