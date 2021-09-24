using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace LTQL28.Models
{
    public class AutoGenerateKey
    {
        public string GenerateKey(string id)
        {
            string strkey = " ";
            Regex regexObj = new Regex(@"(d+)([^0-9]+)", RegexOptions.IgnorePatternWhitespace);
            Match match = regexObj.Match(id);
            string numPart="", strPart="";
            while (match.Success)
            {
                 numPart = match.Groups[1].Value;
                 strPart = match.Groups[2].Value;
                match = match.NextMatch();
                
            }
            strkey = strPart + Convert.ToInt32(numPart) + 1;
            return strkey;
        }
        
    }
}