.. index::
   triple:  &&; and; boolean operation

.. _Compound-Boolean-Expressions:
   
Compound Boolean Expressions
----------------------------

.. todo::

   Compound Boolean Expression translation
	
..  python

	To be eligible to graduate from Loyola University Chicago, you must
	have 120 credits *and* a GPA of at least 2.0. This
	translates directly into C# as a *compound condition*::
	
		credits >= 120 && GPA >=2.0      
	
	This is true if both ``credits >= 120`` is true and
	``GPA >= 2.0`` is
	true. A short example program using this would be::
	
		credits = input('How many units of credit do you have? ') 
		GPA = input('What is your GPA? ') 
		if credits >= 120 and GPA >=2.0: 
			print('You are eligible to graduate!') 
		else: 
			print('You are not eligible to graduate.') 
	
	
	The new C# syntax is for the operator ``and``:
	
		*condition1* ``&&`` *condition2*
	
	The compound condition is true if both of the component conditions
	are true. It is false if at least one of the conditions is false.
	
	See :ref:`congressEx`.
	
	
	.. _congressEx:
	
	Congress Exercise
	~~~~~~~~~~~~~~~~~
	   
	A person is eligible to be a US Senator who is at least 30 years
	old and has been a US citizen for at least 9 years. Write a version
	of a program ``congress.cs`` to obtain age and length of
	citizenship from the user and print out if a person is eligible to
	be a Senator or not. A person is eligible to be a US Representative
	who is at least 25 years old and has been a US citizen for at least
	7 years. Elaborate your program ``congress.cs`` so it obtains age
	and length of citizenship and prints whether a person is eligible
	to be a US Representative only, or is eligible for both offices, or
	is eligible for neither.
