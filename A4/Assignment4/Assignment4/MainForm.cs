using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4
{
    /// <summary>
    /// Daniel Petersén
    /// 2017-10-01
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Delecering necessary instance variables
        /// </summary>
        private RecipeManger recipeManger = new RecipeManger(200);
        private IngredientsForm ingredientsForm = new IngredientsForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
