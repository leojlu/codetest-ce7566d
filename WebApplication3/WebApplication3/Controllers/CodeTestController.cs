using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication3.Controllers
{
    public class CodeTestController : ApiController
    {
        [System.Web.Http.RouteAttribute("api/codetest")]
        public List<long> Get(string input)
        {
            List<long> result = new List<long>();
            if(!string.IsNullOrEmpty(input))
            {
                int n;
                bool isNumeric = int.TryParse(input, out n);
                if(isNumeric) //if it's numeric, loop through every int from 0 to N
                {
                    for (int i = 0; i <= n; i++)
                    {
                        List<long> temp = Get10Substring(i.ToString());
                        foreach(long item in temp)
                        {
                            if (!result.Contains(item))
                            {
                                result.Add(item);
                            }
                        }
                    }
                }
                else // if it's not numeric, only check the string itself.
                {
                    result = Get10Substring(input);
                }
                
            }
            return result;
        }

        private List<long> Get10Substring(string input)
        {
            List<long> result = new List<long>();
            for(int i =0; i < input.Length; i++)
            {
                int sum = 0;
                int j = i;
                while(sum < 10 && j < input.Length) //continue until sum is equal or greater 10
                {
                    int n;
                    bool isNumeric = int.TryParse(input.Substring(j, 1), out n);
                    if (!isNumeric)
                        break;
                    sum = sum + n;
                    j++;
                }
                if (sum == 10) //add string to result
                {
                    result.Add(Convert.ToInt64(input.Substring(i, j - i)));
                }
            }
            return result;
        }

       
    }
}
