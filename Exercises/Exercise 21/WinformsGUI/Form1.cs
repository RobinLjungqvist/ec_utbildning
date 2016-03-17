using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise_21;

namespace WinformsGUI
{
    public partial class Form1 : Form
    {
        ListLoader loader;
        List<LanguageData> LanguageList;
        int currentpost = 0;
        public Form1()
        {
            loader = new ListLoader();
            LanguageList = loader.GetListByYear();
            InitializeComponent();
            InitializePosts();

        }

        private void _btnBack_Click(object sender, EventArgs e)
        {
            if(currentpost > 0)
            {
                currentpost--;
                ChangeLanguage(currentpost);
            }
        }

        private void _btnNext_Click(object sender, EventArgs e)
        {
            if (currentpost < LanguageList.Count)
            {
                currentpost++;
                ChangeLanguage(currentpost);
            }
        }

        private void ChangeLanguage(int index)
        {
            _txtBoxName.Text = LanguageList.ElementAt(index)._Name;
            _txtBoxYear.Text = LanguageList.ElementAt(index)._Year.ToString();
            _txtBoxDesc.Text = LanguageList.ElementAt(index)._Description;
        }
        private void InitializePosts()
        {
            _txtBoxName.Text = LanguageList.ElementAt(0)._Name;
            _txtBoxYear.Text = LanguageList.ElementAt(0)._Year.ToString();
            _txtBoxDesc.Text = LanguageList.ElementAt(0)._Description;
        }

        private void _btnSearch_Click(object sender, EventArgs e)
        {
            int fromYear;
            int toYear;
            if(int.TryParse(_txtBoxMin.Text, out fromYear) && int.TryParse(_txtBoxMax.Text, out toYear))
            {
                LanguageList = loader.search(fromYear, toYear);
                InitializePosts();

            }
        }
    }
}
