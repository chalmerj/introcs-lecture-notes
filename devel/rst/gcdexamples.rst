More While Examples
===================


Greatest Common Divisor
-----------------------

The *greatest common divisor* of two non-zero integers is a great
example to illustrate the power of loops. Everyone learns about the
*concept* of a greatest common divisor when faced with a fraction that
is not in *reduced* form.

Consider the fraction :math:`\frac{2}{4}`, which is the same as
:math:`\frac{1}{2}`. This fraction can be reduced, because the
numerator and denominator both have greatest common factor of 2. That
is, :math:`\frac{2}{4} = \frac{1 \cdot 2}{2 \cdot 2}`. So the factor of 2 can
be canceled from both the numerator and the denominator.

Euclid (the mathematician from classic times and author of *Elements*)
is credited with having come up with a clever algorithm for how to
compute the greatest common divisor efficiently. It is written as
follows, where :math:`a \bmod b` means ``a % b`` in C#.

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
of 10 and 15 is 5. Let's use Euclid's method to verify this:

- :math:`gcd(10, 15) = gcd(15, 10 \bmod 15) = gcd(15, 10)`

- :math:`gcd(15, 10) = gcd(10, 15 \bmod 10) = gcd(10, 5)`

- :math:`gcd(10, 5) = gcd(5, 10 \bmod 5) = gcd(5, 0)`

- :math:`gcd(5, 0) = 5`


Notice that in the example above, the first number (10) was smaller than 
the second (15), and the first transformation just swapped the numbers,
so the larger number was first.  Thereafter the first number is always
larger.

In other words, Euclid's method is smart enough to work for 10 and 15
and 15 and 10. And it must. After all, the greatest common divisor of
these two numbers is always 5 as the order doesn't matter.

GCD "Brute Force" Method
------------------------
.. todo::

   "gcd naive (loop 2 -> max(a, b)"

.. literalinclude:: examples/gcdbruteforce.cs
   :start-after: chunk-GCDBF-begin
   :end-before: chunk-GCDBF-end
   :linenos:


GCD Subtraction Method
----------------------

.. todo::

   "gcd subtraction method"


.. literalinclude:: examples/gcdsubtraction.cs
   :start-after: chunk-GCDSM-begin
   :end-before: chunk-GCDSM-end
   :linenos:


Preview: Recursive GCD
----------------------

As it turns out, we can transform the earlier definition of greatest
common divisor (as formulated by Euclid) directly into C# using a
technique known as *recursion*, where a function calls *itself*
inside its definition. We don't expect you to master this
technique immediately but do feel that it is important you at least
*hear* about it and see its tremendous power:

.. literalinclude:: examples/gcd.cs
   :start-after: chunk-Euclid-begin
   :end-before: chunk-Euclid-end
   :linenos:


- Recalling our earlier definition, the case :math:`gcd(a, 0) = a` is
  handled by lines 3-6.

- And the case :math:`gcd(a, b) = gcd(b, a \bmod b)` is handled by
  line 11.

- Lines 4 and 8-10 exist to show you all of the *steps* that Euclid's
  algorithm takes to compute the greatest common divisor.

The mathematical definition of gcd *refers to itself* in its own definition.  
The recursive version of the ``gcd`` function *refers to itself*
by *calling* itself.  Though this seems circular, you can see
from the examples that it works very well.  The important point is that
the calls to the same function are not completely the same:
*Successive* calls have *smaller* second numbers, and the second
number eventually reaches 0, and in that case 
there is a direct final answer.
