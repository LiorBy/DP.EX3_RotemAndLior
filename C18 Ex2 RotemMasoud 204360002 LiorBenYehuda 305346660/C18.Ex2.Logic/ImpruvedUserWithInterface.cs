using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace C18.Ex2.Logic
{

    public interface ICelebrateBirthdayObserver
    {
        void ReportBirthday(string i_UserFullName);
    }


    public class ImpruvedUser
    {
        private User m_User; 
        bool m_HasBirthday = false;
        private string m_TodayDate;


        private readonly List<ICelebrateBirthdayObserver> m_BirthDayObservers
            = new List<ICelebrateBirthdayObserver>();

     

        public ImpruvedUser(User i_User)
        {
            m_User = i_User;    
        }

        public void updateBirthday()
        {
            string userBirthdayDay = m_User.Birthday.Substring(0, 5);
            string today = DateTime.Now.ToString("MM/dd");
            if (String.Equals(userBirthdayDay, today))
            {
                doWhenUserHasBirthday();
            }
            else
            {
                m_HasBirthday = false;
            }
        }

        private void doWhenUserHasBirthday()
        {
            m_HasBirthday = true;
            notifySickObservers();
        }

        private void notifySickObservers()
        {
            foreach (ICelebrateBirthdayObserver observer in m_BirthDayObservers)
            {
                observer.ReportBirthday(m_User.Name);
            }
        }

        public void AttachObserver(ICelebrateBirthdayObserver i_SicknessObserver)
        {
            m_BirthDayObservers.Add(i_SicknessObserver);
        }

        public void DetachObserver(ICelebrateBirthdayObserver i_SicknessObserver)
        {
            m_BirthDayObservers.Remove(i_SicknessObserver);
        }
    }
}
