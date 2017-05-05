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
    public partial class Form11_cc : Form
    {

        string path = "";

        public Form11_cc()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x50, textBoxCC1,   0x8A72,  0); //<To become strong enough to face future trials thou must first battle many foes>
                backend.updateROMText(absoluteFilename, 0x5F, textBoxCC2,   0x8AC3,  0); //<King Lorik will record thy deeds in his Imperial Scroll so thou may return to thy quest later>
                backend.updateROMText(absoluteFilename, 0x3B, textBoxCC3,   0x8B23,  0); //<When the sun and rain meet, a Rainbow Bridge shall appear>
                backend.updateROMText(absoluteFilename, 0x21, textBoxCC4,   0x8B5F,  0); //<Never does a brave person steal>
                backend.updateROMText(absoluteFilename, 0x55, textBoxCC5,   0x8B81,  0); //<There was a time when Brecconary was a paradise.~Then the Dragonlord゜s minions came>
                backend.updateROMText(absoluteFilename, 0x1F, textBoxCC6,   0x8BD7,  0); //<Let us wish the warrior well!'
                backend.updateROMText(absoluteFilename, 0x20, textBoxCC7,   0x8BF8,  0); //<May the light be thy strength!'
                backend.updateROMText(absoluteFilename, 0x38, textBoxCC8,   0x8C19,  0); //<If thy Hit Points are high enough, by all means, enter>
                backend.updateROMText(absoluteFilename, 0x7D, textBoxCC9,   0x8C52,  0); //<We are merchants who have traveled much in this land.~Many of our colleagues have been killed by servants of the Dragonlord>
                backend.updateROMText(absoluteFilename, 0x51,  textBoxCC10, 0x8CD0,  0); //<Rumor has it that entire towns have been destroyed by the Dragonlord゜s servants>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxCC11,  0x8D22,  0); //<Welcome to Tantegel Castle>
                backend.updateROMText(absoluteFilename, 0x55, textBoxCC12,  0x8D3F,  0); //<In Garinham,look for the grave of Garin.~Thou must push on a wall of darkness there>
                backend.updateROMText(absoluteFilename, 0x12, textBoxCC13,  0x8D95,  0); //<A word of advice>
                backend.updateROMText(absoluteFilename, 0x29, textBoxCC14,  0x8DA9,  0); //<Save thy money for more expensive armor>
                backend.updateROMText(absoluteFilename, 0x34,  textBoxCC15, 0x8DD3,  0); //<Listen to what people say.~It can be of great help>
                backend.updateROMText(absoluteFilename, 0x15, textBoxCC16,  0x8E08,  0); //<Beware the bridges!'
                backend.updateROMText(absoluteFilename, 0x20, textBoxCC17,  0x8E1F,  0); //<Danger grows when thou crosses>
                backend.updateROMText(absoluteFilename, 0x33, textBoxCC18,  0x8E40,  0); //<There is a town where magic keys can be purchased>
                backend.updateROMText(absoluteFilename, 0x36, textBoxCC19,  0x8E74,  0); //<Some say that Garin゜s grave is home to a Silver Harp>
                backend.updateROMText(absoluteFilename, 0x16, textBoxCC20,  0x8EAB,  0); //<Enter where thou can>
                backend.updateROMText(absoluteFilename, 0x41, textBoxCC21,  0x8EC2,  0); //<Welcome!~Enter the shop and speak to its keeper across the desk>
                backend.updateROMText(absoluteFilename, 0x25, textBoxCC22,  0x8F04,  0); //<Thou art most welcome in Brecconary>
                backend.updateROMText(absoluteFilename, 0x32, textBoxCC23,  0x8F2A,  0); //<Watch thy Hit Points when in the Poisonous Marsh>
                backend.updateROMText(absoluteFilename, 0x5B, textBoxCC24,  0x8F5D,  0); //<Go north to the seashore, then follow the coastline west until thou hath reached Garinham>
                backend.updateROMText(absoluteFilename, 0x1E, textBoxCC25,  0x8FB9,  0); //<No,I am not Princess Gwaelin>
                backend.updateROMText(absoluteFilename, 0x33, textBoxCC26,  0x8FD8,  0); //<Please,save us from the minions of the Dragonlord>
                backend.updateROMText(absoluteFilename, 0x36, textBoxCC27,  0x900C,  0); //<See King Lorik when thy experience levels are raised>
                backend.updateROMText(absoluteFilename, 0x3A, textBoxCC28,  0x9043,  0); //<Art thou the descendant of Erdrick?~Hast thou any proof?'
                backend.updateROMText(absoluteFilename, 0x3B, textBoxCC29,  0x907E,  0); //<Within sight of Tantegel Castle to the south is Charlock,'
                backend.updateROMText(absoluteFilename, 0x20, textBoxCC30,  0x90BB,  0); //<The fortress of the Dragonlord>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxCC31,  0x90DC,  0); //<This bath cures rheumatism>
                backend.updateROMText(absoluteFilename, 0x67, textBoxCC32,  0x90F9,  0); //<East of Hauksness there is a town, ﾟtis said, where one may purchase weapons of extraordinary quality>
                backend.updateROMText(absoluteFilename, 0x23, textBoxCC33,  0x9161,  0); //<Rimuldar is the place to buy keys>
                backend.updateROMText(absoluteFilename, 0x31, textBoxCC34,  0x9185,  0); //<Hast thou seen Nester?~I think he may need help>
                backend.updateROMText(absoluteFilename, 0x1E, textBoxCC35,  0x91B7,  0); //<Dreadful is the South Island>
                backend.updateROMText(absoluteFilename, 0x4C, textBoxCC36,  0x91D7,  0); //<Great strength and skill and wit only will bring thee back from that place>
                backend.updateROMText(absoluteFilename, 0x39, textBoxCC37,  0x9224,  0); //<Golem is afraid of the music of the flute, so ﾟtis said>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxCC38,  0x925E,  0); //<This is the village of Kol>
                backend.updateROMText(absoluteFilename, 0x43, textBoxCC39,  0x927B,  0); //<In legends it is said that fairies know how to put Golem to sleep>
                backend.updateROMText(absoluteFilename, 0x41, textBoxCC40,  0x92BF,  0); //<The harp attracts enemies.~Stay away from the grave in Garinham>

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

                backend.getText(path, textBoxCC1,  0x50,  0x8A72, 0);
                backend.getText(path, textBoxCC2,  0x5F,  0x8AC3, 0);
                backend.getText(path, textBoxCC3,  0x3B,  0x8B23, 0);
                backend.getText(path, textBoxCC4,  0x21,  0x8B5F, 0);
                backend.getText(path, textBoxCC5,  0x55,  0x8B81, 0);
                backend.getText(path, textBoxCC6,  0x1F,  0x8BD7, 0);
                backend.getText(path, textBoxCC7,  0x20,  0x8BF8, 0);
                backend.getText(path, textBoxCC8,  0x38,  0x8C19, 0);
                backend.getText(path, textBoxCC9,  0x7D,  0x8C52, 0);
                backend.getText(path, textBoxCC10, 0x51,   0x8CD0, 0);
                backend.getText(path, textBoxCC11, 0x1C,  0x8D22, 0);
                backend.getText(path, textBoxCC12, 0x55,  0x8D3F, 0);
                backend.getText(path, textBoxCC13, 0x12,  0x8D95, 0);
                backend.getText(path, textBoxCC14, 0x29,  0x8DA9, 0);
                backend.getText(path, textBoxCC15, 0x34,   0x8DD3, 0);
                backend.getText(path, textBoxCC16, 0x15,  0x8E08, 0);
                backend.getText(path, textBoxCC17, 0x20,  0x8E1F, 0);
                backend.getText(path, textBoxCC18, 0x33,  0x8E40, 0);
                backend.getText(path, textBoxCC19, 0x36,  0x8E74, 0);
                backend.getText(path, textBoxCC20, 0x16,  0x8EAB, 0);
                backend.getText(path, textBoxCC21, 0x41,  0x8EC2, 0);
                backend.getText(path, textBoxCC22, 0x25,  0x8F04, 0);
                backend.getText(path, textBoxCC23, 0x32,  0x8F2A, 0);
                backend.getText(path, textBoxCC24, 0x5B,  0x8F5D, 0);
                backend.getText(path, textBoxCC25, 0x1E,  0x8FB9, 0);
                backend.getText(path, textBoxCC26, 0x33,  0x8FD8, 0);
                backend.getText(path, textBoxCC27, 0x36,  0x900C, 0);
                backend.getText(path, textBoxCC28, 0x3A,  0x9043, 0);
                backend.getText(path, textBoxCC29, 0x3B,  0x907E, 0);
                backend.getText(path, textBoxCC30, 0x20,  0x90BB, 0);
                backend.getText(path, textBoxCC31, 0x1C,  0x90DC, 0);
                backend.getText(path, textBoxCC32, 0x67,  0x90F9, 0);
                backend.getText(path, textBoxCC33, 0x23,  0x9161, 0);
                backend.getText(path, textBoxCC34, 0x31,  0x9185, 0);
                backend.getText(path, textBoxCC35, 0x1E,  0x91B7, 0);
                backend.getText(path, textBoxCC36, 0x4C,  0x91D7, 0);
                backend.getText(path, textBoxCC37, 0x39,  0x9224, 0);
                backend.getText(path, textBoxCC38, 0x1C,  0x925E, 0);
                backend.getText(path, textBoxCC39, 0x43,  0x927B, 0);
                backend.getText(path, textBoxCC40, 0x41,  0x92BF, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxCC1.MaxLength =  0x50;
            textBoxCC2.MaxLength =  0x5F;
            textBoxCC3.MaxLength =  0x3B;
            textBoxCC4.MaxLength =  0x21;
            textBoxCC5.MaxLength =  0x55;
            textBoxCC6.MaxLength =  0x1F;
            textBoxCC7.MaxLength =  0x20;
            textBoxCC8.MaxLength =  0x38;
            textBoxCC9.MaxLength =  0x7D;
            textBoxCC10.MaxLength = 0x51;
            textBoxCC11.MaxLength = 0x1C;
            textBoxCC12.MaxLength = 0x55;
            textBoxCC13.MaxLength = 0x12;
            textBoxCC14.MaxLength = 0x29;
            textBoxCC15.MaxLength = 0x34;
            textBoxCC16.MaxLength = 0x15;
            textBoxCC17.MaxLength = 0x20;
            textBoxCC18.MaxLength = 0x33;
            textBoxCC19.MaxLength = 0x36;
            textBoxCC20.MaxLength = 0x16;
            textBoxCC21.MaxLength = 0x41;
            textBoxCC22.MaxLength = 0x25;
            textBoxCC23.MaxLength = 0x32;
            textBoxCC24.MaxLength = 0x5B;
            textBoxCC25.MaxLength = 0x1E;
            textBoxCC26.MaxLength = 0x33;
            textBoxCC27.MaxLength = 0x36;
            textBoxCC28.MaxLength = 0x3A;
            textBoxCC29.MaxLength = 0x3B;
            textBoxCC30.MaxLength = 0x20;
            textBoxCC31.MaxLength = 0x1C;
            textBoxCC32.MaxLength = 0x67;
            textBoxCC33.MaxLength = 0x23;
            textBoxCC34.MaxLength = 0x31;
            textBoxCC35.MaxLength = 0x1E;
            textBoxCC36.MaxLength = 0x4C;
            textBoxCC37.MaxLength = 0x39;
            textBoxCC38.MaxLength = 0x1C;
            textBoxCC39.MaxLength = 0x43;
            textBoxCC40.MaxLength = 0x41;
        }
    }
}
