﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.BrovkinAA.Sprint3.Task3.V19.Lib
{
    public class DataService : ISprint3Task3V19
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string resStr = "";
            foreach (char c in value)
            {
                if (c == replaceable)
                {
                    resStr += replacement;
                    continue;
                }
                resStr += c;
            }


            return resStr;
        }
    }
}
