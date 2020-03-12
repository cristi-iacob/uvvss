using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chestionar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetButton.Hide();
            NextButton.Hide();
            DeleteAnswersButton.Hide();
        }

        repository.QuestionRepository QuestionRepository = new repository.QuestionRepository();
        controller.QuizController quizController;
        int QuestionNumber;
        bool[] Visited = new bool[26];
        int TimeLeft;

        private void DisplayQuestion(int questionNumber)
        {
            IntrebareTextBox.Text = quizController.Quiz.Questions[questionNumber].ID + " " + quizController.Quiz.Questions[questionNumber].Intrebare;
            VariantaATextBox.Text = quizController.Quiz.Questions[questionNumber].Variante[0];
            VariantaBTextBox.Text = quizController.Quiz.Questions[questionNumber].Variante[1];
            VariantaCTextBox.Text = quizController.Quiz.Questions[questionNumber].Variante[2];
            VariantaDTextBox.Text = quizController.Quiz.Questions[questionNumber].Variante[3];
        }

        private void InitializeVisited()
        {
            for (int i = 0; i < 26; ++i)
                Visited[i] = false;
        }

        private void ResetCorecteGresite()
        {
            NumarCorecteLabel.Text = "0";
            NumarGresiteLabel.Text = "0";
        }

        private void Start()
        {
            AddQuestionButton.Hide();
            DeleteAnswersButton.Show();
            ResetButton.Show();
            NextButton.Show();
            InitializeVisited();
            ResetCorecteGresite();
            StartButton.Hide();
            IDLabel.Hide();
            IDTextField.Hide();
            
            TimeLeft = 1800;
            Timp.Start();
            TimeLabel.Show();

            List<model.Question> questions = QuestionRepository.ReadAllQuestions();

            quizController = new controller.QuizController();
            QuestionNumber = 0;

            DisplayQuestion(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VariantaCLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void VariantaATextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckIfLost()
        {
            if (quizController.Quiz.Gresite >= 5)
                return true;
            return false;
        }

        private bool CheckIfPassed()
        {
            if (quizController.Quiz.Corecte >= 22)
                return true;
            return false;
        }

        private void UpdateCorecte()
        {
            NumarCorecteLabel.Text = quizController.Quiz.Corecte.ToString();
        }

        private void UpdateGresite()
        {
            NumarGresiteLabel.Text = quizController.Quiz.Gresite.ToString();
        }

        private void ResetCheckBoxes()
        {
            VariantaACheckBox.Checked = false;
            VariantaBCheckBox.Checked = false;
            VariantaCCheckBox.Checked = false;
            VariantaDCheckBox.Checked = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            List<string> variante = new List<string>();

            if (VariantaACheckBox.Checked)
            {
                variante.Add("a");
            }

            if (VariantaBCheckBox.Checked)
            {
                variante.Add("b");
            }

            if (VariantaCCheckBox.Checked)
            {
                variante.Add("c");
            }

            if (VariantaDCheckBox.Checked)
            {
                variante.Add("d");
            }

            if (variante.Count() == 0)
            {
                while (Visited[(QuestionNumber + 1) % 26])
                {
                    QuestionNumber++;

                    if (QuestionNumber == 26)
                        QuestionNumber = 0;
                }

                QuestionNumber++;
                DisplayQuestion(QuestionNumber);
                return;
            }

            Visited[QuestionNumber] = true;

            if (quizController.CheckAnswer(QuestionNumber, variante) == false)
            {
                quizController.Quiz.Gresite++;
                UpdateGresite();
            }
            else
            {
                quizController.Quiz.Corecte++;
                UpdateCorecte();
            }

            if (CheckIfLost())
            {
                IntrebareTextBox.Text = "AI PICAT!";
                NextButton.Hide();
                DeleteAnswersButton.Hide();
                AddQuestionButton.Show();
                IDLabel.Show();
                IDTextField.Show();
                ResetCheckBoxes();
                TimeLabel.Hide();
                return;
            }

            if (quizController.Quiz.Corecte + quizController.Quiz.Gresite == 26)
            {
                if (CheckIfPassed())
                {
                    IntrebareTextBox.Text = "AI TRECUT!";
                    NextButton.Hide();
                    DeleteAnswersButton.Hide();
                    AddQuestionButton.Show();
                    IDLabel.Show();
                    IDTextField.Show();
                    ResetCheckBoxes();
                    TimeLabel.Hide();
                    return;
                }

                if (CheckIfLost())
                {
                    IntrebareTextBox.Text = "AI PICAT!";
                    NextButton.Hide();
                    DeleteAnswersButton.Hide();
                    AddQuestionButton.Show();
                    IDLabel.Show();
                    IDTextField.Show();
                    ResetCheckBoxes();
                    TimeLabel.Hide();
                    return;
                }
            }

            ResetCheckBoxes();
            
            while (Visited[QuestionNumber])
            {
                QuestionNumber++;

                if (QuestionNumber == 26)
                    QuestionNumber = 0;
            }

            DisplayQuestion(QuestionNumber);
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            model.Question question = new model.Question();
            question.ID = int.Parse(IDTextField.Text);
            question.Intrebare = IntrebareTextBox.Text;
            question.Variante.Add(VariantaATextBox.Text);
            question.Variante.Add(VariantaBTextBox.Text);
            question.Variante.Add(VariantaCTextBox.Text);
            question.Variante.Add(VariantaDTextBox.Text);

            if (VariantaACheckBox.Checked)
                question.Corecte.Add("a");
            if (VariantaBCheckBox.Checked)
                question.Corecte.Add("b");
            if (VariantaCCheckBox.Checked)
                question.Corecte.Add("c");
            if (VariantaDCheckBox.Checked)
                question.Corecte.Add("d");

            QuestionRepository.AddQuestion(question);

            ResetCheckBoxes();
        }

        private void DeleteAnswersButton_Click(object sender, EventArgs e)
        {
            ResetCheckBoxes();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TimeLabel.Text = "30:00";
            Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (sender != Timp)
              //  return;

            if (TimeLeft > 0)
            {
                TimeLeft--;
                TimeLabel.Text = (TimeLeft / 60).ToString() + ":" + (TimeLeft % 60).ToString();
                return;
            }

            if (quizController.Quiz.Corecte >= 22)
                IntrebareTextBox.Text = "Timpul a expirat! Ai trecut!";
            else
                IntrebareTextBox.Text = "Timpul a expirat! Ai picat!";

            NextButton.Hide();
            DeleteAnswersButton.Hide();
            AddQuestionButton.Show();
            Timp.Stop();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            TimeLabel.Hide();
            NextButton.Hide();
            AddQuestionButton.Show();
            StartButton.Show();
            ResetButton.Hide();
            IDLabel.Show();
            IDTextField.Show();
            DeleteAnswersButton.Hide();
            Timp.Stop();
        }
    }
}
