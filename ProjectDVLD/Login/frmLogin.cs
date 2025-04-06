using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DVLD_Buisness;
using ProjectDVLD.Global_Classes;

namespace ProjectDVLD.Login
{
    public partial class frmLogin: Form
    {

        // المسار النسبي للملف في Debug
        private string path = "data.txt";
        private string spr = "#//#";
        clsUsersBuisnessLayer _User;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void _FillUserInfo()
        {
            clsUserInfo.UserID = _User.UserID;
            clsUserInfo.PersonID = _User.PersonID;
            clsUserInfo.UserName = _User.UserName;
            clsUserInfo.Password = _User.Password;
            clsUserInfo.IsActive = _User.IsActive;

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            // الحصول على النصوص من الـ TextBoxين
            string txtUserNameContent = txtUserName.Text;
            string txtPasswordContent = txtPassword.Text;


            _User = clsUsersBuisnessLayer.FindUserByUserNameAndPassword(txtUserNameContent.Trim(), txtPasswordContent.Trim());

            if (_User == null)
            {
                MessageBox.Show("This user does not exist. Please enter a user that exists in the system.", "This user does not exist.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.IsActive > 0)
            {
                _FillUserInfo();

                // دمج النصوص مع الفاصل #//#
                string newLine = $"{txtUserNameContent}{spr}{txtPasswordContent}";
                if (chkRememberMe.Checked)
                {
                    try
                    {
                        // كتابة السطر الجديد (يستبدل المحتوى القديم)
                        File.WriteAllText(path, newLine);

                        //MessageBox.Show("تم كتابة السطر الجديد في الملف بنجاح!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"حدث خطأ: {ex.Message}");
                    }


                }
                else
                {
                    newLine = "";
                    File.WriteAllText(path, newLine);

                }

                clsUserInfo.CurrentUser = _User;
                this.Hide();
                Form frmMain = new Main();
                frmMain.ShowDialog();

            }
            else
            {
                MessageBox.Show("This user is not activated in the system.", "user is not activated.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void _LoadDataFromFile()
        {
            try
            {

                // التحقق من وجود الملف
                if (File.Exists(path))
                {
                    // قراءة كامل المحتوى من الملف
                    string fileContent = File.ReadAllText(path);

                    // تقسيم النص بناءً على الفاصل #//#
                    string[] parts = fileContent.Split(new[] { spr }, StringSplitOptions.None);

                    // التأكد من أن هناك جزأين على الأقل
                    if (parts.Length == 2)
                    {
                        // تعبئة الـ TextBoxين بالبيانات
                        txtUserName.Text = parts[0]; // الجزء الأول
                        txtPassword.Text = parts[1]; // الجزء الثاني
                    }
                    else
                    {
                        //MessageBox.Show("تنسيق البيانات في الملف غير صحيح!");
                    }
                }
                else
                {
                    MessageBox.Show("الملف غير موجود!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ: {ex.Message}");
            }

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            _LoadDataFromFile();

        }
    }
}
