using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace ConsoleApp0929
{
    class StreamWriter1
    {
        [STAThread]
        static void Main()
        {
            //System.Environment.CurrentDirectory = "C:\\";

            //
            SaveFileDialog dlg = new SaveFileDialog();
            
            if(dlg.ShowDialog()== DialogResult.OK)
            {
                string filename = dlg.FileName;
                using (StreamWriter sw = new StreamWriter(filename, true, Encoding.UTF8))
                {
                    sw.WriteLine("안녕하세요. {0}님", "홍길동");
                    sw.WriteLine(123456);
                    sw.WriteLine("ABCabc");
                    sw.Flush();
                    sw.Close();
                }
            }
            
            
        }
    }
}
