using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Shawn M. Crawford [sleepy]
 * sleepy3d@gmail.com
 * 03/27/2016
 */
namespace DragonWarriorTextEditor
{
    public partial class Form13_bb : Form
    {

        string path = "";

        public Form13_bb()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x64, textBoxBB1,  0x9C10, 0); //<ﾟTis said that the Dragonlord hath claws that can cleave iron and fiery breath that can melt stone>
                backend.updateROMText(absoluteFilename, 0x21, textBoxBB2,  0x9C76, 0); //<Dost thou still wish to go on?'~
                backend.updateROMText(absoluteFilename, 0x39, textBoxBB3,  0x9C98, 0); //<This is a magic place.~Hast thou found a magic temple?'~
                backend.updateROMText(absoluteFilename, 0x30, textBoxBB4,  0x9CD2, 0); //<When entering the cave, take with thee a torch>
                backend.updateROMText(absoluteFilename, 0x1B, textBoxBB5,  0x9D03, 0); //<Go to the town of Cantlin>
                backend.updateROMText(absoluteFilename, 0x2F, textBoxBB6,  0x9D1F, 0); //<I have heard that powerful enemies live there>
                backend.updateROMText(absoluteFilename, 0x16, textBoxBB7,  0x9D4F, 0); //<Thou art truly brave>
                backend.updateROMText(absoluteFilename, 0x29, textBoxBB8,  0x9D66, 0); //<In this temple do the sun and rain meet>
                backend.updateROMText(absoluteFilename, 0x3B, textBoxBB9,  0x9D91, 0); //<Howard had it, but he went to Rimuldar and never returned>
                backend.updateROMText(absoluteFilename, 0x3A, textBoxBB10, 0x9DCD, 0); //<To the south, I believe, there is a town called Rimuldar>
                backend.updateROMText(absoluteFilename, 0x30, textBoxBB11, 0x9E08, 0); //<That is good>~<No one will say thou art afraid>
                backend.updateROMText(absoluteFilename, 0x11, textBoxBB12, 0x9E39, 0); //<Go to the south>
                backend.updateROMText(absoluteFilename, 0x2D, textBoxBB13, 0x9E4B, 0); //<Where oh where can I find Princess Gwaelin?'
                backend.updateROMText(absoluteFilename, 0x23, textBoxBB14, 0x9E79, 0); //<Thank you for saving the Princess>
                backend.updateROMText(absoluteFilename, 0x2A, textBoxBB15, 0x9E9D, 0); //<Oh, my dearest Gwaelin!'~<I hate thee, ь>
                backend.updateROMText(absoluteFilename, 0x3E, textBoxBB16, 0x9EC8, 0); //<Tell King Lorik that the search for his daughter hath failed>
                backend.updateROMText(absoluteFilename, 0x14, textBoxBB17, 0x9F08, 0); //<I am almost gone....'
                backend.updateROMText(absoluteFilename, 0x31, textBoxBB18, 0x9F1D, 0); //<Who touches me?'~<I see nothing, nor can I hear>
                backend.updateROMText(absoluteFilename, 0x29, textBoxBB19, 0x9F4F, 0); //<Dost thou know about Princess Gwaelin?'~
                backend.updateROMText(absoluteFilename, 0x4B, textBoxBB20, 0x9F79, 0); //<Half a year now hath passed since the Princess was kidnapped by the enemy>
                backend.updateROMText(absoluteFilename, 0x40, textBoxBB21, 0x9FC6, 0); //<Never does the King speak of it, but he must be suffering much>
                backend.updateROMText(absoluteFilename, 0x1D, textBoxBB22, 0xA008, 0); //<ь, please save the Princess>
                backend.updateROMText(absoluteFilename, 0xD,  textBoxBB23, 0xA026, 0); //<Oh, brave ь>
                backend.updateROMText(absoluteFilename, 0x2F, textBoxBB24, 0xA034, 0); //<I have been waiting long for one such as thee>
                backend.updateROMText(absoluteFilename, 0x25, textBoxBB25, 0xA065, 0); //<Thou hast no business here.~Go away>
                backend.updateROMText(absoluteFilename, 0x20, textBoxBB26, 0xA08B, 0); //<If thou art cursed, come again>
                backend.updateROMText(absoluteFilename, 0x21, textBoxBB27, 0xA0AC, 0); //<I will free thee from thy curse>
                backend.updateROMText(absoluteFilename, 0x9,  textBoxBB28, 0xA0CF, 0); //<Now, go>
                backend.updateROMText(absoluteFilename, 0x68, textBoxBB29, 0xA0D9, 0); //<Though thou art as brave as thy ancestor, ь, thou cannot defeat the great Dragonlord with such weapons>
                backend.updateROMText(absoluteFilename, 0x1F, textBoxBB30, 0xA143, 0); //<Thou shouldst come here again>
                backend.updateROMText(absoluteFilename, 0x22, textBoxBB31, 0xA163, 0); //<Finally thou hast obtained it, ь>
                backend.updateROMText(absoluteFilename, 0x3E, textBoxBB32, 0xA186, 0); //<Is that a wedding ring?'~<Thou seems too young to be married>
                backend.updateROMText(absoluteFilename, 0x1F, textBoxBB33, 0xA1C5, 0); //<All true warriors wear a ring>
                backend.updateROMText(absoluteFilename, 0x50, textBoxBB34, 0xA1E5, 0); //<ь゜s coming was foretold by legend.~May the light shine upon this brave warrior>
                backend.updateROMText(absoluteFilename, 0x18, textBoxBB35, 0xA237, 0); //<Thou may go and search>
                backend.updateROMText(absoluteFilename, 0x48, textBoxBB36, 0xA251, 0); //<From Tantegel Castle travel 70 leagues to the south and 40 to the east>
                backend.updateROMText(absoluteFilename, 0xF,  textBoxBB37, 0xA29B, 0); //<It゜s a legend>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxBB38, 0xA2AB, 0); //<Thy bravery must be proven>
                backend.updateROMText(absoluteFilename, 0x18, textBoxBB39, 0xA2C9, 0); //<Thus, I propose a test>
                backend.updateROMText(absoluteFilename, 0x48, textBoxBB40, 0xA2E3, 0); //<There is a Silver Harp that beckons to the creatures of the Dragonlord>

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string sendPathToOtherForm
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
            }
        }

        private void Form9_rc_Load(object sender, EventArgs e)
        {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText()
        {
            try
            {
                Backend backend = new Backend();

                backend.getText(path, textBoxBB1,  0x64, 0x9C10, 0);
                backend.getText(path, textBoxBB2,  0x21, 0x9C76, 0);
                backend.getText(path, textBoxBB3,  0x39, 0x9C98, 0);
                backend.getText(path, textBoxBB4,  0x30, 0x9CD2, 0);
                backend.getText(path, textBoxBB5,  0x1B, 0x9D03, 0);
                backend.getText(path, textBoxBB6,  0x2F, 0x9D1F, 0);
                backend.getText(path, textBoxBB7,  0x16, 0x9D4F, 0);
                backend.getText(path, textBoxBB8,  0x29, 0x9D66, 0);
                backend.getText(path, textBoxBB9,  0x3B, 0x9D91, 0);
                backend.getText(path, textBoxBB10, 0x3A, 0x9DCD, 0);
                backend.getText(path, textBoxBB11, 0x30, 0x9E08, 0);
                backend.getText(path, textBoxBB12, 0x11, 0x9E39, 0);
                backend.getText(path, textBoxBB13, 0x2D, 0x9E4B, 0);
                backend.getText(path, textBoxBB14, 0x23, 0x9E79, 0);
                backend.getText(path, textBoxBB15, 0x2A, 0x9E9D, 0);
                backend.getText(path, textBoxBB16, 0x3E, 0x9EC8, 0);
                backend.getText(path, textBoxBB17, 0x14, 0x9F08, 0);
                backend.getText(path, textBoxBB18, 0x31, 0x9F1D, 0);
                backend.getText(path, textBoxBB19, 0x29, 0x9F4F, 0);
                backend.getText(path, textBoxBB20, 0x4B, 0x9F79, 0);
                backend.getText(path, textBoxBB21, 0x40, 0x9FC6, 0);
                backend.getText(path, textBoxBB22, 0x1D,  0xA008, 0);
                backend.getText(path, textBoxBB23, 0xD, 0xA026, 0);
                backend.getText(path, textBoxBB24, 0x2F, 0xA034, 0);
                backend.getText(path, textBoxBB25, 0x25, 0xA065, 0);
                backend.getText(path, textBoxBB26, 0x20, 0xA08B, 0);
                backend.getText(path, textBoxBB27, 0x21, 0xA0AC, 0);
                backend.getText(path, textBoxBB28, 0x9, 0xA0CF, 0);
                backend.getText(path, textBoxBB29, 0x68, 0xA0D9, 0);
                backend.getText(path, textBoxBB30, 0x1F, 0xA143, 0);
                backend.getText(path, textBoxBB31, 0x22, 0xA163, 0);
                backend.getText(path, textBoxBB32, 0x3E, 0xA186, 0);
                backend.getText(path, textBoxBB33, 0x1F, 0xA1C5, 0);
                backend.getText(path, textBoxBB34, 0x50, 0xA1E5, 0);
                backend.getText(path, textBoxBB35, 0x18, 0xA237, 0);
                backend.getText(path, textBoxBB36, 0x48, 0xA251, 0);
                backend.getText(path, textBoxBB37, 0xF, 0xA29B, 0);
                backend.getText(path, textBoxBB38, 0x1C, 0xA2AB, 0);
                backend.getText(path, textBoxBB39, 0x18, 0xA2C9, 0);
                backend.getText(path, textBoxBB40, 0x48, 0xA2E3, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxBB1.MaxLength =  0x64;
            textBoxBB2.MaxLength =  0x21;
            textBoxBB3.MaxLength =  0x39;
            textBoxBB4.MaxLength =  0x30;
            textBoxBB5.MaxLength =  0x1B;
            textBoxBB6.MaxLength =  0x2F;
            textBoxBB7.MaxLength =  0x16;
            textBoxBB8.MaxLength =  0x29;
            textBoxBB9.MaxLength =  0x3B;
            textBoxBB10.MaxLength = 0x3A;
            textBoxBB11.MaxLength = 0x30;
            textBoxBB12.MaxLength = 0x11;
            textBoxBB13.MaxLength = 0x2D;
            textBoxBB14.MaxLength = 0x23;
            textBoxBB15.MaxLength = 0x2A;
            textBoxBB16.MaxLength = 0x3E;
            textBoxBB17.MaxLength = 0x14;
            textBoxBB18.MaxLength = 0x31;
            textBoxBB19.MaxLength = 0x29;
            textBoxBB20.MaxLength = 0x4B;
            textBoxBB21.MaxLength = 0x40;
            textBoxBB22.MaxLength = 0x1D;
            textBoxBB23.MaxLength = 0xD;
            textBoxBB24.MaxLength = 0x2F;
            textBoxBB25.MaxLength = 0x25;
            textBoxBB26.MaxLength = 0x20;
            textBoxBB27.MaxLength = 0x21;
            textBoxBB28.MaxLength = 0x9;
            textBoxBB29.MaxLength = 0x68;
            textBoxBB30.MaxLength = 0x1F;
            textBoxBB31.MaxLength = 0x22;
            textBoxBB32.MaxLength = 0x3E;
            textBoxBB33.MaxLength = 0x1F;
            textBoxBB34.MaxLength = 0x50;
            textBoxBB35.MaxLength = 0x18;
            textBoxBB36.MaxLength = 0x48;
            textBoxBB37.MaxLength = 0xF;
            textBoxBB38.MaxLength = 0x1C;
            textBoxBB39.MaxLength = 0x18;
            textBoxBB40.MaxLength = 0x48;
        }
    }
}
