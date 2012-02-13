Examples With ``for`` Statements
==================================

Thus far all of our ``for`` loops have used a sequence of successive integers.
Suppose you want to print the first ``n`` multiples of ``k``, 
like the first 5 multiples
of 3:  3, 6, 9, 12, 15.  This could be handled by generating
a sequence ``i`` = 1 through ``n``, and multiply each ``i`` by ``k``::

    for (int i = 1; i <= n; i++) {
       Console.WriteLine(i*k);
    }
    
Another approach is to note that the numbers you want to print advance
in a regular fashion, too, but with an increment 3 in the example above,
or k in general::

    for (int i = k; i <= n*k; i = i+k) {
       Console.WriteLine(i);
    }

The ::

   i = i + k;
   
is a common pattern, less common than incrementing by one, 
but still very common.  C# and many other languages allow a shorter version::

   i += k;
   
This means to increment the variable i by k.  Be careful, the ``+=`` must be in
that order, with no space between.  Unfortunately ::

  i =+k;
  
is also legal, and just assigns the value of k to i.

.. index::
   double operator; +=
   double operator; -=
   double operator; *=
   double operator; /=
   double operator; %=

Most C# binary operations have a similar variation.  For instance
if *op* is ``+``, ``-``, ``*``, ``/`` or ``%``,

    **variable** *op*\ = *expression*
    
means the same as

    **variable** = **variable** op *expression*
    
For example ::

    x *= 5;
    
is the same as  ::

    x = x * 5;

.. todo::

   table of square, cube, and square root.
   
   field width formatting
    
.. index:: 
   double: ASCII; example
   
.. _ASCII:

Here is the reverse of the 
:ref:`Numeric Code of String Characters <codeofstringchar>`:  
Find the characters for a list of numeric codes. Just as we can cast a
``char`` to an ``int``, we can cast an ``int`` 0-127 to a ``char``.

The Unicode used
by C# is an extension of the ASCII codes corresponding to the
characters on a US keyboard.  The codes were originally 
USED to drive printers,
and the first 32 codes are non-printable instructions to the printer.
Characters 32 - 126 yield the 95 characters on a standard US keyboard.

A loop to print each code followed by a space and the corresponding 
printable character
would be::

   for (int i = 32; i < 127; i++) {
      Console.WriteLine("{0} {1}", i, (char)i);
   }

The first line printed does not appear to have a character:  That is the
blank character.  All the other characters are visible.

Part of the output is::

	98 b
	99 c
	100 d
	101 e

The characters do not line up, because the 
integer codes do not all have the same number of digits.
That is a formatting issue.We have already seen how we can give formatting
instructions to get decimal answers rounded to a specified number of digits.
We can also pad values so they take up the same number of columns.  
The only change below is replacing ``{0}`` by ``{0, 3}``.  This means that
is the resulting string is less than 3 characters long, 
it is padded on the left with blanks to be 3 characters wide::

   for (int i = 32; i < 127; i++) {
      Console.WriteLine("{0, 3} {1}", i, (char)i);
   }

Now the same part of the output is::

	 98 b
	 99 c
	100 d
	101 e

Let us make a more concise table, putting 8 entries per line.
We can print successive parts use ``Write`` not ``WriteLine``,
but we still need to advance to the next line after every 8th
entry, for 39, 47, 55, ....
Since they are 8 apart, their remainder when divided by 8 is always
the same:  

    7 = 39 % 8 = 47 % 8 = 55 % 8 = ....

We can add a newline after each of these is printed.  This requires a test::

   for (int i = 32; i < 127; i++) {
      Console.Write("{0, 3} {1}  ", i, (char)i);
      if (i % 8 == 7) {
         Console.WriteLine();
      }
   }

Paste that whole code at once into csharp to see the result.

The next csharp> prompt appears right after ``126 ~``.  
There is no eighth entry on the last line, and hence no advance to the
next line.  A program printing this table should include an extra 
``Console.WriteLine()`` after the loop.

.. todo::

   Do some of these examples backwards.

.. todo::

   Reversing a string...

.. todo::

   Palindrome

.. todo::
   ASCII art, triangles; see for loop lab.

.. todo::
   Make restructured text table with fixed rows, columns, and width empty content.

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

