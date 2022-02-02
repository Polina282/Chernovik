using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using черновик_1.Model;

namespace черновик_1

{
    public partial class Form1 : Form
    {
        Entities db = new Entities();
    

    public Form1()
        {
            InitializeComponent();
        }

        private void materialDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
            {
                materialBindingSource.DataSource = db.Material.ToList();
            }

        
    }
}
