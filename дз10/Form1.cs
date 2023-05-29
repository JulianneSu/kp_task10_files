using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;


namespace дз10
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            name = tb_name.Text;
            root = tb_root.Text;
            path = root + "/" + name;

            if (File.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
        }
        //поля
        string path, thetext, root, name;
        FileInfo f;

        //количество строк
        private void tb1_Click(object sender, EventArgs e)
        {
            string[] lines;
            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd(); 
                lines = thetext.Split('\n');
            }

            tb1.Text = (lines.Length).ToString();
           
        }

        //количество строк с условием
        private void tb2_Click(object sender, EventArgs e)
        {
            int amount = 0;
            string[] lines;

            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
                lines = thetext.Split('\n');
                string str = tb2_in.Text;
              

                foreach (string line in lines)
                {
                    if (line.Contains(str))
                        amount++;
                }

            }
            tb2.Text = amount.ToString();
            
        }

        //частота появления слова
        private void tb3_Click(object sender, EventArgs e)
        {
            int amount = 0;
            string[] lines;

            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
                lines = thetext.Split('\n');
               
                string str = tb3_in.Text;

                foreach (string line in lines)
                { 
                    int index = line.IndexOf(str);
                    while (index >= 0)
                    {
                        index = line.IndexOf(str, index + str.Length);
                        amount++;
                    }
                }
                
            }
            tb3.Text = amount.ToString();
        }

        //замена слова
        private void bt_replace_Click(object sender, EventArgs e)
        {

            string old_str = tb4_old.Text;
            string new_str = tb4_new.Text;

            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
                thetext = thetext.Replace(old_str, new_str);
            }
   
            File.WriteAllText(path, thetext);
            tb_get_text.Text = thetext;
        }

        
        //вывод текста
        private void bt_get_text_Click(object sender, EventArgs e)
        {
            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
            }

            tb_get_text.Text = thetext;
        }

      
        //создание файла
        private void bt_create_Click(object sender, EventArgs e)
        {

            DirectoryInfo dir = new DirectoryInfo(root);
            dir.Create();
            f = new FileInfo(path);

            using (FileStream fs = f.Create()) { }
        }

      
        //запись текста
        private void bt_write_text_Click(object sender, EventArgs e)
        {
            thetext = tb_write_text.Text;
            File.WriteAllText(path, thetext);
        }
       
        //к верхнему регистру
        private void bt_up_Click(object sender, EventArgs e)
        {
            string newstr = tb5.Text;          

            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
                thetext = thetext.Replace(newstr, newstr.ToUpper());
            }
            File.WriteAllText(path, thetext);
            tb_get_text.Text = thetext;
        }

        //К нижнему регистру
        private void bt_down_Click(object sender, EventArgs e)
        {
            string newstr = tb5.Text;

            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd();
                thetext = thetext.Replace(newstr, newstr.ToLower());
            }
            File.WriteAllText(path, thetext);
            tb_get_text.Text = thetext;
        }

        //все к верхнему
        private void bt_all_up_Click(object sender, EventArgs e)
        {
            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd(); ;

                thetext = thetext.ToUpper();
            }
            File.WriteAllText(path, thetext);
            tb_get_text.Text = thetext;
        }

        //все к нижнему
        private void bt_all_down_Click(object sender, EventArgs e)
        {
            using (var fs = File.OpenText(path))
            {
                thetext = fs.ReadToEnd(); ;

                thetext = thetext.ToLower();

            }
            File.WriteAllText(path, thetext);
            tb_get_text.Text = thetext;
        }


    }
}
