using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatchFileUpload
{
    public class BatchUpload
    {
        public void Upload()
        {
            BatchUploadClient.NIWS_NIFClient client = new BatchUploadClient.NIWS_NIFClient();

            //string textFile = @"C:\Users\William\notes\FileJ.nif";
            //string text = File.ReadAllText(textFile);
            //var responce = client.BatchFileUpload("1da553ba-b698-4e26-913a-af2ae0510f53", text);
            //var holder = client.RequestFileUploadReport("1da553ba-b698-4e26-913a-af2ae0510f53", responce);
            //var responce2 = client.RequestAVSReport("1da553ba-b698-4e26-913a-af2ae0510f53", responce);



             var holderA = client.RequestFileUploadReport("1da553ba-b698-4e26-913a-af2ae0510f53", "10019639.1000781433.9653.41001.011");
            //var responce2A = client.RequestAVSReport("1da553ba-b698-4e26-913a-af2ae0510f53", "10019639.1000781433.9653.41001.011");



        }
    }
}
