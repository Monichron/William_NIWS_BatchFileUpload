using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileUpload
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchUpload upl = new BatchUpload();
            upl.Upload();
        }
    }
}
