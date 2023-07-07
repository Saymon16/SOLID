The idea behind "Encapsulate Variable" is that you should minimize direct access to data. If an object needs to get or change some data, it should not access the data directly, but through a method of the object that holds the data.

This provides a lot of benefits, like:

Controlling who and how the data is accessed or modified.
You can add extra behavior when data is accessed or modified, such as validation or event triggering.
You can change the underlying data representation without changing the way other objects interact with it.