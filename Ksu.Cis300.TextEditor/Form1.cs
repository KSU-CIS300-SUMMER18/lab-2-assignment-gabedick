/* Form1.cs
 * Author: Gabriel Dick
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.TextEditor
{
    /// <summary>
    /// Opens a Text Editor
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a dialog that retrieves a file name to open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if(uxOpenDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File " + uxOpenDialog.FileName + " cannot be opened.");
            }
        }

        /// <summary>
        /// Creates a dialog that retrieves a location to save the intended file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if(uxSaveAsDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Cannot write to file.");
            }
        }
    }
}
