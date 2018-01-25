using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpTraining
{
    public class FileStreamDemo
    {
        public void FileReadWrite()
        {
            FileStream st = new FileStream("C:\\Chandrasen\\Learnings\\C Sharp\\CSharpDec2017\\test.txt", FileMode.Truncate);

            byte[] bytes = Encoding.Default.GetBytes("\nTest file stream update 3");

            st.Write(bytes, 0, bytes.Length);
            st.Close();
            Console.WriteLine("file updated");
        }
    }
}
