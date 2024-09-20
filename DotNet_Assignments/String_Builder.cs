using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignments
{
    internal class String_Builder
    {
        static void Main() {
           StringBuilder builder = new StringBuilder();
            builder.Append("We");
            builder.Append(",");
            builder.Append(" are ");
            builder.Append("learning");
            builder.Append(".Net");

            Console.WriteLine(builder.ToString());

            //Replace a specific string
            builder.Replace(".Net", ".Net language");
            Console.WriteLine(builder.ToString());

            //Remove porsion using remove method
            builder.Remove(2,5);
            Console.WriteLine(builder.ToString());
        }
    }
}
