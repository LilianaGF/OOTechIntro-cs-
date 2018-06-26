using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TowaStandard;
using TowaInfrastructure;
using Balls.TechIntroExampleClasses;

namespace Balls
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            System.Console.Write("Hi, OOTechIntroEWT\n");

            /* Challenge 1 */
            System.Console.WriteLine("BallVollVolleyBall diameter is " + BallVollVolleyBall.intDIAMETER);
            System.Console.WriteLine(String.Format("BallVollVolleyBall diameter is {0} \n", BallVollVolleyBall.intDIAMETER));

            //ERROR IF...
            //BallVollVolleyBall.intDIAMETER = 22;
            /* */


        }
    }
}
