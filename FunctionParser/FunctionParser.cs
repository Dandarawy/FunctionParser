using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionParser
{
    public class Function : ParsTreeNode
    {
        public enum FunctionEnum
        {
            Sinh, Sin, Cosh, Cos, Tanh, Tan, Coth, Cot, Sich, Sic, Csch, Csc, E, Log, Ln
        }
        public static bool IsFunction(string function, string[] ids)
        {
            foreach (string func in Enum.GetNames(typeof(FunctionEnum)))
            {
                if (function.ToLower().StartsWith(func.ToLower()))
                {
                    return Term.IsTerm(function.Substring(func.Length), ids);
                }
            }
            return false;
        }
        public FunctionEnum Func { get; set; }
        public Term Term;

        public Function(string function, string[] ids, ParsTreeNode parent)
            : base(function, ids, parent)
        {

            foreach (string func in Enum.GetNames(typeof(FunctionEnum)))
            {
                if (function.ToLower().StartsWith(func.ToLower()))
                {

                    Func = (FunctionEnum)Enum.Parse(typeof(FunctionEnum), func);
                    this.Term = new Term(function.Substring(func.Length), ids, this);
                    break;
                }
            }
        }
        public override double CalculateValue(double[] idsValue)
        {
            double termValue = this.Term.CalculateValue(idsValue);
            double ret = 0;
            switch (Func)
            {
                case FunctionEnum.Sin:
                    ret = Math.Sin(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Cos:
                    ret = Math.Sin(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Tan:
                    ret = Math.Tan(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Sinh:
                    ret = Math.Sinh(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Cosh:
                    ret = Math.Cosh(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Tanh:
                    ret = Math.Tanh(termValue * Math.PI / 180);
                    break;
                case FunctionEnum.Csc:
                    ret = (1 / Math.Sin(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.Sic:
                    ret = (1 / Math.Cos(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.Cot:
                    ret = (1 / Math.Tan(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.Csch:
                    ret = (1 / Math.Sinh(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.Sich:
                    ret = (1 / Math.Cosh(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.Coth:
                    ret = (1 / Math.Tanh(termValue * Math.PI / 180));
                    break;
                case FunctionEnum.E:
                    ret = (Math.Exp(termValue));
                    break;
                case FunctionEnum.Log:
                    ret = (Math.Log10(termValue));
                    break;
                case FunctionEnum.Ln:
                    ret = (Math.Log(termValue, Math.E));
                    break;
            }
            return ret;

        }
        public override double[] CalculateValue(string[] ids, double[][] idsValues)
        {
            double[] termValue = this.Term.CalculateValue(ids, idsValues);
            double[] ret = new double[termValue.Length];
            switch (Func)
            {
                case FunctionEnum.Sin:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Sin(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Cos:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Cos(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Tan:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Tanh(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Sinh:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Sinh(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Cosh:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Cosh(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Tanh:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = Math.Tanh(termValue[i] * Math.PI / 180);
                    break;
                case FunctionEnum.Csc:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Sin(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.Sic:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Cos(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.Cot:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Tan(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.Csch:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Sinh(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.Sich:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Cosh(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.Coth:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (1 / Math.Tanh(termValue[i] * Math.PI / 180));
                    break;
                case FunctionEnum.E:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (Math.Exp(termValue[i]));
                    break;
                case FunctionEnum.Log:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (Math.Log10(termValue[i]));
                    break;
                case FunctionEnum.Ln:
                    for (int i = 0; i < ret.Length; i++)
                        ret[i] = (Math.Log(Math.E, termValue[i]));
                    break;
            }
            return ret;

        }
    }
    public class Factor : ParsTreeNode
    {
        public enum FactorExpansion
        {
            Number,//1,2,3,etc
            Function,//sin,cos,etc
            MinuFactor,//-x,-15,-sin,-(x+1),etc
            WrappedExpression,//(expression)
            ID//x
        }
        public static bool IsFactor(string factor, string[] ids)
        {
            double tst;
            if (double.TryParse(factor, out tst))
                return true;
            else if (factor.StartsWith("(") && factor.EndsWith(")") && Expression.IsExpression(factor.Substring(1, factor.Length - 2), ids))
                return true;
            else if (factor.StartsWith("-") && Factor.IsFactor(factor.Substring(1, factor.Length - 1), ids))
                return true;
            else if (FunctionParser.Function.IsFunction(factor, ids))
                return true;
            else if (IsID(factor, ids))
                return true;
            else { return false; }
        }
        private static bool IsID(string id, string[] ids)
        {
            foreach (string s in ids)
            {
                if (id == s)
                {
                    return true;
                }

            }
            return false;
        }
        public FactorExpansion Expansion { get; set; }
        public Function Function { get; set; }
        public Expression WrappedExpression { get; set; }
        public Factor InnerFactor;
        public Factor(string factor, string[] ids, ParsTreeNode parent)
            : base(factor, ids, parent)
        {

            this.Value = factor;
            double value;
            if (double.TryParse(factor, out value))
            {

                this.Expansion = FactorExpansion.Number;
            }
            else
            {
                if (factor.StartsWith("(") && factor.EndsWith(")"))
                {
                    this.Expansion = FactorExpansion.WrappedExpression;
                    this.WrappedExpression = new Expression(factor.Substring(1, factor.Length - 2), ids, this);
                }
                else if (Function.IsFunction(factor, ids))
                {
                    this.Expansion = FactorExpansion.Function;
                    this.Function = new Function(factor, ids, this);

                }
                else if(factor.StartsWith("-"))
                {
                    this.Expansion = FactorExpansion.MinuFactor;
                    this.InnerFactor = new Factor(factor.Substring(1, factor.Length - 1), ids, this);
                }
                else
                {
                    this.Expansion = FactorExpansion.ID;
                }
            }

        }
        public override double CalculateValue(double[] idsValue)
        {
            if (Expansion == FactorExpansion.Number)
            {
                return (double.Parse(this.Value));
            }
            else if (Expansion == FactorExpansion.WrappedExpression)
            {
                return (WrappedExpression.CalculateValue(idsValue));
            }
            else if (Expansion == FactorExpansion.Function)
            {
                return (this.Function.CalculateValue(idsValue));
            }
            else if(Expansion== FactorExpansion.MinuFactor)
            {
                return -this.InnerFactor.CalculateValue(idsValue);
            }
            else
            {
                //ID
                int idIndex = -1;
                for (int i = 0; i < IDs.Length; i++)
                    if (IDs[i] == this.Value)
                    {
                        idIndex = i;
                        break;
                    }
                return idsValue[idIndex];

            }
        }
        public override double[] CalculateValue(string[] ids, double[][] idsValues)
        {
            if (Expansion == FactorExpansion.Number)
            {
                double[] ret = new double[idsValues.Length];
                double value = double.Parse(this.Value);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = value;
                return ret;
            }
            else if (Expansion == FactorExpansion.WrappedExpression)
            {
                return (WrappedExpression.CalculateValue(ids, idsValues));
            }
            else if (Expansion == FactorExpansion.Function)
            {
                return (this.Function.CalculateValue(ids, idsValues));
            }
            else if(Expansion== FactorExpansion.MinuFactor)
            {
                double[] result = this.InnerFactor.CalculateValue(ids, idsValues);
                for (int i = 0; i < result.Length; i++)
                    result[i] = -result[i];
                return result;
            }
            else
            {
                //ID
                int idIndex = -1;
                for (int i = 0; i < ids.Length; i++)
                    if (ids[i] == this.Value)
                    {
                        idIndex = i;
                        break;
                    }
                return idsValues[idIndex];
            }
        }
    }
    public class Term : ParsTreeNode
    {
        public enum TermExpansion
        {
            TermMulFactor,
            TermDivFactor,
            TermPowFactor,
            Factor
        }
        public static bool IsTerm(string term, string[] ids)
        {
            int oprIndx = -1;
            int brackets = 0;
            for (int i = term.Length - 1; i > 0; i--)
            {
                if ((term[i] == '*' || term[i] == '/' || term[i] == '^') && (brackets == 0))
                {
                    oprIndx = i;
                    break;
                }
                else if (term[i] == ')') brackets++;
                else if (term[i] == '(') brackets--;
            }
            if (oprIndx > 0)
            {

                string subterm, factor;
                subterm = term.Substring(0, oprIndx);
                factor = term.Substring(oprIndx + 1);
                return Term.IsTerm(subterm, ids) && Factor.IsFactor(factor, ids);
            }
            else
            {
                return FunctionParser.Factor.IsFactor(term, ids);
            }

        }
        public TermExpansion Expansion { get; set; }
        public Term SubTerm { get; set; }
        public Factor Factor { get; set; }
        public Term(string term, string[] ids, ParsTreeNode parent)
            : base(term, ids, parent)
        {

            this.Value = term;
            int oprIndx = -1;
            int brackets = 0;
            for (int i = term.Length - 1; i > 0; i--)
            {
                if ((term[i] == '*' || term[i] == '/' || term[i] == '^') && (brackets == 0))
                {
                    oprIndx = i;
                    break;
                }
                else if (term[i] == ')') brackets++;
                else if (term[i] == '(') brackets--;
            }
            if (oprIndx > 0)
            {

                string subterm, factor;
                char opr = term[oprIndx];
                subterm = term.Substring(0, oprIndx);
                factor = term.Substring(oprIndx + 1);
                this.Factor = new Factor(factor, ids, this);
                this.SubTerm = new Term(subterm, ids, this);
                if (opr == '*')
                {
                    this.Expansion = TermExpansion.TermMulFactor;
                }
                else if (opr == '/')
                {
                    this.Expansion = TermExpansion.TermDivFactor;
                }
                else
                {
                    this.Expansion = TermExpansion.TermPowFactor;
                }
            }
            else
            {
                this.Expansion = TermExpansion.Factor;
                this.Factor = new Factor(term, ids, this);
            }

        }
        public override double CalculateValue(double[] idsValue)
        {
            if (Expansion == TermExpansion.TermDivFactor)
            {
                return (this.SubTerm.CalculateValue(idsValue) / this.Factor.CalculateValue(idsValue));
            }
            else if (Expansion == TermExpansion.TermMulFactor)
            {
                return (this.SubTerm.CalculateValue(idsValue) * this.Factor.CalculateValue(idsValue));
            }
            else if (Expansion == TermExpansion.TermPowFactor)
            {
                return (Math.Pow(this.SubTerm.CalculateValue(idsValue), this.Factor.CalculateValue(idsValue)));
            }
            else
                return (this.Factor.CalculateValue(idsValue));
        }
        public override double[] CalculateValue(string[] ids, double[][] idsValues)
        {
            double[] ret = new double[idsValues.Length];
            if (Expansion == TermExpansion.TermDivFactor)
            {
                double[] subtermValues = this.SubTerm.CalculateValue(ids, idsValues);
                double[] factorValues = this.Factor.CalculateValue(ids, idsValues);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = subtermValues[i] / factorValues[i];
                return ret;
            }
            else if (Expansion == TermExpansion.TermMulFactor)
            {
                double[] subtermValues = this.SubTerm.CalculateValue(ids, idsValues);
                double[] factorValues = this.Factor.CalculateValue(ids, idsValues);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = subtermValues[i] * factorValues[i];
                return ret;
            }
            else if (Expansion == TermExpansion.TermPowFactor)
            {
                double[] subtermValues = this.SubTerm.CalculateValue(ids, idsValues);
                double[] factorValues = this.Factor.CalculateValue(ids, idsValues);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = Math.Pow(subtermValues[i], factorValues[i]);
                return ret;
            }
            else
                return (this.Factor.CalculateValue(ids, idsValues));
        }
    }
    public class Expression : ParsTreeNode
    {
        public enum ExpressionExpansion
        {
            ExpressionPlusTerm,
            ExpressionMinusTerm,
            Term
        }
        public static bool IsExpression(string expr, string[] ids)
        {
            expr = expr.Replace(" ", "");
            int oprIndx = -1;
            int brackets = 0;
            for (int i = expr.Length - 1; i > 0; i--)
            {
                if (((expr[i] == '-'&&!IsOperator(expr[i-1]))
                    || expr[i] == '+') && (brackets == 0))
                {
                    oprIndx = i;
                    break;
                }
                else if (expr[i] == ')') brackets++;
                else if (expr[i] == '(') brackets--;
            }
            if (oprIndx > 0)
            {
                string subExpr, term;
                subExpr = expr.Substring(0, oprIndx);
                term = expr.Substring(oprIndx + 1);
                return (FunctionParser.Term.IsTerm(term, ids) && IsExpression(subExpr, ids));
            }
            else
            {
                return FunctionParser.Term.IsTerm(expr, ids);
            }
        }
        static bool IsOperator(char c)
        {
            return c == '-' || c == '+' || c == '*' || c == '/' || c == '^';
        }
        public ExpressionExpansion Expansion { get; set; }
        public Term Term { get; set; }
        public Expression SubExpression { get; set; }
        public Expression(string expr, string[] ids, ParsTreeNode parent)
            : base(expr, ids, parent)
        {
            expr=expr.Replace(" ", "");
            int oprIndx = -1;
            int brackets = 0;
            for (int i = expr.Length - 1; i > 0; i--)
            {
                if (((expr[i] == '-' && !IsOperator(expr[i - 1]))
                    || expr[i] == '+') && (brackets == 0))
                {
                    oprIndx = i;
                    break;
                }
                else if (expr[i] == ')') brackets++;
                else if (expr[i] == '(') brackets--;
            }
            if (oprIndx > 0)
            {
                string subExpr, term;
                char opr;
                subExpr = expr.Substring(0, oprIndx);
                term = expr.Substring(oprIndx + 1);
                opr = expr[oprIndx];
                this.Term = new Term(term, ids, this);
                this.SubExpression = new Expression(subExpr, ids, this);
                if (opr == '-')
                {
                    Expansion = ExpressionExpansion.ExpressionMinusTerm;
                }
                else
                {
                    Expansion = ExpressionExpansion.ExpressionPlusTerm;
                }
            }
            else
            {
                Expansion = ExpressionExpansion.Term;
                this.Term = new Term(expr, ids, this);
            }
        }
        public override double CalculateValue(double[] idsValue)
        {
            if (Expansion == ExpressionExpansion.ExpressionMinusTerm)
            {
                return (this.SubExpression.CalculateValue(idsValue) - this.Term.CalculateValue(idsValue));
            }
            else if (Expansion == ExpressionExpansion.ExpressionPlusTerm)
            {
                return (this.SubExpression.CalculateValue(idsValue) + this.Term.CalculateValue(idsValue));
            }
            else
                return (this.Term.CalculateValue(idsValue));
        }
        public override double[] CalculateValue(string[] ids, double[][] idsValues)
        {
            double[] ret = new double[idsValues.Length];
            if (Expansion == ExpressionExpansion.ExpressionMinusTerm)
            {
                double[] subExprValues = this.SubExpression.CalculateValue(ids, idsValues);
                double[] termValues = this.Term.CalculateValue(ids, idsValues);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = subExprValues[i] - termValues[i];
                return ret;
            }
            else if (Expansion == ExpressionExpansion.ExpressionPlusTerm)
            {
                double[] subExprValues = this.SubExpression.CalculateValue(ids, idsValues);
                double[] termValues = this.Term.CalculateValue(ids, idsValues);
                for (int i = 0; i < ret.Length; i++)
                    ret[i] = subExprValues[i] + termValues[i];
                return ret;
            }
            else
                return (this.Term.CalculateValue(ids, idsValues));
        }

    }
    public abstract class ParsTreeNode
    {
        public string Value { get; set; }
        public abstract double CalculateValue(double[] idsValue);
        public abstract double[] CalculateValue(string[] ids, double[][] idsValues);
        public ParsTreeNode Parent { get; set; }
        public string[] IDs { get; set; }
        protected ParsTreeNode(string value, string[] ids, ParsTreeNode parnet)
        {
            this.Value = value.Replace(" ","");
            this.Parent = parnet;
            this.IDs = ids;
        }
    }
}
