using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Attributes
        //Initializes an array of Student objects
        List<Student> ClassOfStudents = new List<Student>();
        //Position in ClassOfStudents array
        int position = 0;
        //Number of assignments
        int iNumOfAssign;
        //Number of Students
        int iNumOfStudents;
        #endregion
        public MainWindow()
        {
            InitializeComponent();
        }
        #region Methods

        #region UI Changes

        /// <summary>
        /// Determines if the score input should be enabled
        /// </summary>
        private void allowScores()
        {
            if (txtStudentInfo.Text == "")
            {
                gridStudentScores.IsEnabled = false;
            }
            else
            {
                gridStudentScores.IsEnabled = true;
            }
        }

        /// <summary>
        /// Determines which of the navigation buttons to enable
        /// </summary>
        /// <param name="position">Current general position in array</param>
        private void allowNavBtns(int position)
        {
            switch (position)
            {
                case 1: //First Student Edge
                    {
                        btnFirstStudent.IsEnabled = false;
                        btnPrevStudent.IsEnabled = false;
                        btnNextStudent.IsEnabled = true;
                        btnLastStudent.IsEnabled = true;
                        break;
                    }
                case 2: //In the middle
                    {
                        btnFirstStudent.IsEnabled = true;
                        btnPrevStudent.IsEnabled = true;
                        btnNextStudent.IsEnabled = true;
                        btnLastStudent.IsEnabled = true;
                        break;
                    }
                case 3: //Last Student Edge
                    {
                        btnFirstStudent.IsEnabled = true;
                        btnPrevStudent.IsEnabled = true;
                        btnNextStudent.IsEnabled = false;
                        btnLastStudent.IsEnabled = false;
                        break;
                    }
                case 4: //Before text entry
                    {
                        btnFirstStudent.IsEnabled = false;
                        btnPrevStudent.IsEnabled = false;
                        btnNextStudent.IsEnabled = false;
                        btnLastStudent.IsEnabled = false;
                        break;
                    }
            }
        }

        /// <summary>
        /// Determines if Student Information should be filled out
        /// </summary>
        private void fillStudentInfo()
        {
            if (ClassOfStudents[position].StudentName.Contains("#"))
            {
                txtStudentInfo.Text = ClassOfStudents[position].StudentName;
                checkPosition(false);
            }
            else
            {
                txtStudentInfo.Text = ClassOfStudents[position].StudentName;
                allowScores();
            }
        }

        /// <summary>
        /// Displays a list of students and their scores on each assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDisplayScores_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder scores = new StringBuilder();
            scores.AppendFormat("{0,15}\t", "STUDENT");
            for (int i = 0; i < iNumOfAssign; i++)
            {
                scores.AppendFormat("{0,-5}\t", "#" + (i + 1));
            }
            scores.AppendFormat("{0,-5}\t", "AVG");
            scores.AppendFormat("{0,-5}\n", "GRADE");
            double dTotalScore = 0;
            foreach (Student student in ClassOfStudents)
            {
                scores.AppendFormat("{0,15}\t", student.StudentName);
                for (int i = 0; i < iNumOfAssign; i++)
                {
                    double dStudentScore = student.getStudentScore(i);
                    dTotalScore += dStudentScore;
                    scores.AppendFormat("{0:0.0}%\t", dStudentScore);
                }
                double dAverage = dTotalScore / iNumOfAssign;
                scores.AppendFormat("{0:0.0}%\t", dAverage);
                if (dAverage >= 90)
                {
                    scores.AppendFormat("{0,5}\n", "A");
                }
                else if (dAverage >= 80)
                {
                    scores.AppendFormat("{0,5}\n", "B");
                }
                else if (dAverage >= 70)
                {
                    scores.AppendFormat("{0,5}\n", "C");
                }
                else if (dAverage >= 60)
                {
                    scores.AppendFormat("{0,5}\n", "D");
                }
                else
                {
                    scores.AppendFormat("{0,5}\n", "F");
                }
            }

            txtBlockData.Text = scores.ToString();
        }

        /// <summary>
        /// Resets application back to its original state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            position = 0;
            iNumOfAssign = 0;
            iNumOfAssign = 0;
            ClassOfStudents.Clear();
            txtNumOfAssign.Text = "";
            txtAssignNum.Text = "";
            txtNumOfStudents.Text = "";
            txtStudentInfo.Text = "";
            txtAssignNum.Text = "";
            txtAssignScore.Text = "";
            txtBlockData.Text = "";
            checkPosition(false);
            btnSaveName.IsEnabled = false;
            btnDisplayScores.IsEnabled = false;
            txtNumOfAssign.BorderBrush = Brushes.Black;
            txtNumOfStudents.BorderBrush = Brushes.Black;
        }
        #endregion

        #region Save Button Clicks

        /// <summary>
        /// Saves the entered student's name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveName_Click(object sender, RoutedEventArgs e)
        {
            txtStudentInfo.BorderBrush = Brushes.Black;
            //Checks input of txtStudentInfo.Text
            if (Regex.IsMatch(txtStudentInfo.Text, @"^[a-zA-Z]+$"))
            {
                txtStudentInfo.BorderBrush = Brushes.LawnGreen;
                //Sets the StudentName property of specified student in ClassOfStudents
                ClassOfStudents[position].StudentName = txtStudentInfo.Text;
                if (position != ClassOfStudents.Count - 1)
                {
                    btnNextStudent.IsEnabled = true;
                    btnLastStudent.IsEnabled = true;
                }
                if (position != 0)
                {
                    btnFirstStudent.IsEnabled = true;
                    btnPrevStudent.IsEnabled = true;
                }
                gridStudentScores.IsEnabled = true;
                allowScores();
            }
            else
            {
                txtStudentInfo.BorderBrush = Brushes.Red;
            }

        }
        /// <summary>
        /// Saves the students score for the specified assignment
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveScore_Click(object sender, RoutedEventArgs e)
        {
            //Variables for TryParse
            int tempPosition;
            double tempScore;
            //Hides invalid labels
            lblAssignScoreValid.Visibility = Visibility.Hidden;
            lblAssignNumValid.Visibility = Visibility.Hidden;
            //Validate input in txtAssignNum.Text and txtAssignScore.Text
            if (Int32.TryParse(txtAssignNum.Text, out tempPosition) && (tempPosition > 0 && tempPosition <= iNumOfAssign))
            {
                if (Double.TryParse(txtAssignScore.Text, out tempScore) && (tempScore >= 0 && tempScore <= 100))
                {
                    //Sets student score of specified assignment
                    ClassOfStudents[position].setStudentScore(tempPosition, tempScore);
                    txtAssignNum.Text = "";
                    txtAssignScore.Text = "";
                }
                else
                {
                    lblAssignScoreValid.Visibility = Visibility.Visible;
                }
            }
            else
            {
                lblAssignNumValid.Visibility = Visibility.Visible;
            }
        }
        /// <summary>
        /// Submits number of students and number of assignments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmitCounts_Click(object sender, RoutedEventArgs e)
        {
            txtNumOfAssign.BorderBrush = Brushes.Black;
            txtNumOfStudents.BorderBrush = Brushes.Black;
            //Validate txtNumOfStudents.Text and txtNumOfAssign.Text input
            if (Int32.TryParse(txtNumOfStudents.Text, out iNumOfStudents) && iNumOfStudents <= 10)
            {
                txtNumOfStudents.BorderBrush = Brushes.LawnGreen;
                if (Int32.TryParse(txtNumOfAssign.Text, out iNumOfAssign) && iNumOfAssign <= 99)
                {
                    txtNumOfAssign.BorderBrush = Brushes.LawnGreen;
                    for (int i = 0; i < iNumOfStudents; i++)
                    {
                        //Initializes each student in the array of Students
                        ClassOfStudents.Add(new Student("Student #" + (i + 1), iNumOfAssign));
                    }
                    lblAssignNum.Content = "Assignment number (1-" + iNumOfAssign + "):";
                    gbStudentInfo.IsEnabled = true;
                    btnDisplayScores.IsEnabled = true;
                    fillStudentInfo();
                }
                else
                {
                    txtNumOfAssign.BorderBrush = Brushes.Red;
                }
            }
            else
            {
                txtNumOfStudents.BorderBrush = Brushes.Red;
            }
        }
        #endregion

        #region Navigation Button Functions
        /// <summary>
        /// Sets the position of the student array to the first student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirstStudent_Click(object sender, RoutedEventArgs e)
        {
            position = 0;
            checkPosition();
            fillStudentInfo();            
        }
        /// <summary>
        /// Sets the position of the student array to the previous student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevStudent_Click(object sender, RoutedEventArgs e)
        {
            position--;
            checkPosition();
            fillStudentInfo();
        }
        /// <summary>
        /// Sets the position of the student array to the next student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNextStudent_Click(object sender, RoutedEventArgs e)
        {
            position++;
            checkPosition();
            fillStudentInfo();
        }
        /// <summary>
        /// Sets the position of the student array to the last student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLastStudent_Click(object sender, RoutedEventArgs e)
        {
            position = ClassOfStudents.Count - 1;
            checkPosition();
            fillStudentInfo();
        }
        #endregion

        /// <summary>
        /// Checks the position in ClassOfStudents, as well as if
        /// the student's name has been saved, to determine
        /// which navigation buttons should be displayed
        /// </summary>
        /// <param name="nameSaved">Student Name Saved</param>
        private void checkPosition(bool nameSaved = true)
        {
            if (position == 0 && nameSaved == true)
            {
                allowNavBtns(1);
            }
            else if (position == iNumOfStudents - 1 && nameSaved == true)
            {
                allowNavBtns(3);
            }
            else if (nameSaved == true)
            {
                allowNavBtns(2);
            }
            else
            {
                allowNavBtns(4);
            }
        }

        #endregion

    }
    class Student
    {
        #region Attributes
        //Attributes
        private string name;
        private double[] scores;
        #endregion
        #region Constructors
        /// <summary>
        /// Default constructor for student
        /// </summary>
        /// <param name="name">Student Name</param>
        /// <param name="iNumOfAssign">Number of Assignments</param>
        public Student(string name, int iNumOfAssign)
        {
            this.name = name;
            scores = new double[iNumOfAssign];
            for (int i = 0; i < iNumOfAssign; i++)
            {
                scores[i] = 0;
            }
        }
        #endregion
        #region Properties
        public string StudentName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        #endregion
        #region Methods
        /// <summary>
        /// Sets the chosen student's score
        /// </summary>
        /// <param name="position">Student in array</param>
        /// <param name="score">Score</param>
        public void setStudentScore(int position, double score)
        {
            scores[position - 1] = score;
        }
        /// <summary>
        /// Returns the chosen student's score
        /// </summary>
        /// <param name="assignNum">Assignment Number</param>
        /// <returns>Student Score</returns>
        public double getStudentScore(int assignNum)
        {
            return scores[assignNum];
        }
        #endregion
    }
}
