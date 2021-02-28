using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ETests.Model
{
    public class FAQHeader:ObservableCollection<FAQListItems>, INotifyPropertyChanged
    {
        public FAQHeader() { }
        public string  Header { get; set; }

        public int Id { get; set; }

        private bool _expanded;
        public bool Expanded
        {
            get { return _expanded; }
            set
            {
                if (_expanded != value)
                {
                    _expanded = value;
                    OnPropertyChanged();
                }
            }
        }
        public int GroupCount { get; set; }

        public string TitleWithItemCount
        {
            get { return string.Format("{0}", Header); }

        }

        public FAQHeader(int Id, string Header,bool expanded = true)
        {
            this.Id = Id;
            this.Header = Header;
            Expanded = expanded;
            
        }

        public static ObservableCollection<FAQHeader> All { set; get; }

        static FAQHeader()
        {
            ObservableCollection<FAQHeader> Groups = new ObservableCollection<FAQHeader>
   { new FAQHeader(1,"About MDCAT?",false){
           new FAQListItems { Question = " Testing app."
+    " Formula for calculating merit is given below:"
+"(10 % of Matriculation + 40 % of Intermediate + 50 % of MDCAT)/ (1100 x 100)" 


                    }
                },
      new FAQHeader(2,"What is e-test?",false){
           new FAQListItems { Question = "e-test is a digital solution for test taking " +
           "and preparation. The e-test pro is built with various" +
           " tests having time binding. The app has a built-in count down timer to simulate the test environment."

                    }
                },

           new FAQHeader(3,"How the tests in e-test are prepared?",false){
           new FAQListItems { Question = "The tests built in e-test pro are prepared" +
           " by experienced academicians and based on questions that frequently appeared in previous papers."

                    }
                },
        new FAQHeader(4,"How to take a test in e-test?",false){
           new FAQListItems { Question = "To take a test; Go to Menu>Attempt test. A list of tests shall appear pertaining to " +
           "the test category already selected during " +
           "registration process. On clicking a test, there shall appear a pop-up to start test. Click “Yes” to start the test."

                    }
                },
        new FAQHeader(5,"What does the graph show on the dashboard?",false){
           new FAQListItems { Question = "The graph on dashboard shows your average score " +
           "(average correct and incorrect percentages), represented as pie chart. "

                    }
                },
        new FAQHeader(6,"How can I find my section wise average scores?",false){
           new FAQListItems { Question = "You can find your section wise average scores in the table on dashboard."

                    }
                },
        new FAQHeader(7,"How can I see my test attempt history?",false){
           new FAQListItems { Question = "To see your test attempt history; Go to Menu>Attempted Tests History"

                    }
                },
        new FAQHeader(8,"How many times I can attempt a test?",false){
           new FAQListItems { Question = "You can attempt a test maximum 20 times."

                    }
                }};
            All = Groups;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
