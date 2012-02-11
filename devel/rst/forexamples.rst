Examples With ``for`` Statements
==================================

.. todo::

   Print ordinal value and actual character value of printable ASCII characters

.. todo::

   Sum reworked from while to for.

.. todo::

   Print first N multiples of a given number.

.. todo::

   Do some of these examples backwards.

.. todo::

   Reversing a string...

.. todo::

   Palindrome

.. todo::
   ASCII art, triangles; see for loop lab.

.. todo::
   Make restructred text table with fixed rows, columns, and width empty content.

.. todo::
   Repeat string N times.


Head or Tails Exercise
~~~~~~~~~~~~~~~~~~~~~~

Write a program ``HeadsTails.cs``. It should include a function ``Flip()``,
that will randomly prints ``Heads`` or ``Tails``.
Accomplish this by choosing 0 or 1 arbitrarily with a random
number generator.  Recall in :ref:`lab-number-game`::

  Random r = new Random();
  
Then, for ``int``\ s ``low`` and ``higher``, with ``low < higher``::
 
    int n = r.Next(low, higher);

returns a (pseudo) random ``int``, satisfying ``low <= n < higher``.
If you select ``low`` and ``higher`` so there are only two possible values
for n,
then you can choose to print ``Heads`` or ``Tails`` with an
|if-else| statement based on the result.
	
In your Main method have a ``for`` loop calling  ``Flip()``
10 times to test it, so you generate a random sequence of 
10 ``Heads`` and/or
``Tails``.

