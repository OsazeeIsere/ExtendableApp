using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommonSnappableTypes;
namespace CSharpSnapIn
{
    [CompanyInfo(CompanyName = "GoSharp Digital Solutons", CompanyUrl = "www.google.com")]
    public class CSharpModule: IAppFuntionality
    {
        void IAppFuntionality.DoIt()
        {
            Console.WriteLine("You have just used the C# snap-in!");

        }

    }
}
