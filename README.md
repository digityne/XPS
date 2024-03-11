# XPS

Set up a Class Library (XPS services), and a unit test project to start.

Have looked online for Roman Numeral "Rules" - have basic knowledge but need strong definition.
https://byjus.com/maths/roman-numerals

Best approach seems to be in the examples at the bottom - break any number into its decimal units
(i.e. 1s, 10s, 100s, 1000s) and then convert each of these to a value

Set up interface in service layer and think about which functions need exposed to an API and which can be internal

Also define roman numerals in a const class (I = 1, V = 5 etc.)

Also thinking about confines of initial task and good error handing:
Number must be between 1 and 2000 (assume inclusive), no decimals, no negatives.

Trying a TDD approach - write a test, code for it, refactor
Starting with breaking a number into decimal units...

Moved this to a common project and spent too long having fun with it!
