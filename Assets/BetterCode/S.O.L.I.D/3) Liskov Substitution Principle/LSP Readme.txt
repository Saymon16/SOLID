Every subclass/derived class should be substitutable for their base/parent class. This principle ensures that a subclass can always be used in place of its parent class without causing issues.

Use case: Creating a Weapon base class with a Fire method, then subclasses like Gun, Rifle, Shotgun can all replace Weapon and use their own implementation of Fire.