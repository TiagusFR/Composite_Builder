Composite Builder Pattern based on the following scenario: "The entity 'Person" have two different aspects 'Adress' and 'Employment Info'. How can it be done in two separate builders?"


-PersonBuilder: To reference the Entity itself. Also is initialized only in the public parameterless constructor. So, the next constructor saves this reference and is used by it's inheritors and not by the client.
Then, 'Lives' and 'Works' properties returns builder facets. 

-PersonAdressBuilder and PersonJobBuilder are fluent interfaces. Inheriting from 'PersonBuilder' 'Lives' and 'Works' member fucntions. 


(This aproach is not extensible)
