
.. index:: if-else

.. _if-else-Statements:
    
|if-else| Statements
----------------------------

Run the example program, ``Clothes.cs``. Try it at least twice, with
inputs 50 and then 80. As you can see, you get different results,
depending on the input. The main code of ``Clothes.cs`` is:

.. literalinclude:: examples/Clothes.cs
   :start-after: chunk
   :end-before: chunk
   :linenos:

The lines labeled 3-8 are an |if-else| statement. Again it is
close to English, though you might say "otherwise" instead of
"else" (but else is shorter!). There are two indented statements
in braces:
One, like in the simple ``if`` statement, comes right after the
``if`` condition and is executed when the condition  is true. 
In the |if-else| form this is followed by an
``else`` (lined up under the ``if`` by convention), 
followed by another indented statement enclosed in braces that is only
executed when the original condition is *false*. In an |if-else|
statement exactly one of two possible parts in braces is executed.

A final line is also shown that is not indented, about getting exercise.
The `if` and `else` clauses each only embed a single statement
as option, so the last statement is not part of the |if-else|
statement.  Instead it is a part of the normal sequential
flow of statements.  It is *always* executed after the
|if-else| statement, no matter what happens inside the
|if-else| statement.  Again:  inside the |if-else| there is a
choice made, but the whole |if-else| construction is a single
larger statement, which exists in the normal sequential flow.
The compiler does not require the indentation of the if-true-statement
and the if-false-statement, but it is a standard style convention. 

The general C# |if-else| syntax is

    | ``if (`` *condition* ``) {``   
    |    statement(s) for if-true  
    | ``}``
    | ``else {``
    |    statement(s) for if-false 
    | ``}``


The statements chosen based on the condition 
can be any kind of statement.  This is the suggested form, but
as with the plain ``if`` statement, the if-true compound statement or 
the if-false compound statement can be replace by a single statement
without braces, except in one otherwise ambiguous situation discussed
later with two ``if``\ s and an ``else``.
