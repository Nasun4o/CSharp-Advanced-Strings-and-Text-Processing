# CSharp-Advanced-Strings-and-Text-Processing
Advanced CSharp

Problem 1.	Reverse String
Write a program that reads a string from the console, reverses it and prints the result back at the console.
Input	Output
sample	elpmas
24tvcoi92	29iocvt42

Problem 2.	String Length
Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *. Print the resulting string on the console.
Examples:
Input	Output
Welcome to SoftUni!	Welcome to SoftUni!*
a regular expression (abbreviated regex or regexp and sometimes called a rational expression) is a sequence of characters that forms a search pattern	a regular expression
C#	C#******************

Problem 3.	Count Substring Occurrences
Write a program to find how many times a given string appears in a given text as substring. The text is given at the first input line. The search string is given at the second input line. The output is an integer number. Please ignore the character casing. Overlapping between occurrences is allowed. Examples:
Input	Output
Welcome to the Software University (SoftUni)! Welcome to programming. Programming is wellness for developers, said Maxwell.
wel	4

aaaaaa
aa	5
ababa caba
aba	3
Welcome to SoftUni
Java	0

Problem 4.	Text Filter
Write a program that takes a text and a string of banned words. All words included in the ban list should be replaced with asterisks "*", equal to the word's length. The entries in the ban list will be separated by a comma and space ", ".
The ban list should be entered on the first input line and the text on the second input line. Example:
Input	Output
Linux, Windows
It is not Linux, it is GNU/Linux. Linux is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/Linux! Sincerely, a Windows client	It is not *****, it is GNU/*****. ***** is merely the kernel, while GNU adds the functionality. Therefore we owe it to them by calling the OS GNU/*****! Sincerely, a ******* client

Problem 5.	Unicode Characters
Write a program that converts a string to a sequence of C# Unicode character literals. Examples:
Input	Output
Hi!	\u0048\u0069\u0021
What?!?	\u0057\u0068\u0061\u0074\u003f\u0021\u003f
SoftUni	\u0053\u006f\u0066\u0074\u0055\u006e\u0069
