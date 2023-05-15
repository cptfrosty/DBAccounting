using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBAccounting
{
    public partial class SearchWindow : Form
    {
        public static SearchWindow Instance;
        public SearchWindow()
        {
            InitializeComponent();
            Instance = this;
        }

        private void SearchWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Instance = null;
        }

        private void LbStaff_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.LbStaff.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(LbStaff.Items[index].ToString());
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Models.Employee> search = StaffController.GetFindFullnameEmployee(TbFullName.Text);
            LbStaff.Items.Clear();

            foreach(var item in search)
            {
                LbStaff.Items.Add($"{item.Id.ToString("00000")} {item.Fullname}");
            }
        }
    }
}
