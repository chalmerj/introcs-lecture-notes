
.. index::
   triple: homework; input-output; decisions
   triple: homework; input-output; loops
   
.. _homework-grade-calculation2:

Homework: Grade Calculation from Individual Scores
==================================================

In the previous assignment, we calculated grades based on a *memorized* 
overall grade within each of the categories below:

- exams - 40% (integer weight is 40)
- labs - 15% (weight 15)
- homework - 15% (weight 15)
- project - 20% (weight 20)
- participation - 10% (weight 10)

In this assignment, we are going to change the specification slightly
to make the program a bit smarter. Instead of someone having to remember
what their average grade was for each category, we will prompt the user for
the number of items within each category (e.g. number of exams, number
of labs, etc.), have the user enter individual grades, and have the program
calculate the average for the category.

As usual, we will begin by specifying *requirements*. Whenever required,
we will explain how you would approach the solution to the requirement
in C#.  User responses are shown **bold faced**.

Requirements
------------

#. Add code to prompt the user for the number of items in each category:

      Please enter the number of exams: **3**

#. Instead of prompting the user for an overall average 
   exam grade, use a loop to 
   read one grade at a time. The grades will be added together (on the fly)
   to give the grade for that category. For example, after you have asked
   for the number of exams, you'd prompt the user to enter each exam 
   grade and have the program compute the sum. 
   To make sure everyone understands what should
   be happening, you should also print a *running total* of the grade 
   category you're calculating:

     | Please enter the grade for exam 1: **100**
     | Total exam points: 100
     |
     | Please enter the grade for exam 2: **90**
     | Total exam points: 190
     |
     | Please enter the grade for exam 3: **80**
     | Total exam points: 270
     |
     | Calculated average exam grade = 90.0

   Write a function to do this that can be reused for each
   category.  (Since it works for each category, the category
   name will need to be a parameter.)

#. Once you have read in the data for each of the items within a category,
   you'll basically be able to *reuse* the code that you developed in the
   previous assignment to compute the weighted average and print the
   final letter grade.

#. For this assignment, you are expected to start using functions for all
   aspects of the assignment. For example, it can become tedious in a hurry
   to write code to prompt for each of exams, labs, homeworks, etc. when 
   a single function (with parameter named *category*) could be used to
   avoid repeating yourself. (And per the Hints section, you will also
   want to write your function to take advantage of our *input* 
   functions.

#. Also beginning with this assignment, it is expected that your work 
   will be presented neatly. That is, we expect the following:

   - proper indentation that makes your program more readable by other
     humans.

   - proper naming of variables and functions. In C#, the convention is to
     begin a name with a capital letter. You can have multiple words in a
     function name, but these should be capitalized using a method known as 
     CamelCase [CamelCase]_. We also recommend this same naming convention
     for variables but with a lowercase first letter. For variables, we are also
     ok with the use of underscores. For example, in homework 1 we used
     names like `exam_grade`. If you use CamelCase, you can name this
     variable `examGrade`. 

   - If you have any questions about the neatness or appearance of your 
     code, please talk to the instructor or teaching assistant.

   - This guide from CIS 193 at [UPennCSharp]_ provides a nice set of conventions
     to follow. We include this here so you know that other faculty at 
     other universities also consider neatness/apperance to be important.

Hints
-----

This assignment will be the first one where you need to start using 
functions. Otherwise, you'll find yourself getting tired within minutes
of starting your work.`

You need to have two functions to prompt the user to input 
integer and double
data. We're going to give you the code for these here and in 
example ``PromptUser1.cs``.  Your job is to
copy them into your program and make use of them in your solution.  The
first function is
a supporting function to return a string in response to a prompt.
These versions are sufficient for the assignment, 
though you are *welcomed* to replace these
with more *robust* versions that get developed in class later:

.. literalinclude:: examples/PromptUser1.cs
   :start-after: chunk
   :end-before: chunk
   
.. [CamelCase] http://en.wikipedia.org/wiki/CamelCase

.. [UPennCSharp] http://www.cis.upenn.edu/~cis193/csstyle.html
