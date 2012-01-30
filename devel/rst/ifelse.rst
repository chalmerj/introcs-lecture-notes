
.. index:: if-else

.. _if-else-Statements:
    
``if-else`` Statements
----------------------------

Run the example program, ``clothes.cs``. Try it at least twice, with
inputs 50 and then 80. As you can see, you get different results,
depending on the input. The main code of ``clothes.cs`` is:

.. literalinclude:: examples/clothes.cs
   :lines: 7-13
   :linenos:

The lines labeled 3-6 are an ``if-else`` statement. Again it is
close to English, though you might say "otherwise" instead of
"else" (but else is shorter!). There are two indented statements:
One, like in the simple ``if`` statement, comes right after the
``if`` condition and is executed when the condition  is true. 
In the ``if-else`` form this is followed by an
``else`` (on its own line by convention), 
followed by another indented statement that is only
executed when the original condition is *false*. In an ``if-else``
statement exactly one of two possible indented statements is executed.

A final line is also shown that is not indented, about getting exercise.
The `if` and `else` clauses each only embed a single statement
as option, so the last statement is not part of the ``if-else``
statement.  Instead it is a part of the normal sequential
flow of statements.  It is *always* executed after the
``if-else`` statement, no matter what happens inside the
``if-else`` statement.  Again:  inside the ``if-else`` there is a
choice made, but the whole ``if-else`` construction is a single
larger statement, which exists in the normal sequential flow.
The compiler does not require the indentation of the if-true-statement
and the if-false-statement, but it is a standard style convention. 

The general C# ``if-else`` syntax is

    | ``if`` *condition* : 
    |    statement (or compound statement in braces) for true condition 
    | ``else``
    |    statement (or compound statement in braces) for false condition 


The statement chosen based on the condition 
can be any kind of statement.  When the statement is a compound
statement, it can contain any kinds of statements.
