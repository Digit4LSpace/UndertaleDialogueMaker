namespace UndertaleDialogueMaker
{
    public partial class Form1 : Form
    {
        private string currentChar = "";

        private string customFallen = "Chara";

        private bool isEntryNumber17 = false;

        private void ApplyCharacter(int Char)
        {
            switch (Char)
            {
                case 0:
                    // System
                    label1.Text = "Character selected: System";
                    currentChar = "System";
                    isEntryNumber17 = false;
                    break;
                case 1:
                    // Flowey
                    label1.Text = "Character selected: Flowey";
                    currentChar = "Flowey";
                    isEntryNumber17 = false;
                    break;
                case 2:
                    // Toriel
                    label1.Text = "Character selected: Toriel";
                    currentChar = "Toriel";
                    isEntryNumber17 = false;
                    break;
                case 3:
                    // Sans
                    label1.Text = "Character selected: sans";
                    currentChar = "sans";
                    isEntryNumber17 = false;
                    break;
                case 4:
                    // Papyrus
                    label1.Text = "Character selected: Papyrus";
                    currentChar = "Papyrus";
                    isEntryNumber17 = false;
                    break;
                case 5:
                    // Undyne
                    label1.Text = "Character selected: Undyne";
                    currentChar = "Undyne";
                    isEntryNumber17 = false;
                    break;
                case 6:
                    // Alphys
                    label1.Text = "Character selected: Alphys";
                    currentChar = "Alphys";
                    isEntryNumber17 = false;
                    break;
                case 7:
                    // Mettaton
                    label1.Text = "Character selected: Mettaton";
                    currentChar = "Mettaton";
                    isEntryNumber17 = false;
                    break;
                case 8:
                    // Asgore
                    label1.Text = "Character selected: Asgore";
                    currentChar = "Asgore";
                    isEntryNumber17 = false;
                    break;
                case 9:
                    // Asriel
                    label1.Text = "Character selected: Asriel";
                    currentChar = "Asriel";
                    isEntryNumber17 = false;
                    break;
                case 10:
                    // Chara
                    label1.Text = "Character selected: " + customFallen;
                    currentChar = customFallen;
                    isEntryNumber17 = false;
                    break;
                case 11:
                    // You
                    label1.Text = "Character selected: You";
                    currentChar = "";
                    isEntryNumber17 = false;
                    break;
                case 12:
                    // Froggit
                    label1.Text = "Character selected: Froggit";
                    currentChar = "Froggit";
                    isEntryNumber17 = false;
                    break;
                case 13:
                    // Whimsun
                    label1.Text = "Character selected: Whimsun";
                    currentChar = "Whimsun";
                    isEntryNumber17 = false;
                    break;
                case 14:
                    // Moldsmal
                    label1.Text = "Character selected: Moldsmal";
                    currentChar = "Moldsmal";
                    isEntryNumber17 = false;
                    break;
                case 15:
                    // Vegetoid
                    label1.Text = "Character selected: Vegetoid";
                    currentChar = "Vegetoid";
                    isEntryNumber17 = false;
                    break;
                case 16:
                    // Migosp
                    label1.Text = "Character selected: Migosp";
                    currentChar = "Migosp";
                    isEntryNumber17 = false;
                    break;
                case 17:
                    // Loox
                    label1.Text = "Character selected: Loox";
                    currentChar = "Loox";
                    isEntryNumber17 = false;
                    break;
                case 18:
                    // Snowdrake
                    label1.Text = "Character selected: Snowdrake";
                    currentChar = "Snowdrake";
                    isEntryNumber17 = false;
                    break;
                case 19:
                    // Doggo
                    label1.Text = "Character selected: Doggo";
                    currentChar = "Doggo";
                    isEntryNumber17 = false;
                    break;
                case 20:
                    // Lesser Dog
                    label1.Text = "Character selected: Lesser Dog";
                    currentChar = "Lesser Dog";
                    isEntryNumber17 = false;
                    break;
                case 21:
                    // Greater Dog
                    label1.Text = "Character selected: Greater Dog";
                    currentChar = "Greater Dog";
                    isEntryNumber17 = false;
                    break;
                case 22:
                    // Jerry
                    label1.Text = "Character selected: Jerry";
                    currentChar = "Jerry";
                    isEntryNumber17 = false;
                    break;
                case 23:
                    // Dogamy
                    label1.Text = "Character selected: Dogamy";
                    currentChar = "Dogamy";
                    isEntryNumber17 = false;
                    break;
                case 24:
                    // Dogaressa
                    label1.Text = "Character selected: Dogaressa";
                    currentChar = "Dogaressa";
                    isEntryNumber17 = false;
                    break;
                case 25:
                    // Gyftrot
                    label1.Text = "Character selected: Gyftrot";
                    currentChar = "Gyftrot";
                    isEntryNumber17 = false;
                    break;
                case 26:
                    // Glyde
                    label1.Text = "Character selected: Glyde";
                    currentChar = "Glyde";
                    isEntryNumber17 = false;
                    break;
                case 27:
                    // Ice Cap
                    label1.Text = "Character selected: Ice Cap";
                    currentChar = "Ice Cap";
                    isEntryNumber17 = false;
                    break;
                case 28:
                    // Aaron
                    label1.Text = "Character selected: Aaron";
                    currentChar = "Aaron";
                    isEntryNumber17 = false;
                    break;
                case 29:
                    // Woshua
                    label1.Text = "Character selected: Woshua";
                    currentChar = "Woshua";
                    isEntryNumber17 = false;
                    break;
                case 30:
                    // Shyren
                    label1.Text = "Character selected: Shyren";
                    currentChar = "Shyren";
                    isEntryNumber17 = false;
                    break;
                case 31:
                    // Temmie
                    label1.Text = "Character selected: Temmie";
                    currentChar = "Temmie";
                    isEntryNumber17 = false;
                    break;
                case 32:
                    // Moldbygg
                    label1.Text = "Character selected: Moldbygg";
                    currentChar = "Moldbygg";
                    isEntryNumber17 = false;
                    break;
                case 33:
                    // Mad Dummy
                    label1.Text = "Character selected: Mad Dummy";
                    currentChar = "Mad Dummy";
                    isEntryNumber17 = false;
                    break;
                case 34:
                    // Vulkin
                    label1.Text = "Character selected: Vulkin";
                    currentChar = "Vulkin";
                    isEntryNumber17 = false;
                    break;
                case 35:
                    // Tsunderplane
                    label1.Text = "Character selected: Tsunderplane";
                    currentChar = "Tsunderplane";
                    isEntryNumber17 = false;
                    break;
                case 36:
                    // Pyrope
                    label1.Text = "Character selected: Pyrope";
                    currentChar = "Pyrope";
                    isEntryNumber17 = false;
                    break;
                case 37:
                    // So Sorry
                    label1.Text = "Character selected: So Sorry";
                    currentChar = "So Sorry";
                    isEntryNumber17 = false;
                    break;
                case 38:
                    // Madjick
                    label1.Text = "Character selected: Madjick";
                    currentChar = "Madjick";
                    isEntryNumber17 = false;
                    break;
                case 39:
                    // Muffet
                    label1.Text = "Character selected: Muffet";
                    currentChar = "Muffet";
                    isEntryNumber17 = false;
                    break;
                case 40:
                    // Knight Knight
                    label1.Text = "Character selected: Knight Knight";
                    currentChar = "Knight Knight";
                    isEntryNumber17 = false;
                    break;
                case 41:
                    // Final Froggit
                    label1.Text = "Character selected: Final Froggit";
                    currentChar = "Final Froggit";
                    isEntryNumber17 = false;
                    break;
                case 42:
                    // Whimsalot
                    label1.Text = "Character selected: Whimsalot";
                    currentChar = "Whimsalot";
                    isEntryNumber17 = false;
                    break;
                case 43:
                    // Astigmatism
                    label1.Text = "Character selected: Astigmatism";
                    currentChar = "Astigmatism";
                    isEntryNumber17 = false;
                    break;
                case 44:
                    // Memoryhead
                    label1.Text = "Character selected: Memoryhead";
                    currentChar = "Memoryhead";
                    isEntryNumber17 = false;
                    break;
                case 45:
                    // Reaper Bird
                    label1.Text = "Character selected: Reaper Bird";
                    currentChar = "Reaper Bird";
                    isEntryNumber17 = false;
                    break;
                case 46:
                    // Endogeny
                    label1.Text = "Character selected: Endogeny";
                    currentChar = "Endogeny";
                    isEntryNumber17 = false;
                    break;
                case 47:
                    // Lemon Bread
                    label1.Text = "Character selected: Lemon Bread";
                    currentChar = "Lemon Bread";
                    isEntryNumber17 = false;
                    break;
                case 48:
                    // Snowdrake's Mother
                    label1.Text = "Character selected: Snowdrake's Mother";
                    currentChar = "Snowdrake's Mother";
                    isEntryNumber17 = false;
                    break;
                case 49:
                    // Annoying Dog
                    label1.Text = "Character selected: Annoying Dog";
                    currentChar = "Annoying Dog";
                    isEntryNumber17 = false;
                    break;
                case 50:
                    // W. D. Gaster
                    label1.Text = "Character selected: W. D. Gaster";
                    currentChar = "W. D. Gaster";
                    isEntryNumber17 = true;
                    break;
                default:
                    // nah
                    label1.Text = "Character selected: ERROR";
                    currentChar = "ERROR";
                    isEntryNumber17 = false;
                    break;
            }
        }

        private void ApplyCustomChar()
        {
            if (textBoxCustomChar.Text != "")
            {
                currentChar = textBoxCustomChar.Text;
                label1.Text = "Character selected: " + textBoxCustomChar.Text;
            }
        }

        private void ApplyCustomFallen()
        {
            if (textBoxFallenName.Text != "")
            {
                customFallen = textBoxFallenName.Text;
                charButton_Chara.Text = customFallen;
            }
        }

        private void ApplyText()
        {
            string message = textBox_Input.Text;

            if (checkBoxSpaced.Checked)
            {
                message = string.Join(" ", message.ToCharArray());
            }

            if (checkBoxWonky.Checked)
            {
                string wonkyResult = "";
                int letterIndex = 0;
                for (int i = 0; i < message.Length; i++)
                {
                    char c = message[i];
                    if (c == ' ')
                    {
                        wonkyResult += c;
                    }
                    else
                    {
                        if (letterIndex % 2 == 0)
                            wonkyResult += char.ToUpper(c);
                        else
                            wonkyResult += char.ToLower(c);
                        letterIndex++;
                    }
                }
                message = wonkyResult;
            }

            if (checkBoxCaps.Checked)
            {
                message = message.ToUpper();
            }

            if (isEntryNumber17)
            {
                string wingdingsResult = "";
                foreach (char c in message.ToLower())
                {
                    if (wingdingsMap.ContainsKey(c))
                        wingdingsResult += wingdingsMap[c];
                    else
                        wingdingsResult += c; // keep spaces, punctuation, etc. as-is
                }
                message = wingdingsResult;
            }

            textBox1.Text = currentChar + " *" + message;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplyCharacter(0);
            textBoxCustomChar.Text = "";
            textBoxFallenName.Text = "";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ApplyText();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox_Input.Text = "";
        }

        private void buttonApplyCustomChar_Click(object sender, EventArgs e)
        {
            ApplyCustomFallen();
        }

        private void buttonCustomChar_Click(object sender, EventArgs e)
        {
            ApplyCustomChar();
        }

        private void charButton_System_Click(object sender, EventArgs e)
        {
            ApplyCharacter(0);
        }
        private void charButton_Flowey_Click(object sender, EventArgs e)
        {
            ApplyCharacter(1);
        }
        private void charButton_Toriel_Click(object sender, EventArgs e)
        {
            ApplyCharacter(2);
        }
        private void charButton_sans_Click(object sender, EventArgs e)
        {
            ApplyCharacter(3);
        }
        private void charButton_Papyrus_Click(object sender, EventArgs e)
        {
            ApplyCharacter(4);
        }
        private void charButton_Undyne_Click(object sender, EventArgs e)
        {
            ApplyCharacter(5);
        }
        private void charButton_Alphys_Click(object sender, EventArgs e)
        {
            ApplyCharacter(6);
        }
        private void charButton_Mettaton_Click(object sender, EventArgs e)
        {
            ApplyCharacter(7);
        }
        private void charButton_Asgore_Click(object sender, EventArgs e)
        {
            ApplyCharacter(8);
        }
        private void charButton_Asriel_Click(object sender, EventArgs e)
        {
            ApplyCharacter(9);
        }
        private void charButton_Chara_Click(object sender, EventArgs e)
        {
            ApplyCharacter(10);
        }
        private void charButton_You_Click(object sender, EventArgs e)
        {
            ApplyCharacter(11);
        }

        private void charButton_Froggit_Click(object sender, EventArgs e)
        {
            ApplyCharacter(12);
        }

        private void charButton_Whimsun_Click(object sender, EventArgs e)
        {
            ApplyCharacter(13);
        }

        private void charButton_Moldsmal_Click(object sender, EventArgs e)
        {
            ApplyCharacter(14);
        }

        private void charButton_Vegetoid_Click(object sender, EventArgs e)
        {
            ApplyCharacter(15);
        }

        private void charButton_Migosp_Click(object sender, EventArgs e)
        {
            ApplyCharacter(16);
        }

        private void charButton_Loox_Click(object sender, EventArgs e)
        {
            ApplyCharacter(17);
        }

        private void charButton_Snowdrake_Click(object sender, EventArgs e)
        {
            ApplyCharacter(18);
        }

        private void charButton_Doggo_Click(object sender, EventArgs e)
        {
            ApplyCharacter(19);
        }

        private void charButton_LesserDog_Click(object sender, EventArgs e)
        {
            ApplyCharacter(20);
        }

        private void charButton_GreaterDog_Click(object sender, EventArgs e)
        {
            ApplyCharacter(21);
        }

        private void charButton_Jerry_Click(object sender, EventArgs e)
        {
            ApplyCharacter(22);
        }

        private void charButton_Dogamy_Click(object sender, EventArgs e)
        {
            ApplyCharacter(23);
        }

        private void charButton_Dogaressa_Click(object sender, EventArgs e)
        {
            ApplyCharacter(24);
        }

        private void charButton_Gyftrot_Click(object sender, EventArgs e)
        {
            ApplyCharacter(25);
        }

        private void charButton_Glyde_Click(object sender, EventArgs e)
        {
            ApplyCharacter(26);
        }

        private void charButton_IceCap_Click(object sender, EventArgs e)
        {
            ApplyCharacter(27);
        }

        private void charButton_Aaron_Click(object sender, EventArgs e)
        {
            ApplyCharacter(28);
        }

        private void charButton_Woshua_Click(object sender, EventArgs e)
        {
            ApplyCharacter(29);
        }

        private void charButton_Shyren_Click(object sender, EventArgs e)
        {
            ApplyCharacter(30);
        }

        private void charButton_Temmie_Click(object sender, EventArgs e)
        {
            ApplyCharacter(31);
        }

        private void charButton_Moldbygg_Click(object sender, EventArgs e)
        {
            ApplyCharacter(32);
        }

        private void charButton_MadDummy_Click(object sender, EventArgs e)
        {
            ApplyCharacter(33);
        }
        private void charButton_Vulkin_Click(object sender, EventArgs e)
        {
            ApplyCharacter(34);
        }
        private void charButton_Tsunderplane_Click(object sender, EventArgs e)
        {
            ApplyCharacter(35);
        }
        private void charButton_Pyrope_Click(object sender, EventArgs e)
        {
            ApplyCharacter(36);
        }
        private void charButton_SoSorry_Click(object sender, EventArgs e)
        {
            ApplyCharacter(37);
        }
        private void charButton_Madjick_Click(object sender, EventArgs e)
        {
            ApplyCharacter(38);
        }
        private void charButton_Muffet_Click(object sender, EventArgs e)
        {
            ApplyCharacter(39);
        }
        private void charButton_KnightKnight_Click(object sender, EventArgs e)
        {
            ApplyCharacter(40);
        }
        private void charButton_FinalFroggit_Click(object sender, EventArgs e)
        {
            ApplyCharacter(41);
        }
        private void charButton_Whimsalot_Click(object sender, EventArgs e)
        {
            ApplyCharacter(42);
        }
        private void charButton_Astigmatism_Click(object sender, EventArgs e)
        {
            ApplyCharacter(43);
        }
        private void charButton_Memoryhead_Click(object sender, EventArgs e)
        {
            ApplyCharacter(44);
        }
        private void charButton_ReaperBird_Click(object sender, EventArgs e)
        {
            ApplyCharacter(45);
        }
        private void charButton_Endogeny_Click(object sender, EventArgs e)
        {
            ApplyCharacter(46);
        }
        private void charButton_LemonBread_Click(object sender, EventArgs e)
        {
            ApplyCharacter(47);
        }
        private void charButton_SnowMother_Click(object sender, EventArgs e)
        {
            ApplyCharacter(48);
        }
        private void charButton_AnnoyingDog_Click(object sender, EventArgs e)
        {
            ApplyCharacter(49);
        }
        private void charButton_WDGaster_Click(object sender, EventArgs e)
        {
            ApplyCharacter(50);
        }

        private readonly Dictionary<char, string> wingdingsMap = new Dictionary<char, string>
        {
            {'a', "✌︎"}, {'b', "👌︎"}, {'c', "👍︎"}, {'d', "👎︎"}, {'e', "☝︎"},
            {'f', "✋︎"}, {'g', "☺︎"}, {'h', "😐︎"}, {'i', "☹︎"}, {'j', "💣︎"},
            {'k', "☠︎"}, {'l', "⚐︎"}, {'m', "🏳︎"}, {'n', "🏱︎"}, {'o', "✈︎"},
            {'p', "☼︎"}, {'q', "💧︎"}, {'r', "❄︎"}, {'s', "🕆︎"}, {'t', "✞︎"},
            {'u', "🕈︎"}, {'v', "✟︎"}, {'w', "☯︎"}, {'x', "🕉︎"}, {'y', "☮︎"},
            {'z', "🕎︎"}
        };
    }
}