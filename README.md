<h1 align="center">A&A</h1>

# Matrix Calculator

# What In This Document

- [What In This Document](#what-in-this-document)
- [How to connect in your app](#how-to-connect-in-your-app)
- [How to use in code](#how-to-use-in-code)
- [Code examples](#code-examples)

# How to connect in your app

1. Download as zip.
2. Open and build solution.
3. In your project add reference to **MatrixCalculateLibrary.dll**

Or just install nuget package:
	
	Install-Package AandA.MatrixCalculateLibrary -Version 1.0.0

# How to use in code

**Add using to list**

	using MatrixCalculateLibrary;
	
# Code examples

**Create matrix(array)**
	
	double[,] A = new double[3, 3]
	{
		{ 3, 0, 2 },
		{ 2, 0, -2 },
		{ 0, 1, 1 }
	};
	double[,] B = new double[3, 3]
	{
		{ 3, -1, 2 },
        	{ 1, 0, 3 },
        	{ 2, -1, 0 }
	};
		
In examples we will use the A and the B matrixies.

**Matrix sum**

	var result = BasicMatrixArithmetic.Add(a, b);
	
or
	
	var result = A.Add(B);

**Matrix subtract**

	var result = BasicMatrixArithmetic.Subtract(a, b);
	
or
	
	var result = A.Subtract(B);
		
**Matrix inverting**

	var result = InvertMatrixCalculator.CalculateInvertMatrix(A);
	
or
	
	var result = A.Invert();
	
**Matrix element cofactor**

	var result = MatrixCalculator.CalculateElementCofactor(0, 0, A);
	
or
	
	var result = A.ElementCofactor(0, 0);
	
**Matrix transpose**

	var result = MatrixCalculator.CalculateTransposeMatrix(A);
	
or
	
	var result = A.TransposeMatrix();
	
**Matrix determinant**

	var result = MatrixDeterminantCalculator.CalculateDeterminant(0, A);
	
or
	
	var result = A.Determinant(0);
	
**Matrix multiply**

	var result = MultiplyMatrixCalculator.Multiply(A, B);
	
or
	
	var result = A.Multiply(B);

**Matrix multiply on number**

	var result = MultiplyMatrixCalculator.MultiplyToNumber(A, B);
	
or
	
	var result = A.MultiplyToNumber(5);
