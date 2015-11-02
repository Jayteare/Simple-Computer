using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimpleComputer
{
    public partial class Base : Form
    {

        /*****************************************************************
        * MAIN REGION | Memory
        * ----------------------------------------------------------------
        * This section is the base section of the program.
        * ----------------------------------------------------------------
        * 
        * Base                  - The base form init.
        * Base Load             - Button load object form. 
        * Simple Computer Label - The label Click event for SC. 
        * 
        * SUB REGION Base Buttons 
        * - Save Click Event
        * - Load Click Event 
        * -  
        ******************************************************************/
        #region Base

        /* The form is being initialized here. */
        public Base()
        {
            InitializeComponent();
        }

        /*****************************************************************
        * VOID| Base Load button
        * ----------------------------------------------------------------
        * Basic button form of the load button in the simple computer. 
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void Base_Load(object sender, EventArgs e)
        {
            //BASE OBJECT FORM OF THE LOAD BUTTON IS LOADED...
        }

        /*****************************************************************
        * VOID| Simple Computer label Click Event
        * ----------------------------------------------------------------
        * The Simple Computers Main Label. This function is designed to 
        * open information regarding the Simple Computer.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void SimpleComputerlbl_Click(object sender, EventArgs e)
        {
            var newHelpForm = new SImpleCmp1(); //Creates the new form.

            newHelpForm.Show(); //Displays the new Form.
        }

            /*****************************************************************
            * SUB-REGION | Base Buttons
            * ----------------------------------------------------------------
            * This sub-region holds base buttons listed below.
            * ----------------------------------------------------------------
            * 
            * + Save Click Event - The save click event for the program.
            * + Load Click Event - The load click event for the program.
            * + About Click      - The about box based on the program.
            * + Help Click       - The help box about the program. 
            *  
            ******************************************************************/
            #region Base Buttons

                /*****************************************************************
                * VOID| Save Click Event
                * ----------------------------------------------------------------
                * This click event is designed to save the minimal required
                * material. Save Click event uses a SaveFileDialog in order to
                * open any accesable location within the computers grasp. 
                * 
                * RETURNS: Nothing.
                ******************************************************************/
                private void Save_Click(object sender, EventArgs e)
                {

                    SaveFileDialog mySaveFileDialog1 = new SaveFileDialog();

                    mySaveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; //The current filter to .txt formats.
                    mySaveFileDialog1.FilterIndex = 2;
                    mySaveFileDialog1.RestoreDirectory = true;

                    /* This statement checks the openfile dialog, if the contents of the system is OK,
                     * it advances to running the contents of the statement.*/
                    if (mySaveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        using (Stream myStream = File.Open(mySaveFileDialog1.FileName, FileMode.CreateNew))
                        using (StreamWriter w = new StreamWriter(myStream)) //StreamWriter will write the contents of the selected boxes.
                        {
                            /* This section will write the contents of the Input Cards into the .txt file */
                            #region Input Cards

                            w.Write("InputBox1:" + InputBox1.Text + Environment.NewLine);
                            w.Write("InputBox2:" + InputBox2.Text + Environment.NewLine);
                            w.Write("InputBox3:" + InputBox3.Text + Environment.NewLine);
                            w.Write("InputBox4:" + InputBox4.Text + Environment.NewLine);
                            w.Write("InputBox5:" + InputBox5.Text + Environment.NewLine);
                            w.Write("InputBox6:" + InputBox6.Text + Environment.NewLine);
                            w.Write("InputBox7:" + InputBox7.Text + Environment.NewLine);
                            w.Write("InputBox8:" + InputBox8.Text + Environment.NewLine);
                            w.Write("InputBox9:" + InputBox9.Text + Environment.NewLine);
                            w.Write("InputBox10:" + InputBox10.Text + Environment.NewLine);
                            w.Write("InputBox11:" + InputBox11.Text + Environment.NewLine);
                            w.Write("InputBox12:" + InputBox12.Text + Environment.NewLine);
                            w.Write("InputBox13:" + InputBox13.Text + Environment.NewLine);
                            w.Write("InputBox14:" + InputBox14.Text + Environment.NewLine);
                            w.Write("InputBox15:" + InputBox15.Text + Environment.NewLine);

                            #endregion

                            /* This section will write the contents of the Program Counter into the .txt file
                             * Seperated out with spaces between Input Boxes and the Memory Cards*/
                            w.Write(Environment.NewLine);
                            w.Write("PCBox1:" + PCBox1.Text + Environment.NewLine);
                            w.Write(Environment.NewLine);

                            /* This section will write the contents of the Memory Cards into the .txt file */
                            #region Memory Cards

                            w.Write("MemoryBox01:" + MemoryBox01.Text + Environment.NewLine);
                            w.Write("MemoryBox02:" + MemoryBox02.Text + Environment.NewLine);
                            w.Write("MemoryBox03:" + MemoryBox03.Text + Environment.NewLine);
                            w.Write("MemoryBox04:" + MemoryBox04.Text + Environment.NewLine);
                            w.Write("MemoryBox05:" + MemoryBox05.Text + Environment.NewLine);
                            w.Write("MemoryBox06:" + MemoryBox06.Text + Environment.NewLine);
                            w.Write("MemoryBox07:" + MemoryBox07.Text + Environment.NewLine);
                            w.Write("MemoryBox08:" + MemoryBox08.Text + Environment.NewLine);
                            w.Write("MemoryBox09:" + MemoryBox09.Text + Environment.NewLine);
                            w.Write("MemoryBox10:" + MemoryBox10.Text + Environment.NewLine);
                            w.Write("MemoryBox11:" + MemoryBox11.Text + Environment.NewLine);
                            w.Write("MemoryBox12:" + MemoryBox12.Text + Environment.NewLine);
                            w.Write("MemoryBox13:" + MemoryBox13.Text + Environment.NewLine);
                            w.Write("MemoryBox14:" + MemoryBox14.Text + Environment.NewLine);
                            w.Write("MemoryBox15:" + MemoryBox15.Text + Environment.NewLine);
                            w.Write("MemoryBox16:" + MemoryBox16.Text + Environment.NewLine);
                            w.Write("MemoryBox17:" + MemoryBox17.Text + Environment.NewLine);
                            w.Write("MemoryBox18:" + MemoryBox18.Text + Environment.NewLine);
                            w.Write("MemoryBox19:" + MemoryBox19.Text + Environment.NewLine);
                            w.Write("MemoryBox20:" + MemoryBox20.Text + Environment.NewLine);
                            w.Write("MemoryBox21:" + MemoryBox21.Text + Environment.NewLine);
                            w.Write("MemoryBox22:" + MemoryBox22.Text + Environment.NewLine);
                            w.Write("MemoryBox23:" + MemoryBox23.Text + Environment.NewLine);
                            w.Write("MemoryBox24:" + MemoryBox24.Text + Environment.NewLine);
                            w.Write("MemoryBox25:" + MemoryBox25.Text + Environment.NewLine);
                            w.Write("MemoryBox26:" + MemoryBox26.Text + Environment.NewLine);
                            w.Write("MemoryBox27:" + MemoryBox27.Text + Environment.NewLine);
                            w.Write("MemoryBox28:" + MemoryBox28.Text + Environment.NewLine);
                            w.Write("MemoryBox29:" + MemoryBox29.Text + Environment.NewLine);
                            w.Write("MemoryBox30:" + MemoryBox30.Text + Environment.NewLine);
                            w.Write("MemoryBox31:" + MemoryBox31.Text + Environment.NewLine);
                            w.Write("MemoryBox32:" + MemoryBox32.Text + Environment.NewLine);
                            w.Write("MemoryBox33:" + MemoryBox33.Text + Environment.NewLine);
                            w.Write("MemoryBox34:" + MemoryBox34.Text + Environment.NewLine);
                            w.Write("MemoryBox35:" + MemoryBox35.Text + Environment.NewLine);
                            w.Write("MemoryBox36:" + MemoryBox36.Text + Environment.NewLine);
                            w.Write("MemoryBox37:" + MemoryBox37.Text + Environment.NewLine);
                            w.Write("MemoryBox38:" + MemoryBox38.Text + Environment.NewLine);
                            w.Write("MemoryBox39:" + MemoryBox39.Text + Environment.NewLine);
                            w.Write("MemoryBox40:" + MemoryBox40.Text + Environment.NewLine);
                            w.Write("MemoryBox41:" + MemoryBox41.Text + Environment.NewLine);
                            w.Write("MemoryBox42:" + MemoryBox42.Text + Environment.NewLine);
                            w.Write("MemoryBox43:" + MemoryBox43.Text + Environment.NewLine);
                            w.Write("MemoryBox44:" + MemoryBox44.Text + Environment.NewLine);
                            w.Write("MemoryBox45:" + MemoryBox45.Text + Environment.NewLine);
                            w.Write("MemoryBox46:" + MemoryBox46.Text + Environment.NewLine);
                            w.Write("MemoryBox47:" + MemoryBox47.Text + Environment.NewLine);
                            w.Write("MemoryBox48:" + MemoryBox48.Text + Environment.NewLine);
                            w.Write("MemoryBox49:" + MemoryBox49.Text + Environment.NewLine);
                            w.Write("MemoryBox50:" + MemoryBox50.Text + Environment.NewLine);
                            w.Write("MemoryBox51:" + MemoryBox51.Text + Environment.NewLine);
                            w.Write("MemoryBox52:" + MemoryBox52.Text + Environment.NewLine);
                            w.Write("MemoryBox53:" + MemoryBox53.Text + Environment.NewLine);
                            w.Write("MemoryBox54:" + MemoryBox54.Text + Environment.NewLine);
                            w.Write("MemoryBox55:" + MemoryBox55.Text + Environment.NewLine);
                            w.Write("MemoryBox56:" + MemoryBox56.Text + Environment.NewLine);
                            w.Write("MemoryBox57:" + MemoryBox57.Text + Environment.NewLine);
                            w.Write("MemoryBox58:" + MemoryBox58.Text + Environment.NewLine);
                            w.Write("MemoryBox59:" + MemoryBox59.Text + Environment.NewLine);
                            w.Write("MemoryBox60:" + MemoryBox60.Text + Environment.NewLine);
                            w.Write("MemoryBox61:" + MemoryBox61.Text + Environment.NewLine);
                            w.Write("MemoryBox62:" + MemoryBox62.Text + Environment.NewLine);
                            w.Write("MemoryBox63:" + MemoryBox63.Text + Environment.NewLine);
                            w.Write("MemoryBox64:" + MemoryBox64.Text + Environment.NewLine);
                            w.Write("MemoryBox65:" + MemoryBox65.Text + Environment.NewLine);
                            w.Write("MemoryBox66:" + MemoryBox66.Text + Environment.NewLine);
                            w.Write("MemoryBox67:" + MemoryBox67.Text + Environment.NewLine);
                            w.Write("MemoryBox68:" + MemoryBox68.Text + Environment.NewLine);
                            w.Write("MemoryBox69:" + MemoryBox69.Text + Environment.NewLine);
                            w.Write("MemoryBox70:" + MemoryBox70.Text + Environment.NewLine);
                            w.Write("MemoryBox71:" + MemoryBox71.Text + Environment.NewLine);
                            w.Write("MemoryBox72:" + MemoryBox72.Text + Environment.NewLine);
                            w.Write("MemoryBox73:" + MemoryBox73.Text + Environment.NewLine);
                            w.Write("MemoryBox74:" + MemoryBox74.Text + Environment.NewLine);
                            w.Write("MemoryBox75:" + MemoryBox75.Text + Environment.NewLine);
                            w.Write("MemoryBox76:" + MemoryBox76.Text + Environment.NewLine);
                            w.Write("MemoryBox77:" + MemoryBox77.Text + Environment.NewLine);
                            w.Write("MemoryBox78:" + MemoryBox78.Text + Environment.NewLine);
                            w.Write("MemoryBox79:" + MemoryBox79.Text + Environment.NewLine);
                            w.Write("MemoryBox80:" + MemoryBox80.Text + Environment.NewLine);
                            w.Write("MemoryBox81:" + MemoryBox81.Text + Environment.NewLine);
                            w.Write("MemoryBox82:" + MemoryBox82.Text + Environment.NewLine);
                            w.Write("MemoryBox83:" + MemoryBox83.Text + Environment.NewLine);
                            w.Write("MemoryBox84:" + MemoryBox84.Text + Environment.NewLine);
                            w.Write("MemoryBox85:" + MemoryBox85.Text + Environment.NewLine);
                            w.Write("MemoryBox86:" + MemoryBox86.Text + Environment.NewLine);
                            w.Write("MemoryBox87:" + MemoryBox87.Text + Environment.NewLine);
                            w.Write("MemoryBox88:" + MemoryBox88.Text + Environment.NewLine);
                            w.Write("MemoryBox89:" + MemoryBox89.Text + Environment.NewLine);
                            w.Write("MemoryBox90:" + MemoryBox90.Text + Environment.NewLine);
                            w.Write("MemoryBox91:" + MemoryBox91.Text + Environment.NewLine);
                            w.Write("MemoryBox92:" + MemoryBox92.Text + Environment.NewLine);
                            w.Write("MemoryBox93:" + MemoryBox93.Text + Environment.NewLine);
                            w.Write("MemoryBox94:" + MemoryBox94.Text + Environment.NewLine);
                            w.Write("MemoryBox95:" + MemoryBox95.Text + Environment.NewLine);
                            w.Write("MemoryBox96:" + MemoryBox96.Text + Environment.NewLine);
                            w.Write("MemoryBox97:" + MemoryBox97.Text + Environment.NewLine);
                            w.Write("MemoryBox98:" + MemoryBox98.Text + Environment.NewLine);
                            w.Write("MemoryBox99:" + MemoryBox99.Text + Environment.NewLine);

                            #endregion

                        }//StreamWriter - End

                    }//If Statement - End

                }//Save Click Event - End

                /*****************************************************************
                * VOID| Load Click Event
                * ----------------------------------------------------------------
                * This click event is designed to load the SC saved material to
                * the running/current application disregarding other enteries. 
                * Load Click event uses a OpenFileDialog in order to
                * open any accesable location within the computers grasp. 
                * 
                * RETURNS: Nothing.
                ******************************************************************/
                private void LoadP_Click(object sender, EventArgs e)
                {
                    int sIndex;//Special index counter to write the correct object number name.
                    Stream readStream;
                    string dText; //Temporary string that the lines will be read into one by one.
                    OpenFileDialog openFiledialog1 = new OpenFileDialog();

                    sIndex = 1;

                    /* This statement checks the openfile dialog, if the contents of the system is OK,
                     * it advances to running the contents of the statement.*/
                    if(openFiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        /* This statement checks the openfile dialog, if the contents of selected .txt file
                         * is not empty, it advances to running the contents of the statement.*/
                        if ((readStream = openFiledialog1.OpenFile()) != null)
                        {
                            string strfilename = openFiledialog1.FileName;
                            string[] lines     = System.IO.File.ReadAllLines(strfilename);


                            /* This next section is designed to split the loaded material into
                             * two parts; one the dummy text and the two actual contents that is going to
                             * be displayed in the content boxes. This procedure is hapening as:
                             * First 15 lines of text is INPUT.
                             * SPACE
                             * Program counter text.
                             * SPACE
                             * REST INTO MEMORY TEXTBOXES
                             * 
                             * This procedure is done after all the text is stored into the string array
                             * lines.*/
                            #region Split Text File

                            /* Input Card Split after text is read into the string array lines. */
                            for (int index = 0; index < 15; index++ )
                            {
                                dText = lines[index]; //The selected line is copied onto a temporary string.
                                string[] words = dText.Split(':'); //The string is now split into two parts, one before the ":", and one after.
                                TextBox InBox = (TextBox)InBoxGroup00.Controls["InputBox" + sIndex]; //The textbox is formed.
                                InBox.Text = words[1];//The last part of the selected line is than stored into the correct InBox.

                                sIndex++;
                            }

                            /* Input Card Split after text is read into the string array lines. 
                             * Detailed information about the actual split procedure is explained above.*/
                            dText = lines[16];//The Program Counter is stored into here disregarding the spaces and the gap between 14 to 15.
                            string[] words2 = dText.Split(':');
                            PCBox1.Text = words2[1];

                            sIndex = 1;

                            /* Input Card Split after text is read into the string array lines. 
                             * Detailed information about the actual split procedure is explained above.*/
                            for(int index = 18; index < 117; index++)
                            {
                                dText = lines[index];
                                string[] words3 = dText.Split(':');
                                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (sIndex < 10 ? "0" : "") + sIndex];
                                MemBox.Text = words3[1];

                                sIndex++;
                            }

                            #endregion

                        }//ReadStream - End

                    }//OpenDialog OK - End

                }//Load Click Event - End

                /*****************************************************************
                * VOID| About Box Click
                * ----------------------------------------------------------------
                * Opens the About box about the author and copywright information. 
                * 
                * RETURNS: Nothing.
                ******************************************************************/
                private void About_Click(object sender, EventArgs e)
                {
                    var newAboutBox = new AboutBox1();

                    newAboutBox.Show();
                }

                /*****************************************************************
                * VOID| Help Click
                * ----------------------------------------------------------------
                * Opens the Help window about the program. 
                * 
                * RETURNS: Nothing.
                ******************************************************************/
                private void Help_Click(object sender, EventArgs e)
                {
                    var newHelpForm = new MemoryHelp();

                    newHelpForm.Show();
                }

                #endregion

        #endregion

        /*****************************************************************
        * MAIN REGION | Input Card
        * ----------------------------------------------------------------
        * This section holds the Input Card object forms and reset and
        * clear events.
        * ----------------------------------------------------------------
        * 
        * SUB REGION Base Buttons 
        * - Input Card Boxes
        * - Input Card Buttons 
        * - Input Card Labels 
        ******************************************************************/
        #region Input Card

            /*****************************************************************
            * SUB-REGION | Input Card Boxes
            * ----------------------------------------------------------------
            * This sub-region holds Input Card Boxes object forms
            *  
            ******************************************************************/
            #region Input Card Boxes

            private void InputBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox5_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox8_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox10_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox11_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox12_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox13_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox14_TextChanged(object sender, EventArgs e)
            {

            }

            private void InputBox15_TextChanged(object sender, EventArgs e)
            {

            }

            #endregion

            /*****************************************************************
            * SUB-REGION | Input Card Click Events
            * ----------------------------------------------------------------
            * This sub-region holds base buttons listed below.
            * ----------------------------------------------------------------
            * 
            * + InputReset Click - Resets the artificial Input counter.
            * + InputClear Click - Clears the input boxes. 
            * 
            ******************************************************************/
            #region Input Card Buttons

            /*****************************************************************
            * VOID | InputReset Click Event
            * ----------------------------------------------------------------
            * This function is designed to reset the input card order.
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void InputReset_Click(object sender, EventArgs e)
            {
                ICBox.ResetText();
            }

            /*****************************************************************
            * VOID | InputClear Click Event
            * ----------------------------------------------------------------
            * This function is designed to clear the contents of the 15 input
            * boxes. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void InputClear_Click(object sender, EventArgs e)
            {

                InputBox1.Text  = "";
                InputBox2.Text  = "";
                InputBox3.Text  = "";
                InputBox4.Text  = "";
                InputBox5.Text  = "";
                InputBox6.Text  = "";
                InputBox7.Text  = "";
                InputBox8.Text  = "";
                InputBox9.Text  = "";
                InputBox10.Text = "";
                InputBox11.Text = "";
                InputBox12.Text = "";
                InputBox13.Text = "";
                InputBox14.Text = "";
                InputBox15.Text = "";

            }

            #endregion //Input Card Button - End

            /*****************************************************************
            * SUB-REGION | Input Card Click Events
            * ----------------------------------------------------------------
            * This sub-region holds label object forms of the input cards.
            * 
            ******************************************************************/
            #region Input Card Labels

            private void IC01_Click(object sender, EventArgs e)
            {

            }
            private void IC02_Click(object sender, EventArgs e)
            {

            }
            private void IC03_Click(object sender, EventArgs e)
            {

            }
            private void IC04_Click(object sender, EventArgs e)
            {

            }
            private void IC05_Click(object sender, EventArgs e)
            {

            }
            private void IC06_Click(object sender, EventArgs e)
            {

            }
            private void IC07_Click(object sender, EventArgs e)
            {

            }
            private void IC08_Click(object sender, EventArgs e)
            {

            }
            private void IC09_Click(object sender, EventArgs e)
            {

            }
            private void IC10_Click(object sender, EventArgs e)
            {

            }

            private void IC11_Click(object sender, EventArgs e)
            {

            }

            private void IC12_Click(object sender, EventArgs e)
            {

            }

            private void IC13_Click(object sender, EventArgs e)
            {

            }

            private void IC14_Click(object sender, EventArgs e)
            {

            }

            private void IC15_Click(object sender, EventArgs e)
            {

            }

            #endregion

        #endregion //Input Card - End

        /*****************************************************************
        * MAIN REGION | Output Cards
        * ----------------------------------------------------------------
        * This section holds the Output Card object forms and reset and
        * clear events.
        * ----------------------------------------------------------------
        * 
        * SUB REGION Base Buttons 
        * - Output Card Boxes
        * - Output Clear Buttons 
        * - Output Card Labels 
        ******************************************************************/
        #region Output Card

            /*****************************************************************
            * SUB-REGION | Output Card Boxes
            * ----------------------------------------------------------------
            * This sub-region holds Output Card Boxes object forms
            *  
            ******************************************************************/
            #region Output Card Boxes

            private void OutputBox1_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox2_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox4_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox5_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox6_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox7_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox8_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox9_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox10_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox11_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox12_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox13_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox14_TextChanged(object sender, EventArgs e)
            {

            }

            private void OutputBox15_TextChanged(object sender, EventArgs e)
            {

            }

            #endregion

            /*****************************************************************
            * SUB-REGION | Output Card Click Events
            * ----------------------------------------------------------------
            * This sub-region holds base buttons listed below.
            * ----------------------------------------------------------------
            * 
            * + InputClear Click - Clears the output boxes. 
            * 
            ******************************************************************/
            #region Output Clear Button

            /*****************************************************************
            * VOID | OutputClear Click Event
            * ----------------------------------------------------------------
            * This function is designed to clear the contents of the 15 output
            * boxes. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void OutputClear_Click(object sender, EventArgs e)
            {
                OutputBox1.Text  = "";
                OutputBox2.Text  = "";
                OutputBox3.Text  = "";
                OutputBox4.Text  = "";
                OutputBox5.Text  = "";
                OutputBox6.Text  = "";
                OutputBox7.Text  = "";
                OutputBox8.Text  = "";
                OutputBox9.Text  = "";
                OutputBox10.Text = "";
                OutputBox11.Text = "";
                OutputBox12.Text = "";
                OutputBox13.Text = "";
                OutputBox14.Text = "";
                OutputBox15.Text = "";
            }

            #endregion

            /*****************************************************************
            * SUB-REGION | Output Card Click Events
            * ----------------------------------------------------------------
            * This sub-region holds label object forms of the output cards.
            * 
            ******************************************************************/
            #region Output Card Labels

            private void OC1_Click(object sender, EventArgs e)
            {

            }

            private void OC2_Click(object sender, EventArgs e)
            {

            }

            private void OC3_Click(object sender, EventArgs e)
            {

            }

            private void OC4_Click(object sender, EventArgs e)
            {

            }

            private void OC5_Click(object sender, EventArgs e)
            {

            }

            private void OC6_Click(object sender, EventArgs e)
            {

            }

            private void OC7_Click(object sender, EventArgs e)
            {

            }

            private void OC8_Click(object sender, EventArgs e)
            {

            }

            private void OC9_Click(object sender, EventArgs e)
            {

            }

            private void OC10_Click(object sender, EventArgs e)
            {

            }

            private void OC11_Click(object sender, EventArgs e)
            {

            }

            private void OC12_Click(object sender, EventArgs e)
            {

            }

            private void OC13_Click(object sender, EventArgs e)
            {

            }

            private void OC14_Click(object sender, EventArgs e)
            {

            }

            private void OC15_Click(object sender, EventArgs e)
            {

            }

            #endregion

        #endregion

        /*****************************************************************
        * MAIN REGION | Memory
        * ----------------------------------------------------------------
        * This section is designed to hold the main componenets of the
        * memory contents. 
        * ----------------------------------------------------------------
        * 
        * Memory Clear          - Clears the memory boxes.
        * Memory Address Labels - Address labels for the memory boxes.
        * MemoryBox Events      - Events that follow the memory boxes.
        * Memory Boxes          - Objects for the memory boxes.
        *  
        ******************************************************************/
        #region Memory

            /*****************************************************************
            * VOID | MemoryClear Click Event
            * ----------------------------------------------------------------
            * This function is designed to clear the contents of the 100
            * memory boxes. It contains all 100 Memory Boxes. Seperated into
            * column sections.
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void MemoryClear_Click(object sender, EventArgs e)
            {
                #region Memory Clear 01 to 19
                MemoryBox01.Text = "";
                MemoryBox02.Text = "";
                MemoryBox03.Text = "";
                MemoryBox04.Text = "";
                MemoryBox05.Text = "";
                MemoryBox06.Text = "";
                MemoryBox07.Text = "";
                MemoryBox08.Text = "";
                MemoryBox09.Text = "";
                MemoryBox10.Text = "";
                MemoryBox11.Text = "";
                MemoryBox12.Text = "";
                MemoryBox13.Text = "";
                MemoryBox14.Text = "";
                MemoryBox15.Text = "";
                MemoryBox16.Text = "";
                MemoryBox17.Text = "";
                MemoryBox18.Text = "";
                MemoryBox19.Text = "";
                #endregion

                #region Memory Clear 20 to 39

                MemoryBox20.Text = "";
                MemoryBox21.Text = "";
                MemoryBox22.Text = "";
                MemoryBox23.Text = "";
                MemoryBox24.Text = "";
                MemoryBox25.Text = "";
                MemoryBox26.Text = "";
                MemoryBox27.Text = "";
                MemoryBox28.Text = "";
                MemoryBox29.Text = "";
                MemoryBox30.Text = "";
                MemoryBox31.Text = "";
                MemoryBox32.Text = "";
                MemoryBox33.Text = "";
                MemoryBox34.Text = "";
                MemoryBox35.Text = "";
                MemoryBox36.Text = "";
                MemoryBox37.Text = "";
                MemoryBox38.Text = "";
                MemoryBox39.Text = "";
                #endregion

                #region Memory Clear 40 to 59

                MemoryBox40.Text = "";
                MemoryBox41.Text = "";
                MemoryBox42.Text = "";
                MemoryBox43.Text = "";
                MemoryBox44.Text = "";
                MemoryBox45.Text = "";
                MemoryBox46.Text = "";
                MemoryBox47.Text = "";
                MemoryBox48.Text = "";
                MemoryBox49.Text = "";
                MemoryBox50.Text = "";
                MemoryBox51.Text = "";
                MemoryBox52.Text = "";
                MemoryBox53.Text = "";
                MemoryBox54.Text = "";
                MemoryBox55.Text = "";
                MemoryBox56.Text = "";
                MemoryBox57.Text = "";
                MemoryBox58.Text = "";
                MemoryBox59.Text = "";

                #endregion

                #region Memory Clear 60 to 79

                MemoryBox60.Text = "";
                MemoryBox61.Text = "";
                MemoryBox62.Text = "";
                MemoryBox63.Text = "";
                MemoryBox64.Text = "";
                MemoryBox65.Text = "";
                MemoryBox66.Text = "";
                MemoryBox67.Text = "";
                MemoryBox68.Text = "";
                MemoryBox69.Text = "";
                MemoryBox70.Text = "";
                MemoryBox71.Text = "";
                MemoryBox72.Text = "";
                MemoryBox73.Text = "";
                MemoryBox74.Text = "";
                MemoryBox75.Text = "";
                MemoryBox76.Text = "";
                MemoryBox77.Text = "";
                MemoryBox78.Text = "";
                MemoryBox79.Text = "";

                #endregion

                #region Memory Clear 80 to 99

                MemoryBox80.Text = "";
                MemoryBox81.Text = "";
                MemoryBox82.Text = "";
                MemoryBox83.Text = "";
                MemoryBox84.Text = "";
                MemoryBox85.Text = "";
                MemoryBox86.Text = "";
                MemoryBox87.Text = "";
                MemoryBox88.Text = "";
                MemoryBox89.Text = "";
                MemoryBox90.Text = "";
                MemoryBox91.Text = "";
                MemoryBox92.Text = "";
                MemoryBox93.Text = "";
                MemoryBox94.Text = "";
                MemoryBox95.Text = "";
                MemoryBox96.Text = "";
                MemoryBox97.Text = "";
                MemoryBox98.Text = "";
                MemoryBox99.Text = "";

                #endregion

            }

            /*****************************************************************
            * VOID | Memorylbl00 Click Event
            * ----------------------------------------------------------------
            * A test event, to check how label click events work. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void Memorylbl00_Click(object sender, EventArgs e)
            {
                Memorylbl00.ForeColor = Color.Blue;
            }

            /*****************************************************************
            * VOID | Memorylbl00 Text Changed
            * ----------------------------------------------------------------
            * This function is designed to set the memory box text to 001
            * and set it to read only mode.
             * 
            * RETURNS: nothing.
            ******************************************************************/
            private void MemoryBox00_TextChanged(object sender, EventArgs e)
            {
                MemoryBox00.Text = "001";

                MemoryBox00.ReadOnly = true;
            }

            /*****************************************************************
            * VOID | Memorylbl01 Text Changed
            * ----------------------------------------------------------------
            * 
            * Test Function. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void MemoryBox01_TextChanged(object sender, EventArgs e)
            {
                Memorylbl1.ForeColor  = Color.Red;
            }

            /*****************************************************************
            * VOID | Memorylbl02 Text Changed
            * ----------------------------------------------------------------
            * 
            * Test Function. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void MemoryBox02_TextChanged(object sender, EventArgs e)
            {
                Memorylbl2.BackColor = Color.Red;
            }

            /*****************************************************************
            * SUB-REGION | Memory Boxes
            * ----------------------------------------------------------------
            * This section is designed to hold the physical form of the memory 
            * texboxes, all 100 physical object forms. 
            * 
            ******************************************************************/
            #region Memory Boxes

                #region Memory Boxes 00 to 19



                #endregion

                #region Memory Boxes 20 to 39


                #endregion

                #region Memory Boxes 40 to 59


                #endregion

                #region Memory Boxes 60 to 79


                #endregion

                #region Memory Boxes 80 to 99


                #endregion

            #endregion

        #endregion //Memory - End

        /*****************************************************************
        * MAIN REGION | CPU
        * ----------------------------------------------------------------
        * This section is designed to hold the main componenets of the
        * CPU contents 
        * ----------------------------------------------------------------
        * 
        *  Cpu Clear Buttons    - It holds the clear and clear all methods.
        *  Accumulator          - The contents of the Accumulator.
        *  Program Counter      - Counter for the main program memory.
        *  Instruction Register - No idea what this does yet.
        *  Program Step Click   - Runs the program.  
        *  
        ******************************************************************/
        #region CPU

            /*****************************************************************
            * VOID | CPU_Label Click event
            * ----------------------------------------------------------------
            * Opens the CPU Help information box. 
            * 
            * RETURNS: Nothing.
            ******************************************************************/
            private void CPU_Click(object sender, EventArgs e)
            {
                var newHelpForm = new CPUH();

                newHelpForm.Show();
            }

            /*****************************************************************
            * SUB-REGION | CPU Clear Buttons
            * ----------------------------------------------------------------
            * This sub-region holds the clear buttons related to CPU clear
            * data.
            * ----------------------------------------------------------------
            * 
            * + CPUClear    - Selection of opCodes.
            * + CPUClearAll - Runs opCode methods.
            *  
            ******************************************************************/
            #region CPU Clear Buttons

            /*****************************************************************
            * VOID | CPUClear
            * ----------------------------------------------------------------
            * This function is designed to clear the cpu main componenets.
            * Hard reset to null.
            * 
            * RETURNS: Nothing.
            ******************************************************************/
            private void CPUClear_Click(object sender, EventArgs e)
            {
                ACBox1.ResetText(); //Clears the Carryflag bit.
                ACBox2.ResetText(); //Clears the accumulator.
                PCBox1.ResetText(); //Clears the program counter.
                IRBox1.ResetText(); //Clears the instruction register.
                ICBox.ResetText();  //Clears the Input Card counter.
            }

            /*****************************************************************
            * VOID | CPUClearALL
            * ----------------------------------------------------------------
            * This function is designed to clear the programs main componenets.
            * Hard reset to null.
            * 
            * RETURNS: Nothing.
            ******************************************************************/
            private void CPUClearAll_Click(object sender, EventArgs e)
            {
                CPUClear_Click(sender, e);    //Calls the CPU Clear function.
                OutputClear_Click(sender, e); //Calls the Output Clear function.
                InputClear_Click(sender, e);  //Calls the Input Clear function.
                MemoryClear_Click(sender, e); //Calls the Memory Clear function.
            }

            #endregion //CPU Clear Buttons - End

            /*****************************************************************
            * SUB-REGION | Accumulator
            * ----------------------------------------------------------------
            * This sub-region holds accumulator functions.
            * ----------------------------------------------------------------
            * 
            * + AC_Click    - Accumulator help information label.
            * + ACBox2      - Runs opCode methods.
            *  
            ******************************************************************/
            #region Accumulator

            /*****************************************************************
            * VOID | AC_Click(Click event)
            * ----------------------------------------------------------------
            * A label click event that opens a new windowform. 
            * 
            * RETURNS: Nothing.
            ******************************************************************/
            private void AC_Click(object sender, EventArgs e)
            {
                var newHelpForm = new AccumulatorH();

                newHelpForm.Show();
            }

            #endregion //Accumulator - End

            /*****************************************************************
            * SUB-REGION | Program Counter
            * ----------------------------------------------------------------
            * This sub-region holds program counter functions.
            * ----------------------------------------------------------------
            * 
            * + PCBox1      - Program Counter textbox.
            * + PC_Click    - Reserved.
            *  
            ******************************************************************/
            #region Program Counter

            /*****************************************************************
            * VOID | Program Counter Text Change Event
            * ----------------------------------------------------------------
            * This function is designed to set the program counter to "00"
            * based on the program counter's current text forms and resets
            * the label forecolors. 
            * 
            * RETURNS: Nothing.
            ******************************************************************/
            private void PCBox1_TextChanged(object sender, EventArgs e)
            {
                if (PCBox1.Text.Length == 0)
                {
                    PCBox1.Text = "00";

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion
                }

                #region MemoryColor Change

                if (PCBox1.Text == "01")
                {
                    Memorylbl1.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion
                }
                else if (PCBox1.Text == "02")
                {
                    Memorylbl2.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion


                }
                else if (PCBox1.Text == "03")
                {
                    Memorylbl3.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "04")
                {
                    Memorylbl4.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "05")
                {
                    Memorylbl5.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion
                }
                else if (PCBox1.Text == "06")
                {
                    Memorylbl6.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "07")
                {
                    Memorylbl7.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "08")
                {
                    Memorylbl8.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "09")
                {
                    Memorylbl9.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "10")
                {
                    Memorylbl10.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "11")
                {
                    Memorylbl11.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "12")
                {
                    Memorylbl12.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "13")
                {
                    Memorylbl13.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "14")
                {
                    Memorylbl14.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "15")
                {
                    Memorylbl15.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "16")
                {
                    Memorylbl16.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "17")
                {
                    Memorylbl17.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "18")
                {
                    Memorylbl18.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "19")
                {
                    Memorylbl19.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "20")
                {
                    Memorylbl20.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "21")
                {
                    Memorylbl21.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "22")
                {
                    Memorylbl22.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "23")
                {
                    Memorylbl23.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "24")
                {
                    Memorylbl24.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "25")
                {
                    Memorylbl25.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "26")
                {
                    Memorylbl26.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "27")
                {
                    Memorylbl27.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "28")
                {
                    Memorylbl28.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "29")
                {
                    Memorylbl29.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "30")
                {
                    Memorylbl30.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "31")
                {
                    Memorylbl31.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "32")
                {
                    Memorylbl32.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "33")
                {
                    Memorylbl33.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "34")
                {
                    Memorylbl34.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "35")
                {
                    Memorylbl35.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "36")
                {
                    Memorylbl36.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "37")
                {
                    Memorylbl37.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "38")
                {
                    Memorylbl38.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "39")
                {
                    Memorylbl39.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "40")
                {
                    Memorylbl40.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "41")
                {
                    Memorylbl41.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "42")
                {
                    Memorylbl42.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "43")
                {
                    Memorylbl43.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "44")
                {
                    Memorylbl44.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "45")
                {
                    Memorylbl45.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "46")
                {
                    Memorylbl46.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "47")
                {
                    Memorylbl47.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "48")
                {
                    Memorylbl48.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "49")
                {
                    Memorylbl49.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "50")
                {
                    Memorylbl50.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "51")
                {
                    Memorylbl51.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "52")
                {
                    Memorylbl52.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "53")
                {
                    Memorylbl53.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "54")
                {
                    Memorylbl54.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "55")
                {
                    Memorylbl55.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "56")
                {
                    Memorylbl56.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "57")
                {
                    Memorylbl57.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "58")
                {
                    Memorylbl58.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "59")
                {
                    Memorylbl59.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "60")
                {
                    Memorylbl60.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "61")
                {
                    Memorylbl61.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "62")
                {
                    Memorylbl62.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "63")
                {
                    Memorylbl63.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "64")
                {
                    Memorylbl64.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "65")
                {
                    Memorylbl65.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "66")
                {
                    Memorylbl66.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "67")
                {
                    Memorylbl67.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "68")
                {
                    Memorylbl68.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "69")
                {
                    Memorylbl69.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "70")
                {
                    Memorylbl70.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "71")
                {
                    Memorylbl71.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "72")
                {
                    Memorylbl72.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "73")
                {
                    Memorylbl73.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "74")
                {
                    Memorylbl74.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "75")
                {
                    Memorylbl75.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "76")
                {
                    Memorylbl76.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "77")
                {
                    Memorylbl77.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "78")
                {
                    Memorylbl78.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "79")
                {
                    Memorylbl79.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "80")
                {
                    Memorylbl80.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "81")
                {
                    Memorylbl81.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "82")
                {
                    Memorylbl82.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "83")
                {
                    Memorylbl83.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "84")
                {
                    Memorylbl84.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "85")
                {
                    Memorylbl85.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "86")
                {
                    Memorylbl86.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "87")
                {
                    Memorylbl87.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "88")
                {
                    Memorylbl88.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "89")
                {
                    Memorylbl89.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "90")
                {
                    Memorylbl90.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "91")
                {
                    Memorylbl91.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "92")
                {
                    Memorylbl92.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "93")
                {
                    Memorylbl93.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "94")
                {
                    Memorylbl94.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "95")
                {
                    Memorylbl95.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "96")
                {
                    Memorylbl96.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "97")
                {
                    Memorylbl97.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "98")
                {
                    Memorylbl98.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl99.ForeColor = System.Drawing.Color.White;


                    #endregion

                }
                else if (PCBox1.Text == "99")
                {
                    Memorylbl99.ForeColor = System.Drawing.Color.Red;

                    #region MemoryWhiteLbl Seciton

                    Memorylbl1.ForeColor = System.Drawing.Color.White;
                    Memorylbl2.ForeColor = System.Drawing.Color.White;
                    Memorylbl3.ForeColor = System.Drawing.Color.White;
                    Memorylbl4.ForeColor = System.Drawing.Color.White;
                    Memorylbl5.ForeColor = System.Drawing.Color.White;
                    Memorylbl6.ForeColor = System.Drawing.Color.White;
                    Memorylbl7.ForeColor = System.Drawing.Color.White;
                    Memorylbl8.ForeColor = System.Drawing.Color.White;
                    Memorylbl9.ForeColor = System.Drawing.Color.White;
                    Memorylbl10.ForeColor = System.Drawing.Color.White;
                    Memorylbl11.ForeColor = System.Drawing.Color.White;
                    Memorylbl12.ForeColor = System.Drawing.Color.White;
                    Memorylbl13.ForeColor = System.Drawing.Color.White;
                    Memorylbl14.ForeColor = System.Drawing.Color.White;
                    Memorylbl15.ForeColor = System.Drawing.Color.White;
                    Memorylbl16.ForeColor = System.Drawing.Color.White;
                    Memorylbl17.ForeColor = System.Drawing.Color.White;
                    Memorylbl18.ForeColor = System.Drawing.Color.White;
                    Memorylbl19.ForeColor = System.Drawing.Color.White;
                    Memorylbl20.ForeColor = System.Drawing.Color.White;
                    Memorylbl21.ForeColor = System.Drawing.Color.White;
                    Memorylbl22.ForeColor = System.Drawing.Color.White;
                    Memorylbl23.ForeColor = System.Drawing.Color.White;
                    Memorylbl24.ForeColor = System.Drawing.Color.White;
                    Memorylbl25.ForeColor = System.Drawing.Color.White;
                    Memorylbl26.ForeColor = System.Drawing.Color.White;
                    Memorylbl27.ForeColor = System.Drawing.Color.White;
                    Memorylbl28.ForeColor = System.Drawing.Color.White;
                    Memorylbl29.ForeColor = System.Drawing.Color.White;
                    Memorylbl30.ForeColor = System.Drawing.Color.White;
                    Memorylbl31.ForeColor = System.Drawing.Color.White;
                    Memorylbl32.ForeColor = System.Drawing.Color.White;
                    Memorylbl33.ForeColor = System.Drawing.Color.White;
                    Memorylbl34.ForeColor = System.Drawing.Color.White;
                    Memorylbl35.ForeColor = System.Drawing.Color.White;
                    Memorylbl36.ForeColor = System.Drawing.Color.White;
                    Memorylbl37.ForeColor = System.Drawing.Color.White;
                    Memorylbl38.ForeColor = System.Drawing.Color.White;
                    Memorylbl39.ForeColor = System.Drawing.Color.White;
                    Memorylbl40.ForeColor = System.Drawing.Color.White;
                    Memorylbl41.ForeColor = System.Drawing.Color.White;
                    Memorylbl42.ForeColor = System.Drawing.Color.White;
                    Memorylbl43.ForeColor = System.Drawing.Color.White;
                    Memorylbl44.ForeColor = System.Drawing.Color.White;
                    Memorylbl45.ForeColor = System.Drawing.Color.White;
                    Memorylbl46.ForeColor = System.Drawing.Color.White;
                    Memorylbl47.ForeColor = System.Drawing.Color.White;
                    Memorylbl48.ForeColor = System.Drawing.Color.White;
                    Memorylbl49.ForeColor = System.Drawing.Color.White;
                    Memorylbl50.ForeColor = System.Drawing.Color.White;
                    Memorylbl51.ForeColor = System.Drawing.Color.White;
                    Memorylbl52.ForeColor = System.Drawing.Color.White;
                    Memorylbl53.ForeColor = System.Drawing.Color.White;
                    Memorylbl54.ForeColor = System.Drawing.Color.White;
                    Memorylbl55.ForeColor = System.Drawing.Color.White;
                    Memorylbl56.ForeColor = System.Drawing.Color.White;
                    Memorylbl57.ForeColor = System.Drawing.Color.White;
                    Memorylbl58.ForeColor = System.Drawing.Color.White;
                    Memorylbl59.ForeColor = System.Drawing.Color.White;
                    Memorylbl60.ForeColor = System.Drawing.Color.White;
                    Memorylbl61.ForeColor = System.Drawing.Color.White;
                    Memorylbl62.ForeColor = System.Drawing.Color.White;
                    Memorylbl63.ForeColor = System.Drawing.Color.White;
                    Memorylbl64.ForeColor = System.Drawing.Color.White;
                    Memorylbl65.ForeColor = System.Drawing.Color.White;
                    Memorylbl66.ForeColor = System.Drawing.Color.White;
                    Memorylbl67.ForeColor = System.Drawing.Color.White;
                    Memorylbl68.ForeColor = System.Drawing.Color.White;
                    Memorylbl69.ForeColor = System.Drawing.Color.White;
                    Memorylbl70.ForeColor = System.Drawing.Color.White;
                    Memorylbl71.ForeColor = System.Drawing.Color.White;
                    Memorylbl72.ForeColor = System.Drawing.Color.White;
                    Memorylbl73.ForeColor = System.Drawing.Color.White;
                    Memorylbl74.ForeColor = System.Drawing.Color.White;
                    Memorylbl75.ForeColor = System.Drawing.Color.White;
                    Memorylbl76.ForeColor = System.Drawing.Color.White;
                    Memorylbl77.ForeColor = System.Drawing.Color.White;
                    Memorylbl78.ForeColor = System.Drawing.Color.White;
                    Memorylbl79.ForeColor = System.Drawing.Color.White;
                    Memorylbl80.ForeColor = System.Drawing.Color.White;
                    Memorylbl81.ForeColor = System.Drawing.Color.White;
                    Memorylbl82.ForeColor = System.Drawing.Color.White;
                    Memorylbl83.ForeColor = System.Drawing.Color.White;
                    Memorylbl84.ForeColor = System.Drawing.Color.White;
                    Memorylbl85.ForeColor = System.Drawing.Color.White;
                    Memorylbl86.ForeColor = System.Drawing.Color.White;
                    Memorylbl87.ForeColor = System.Drawing.Color.White;
                    Memorylbl88.ForeColor = System.Drawing.Color.White;
                    Memorylbl89.ForeColor = System.Drawing.Color.White;
                    Memorylbl90.ForeColor = System.Drawing.Color.White;
                    Memorylbl91.ForeColor = System.Drawing.Color.White;
                    Memorylbl92.ForeColor = System.Drawing.Color.White;
                    Memorylbl93.ForeColor = System.Drawing.Color.White;
                    Memorylbl94.ForeColor = System.Drawing.Color.White;
                    Memorylbl95.ForeColor = System.Drawing.Color.White;
                    Memorylbl96.ForeColor = System.Drawing.Color.White;
                    Memorylbl97.ForeColor = System.Drawing.Color.White;
                    Memorylbl98.ForeColor = System.Drawing.Color.White;


                    #endregion

                }

                #endregion

            }

            /*****************************************************************
            * VOID | Program Counter Label Click Event
            * ----------------------------------------------------------------
            * 
            * Opens the program counter label click event, a help box
            * displaying information based on the program counter.
            *  
            * RETURNS: Nothing.
            ******************************************************************/
            private void PCounter_Click(object sender, EventArgs e)
            {
                var newHelpForm = new ProgramCounterH();

                newHelpForm.Show();
            }

            #endregion

            /*****************************************************************
            * SUB-REGION | Instruction Register
            * ----------------------------------------------------------------
            * This sub-region holds Instruction Register functions.
            * 
            ******************************************************************/
            #region Instruction Register

            /*****************************************************************
            * VOID | Input Register Label Click Event
            * ----------------------------------------------------------------
            * 
            * Opens the input register label click event, a help box
            * displaying information based on the input register.
            *  
            * RETURNS: Nothing.
            ******************************************************************/
            private void IR_Click(object sender, EventArgs e)
            {
                var newHelpForm = new InputRegistH();

                newHelpForm.Show();
            }

            #endregion

            /*****************************************************************
            * SUB-REGION | Program Step/Run
            * ----------------------------------------------------------------
            * This sub-region is designed to have Step Clicks and Run method
            * to execute the program.
            * ----------------------------------------------------------------
            * 
            * + ProgramStep_Click - Goes throught the program in debug mode.
            * + ProgramRun_Click  - Executes the program.
            *  
            ******************************************************************/
            #region Program Run

            /*****************************************************************
            * VOID | ProgramStep_Click
            * ----------------------------------------------------------------
            * This function is designed to be an artificial debug mode for 
            * the program that is to be executed on the simple computer.
            * It follows a trace method/debug method of displaying the 
            * current program counter location with updating label color.
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void ProgramStep_Click(object sender, EventArgs e)
            {
                int fullNum;//The full 3-digit number.
                int cellNum;//The cell number of the opCode.
                int opCode;//The opCode thats to be executed.

                string content;//Content grabbed being from the memory cell.

                cellNum  = grabPC();//Grabs the program counter.

                cellNum -= 1;

                content = getCellContents(cellNum);//Gets the cellcontents of the memory cell.

                /* This section runs the program operations.
                 * It has multiple checks for empty content pass.*/
                if (content == null)
                {
                    MessageBox.Show("Execution Stopped! There is no Memory to fetch!");
                    resetPRGM();
                    return;
                }
                else
                {

                    if (content == string.Empty)
                    {
                        MessageBox.Show("Execution Stopped! There is no Memory to fetch!");
                    
                        cellNum = 00;
                        opCodeHalt(cellNum);//Halts the program, and sets the cellNum to 00.
                    }
                    else
                    {

                        IRBox1.Text = content;//Sets the Input Register.

                        fullNum = Convert.ToInt32(content); //Grabs and does an indirect conversion of the data to integer and copies into fullNum.
                        cellNum = fullNum % 100; //Locates the cellNum from the fullNums Contents.
                        opCode  = (fullNum - cellNum) / 100; // Grabs the opCode.

                        /* Broken down opCode and the cellNum is passed into the opCode Selection
                         * function to run the correct opCode.*/
                        opCodeSelection(opCode, cellNum);
                    }

                }

            }//FUNCTION - END

            /*****************************************************************
            * VOID | ProgramRun_Click
            * ----------------------------------------------------------------
            * This function is designed to execute the program in the 
            * simple computer.
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void ProgramRun_Click(object sender, EventArgs e)
            {
                string content;

                do
                {

                    int fullNum;
                    int cellNum;
                    int opCode;


                    cellNum = grabPC(); //Grabs the program counter...

                    cellNum -= 1;

                    content = getCellContents(cellNum);

                    if (content == null)
                    {
                        cellNum = 00;

                        resetPRGM();
                        return;
                    }
                    else
                    {

                        if (content == string.Empty)
                        {

                            cellNum = 00;

                            resetPRGM();
                            return;
                        }
                        else
                        {
                            fullNum = Convert.ToInt32(content);
                            cellNum = fullNum % 100;
                            opCode = (fullNum - cellNum) / 100;

                            opCodeSelection(opCode, cellNum);
                        }

                    }

                } while (content != null && content != string.Empty);//DO-WHILE - END

            }//PROGRAMRUN_CLICK - END

            #endregion

        #endregion

        /*****************************************************************
        * MAIN REGION | Key Press Events
        * ----------------------------------------------------------------
        * This section is designed to hold the key press events of the
        * textbot event input. Limits the key press to integers only
        * and "-" to input cards.
        * ----------------------------------------------------------------
        * 
        * + MemoryBox01 KeyPress - Limits the regular input to integers only.
        * + MemoryBox19 KeyPress - Limits the regular input to integers only.
        * + InputKeyPress        - Limits the regular input to integers only 
        *                           and "-".
        *  
        ******************************************************************/
        #region KeyPress_Events

        private void MemoryBox01_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void MemoryBox19_KeyPress(object sender, KeyPressEventArgs e)
        {

            char ch = e.KeyChar;

            if(!Char.IsDigit(ch) && ch!=8)
            {
                e.Handled = true;
            }
        }

        private void InputKeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 45)
            {
                e.Handled = true;
            }
        }

        #endregion

        /* Test Event here. */
        #region MemoryBox Events

        //MEMORYBOX CONTROLLED EVENTS
        private void MemoryBox19_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        /*****************************************************************
        * MAIN REGION | opCode
        * ----------------------------------------------------------------
        * This section is designed to hold two subregions of the program
        * opCode selections and opcode methods. 
        * ----------------------------------------------------------------
        * 
        *  opCode Selections - Selection of opCodes.
        *  opCode Methods    - Runs opCode methods.
        *  
        ******************************************************************/
        #region opCode

            /*****************************************************************
            * SUB-REGION | opCode Selections
            * ----------------------------------------------------------------
            * This sub-region is designed to call the right subfunction of the
            * opCode that was recieved from the main program.
            * ----------------------------------------------------------------
            ******************************************************************/
            #region OpCode Selections

            /*****************************************************************
            * VOID | opCodeSelection
            * ----------------------------------------------------------------
            * This function is designed to call the right subfunction of the
            * opCode that was recieved from the main program.
            * 
            * - opCode == 0 : Grab data from input card.
            * - opCode == 1 : Output data from selected cell.
            * - opCode == 2 : Add the selected cell contents to the ACC.
            * - opCode == 3 : Subtract the selected cell contentes from ACC.
            * - opCode == 4 : Loads the contents of the cell to the ACC.
            * - opCode == 5 : Stores the contents of the ACC to the selected Cell.
            * - opCode == 6 : Does an unconditional jump to the selected cell.
            * - opCode == 7 : Checks to see if the accumulator is < 0 and jumps.
            * - opCode == 8 : Does a shift depending on the (x,y) value.
            * - opCode == 9 : Terminates the program and sets ACC. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeSelection(int opCode, int cellNum)
            {
                if (opCode == 0)
                {
                    opCodeCopy(cellNum);
                }
                else if(opCode == 1)
                {
                    opCodeOutput(cellNum);
                }
                else if (opCode == 2)
                {
                    if (ACBox2.Text == string.Empty)
                    {
                        MessageBox.Show("Execution Stopped! There is nothing to fetch from the accumulator!");

                        resetPRGM();
                        return;
                    }
                    else
                    {
                        opCodeAdd(cellNum);
                    }
                    
                }
                else if (opCode == 3)
                {
                    if (ACBox2.Text == string.Empty)
                    {
                        MessageBox.Show("Execution Stopped! There is nothing to fetch from the accumulator!");

                        resetPRGM();
                        return;
                    }
                    else
                    {
                        opCodeSubtract(cellNum);
                    }
                }
                else if (opCode == 4)
                {
                    opCodeLoad(cellNum);
                }
                else if (opCode == 5)
                {
                    if (ACBox2.Text == string.Empty)
                    {
                        MessageBox.Show("Execution Stopped! There is nothing to fetch from the accumulator!");

                        resetPRGM();
                        return;
                    }
                    else
                    {
                        opCodeStore(cellNum);
                    }
                }
                else if (opCode == 6)
                {
                    opCodeJump(cellNum);
                }
                else if (opCode == 7)
                {
                    if (ACBox2.Text == string.Empty)
                    {
                        MessageBox.Show("Execution Stopped! There is nothing to fetch from the accumulator!");

                        resetPRGM();
                        return;
                    }
                    else
                    {
                        opCodeCondJump(cellNum);
                    }
                }
                else if (opCode == 8)
                {
                    if (ACBox2.Text == string.Empty)
                    {
                        ACBox1.Text = "0";
                        ACBox2.Text = "000";
                    }
                    else
                    {
                        opCodeShift(cellNum);
                    }
                }
                else if (opCode == 9)
                {
                    opCodeHalt(cellNum);
                }
            }

            #endregion

            /*************************************************************************
            * SUB-REGION | OpCode Methods
            * ------------------------------------------------------------------------
            * This sub-region holds the opCode methods that are called from the
            * opCode selection region.  
            * ------------------------------------------------------------------------
            * Current Functions:
            * 
            * + opCodeCopy     - Grab data from input card.
            * + opCodeOutput   - Output data from selected cell.
            * + opCodeAdd      - Add the selected cell contents to the ACC.
            * + opCodeSubtract - Subtract the selected cell contentes from ACC.
            * + opCodeLoad     - Loads the contents of the cell to the ACC.
            * + opCodeStore    - Stores the contents of the ACC to the selected Cell.
            * + opCodeJump     - Does an unconditional jump to the selected cell.
            * + opCodeCondJump - Checks to see if the accumulator is < 0 and jumps.
            * + opCodeShift    - Does a shift depending on the (x,y) value.
            * + opCodeHalt     - Terminates the program and sets ACC. 
            * 
            **************************************************************************/
            #region OpCode Methods

            /*****************************************************************
            * VOID | opCodeCopy (0)
            * ----------------------------------------------------------------
            * Input – Copy the current input card into cell number _ _ 
            * and advance to the next card. Halt execution if the input card 
            * is empty. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeCopy(int cellNum)
            {
                int cardNum;

                cardNum = grabInputCard();//Grabs the Input Card.

                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                TextBox InBox  = (TextBox)InBoxGroup00.Controls["InputBox" + cardNum];

                if (InBox.Text == string.Empty)
                {
                    MessageBox.Show("Execution Stopped! There is no input!");

                    resetPRGM();
                    return;
                }
                else
                {
                    MemBox.Text = InBox.Text; // Assigns The string data in InputBox1.Text to MemBox.Text;
                }

            }

            /*****************************************************************
            * VOID | opCodeOutput (1)
            * ----------------------------------------------------------------
            * Output – Copy the contents of cell number _ _ to the current 
            * output card and advance to the next card. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeOutput(int cellNum)
            {
                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                OutputBox1.Text = MemBox.Text; // Assigns The string data in MemBox.Text to OutputBox1.Text;
            }

            /*****************************************************************
            * VOID | opCodeAdd (2)
            * ----------------------------------------------------------------
            * Add – Add the contents of cell number _ _ to the value of the 
            * accumulator. Sets Carry Bit on overflow. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeAdd(int cellNum)
            {
                int acBoxCon;   // Accumulator data temporary holder.
                int numberCell; // Selected cell data temporary holder.
                int sum;        // The collected data of acBoxCon + numberCell.
                string numCell; // String cell number display.

                numCell = cellNum.ToString(); // Converts cellNum data and copies it into numCell as a string type. 

                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                numberCell = Convert.ToInt32(MemBox.Text); // Converts MemBox.Text data into an 32 bit integer type. 
                acBoxCon   = Convert.ToInt32(ACBox2.Text); // Converts ACBox2.Text data into an 32 bit integer type. 

                sum = acBoxCon + numberCell; // Adds the data in acBoxCon(int32) and numberCell(int32); assigns it to sum.

                if (sum < 10)
                {
                    ACBox2.Text = sum.ToString("D3"); // ACBox2.Text now will display the string type converted data from sum.
                }
                else if( sum < 100)
                {
                    ACBox2.Text = sum.ToString("D3"); // ACBox2.Text now will display the string type converted data from sum.
                }
                else
                {
                    ACBox2.Text = sum.ToString(); // ACBox2.Text now will display the string type converted data from sum.
                }

            }

            /*****************************************************************
            * VOID | opCodeSubtract (3)
            * ----------------------------------------------------------------
            * Subtract – Subtract the contents of cell number _ _ from the 
            * current value of the accumulator. Sets Carry Bit on overflow. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeSubtract(int cellNum)
            {
                int acBoxCon;   // Accumulator data temporary holder.
                int numberCell; // Selected cell data temporary holder.
                int sum;        // The collected data of acBoxCon + numberCell.
                string numCell; // String cell number display.

                numCell = cellNum.ToString(); // Converts cellNum data and copies it into numCell as a string type.

                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                if(MemBox.Text != string.Empty)
                {
                    numberCell = Convert.ToInt32(MemBox.Text); // Converts MemBox.Text data into an 32 bit integer type.
                    acBoxCon   = Convert.ToInt32(ACBox2.Text); // Converts ACBox2.Text data into an 32 bit integer type.


                    sum = acBoxCon - numberCell; // Adds the data in acBoxCon(int32) and numberCell(int32); assigns it to sum.

                    if (sum < 10)
                    {
                        ACBox2.Text = sum.ToString("D3"); // ACBox2.Text now will display the string type converted data from sum.
                    }
                    else if (sum < 100)
                    {
                        ACBox2.Text = sum.ToString("D3"); // ACBox2.Text now will display the string type converted data from sum.
                    }
                    else
                    {
                        ACBox2.Text = sum.ToString(); // ACBox2.Text now will display the string type converted data from sum.
                    }

                }
 
            }

            /*****************************************************************
            * VOID | opCodeLoad (4)
            * ----------------------------------------------------------------
            * Load Accumulator – Clear the accumulator and carry flag, then 
            * copy the contents of cell number _ _ into the accumulator. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeLoad(int cellNum)
            {
                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                ACBox2.Text = MemBox.Text; // ACBox2.Text now will display the string type converted data from MemBox.Text.
            }

            /*****************************************************************
            * VOID | opCodeStore (5)
            * ----------------------------------------------------------------
            * Store Accumulator – Copy the tree digits of the accumulator 
            * into cell number _ _. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeStore(int cellNum)
            {
                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                MemBox.Text = ACBox2.Text; // MemBox.Text now will display the string type converted data from  ACBox2.Text.
            }

            /*****************************************************************
            * VOID | opCodeJump (6)
            * ----------------------------------------------------------------
            * Jump – Place the current value of the program counter into 
            * cell 99. Next, change the value of the program counter to _ _.
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeJump(int cellNum)
            {
                int numCheck;

                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                numCheck = Convert.ToInt32(PCBox1.Text);//Gabs the Program Counter to indirect conversion.

                /* This section adds padding of leading zeros depending on the numCheck. */
                if (numCheck < 10)
                {
                    MemoryBox99.Text = "0" + PCBox1.Text;
                }
                else if (numCheck < 100)
                {
                    MemoryBox99.Text = "0" + PCBox1.Text;
                }
                else
                {
                    MemoryBox99.Text = PCBox1.Text;
                }
                
                PCBox1.Text      = cellNum.ToString();
            }

            /*****************************************************************
            * VOID | opCodeCondJump (7)
            * ----------------------------------------------------------------
            * Test Accumulator – If the value of the accumulator is negative, 
            * change the value of the program counter to _ _. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeCondJump(int cellNum)
            {
                int valueChk;
                int getPcNum;
                int increment;

                valueChk = Convert.ToInt32(ACBox2.Text); // Converts ACBox2.Text data into an 32 bit integer type.

                // IF - ELSE STATEMENT: This statement is designed to check to see if the accumulator is less than 0, and assign
                //                      the correct cellNumber to jump to.
                if( valueChk < 0)
                {
                    PCBox1.Text = cellNum.ToString();
                }
                else
                {
                    getPcNum = Convert.ToInt32(PCBox1.Text);
                    increment = getPcNum + 1;
                }

            }
            /*****************************************************************
            * VOID | opCodeShift (8)
            * ----------------------------------------------------------------
            * Shift – Shift the accumulator left x digits, then shift the 
            * result right y digits. Shift digits through the Carry Bit and 
            * enter zeros from the left and right appropriately. 
            * 
            * RETURNS: nothing.
            ******************************************************************/
            private void opCodeShift(int cellNum)
            {
                int left;//The left number of shift digits.
                int right;//The right number of shift digits.
                int getShifts;//The full shift number to do the shifts.
                int PCNum;
                int shiftNums;
                int getShiftNum;
                int carryInt; //ACBOX1 Int convert.
                string tempShiftNum;
                string content;

                PCNum = Convert.ToInt32(PCBox1.Text);//Grabs the Program Counter for the right convert.
                PCNum = PCNum - 1;

                TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (PCNum < 10 ? "0" : "") + PCNum];

                content = MemBox.Text;

                /* These sections check for the content and does the correct shifts. */
                if (content == string.Empty)
                {

                    MessageBox.Show("Execution Stopped! There is no Memory to fetch!");

                    cellNum = 00;

                    opCodeHalt(cellNum);
                }
                else
                {
                    getShifts = Convert.ToInt32(MemBox.Text);//Grabs the correct number to shift.
                    shiftNums = getShifts % 100;
                    left  = shiftNums / 10;
                    right = shiftNums % 10;

                    getShiftNum = Convert.ToInt32(ACBox2.Text);

                    /* The left shift is executed in this section if the left shift number is greater than 0. */
                    if (left > 0)
                    {
                        /* Shifts the number to the left until it reaches zero. */
                        while (left > 0)
                        {
                            getShiftNum *= 10;
                            left--;
                        }

                        /* The correct padding, for the Accumulator. */
                        if (getShiftNum < 1000)
                        {
                            ACBox2.Text = getShiftNum.ToString("D3");
                        }
                        else
                        {

                            carryInt = getShiftNum / 1000;
                            carryInt = carryInt % 10;

                            getShiftNum = getShiftNum % 1000;

                            ACBox2.Text = getShiftNum.ToString();//The shift number is set to the Accumulator.
                            ACBox1.Text = carryInt.ToString();//The carry flag of the Accumulator.

                            if (getShiftNum <= 0)
                            {
                                ACBox2.Text = "000";
                            }
                        }
                    }

                    /* Shifts the number to the right until it reaches zero. */
                    if(right > 0)
                    {
                        if(ACBox1.Text != string.Empty)
                        {
                            carryInt     = Convert.ToInt32(ACBox1.Text);

                            if(getShiftNum == 0)
                            {
                                tempShiftNum = carryInt.ToString() + getShiftNum.ToString("D3");
                                getShiftNum = Convert.ToInt32(tempShiftNum);
                            }
                            else if (getShiftNum < 0)
                            {
                                tempShiftNum = getShiftNum.ToString("D3");
                                getShiftNum  = Convert.ToInt32(tempShiftNum);
                            }
                            else if (getShiftNum > 99)
                            {
                                tempShiftNum = carryInt.ToString() + getShiftNum.ToString();
                                getShiftNum = Convert.ToInt32(tempShiftNum);
                            }
                            else
                            {
                                tempShiftNum = carryInt.ToString() + getShiftNum.ToString("D2");
                                getShiftNum = Convert.ToInt32(tempShiftNum);
                            }
                            
                        }

                        carryInt = 0;
                        ACBox1.Text = carryInt.ToString();
                       
                    }

                    while (right > 0)
                    {
                        getShiftNum /= 10;
                        right--;
                    }

                    ACBox2.Text = getShiftNum.ToString("D3");

                }//ELSE - End

            }
            /*****************************************************************
            * VOID | opCodeHalt (9)
            * ----------------------------------------------------------------
            * Halt – Replace the value of the program counter with cell 
            * number _ _ and then halt execution. 
            * 
            * RETURNS: Halt program.
            ******************************************************************/
            private void opCodeHalt(int cellNum)
            {
                int numCheck;

                if(cellNum == 00)
                {
                    ACBox2.Text = MemoryBox00.Text;
                }
                else
                {
                    TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

                    numCheck = Convert.ToInt32(MemBox.Text);

                    if (numCheck < 10)
                    {
                        ACBox2.Text = "00" + MemBox.Text;
                    }
                    else if (numCheck < 99)
                    {
                        ACBox2.Text = "0" + MemBox.Text;
                    }
                    else
                    {
                        ACBox2.Text = MemBox.Text;
                    }
                    
                }

                MessageBox.Show("Program has been terminated!");

                PCBox1.Text = "00";

                ACBox1.ResetText();
                PCBox1.ResetText();
                IRBox1.Text = "900";

                return;
            }

            #endregion //opCode region - end

        #endregion

        /*************************************************************************
        * REGION | OtherFunctions
        * ------------------------------------------------------------------------
        *  This region holds the functions that arent related to any opcodes.
        *  It holds subfunctions of certain opCodes.
        * ------------------------------------------------------------------------
        * Current Functions:
        * 
        * + getCallContents - Grabs memory data.
        * + grabInputCard   - Grabs input card data.
        * + grabPC          - Grabs program counter.
        * + ICBox           - Artificial input card textbox.
        * + haltZero        - Halts returns nothing. 
        * 
        **************************************************************************/
        #region OtherFunctions

        /*****************************************************************
        * STRING | getCellContents
        * ----------------------------------------------------------------
        * This function is designed to grab the data within the selected
        * cell(textbox).
        * 
        * RETURNS: Data from the selected cell.
        ******************************************************************/
        private string getCellContents(int cellNum)
        {
            string cellContents;
            int    checkNum;

            checkNum = cellNum % 10;

            TextBox MemBox = (TextBox)groupMemory00.Controls["MemoryBox" + (cellNum < 10 ? "0" : "") + cellNum];

            if(cellNum == 0)
            {
                cellContents = "001";
            }
            else
            {
                if(checkNum == 0)
                {
                    cellContents = MemBox.Text;
                }
                else
                {
                    cellContents = MemBox.Text;
                }

            }

            if(cellContents == null)
            {
                MessageBox.Show("Execution Stopped! There is no Memory to fetch!");
                haltZero();
            }

            return cellContents;
        }
        /*****************************************************************
        * STRING | grabInputCard
        * ----------------------------------------------------------------
        * This function is designed to grab the data from the input card
        * and increment according to input card space. 
        * 
        * RETURNS: Data from the selected inputcard cell.
        ******************************************************************/
        private int grabInputCard()
        {
            int cardNum;

            cardNum = Convert.ToInt32(ICBox.Text);

            cardNum++;

            ICBox.Text = cardNum.ToString();

            return cardNum;
        }
        /*****************************************************************
        * STRING | grabPC
        * ----------------------------------------------------------------
        * This function is designed to grab the program counter data.
        * 
        * RETURNS: Program counter data.
        ******************************************************************/
        private int grabPC()
        {
            int numPC;

            numPC = Convert.ToInt32(PCBox1.Text);

            numPC++;

            if (numPC < 10)
            {
                PCBox1.Text = numPC.ToString("D2");
            }
            else
            {
                PCBox1.Text = numPC.ToString();
            }

            return numPC;
        }
        /*****************************************************************
        * VOID| ICBox
        * ----------------------------------------------------------------
        * Artificial Input card text box.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void ICBox_TextChanged(object sender, EventArgs e)
        {
            if (ICBox.Text == "")
            {
                ICBox.Text = "00";
            }

            #region Input Card Label Event

                if(ICBox.Text == "00")
                {
                    IC01.ForeColor = System.Drawing.Color.Red;

                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;
                }
                else if (ICBox.Text == "1")
                {
                    IC02.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor  = System.Drawing.Color.White;
                    IC03.ForeColor  = System.Drawing.Color.White;
                    IC04.ForeColor  = System.Drawing.Color.White;
                    IC05.ForeColor  = System.Drawing.Color.White;
                    IC06.ForeColor  = System.Drawing.Color.White;
                    IC07.ForeColor  = System.Drawing.Color.White;
                    IC08.ForeColor  = System.Drawing.Color.White;
                    IC09.ForeColor  = System.Drawing.Color.White;
                    IC10.ForeColor  = System.Drawing.Color.White;
                    IC11.ForeColor  = System.Drawing.Color.White;
                    IC12.ForeColor  = System.Drawing.Color.White;
                    IC13.ForeColor  = System.Drawing.Color.White;
                    IC14.ForeColor  = System.Drawing.Color.White;
                    IC15.ForeColor  = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "2")
                {
                    IC03.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "3")
                {
                    IC04.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "4")
                {
                    IC05.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "5")
                {
                    IC06.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "6")
                {
                    IC07.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "7")
                {
                    IC08.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "8")
                {
                    IC09.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "9")
                {
                    IC10.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "10")
                {
                    IC11.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "11")
                {
                    IC12.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "12")
                {
                    IC13.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "13")
                {
                    IC14.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC15.ForeColor = System.Drawing.Color.White;

                }
                else if (ICBox.Text == "14")
                {
                    IC15.ForeColor = System.Drawing.Color.Red;

                    IC01.ForeColor = System.Drawing.Color.White;
                    IC02.ForeColor = System.Drawing.Color.White;
                    IC03.ForeColor = System.Drawing.Color.White;
                    IC04.ForeColor = System.Drawing.Color.White;
                    IC05.ForeColor = System.Drawing.Color.White;
                    IC06.ForeColor = System.Drawing.Color.White;
                    IC07.ForeColor = System.Drawing.Color.White;
                    IC08.ForeColor = System.Drawing.Color.White;
                    IC09.ForeColor = System.Drawing.Color.White;
                    IC10.ForeColor = System.Drawing.Color.White;
                    IC11.ForeColor = System.Drawing.Color.White;
                    IC12.ForeColor = System.Drawing.Color.White;
                    IC13.ForeColor = System.Drawing.Color.White;
                    IC14.ForeColor = System.Drawing.Color.White;

                }



            #endregion
        }
        /*****************************************************************
        * VOID| resetPRGM
        * ----------------------------------------------------------------
        * Resets the text for CPU before return;
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void resetPRGM()
        {
            ACBox1.ResetText();
            ACBox2.ResetText();
            PCBox1.ResetText();
            IRBox1.ResetText();
            ICBox.ResetText();
        }
        /*****************************************************************
        * VOID| haltZero
        * ----------------------------------------------------------------
        * Halt!
        * 
        * RETURNS: Program counter data.
        ******************************************************************/
        private void haltZero()
        {
            resetPRGM();
            return;
        }

        #endregion

        /*****************************************************************
        * VOID| Memory Label Click Event
        * ----------------------------------------------------------------
        * Opens the Memory Help Information.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void Memory_Click(object sender, EventArgs e)
        {
            var newHelpForm = new MemHelp();

            newHelpForm.Show();
        }

        /*****************************************************************
        * VOID| Output Card Label Click Event
        * ----------------------------------------------------------------
        * Opens the Output Card Help Information.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void OutputCardlbl_Click(object sender, EventArgs e)
        {
            var newHelpForm = new OutputH();

            newHelpForm.Show();
        }

        /*****************************************************************
        * VOID| Input Card Label Click Event
        * ----------------------------------------------------------------
        * Opens the Input Card Help Information.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void InputCardlbl_Click(object sender, EventArgs e)
        {
            var newHelpForm = new InputH();

            newHelpForm.Show();
        }

        /*****************************************************************
        * VOID| Assist Button Click Event
        * ----------------------------------------------------------------
        * Opens the Assist Help Box.
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            var newHelpForm = new Assist1();

            newHelpForm.Show();
        }

        /*****************************************************************
        * VOID| DivisionBtn Click Event
        * ----------------------------------------------------------------
        * Sets the program values to Division problem and opens the
        * division help box. 
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void DivisionBtn_Click(object sender, EventArgs e)
        {

            //Reset and clear the program before setting boxes.
            CPUClear_Click(sender, e);    //Clears the CPU alltogether.
            OutputClear_Click(sender, e); //Clears the Output Cards.
            InputClear_Click(sender, e);  //Clears the Input Cards.
            MemoryClear_Click(sender, e); //Clears the Memory.

            var newHelpForm = new DivisionH();
            newHelpForm.Show();

            PCBox1.Text    = "20";
            InputBox1.Text = "007";
            InputBox2.Text = "003";

            MemoryBox20.Text = "804";
            MemoryBox21.Text = "534";
            MemoryBox22.Text = "035";
            MemoryBox23.Text = "036";
            MemoryBox24.Text = "435";
            MemoryBox25.Text = "336";
            MemoryBox26.Text = "732";
            MemoryBox27.Text = "535";
            MemoryBox28.Text = "434";
            MemoryBox29.Text = "200";
            MemoryBox30.Text = "534";
            MemoryBox31.Text = "624";
            MemoryBox32.Text = "134";
            MemoryBox33.Text = "900";
        }

        /*****************************************************************
        * VOID| ShiftingBtn Click Event
        * ----------------------------------------------------------------
        * Sets the program values to Shifting problem and opens the
        * Shifting help box. 
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void ShiftingBtn_Click(object sender, EventArgs e)
        {

            //Reset and clear the program before setting boxes.
            CPUClear_Click(sender, e);    //Clears the CPU alltogether.
            OutputClear_Click(sender, e); //Clears the Output Cards.
            InputClear_Click(sender, e);  //Clears the Input Cards.
            MemoryClear_Click(sender, e); //Clears the Memory.

            var newHelpForm = new ShiftingH();
            newHelpForm.Show();

            PCBox1.Text = "20";
            InputBox1.Text = "789";

            MemoryBox20.Text = "035";
            MemoryBox21.Text = "435";
            MemoryBox22.Text = "813";
            MemoryBox23.Text = "536";
            MemoryBox24.Text = "435";
            MemoryBox25.Text = "823";
            MemoryBox26.Text = "810";
            MemoryBox27.Text = "236";
            MemoryBox28.Text = "536";
            MemoryBox29.Text = "435";
            MemoryBox30.Text = "831";
            MemoryBox31.Text = "236";
            MemoryBox32.Text = "536";
            MemoryBox33.Text = "136";
            MemoryBox34.Text = "900";
        }

        /*****************************************************************
        * VOID| AbsoluteValueBtn Click Event
        * ----------------------------------------------------------------
        * Sets the program values to Absolute value problem and opens the
        * Absolute value help box. 
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void Absolute_Click(object sender, EventArgs e)
        {

            //Reset and clear the program before setting boxes.
            CPUClear_Click(sender, e);    //Clears the CPU alltogether.
            OutputClear_Click(sender, e); //Clears the Output Cards.
            InputClear_Click(sender, e);  //Clears the Input Cards.
            MemoryClear_Click(sender, e); //Clears the Memory.

            var newHelpForm = new AbsoluteH();

            newHelpForm.Show();

            PCBox1.Text = "20";
            InputBox1.Text = "004";
            InputBox2.Text = "-005";
            InputBox3.Text = "-003";

            MemoryBox20.Text = "036";
            MemoryBox21.Text = "037";
            MemoryBox22.Text = "038";
            MemoryBox23.Text = "436";
            MemoryBox24.Text = "680";
            MemoryBox25.Text = "539";
            MemoryBox26.Text = "437";
            MemoryBox27.Text = "680";
            MemoryBox28.Text = "239";
            MemoryBox29.Text = "539";
            MemoryBox30.Text = "438";
            MemoryBox31.Text = "680";
            MemoryBox32.Text = "239";
            MemoryBox33.Text = "539";
            MemoryBox34.Text = "139";
            MemoryBox35.Text = "900";

            MemoryBox80.Text = "591";
            MemoryBox81.Text = "499";
            MemoryBox82.Text = "290";
            MemoryBox83.Text = "589";
            MemoryBox84.Text = "491";
            MemoryBox85.Text = "787";
            MemoryBox86.Text = "689";
            MemoryBox87.Text = "804";
            MemoryBox88.Text = "391";
            MemoryBox90.Text = "600";
        }

        /*****************************************************************
        * VOID| BootStrap Click Event
        * ----------------------------------------------------------------
        * Sets the program values to BootStrap problem and opens the
        * BootStrap help box. 
        * 
        * RETURNS: Nothing.
        ******************************************************************/
        private void BootStrap_Click(object sender, EventArgs e)
        {
            //Reset and clear the program before setting boxes.
            CPUClear_Click(sender, e);    //Clears the CPU alltogether.
            OutputClear_Click(sender, e); //Clears the Output Cards.
            InputClear_Click(sender, e);  //Clears the Input Cards.
            MemoryClear_Click(sender, e); //Clears the Memory.

            var newHelpForm = new BootH();

            newHelpForm.Show();

            InputBox1.Text  = "002";
            InputBox2.Text  = "600";
            InputBox3.Text  = "003";
            InputBox4.Text  = "200";
            InputBox5.Text  = "004";
            InputBox6.Text  = "501";
            InputBox7.Text  = "005";
            InputBox8.Text  = "601";
            InputBox9.Text  = "002";
            InputBox10.Text = "401";

            MemoryBox02.Text = "401";
            MemoryBox03.Text = "200";
            MemoryBox04.Text = "501";
            MemoryBox05.Text = "601";
        }

    }//public partial class Base : Form

}//namespace SimpleComputer
