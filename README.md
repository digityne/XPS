# XPS - Roman Numeral Conversion Solution

- I set up a services and common library to exemplify some n-tier architecture and facilitate TDD
(which I tried to use for the most part).

- I ensured all aspects were working through tests before finally implementing a Console App to act as the UI.

- I looked online for Roman Numeral "Rules" - I have basic knowledge but needed a strong definition.
https://byjus.com/maths/roman-numerals

- The best explanation for the rules was in the examples at the bottom;
- - break any number into its decimal units
- - (i.e. 1s, 10s, 100s, 1000s), convert each of these to a roman numeral and string them together

- Also thought about the parameters of the initial task and good error handing:
- - A number must be between 1 and 2000 (assumed inclusive) and not be a decimals or a negative.

- Room for improvements
- - Some of the test data rows are a bit much
	- Could load large data sets from a file to test against
- - Scalability
	- I'd liked to have put the template .Replace() functions in a loop, 