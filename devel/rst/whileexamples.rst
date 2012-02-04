While Examples
==============

.. todo::

   "number guessing game with randomness for the secret number"

.. todo::

   "sum of first N numbers using loop & Euler formula"

.. todo::

   "bisection method"


Greatest Common Divisor
-----------------------

The *greatest common divisor* of two non-zero integers is a great
example to illustrate the power of loops. Everyone learns about the
*concept* of a greatest common divisor when faced with a fraction that
is not in *reduced* form.

Consider the fraction :math:`\frac{2}{4}`, which is the same as
:math:`\frac{1}{2}`. This fraction can be reduced, becuase the
numerator and denominator both have greatest common factor of 2. That
is, :math:`\frac{2}{4} = \frac{1 . 2}{2 . 2}`. So the factor of 2 can
be cancelled from both the numerator and the denominator.

Euclid (the mathematician from classic times and author of *Elements*)
is credited with having come up with a clever algorithm for how to
compute the greatest common divisor efficiently. It is written as
follows:

.. math::

   gcd(a, b) = gcd(b, a \bmod b)

   gcd(a, 0) = a


It is common in mathematics to list functions as one or more
*cases*. The way you read this is as follows:

- In general, the greatest common divisor of ``a`` and ``b`` is the
  same as computing the greatest common divisor of ``b`` and the
  remainder of ``a`` divided by ``b``. 

- In the case where ``b`` is zero, the result is ``a``. This makes
  sense because ``a`` divides itself and 0.

To gain some appreciation of how the definition *always* allows you to
compute the greatest common divisor, it is worthwhile to try it out
for a couple of numbers where you *know* the greatest common
divisor. For example, we already know that the greatest common divisor
of 25 and 35 is 5. Let's use Euclid's method to verify this:

- :math:`gcd(10, 15) = gcd(15, 10 \bmod 15) = gcd(15, 10)`

- :math:`gcd(15, 10) = gcd(10, 15 \bmod 10) = gcd(10, 5)`

- :math:`gcd(10, 5) = gcd(5, 10 \bmod 5) = gcd(5, 0)`

- :math:`gcd(5, 0) = 5`


It's also worthwhile to take a look at what happens when you try to
compute the greatest common divisor of 15 and 10 (i.e. where the
values are swapped):

- :math:`gcd(15, 10) = gcd(10, 15 \bmod 10) = gcd(10, 5)`
- :math:`gcd(10, 5) = gcd(5, 10 \bmod 5) = gcd(5, 0)`
- :math:`gcd(5, 0) = 5`

In other words, Euclid's method is smart enough to work for 10 and 15
and 15 and 10. And it must. After all, the greatest common divisor of
these two numbers is always 5 as the order doesn't matter.


GCD "Brute Force" Method
------------------------
.. todo::

   "gcd naive (loop 2 -> max(a, b)"

GCD Subtraction Method
----------------------

.. todo::

   "gcd subtraction method"


Preview: Recursive GCD
----------------------

As it turns out, we can transform the earlier definition of greatest
common divisor (as formulated by Euclid) directly into C# using a
technique known as *recursion*. We don't expect you to master this
technique immediately but do feel that it is important you at least
*hear* about it and see its tremendous power:

.. literalinclude:: examples/gcd.cs
   :start-after: snip-Euclid-begin
   :end-before: snip-Euclid-end
   :linenos:


- Recalling our earlier definition, the case :math:`gcd(a, 0) = a` is
  handled by lines 2-4.

- And the case :math:`gcd(a, b) = gcd(b, a \bmod b)` is handled by
  line 7.

- Lines 3 and 6 exist to show you all of the *steps* that Euclid's
  algorithm takes to compute the greatest common divisor.
