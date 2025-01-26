using System;
using System.Collections.Generic;
using System.Linq;

namespace Ops
{
    class Operate
    {
        public static Object Add(Object a, Object b)
        {
            switch (a, b)
            {
                case (int aInt, int bInt):
                    return aInt + bInt;
                case (double aDouble, double bDouble):
                    return aDouble + bDouble;
                case (string aStr, string bStr):
                    return aStr + bStr;
                case (bool aBool, bool bBool):
                    return aBool || bBool;
                case (char aChar, char bChar):
                    return $"{aChar}{bChar}";
                case (char aChar, int bInt):
                case (int aInt, char bChar):
                    char charValue = a is char ? (char)a : (char)b;
                    int intValue = a is int ? (int)a : (int)b;
                    return (char)(charValue + intValue);
                default:
                    return "Invalid Types";
            }
        }

        public static object Sub(object a, object b)
        {
            if (a is string aStr && b is string bStr)
            {
                string result = new string(aStr.Where(c => !bStr.Contains(c)).ToArray());
                return result;
            }
            switch (a, b)
            {
                case (int aInt, int bInt):
                    return aInt - bInt;
                case (double aDouble, double bDouble):
                    return aDouble - bDouble;
                case (char aChar, char bChar):
                    return (char)((int)aChar - (int)bChar);
                case (char aChar, int bInt):
                case (int aInt, char bChar):
                    char charValue = a is char ? (char)a : (char)b;
                    int intValue = a is int ? (int)a : (int)b;
                    return (char)(charValue - intValue);
                case (bool aBool, bool bBool):
                    return !(aBool || bBool);
                default:
                    return "Invalid Types";
            }
        }

        public static Object Mult(Object a, Object b)
        {
            switch (a, b)
            {
                case (int aInt, int bInt):
                    return aInt * bInt;
                case (double aDouble, double bDouble):
                    return aDouble * bDouble;
                case (bool aBool, bool bBool):
                    return aBool && bBool;
                case (char aChar, char bChar):
                    return (char)(aChar * bChar);
                case (char aChar, int bInt):
                case (int aInt, char bChar):
                    char charValue = a is char ? (char)a : (char)b;
                    int intValue = a is int ? (int)a : (int)b;
                    return (char)(charValue * intValue);
                case (string aStr, int bInt):
                    return string.Concat(Enumerable.Repeat(aStr, bInt));
                default:
                    return "Invalid Types";
            }
        }

        public static Object Div(Object a, Object b)
        {
            try
            {
                switch (a, b)
                {
                    case (int aInt, int bInt) when bInt != 0:
                        return aInt / bInt;
                    case (double aDouble, double bDouble) when bDouble != 0:
                        return aDouble / bDouble;
                    case (char aChar, char bChar) when (int)bChar != 0:
                        return (char)((int)aChar / (int)bChar);
                    case (char aChar, int bInt) when bInt != 0:
                    case (int aInt, char bChar) when (int)bChar != 0:
                        char charValue = a is char ? (char)a : (char)b;
                        int intValue = a is int ? (int)a : (int)b;
                        return (char)(charValue / intValue);
                    case (bool aBool, bool bBool):
                        return aBool ^ bBool;
                    default:
                        return "Invalid Types";
                }
            }
            catch (DivideByZeroException)
            {
                return "Cannot divide by zero";
            }
        }
    }
}