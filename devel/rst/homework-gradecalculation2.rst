
.. index::
   triple: homework; input-output; decisions
   triple: homework; input-output; loops
   
.. _homework-grade-calculation2:

Homework: Grade Calculation from Individual Scores
==================================================

In the previous assignment, we calculated grades based on a *memorized* 
grade within each of the categories below:

- exams - 40% (integer weight is 40)
- labs - 15% (weight 15)
- homework - 15% (weight 15)
- project - 20% (weight 20)
- participation - 10% (weight 10)

In this assignment, we are going to change the specification slightly
to make the program a bit smarter. Instead of someone having to remember
what their grade for each category was, we will prompt the user for
the number of items within each category (e.g. number of exams, number
of labs, etc.) 

As usual, we will begin by specifying *requirements*. Whenever required,
we will explain how you would approach the solution to the requirement
in C#.

Requirements
------------

#. Add code to prompt the user for the number of items in each category::

      Please enter the number of exams?
      3

#. Instead of prompting the user for an exam grade, use a loop to 
   read one grade at a time. The grades will be added together (on the fly)
   to give the grade for that category. For example, after you have asked
   for the number of exams, you'd prompt the user to enter each exam 
   grade and compute the sum. To make sure everyone understands what should
   be happening, you should also print a *running total* of the grade 
   category you're calculating::


     Please enter the grade for exam 1:
     100
     Total exam points: 100

     Please enter the grade for exam 2:
     90
     Total exam points: 190

     Please enter the grade for exam 3:
     80
     Total exam points: 270

     Calculated exam grade = 90.0

   This will be repeated for all categories.

#. Once you have read in the data for each of the items within a category,
   you'll basically be able to *reuse* the code that you developed in the
   previous assignment.

Hints
-----

This assignment will be the first one where you need to start using 
functions. Otherwise, you'll find yourself getting tired within minutes
of starting your work.`

You need to have two functions to prompt the user for integer and double
data. We're going to give you the code for these here, but your job is to
copy them into your program and make use of them in your solution.


This function (or method) will prompt the user to enter an integer.

   .. literalinclude:: examples/promptuser.cs
      :start-after: snip-ReadInteger-begin
      :end-before: snip-ReadInteger-end
   

This function (or method)  will prompt the user to enter a double.

   .. literalinclude:: examples/promptuser.cs
      :start-after: snip-ReadDouble-begin
      :end-before: snip-ReadDouble-end


