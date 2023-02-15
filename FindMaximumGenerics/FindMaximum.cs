﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FindMaximumGenerics
{
    internal class FindMaximum
    {
        public static float FindMaximumValue(float firstValue, float secondValue, float thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("firstvalue ,secondvalur,thirdvalue are same");
        }
    }
}
