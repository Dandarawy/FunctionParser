# Function Parser
This repo contains 4 different projects: 
## 1. FunctionParser:
A class library to parse and evaluate any mathematical expression.  
The parser is applying the following rules to evaluate any expression:
- expr     → expr + term | expr - term | term
- term     → term * factor | term / factor | term ^ factor | factor
- factor   → number | ( expr )  | -factor | id | function
- function → functerm
- func     → Sinh | Sin | Cosh | Cos | Tanh | Tan | Coth | Cot | Sich | Sic | Csch | Csc | E | Log | Ln

For more information about parsing technique check this [Compiler Course Notes](https://cs.nyu.edu/~gottlieb/courses/2000s/2006-07-fall/compilers/class-notes.html). 
### How to use? 
To use the FunctionParser library download the repo and build the project, then grap the dll file and add it to your project, after that you should be able to parse any function using this library as the following:
* First use the FunctionParser namespace:
   ```cs
   using FunctionParser;
   ```
* Check if the exression is valid or not, if valid create the Expression object
   ```cs
   if (Expression.IsExpression(equation, idsNames))
   {
     Expression expression = new Expression(equation, idsNames, null);
    //Use the expression ...
   }
   ```
 * Calculate the expression value according to specific ids values:
   ```cs
   double result = expression.CalculateValue(idsValues);
   ```
 For more details about how to use the library check **FunctionParserWindowsFormTester** and **FunctionParserAndPlotterTester** projects.
 
 ---
 ## 2. FunctionParserWindowsFormTester [TBC]:
 ![FunctionParserWindowsFormTester screenshot](https://github.com/Dandarawy/FunctionParser/blob/master/docs/images/example_1.png)

 ---
 ## 3. FunctionPlotter [TBC]:
 
 ---
 ## 4. FunctionParserAndPlotterTester [TBC]:
 ![FunctionParserAndPlotterTester screenshot](https://github.com/Dandarawy/FunctionParser/blob/master/docs/images/record.gif)
