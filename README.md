# Function Parser
[Source Dandarawy/FunctionParser](https://github.com/Dandarawy/FunctionParser)   
[This fork fix bug with math.pow](https://github.com/Dandarawy/FunctionParser/issues/1)    
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
To use the FunctionParser library download the repo and build the project or get the dlls from the release section, then add it to your project, after that you should be able to parse any function using this library as the following:
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
 ## 2. FunctionParserWindowsFormTester:
 ![FunctionParserWindowsFormTester screenshot](https://github.com/Dandarawy/FunctionParser/blob/master/docs/images/example_1.png)

This is a simple tester for the parsing library, write the expression in the textbox if the expression contains ids (variables) add the ids names and values, then the application will evaluate the expression and show the parse tree.

 ---
 ## 3. FunctionPlotter:
 
 A class library project to plot any series of points, it is based on GDI+.
 The main class in the library is the ```Plotter``` class.
 To use the plotter class you need to define an object of this class the following line will define a plotter object in which the unit on the x and y axis is represented by 50 pixels and the center of the axis (the origin) is at the center point on the picBox_graph:
```cs
Plotter plotter = new Plotter(50, 50, new Point(picBox_graph.Width / 2, picBox_graph.Height / 2));
```
 Create a ```Curve``` object and populate its points list, then add this curve object to the plotter's curves list:
 ```
 plotter.Curves.Add(curve);
 ```
 
 Call the Draw functions of the plotter and send the graphics object associated with the control that you want to draw on it, the typical way to do that is to call the draw functions in the paint event of the control
 ```cs
        private void picBox_graph_Paint(object sender, PaintEventArgs e)
        {
            plotter.DrawGridandAxes(e.Graphics, picBox_graph.Width, picBox_graph.Height);
            plotter.DrawCurves(e.Graphics);
        }
 ```
 For more info about how to use the plotter check FunctionParserAndPlotterTester source code.
 
 ---
 ## 4. FunctionParserAndPlotterTester [TBC]:
 ![FunctionParserAndPlotterTester screenshot](https://github.com/Dandarawy/FunctionParser/blob/master/docs/images/record.gif)
