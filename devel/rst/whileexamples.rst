While Examples
==============


.. todo::

   "sum of first N numbers using loop & Euler formula"

.. todo::

   "bisection method"

.. todo::

   "gcd naive (loop 2 -> max(a, b)"

.. todo::

   "gcd subtraction method"

.. todo::

   "gcd recursive definition and solution"

Savings Exercise
~~~~~~~~~~~~~~~~

The idea here is to see how many years it will take a bank account to grow
to at least a given value, assuming a fixed annual interest.
Write a program ``Savings.cs``.
Prompts the user for three numbers: an initial balance, the annual percentage
for interest as a decimal. like .04 for 4%, and the final balance desired.
Print the initial balance, and the balance each year until
the desired amount is reached. Round displayed amounts
to two decimal places, as usual.

The math:  The amount next year is the amount now times
(1 + interest fraction),
so if I have $500 now and the interest rate is .04,
I have $500*(1.04) = $520 after one year, and after two years I have,
$520*(1.04) = $540.80.
If I enter into the program a $500 starting balance, .04 interest rate and
a target of $550, the program prints::

   500.00
   520.00
   540.80
   563.42
