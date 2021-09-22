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

        static UserDetails loginUser0 = new UserDetails("Bob", "Bobby", 44, "bobtheblob", "1 street road", 3);
        static UserDetails loginUser1 = new UserDetails("Janet", "Jellyface", 48, "nobbynob", "2 street road", 3);
        static UserDetails loginUser2 = new UserDetails("Brian", "BigBri", 25, "helloworld", "3 street road", 3);
        static UserDetails loginUser3 = new UserDetails("Freya", "freshfrey", 26, "dynamite3", "4 street road", 3);
        static UserDetails loginUser4 = new UserDetails("shirley", "sourshirl", 32, "shirley2", "5 street road", 3);

        UserDetails[] loginArray = new UserDetails[] { loginUser0, loginUser1, loginUser2, loginUser3, loginUser4 };

       

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= loginArray.Length - 1; i++)
               if (inputUserName.Text == loginArray[i].UserName & Inputpassword.Text == loginArray[i].Password)
                {
                    Details dtl = new Details(loginArray[i]);
                    dtl.Show();
                    
                }
                else if (inputUserName.Text == loginArray[i].UserName || Inputpassword.Text == loginArray[i].Password)
                {  
                    inputUserName.Clear();
                    Inputpassword.Clear();
                    MessageBox.Show("Details Incorrect");
                    
                }

                 

        }
       
       
    }
    
}
