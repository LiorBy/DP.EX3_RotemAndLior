using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using C18.Ex2.Logic;


namespace C18_Ex1_Rotem_204360002_Lior_305346660
{
    public partial class BirthdatForm : Form, ICelebrateBirthdayObserver
    {
        public readonly List<ImpruvedUser> m_Friends = new List<ImpruvedUser>();
        private User m_LoggedInUser;

        public BirthdatForm(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            passingTheListeners();
    
        }

        private void passingTheListeners()
        {

            foreach (User friend in m_LoggedInUser.Friends)
            {
                ImpruvedUser impruvedFriend = new ImpruvedUser(friend);
                impruvedFriend.AttachObserver(this as ICelebrateBirthdayObserver);
                impruvedFriend.updateBirthday();
                m_Friends.Add(impruvedFriend);
            }
            if(listBox1.Items.Count == 0)
            {
                listBox1.Text = "no one has a birthday today";
            }
        }

       public void ReportBirthday(string i_UserFullName)
        {
            listBox1.Items.Add(i_UserFullName);
        }


    }
}
