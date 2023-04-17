namespace Guessing_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lblYourGuess.Text = "";
            lblCorrect.Text = "";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string topic = cmbTopic.Items[cmbTopic.SelectedIndex].ToString();

            Random random = new Random();
            int rnd = random.Next(0, 4);
            string hint = "";

            if (topic == "Car Brands") // Topic 1
            {
                switch (rnd) // Randomises the hints for topic 1
                {
                    default:
                    case 0:
                        hint = "Japan"; // Hint for Toyota
                        break;
                    case 1:
                        hint = "USA"; // Hint for Chevrolet
                        break;
                    case 2:
                        hint = "Germany"; // Hint for Audi
                        break;
                    case 3:
                        hint = "Italy"; // Hint for Ferrari
                        break;
                }
            }
            else if (topic == "Flowers") // Topic 2
            {
                switch (rnd) // Randomises the hints for topic 2
                {
                    default:
                    case 0:
                        hint = "Purple"; // Hint for Lavender
                        break;
                    case 1:
                        hint = "Yellow"; // Hint for Dandelion
                        break;
                    case 2:
                        hint = "Red"; // Hint for Rose
                        break;
                    case 3:
                        hint = "White"; // Hint for Lily
                        break;
                }
            }
            else if (topic == "Countries in Europe") // Topic 3
            {
                switch (rnd) // Randomises the hints for topic 3
                {
                    default:
                    case 0:
                        hint = "Eiffel Tower"; // Hint for France
                        break;
                    case 1:
                        hint = "Colosseum"; // Hint for Italy
                        break;
                    case 2:
                        hint = "Big Ben"; // Hint for England
                        break;
                    case 3:
                        hint = "Parthenon"; // Hint for Greece
                        break;
                }
            }

            txtHint.Text = hint;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string operatorWord = txtGuess.Text;
            bool correct = false;
            string hint = txtHint.Text;
            string correctWord;

            switch (hint)
            {
                case "Japan":
                    if (operatorWord.ToLower() == "toyota")

                        correct = true;
                    else
                        correct = false;

                    correctWord = "Toyota";
                    DisplayAns(correct, correctWord);
                    break;

                case "USA":
                    if (operatorWord.ToLower() == "chevrolet")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Chevrolet";
                    DisplayAns(correct, correctWord);
                    break;

                case "Germany":
                    if (operatorWord.ToLower() == "audi")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Audi";
                    DisplayAns(correct, correctWord);
                    break;

                case "Italy":
                    if (operatorWord.ToLower() == "ferrari")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Ferrari";
                    DisplayAns(correct, correctWord);
                    break;

                case "Purple":
                    if (operatorWord.ToLower() == "lavender")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Lavender";
                    DisplayAns(correct, correctWord);
                    break;

                case "Yellow":
                    if (operatorWord.ToLower() == "dandelion")
                        correct = true;
                    else
                        correct = false;
                    correctWord = "Dandelion";
                    DisplayAns(correct, correctWord);
                    break;

                case "Red":
                    if (operatorWord.ToLower() == "rose")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Rose";
                    DisplayAns(correct, correctWord);
                    break;

                case "White":
                    if (operatorWord.ToLower() == "lily")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "Lily";
                    DisplayAns(correct, correctWord);
                    break;

                case "Eiffel Tower":
                    if (operatorWord.ToLower() == "france")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "France";
                    DisplayAns(correct, correctWord);
                    break;

                case "Colosseum":
                    if (operatorWord.ToLower() == "italy")
                        correct = true;
                    else
                        correct = false;
                    correctWord = "Italy";
                    DisplayAns(correct, correctWord);
                    break;

                case "Big Ben":
                    if (operatorWord.ToLower() == "england")
                        correct = true;
                    else
                        correct = false;

                    correctWord = "England";
                    DisplayAns(correct, correctWord);
                    break;

                case "Parthenon":
                    if (operatorWord.ToLower() == "greece")
                        correct = true;
                    else
                        correct = false;
                    correctWord = "Greece";
                    DisplayAns(correct, correctWord);
                    break;
            }
        }

        private void DisplayAns(bool correct, string correctWord)
        {
            if (correct)
            {
                lblYourGuess.Text = "Your guess was correct";
                lblCorrect.Text = "You guessed " + correctWord;
            }
            else
            {
                lblYourGuess.Text = "Your guess was incorrect";
                lblCorrect.Text = "The correct word was " + correctWord;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Closes the program
        }
    }
}
