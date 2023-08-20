using Library.Business.Abstruct;
using Library.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _memberService = InstanceFactory.GetInstance<IMemberService>();
        }
        private IMemberService _memberService;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMembers();
        }

        private void LoadMembers()
        {
            dgwMembers.DataSource = _memberService.GetAll();
        }
    }
}
