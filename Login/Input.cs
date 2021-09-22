using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Input : Form
    {
        public Input()
        {
            InitializeComponent();
        }

        static Class1 loginUser0 = new Class1("Bob", "Bobby", 44, "bobtheblob", "1 street road", 3);
        static Class1 loginUser1 = new Class1("Janet", "Jellyface", 48, "nobbynob", "2 street road", 3);
        static Class1 loginUser2 = new Class1("Brian", "BigBri", 25, "helloworld", "3 street road", 3);
        static Class1 loginUser3 = new Class1("Freya", "freshfrey", 26, "dynamite3", "4 street road", 3);
        static Class1 loginUser4 = new Class1("shirley", "sourshirl", 32, "shirley2", "5 street road", 3);

        Class1[] loginArray = new Class1[] { loginUser0, loginUser1, loginUser2, loginUser3, loginUser4 };

        int arrIndex = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= loginArray.Length - 1; i++)
                if (inputUserName.Text == loginArray[i].UserName & Inputpassword.Text == loginArray[i].Password)
            {
                    Details dtl = new Details();
                    dtl.Show();
               // Details details = new Details(loginArray[i]);
               // details.Show();
            }
                else
                {  
                    inputUserName.Clear();
                    Inputpassword.Clear();
                    MessageBox.Show("Details Incorrect");
                }
        }
       
       // Details details = new Details(); 
    }
    
}
