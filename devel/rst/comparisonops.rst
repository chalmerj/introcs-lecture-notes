.. index:: boolean expression; condition; comparison
   
.. _More-Conditional-Expressions:
    
More Conditional Expressions
----------------------------

All the usual arithmetic comparisons may be made, but many do not
use standard mathematical symbolism, mostly for lack of proper keys
on a standard keyboard.
 
=====================  ===========  ==============
Meaning                Math Symbol  C# Symbols
=====================  ===========  ==============
Less than              <            ``<`` 
Greater than           >            ``>``
Less than or equal     ≤            ``<=``
Greater than or equal  ≥            ``>=``
Equals                 =            ``==``
Not equal              ≠            ``!=``
=====================  ===========  ============== 

There should not be space between the two-symbol C#
substitutes.

Notice that the obvious choice for *equals*, a single equal sign,
is *not* used to check for equality. An annoying second equal sign
is required. This is because the single equal sign is already used
for *assignment* in C#, so it is not available for tests.

.. warning::
   It is a common error to use only one equal sign when you mean to *test*
   for equality, and not make an assignment!

Tests for equality do not make an assignment, and they do not
require a variable on the left. Any expressions can be tested for
equality or inequality (!=). They also work for strings!
Predict the results and try each line in csharp::

    x = 5; 
    x; 
    x == 5; 
    x == 6; 
    x; 
    x != 6; 
    x = 6; 
    6 == x; 
    6 != x; 
    "hi" == "h" + "i"; 
    "HI" != "hi";  

An equality check does not make an assignment. Strings are case
sensitive. 

Following up on the discussion of the *inexactness* of float
arithmetic, confirm that C#
does not consider .1 + .2 to be equal to .3: Write a simple
condition into csharp to test.

Here is another example: Pay with Overtime. Given a person's work
hours for the week and regular hourly wage, calculate the total pay
for the week, taking into account overtime. Hours worked over 40
are overtime, paid at 1.5 times the normal rate. This is a natural
place for a function enclosing the calculation.

*Read* the setup for the function:

.. literalinclude:: examples/Wages1.cs
   :lines: 5-8

The problem clearly indicates two cases: when no more than 40
hours are worked or when more than 40 hours are worked. In case
more than 40 hours are worked, it is convenient to introduce a
variable overtimeHours. You are encouraged to think about a
solution before going on and examining mine.

You can try running my complete example program, :file:`Wages1.cs`, 
also
shown below. The program uses the keyboard input functions
developed in class.  If shows an alternate convention for braces
after ``if`` or ``else``, with the opening brace on the same line.

.. literalinclude:: examples/Wages1.cs
   
This program also introduces new notation for 
displaying decimal numbers:  Inside the format string, inside 
the braces, after the parameter index, you see ``:F2``.  That
means display in the fixed format rounded to 2 places beyond the decimal
point.  This is appropriate for money with dollars and cents.  
Replace the 2 to display
a different number of digits after the decimal point.
More formatting instructions will be discussed later.

Below is an equivalent alternative version of the body of
``calcWeeklyWages``, used in ``Wages2.cs``. It uses just one
general calculation formula and sets the parameters for the formula
in the ``if`` statement. There are generally a number of ways you might
solve the same problem!

.. literalinclude:: examples/Wages2.cs
   :lines: 8-20


.. _graduateEx:
   
Graduate Exercise
~~~~~~~~~~~~~~~~~
   
Write a program, ``graduate.cs``, that prompts students for how
many credits they have. Print whether of not they have enough
credits for graduation. (At Loyola University Chicago 120 credits
are needed for graduation.)

.. need random first

	Head or Tails Exercise
	~~~~~~~~~~~~~~~~~~~~~~
	
	Write a program ``headstails.cs``. It should include a function ``flip()``,
	that will randomly prints ``Heads`` or ``Tails``.
	Accomplish this by choosing 0 or 1 arbitrarily with ``random.randrange(2)``,
	and use an |if-else|
	statement to print ``Heads``
	when the result is 0, and ``Tails`` otherwise.
	
	In your main program have a simple repeat loop that calls ``flip()``
	10 times to test it, so you generate a random sequence of 
	10 ``Heads`` and
	``Tails``.

.. need loops
	.. _Strange-Func-Ex:
	
	Strange Function Exercise
	~~~~~~~~~~~~~~~~~~~~~~~~~
	
	Save the example program ``jumpFuncStub.cs`` as ``jumpFunc.cs``,
	and complete the definitions of functions ``jump`` and ``main`` as
	described in the function documentation strings in the program.
	In the ``jump`` function definition use an |if-else|
	statement.  Hint [#oddeven]_
	In the ``main`` function definition
	use a |for-each| loop, the range function, and the jump function.
		
	The ``jump`` function is introduced for use in
	:ref:`Strange-Seq-Ex`, and others after that.
	
	.. comment
	   ]]
	
	.. [#oddeven]
	   If you divide an even number by 2, what is the remainder?  Use this idea
	   in your ``if`` condition.
   
