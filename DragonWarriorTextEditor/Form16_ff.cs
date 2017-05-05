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
    public partial class Form16_ff : Form
    {

        string path = "";

        public Form16_ff()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x16, textBoxFF1,   0xAFB6, 0); //chants the spell of Σ.
                backend.updateROMText(absoluteFilename, 0x15, textBoxFF2,   0xAFCD, 0); //ь゜s spell is blocked.
                backend.updateROMText(absoluteFilename, 0x45, textBoxFF3,   0xAFFE, 0); //<If thou hast collected all the Treasure Chests,~a key will be found>
                backend.updateROMText(absoluteFilename, 0x58, textBoxFF4,   0xB045, 0); //<Once used, the key will disappear, but the door will be open and thou may pass through>
                backend.updateROMText(absoluteFilename, 0x5B, textBoxFF5,   0xB09E, 0); //<East of this castle is a town where armor, weapons, and many other items may be purchased>
                backend.updateROMText(absoluteFilename, 0x3F, textBoxFF6,   0xB0FB, 0); //<Return to the Inn for a rest if thou art wounded in battle, ь>
                backend.updateROMText(absoluteFilename, 0x11, textBoxFF7,   0xB13C, 0); //<Sleep heals all>
                backend.updateROMText(absoluteFilename, 0x2F, textBoxFF8,   0xB14E, 0); //<Descendant of Erdrick, listen now to my words>
                backend.updateROMText(absoluteFilename, 0x49, textBoxFF9,   0xB17F, 0); //<It is told that in ages past Erdrick fought demons with a Ball of Light>
                backend.updateROMText(absoluteFilename, 0x52, textBoxFF10,  0xB1CA, 0); //<Then came the Dragonlord who stole the precious globe and hid it in the darkness>
                backend.updateROMText(absoluteFilename, 0x53, textBoxFF11,  0xB21E, 0); //<Now, ь, thou must help us recover the Ball of Light and restore peace to our land>
                backend.updateROMText(absoluteFilename, 0x21, textBoxFF12,  0xB273, 0); //<The Dragonlord must be defeated>
                backend.updateROMText(absoluteFilename, 0x53, textBoxFF13,  0xB296, 0); //<Take now whatever thou may find in these Treasure Chests to aid thee in thy quest>
                backend.updateROMText(absoluteFilename, 0x4C, textBoxFF14,  0xB2EB, 0); //<Then speak with the guards, for they have much knowledge that may aid thee>
                backend.updateROMText(absoluteFilename, 0x22, textBoxFF15,  0xB339, 0); //<May the light shine upon thee, ь>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxFF16,  0xB35D, 0); //The tablet reads as follows:
                backend.updateROMText(absoluteFilename, 0x2A, textBoxFF17,  0xB37D, 0); // <I am Erdrick and thou art my descendant>
                backend.updateROMText(absoluteFilename, 0x55, textBoxFF18,  0xB3A9, 0); // <Three items were needed to reach the Isle of Dragons, which is south of Brecconary>
                backend.updateROMText(absoluteFilename, 0x5A, textBoxFF19,  0xB400, 0); // <I gathered these items, reached the island, and there defeated a creature of great evil>
                backend.updateROMText(absoluteFilename, 0x3F, textBoxFF20,  0xB45C, 0); // <Now I have entrusted the three items to three worthy keepers>
                backend.updateROMText(absoluteFilename, 0x57, textBoxFF21,  0xB49D, 0); // <Their descendants will protect the items until thy quest leads thee to seek them out>
                backend.updateROMText(absoluteFilename, 0x3C, textBoxFF22,  0xB4F6, 0); // <When a new evil arises, find the three items, then fight!'
                backend.updateROMText(absoluteFilename, 0xF, textBoxFF23,  0xB533, 0); //Excellent move!
                backend.updateROMText(absoluteFilename, 0x41, textBoxFF24,  0xB543, 0); //<ь?~This is Gwaelin.~Know that thou hath reached the final level>
                backend.updateROMText(absoluteFilename, 0x10, textBoxFF25,  0xB586, 0); //Thou art asleep.
                backend.updateROMText(absoluteFilename, 0x16, textBoxFF26,  0xB599, 0); //Thou art still asleep.
                backend.updateROMText(absoluteFilename, 0x9, textBoxFF27,  0xB5B2, 0); //ь awakes.
                backend.updateROMText(absoluteFilename, 0x15, textBoxFF28,  0xB5BC, 0); //The ё hath recovered.
                backend.updateROMText(absoluteFilename, 0xE, textBoxFF29,  0xB5D2, 0); //It is dodging!
                backend.updateROMText(absoluteFilename, 0x16, textBoxFF30,  0xB5E1, 0); //There is no door here.
                backend.updateROMText(absoluteFilename, 0x1B, textBoxFF31,  0xB5F8, 0); //Thou hast not a key to use.
                backend.updateROMText(absoluteFilename, 0x25, textBoxFF32,  0xB614, 0); //<Death should not have taken thee, ь>
                backend.updateROMText(absoluteFilename, 0x21,  textBoxFF33, 0xB63B, 0); //<I will give thee another chance>
                backend.updateROMText(absoluteFilename, 0x19, textBoxFF34,  0xB65E, 0); //Thy power increases by Ɠ.
                backend.updateROMText(absoluteFilename, 0x22, textBoxFF35,  0xB678, 0); //Thy Response Speed increases by Ɠ.
                backend.updateROMText(absoluteFilename, 0x20, textBoxFF36,  0xB69C, 0); // Thy Maximum Hitϋ increase by Ɠ.
                backend.updateROMText(absoluteFilename, 0x22, textBoxFF37,  0xB6BE, 0); // Thy Maximum Magicϋ increase by Ɠ.
                backend.updateROMText(absoluteFilename, 0x3D, textBoxFF38,  0xB6E1, 0); //<To reach the next level, thy Experienceϋ must increase by Ɠ>
                backend.updateROMText(absoluteFilename, 0xD, textBoxFF39,  0xB720, 0); //<Now, go, ь!'
                backend.updateROMText(absoluteFilename, 0x26, textBoxFF40,  0xB72E, 0); //<Thou hast failed and thou art cursed>

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

                backend.getText(path, textBoxFF1,  0x16, 0xAFB6, 0);
                backend.getText(path, textBoxFF2,  0x15, 0xAFCD, 0);
                backend.getText(path, textBoxFF3,  0x45, 0xAFFE, 0);
                backend.getText(path, textBoxFF4,  0x58, 0xB045, 0);
                backend.getText(path, textBoxFF5,  0x5B, 0xB09E, 0);
                backend.getText(path, textBoxFF6,  0x3F, 0xB0FB, 0);
                backend.getText(path, textBoxFF7,  0x11, 0xB13C, 0);
                backend.getText(path, textBoxFF8,  0x2F, 0xB14E, 0);
                backend.getText(path, textBoxFF9,  0x49, 0xB17F, 0);
                backend.getText(path, textBoxFF10, 0x52, 0xB1CA, 0);
                backend.getText(path, textBoxFF11, 0x53, 0xB21E, 0);
                backend.getText(path, textBoxFF12, 0x21, 0xB273, 0);
                backend.getText(path, textBoxFF13, 0x53,  0xB296, 0);
                backend.getText(path, textBoxFF14, 0x4C,  0xB2EB, 0);
                backend.getText(path, textBoxFF15, 0x22,  0xB339, 0);
                backend.getText(path, textBoxFF16, 0x1C, 0xB35D, 0);
                backend.getText(path, textBoxFF17, 0x2A, 0xB37D, 0);
                backend.getText(path, textBoxFF18, 0x55,  0xB3A9, 0);
                backend.getText(path, textBoxFF19, 0x5A, 0xB400, 0);
                backend.getText(path, textBoxFF20, 0x3F, 0xB45C, 0);
                backend.getText(path, textBoxFF21, 0x57,  0xB49D, 0);
                backend.getText(path, textBoxFF22, 0x3C, 0xB4F6, 0);
                backend.getText(path, textBoxFF23, 0xF, 0xB533, 0);
                backend.getText(path, textBoxFF24, 0x41, 0xB543, 0);
                backend.getText(path, textBoxFF25, 0x10, 0xB586, 0);
                backend.getText(path, textBoxFF26, 0x16, 0xB599, 0);
                backend.getText(path, textBoxFF27, 0x9, 0xB5B2, 0);
                backend.getText(path, textBoxFF28, 0x15, 0xB5BC, 0);
                backend.getText(path, textBoxFF29, 0xE, 0xB5D2, 0);
                backend.getText(path, textBoxFF30, 0x16, 0xB5E1, 0);
                backend.getText(path, textBoxFF31, 0x1B, 0xB5F8, 0);
                backend.getText(path, textBoxFF32, 0x25, 0xB614, 0);
                backend.getText(path, textBoxFF33, 0x21,  0xB63B, 0);
                backend.getText(path, textBoxFF34, 0x19, 0xB65E, 0);
                backend.getText(path, textBoxFF35, 0x22, 0xB678, 0);
                backend.getText(path, textBoxFF36, 0x20, 0xB69C, 0);
                backend.getText(path, textBoxFF37, 0x22, 0xB6BE, 0);
                backend.getText(path, textBoxFF38, 0x3D,  0xB6E1, 0);
                backend.getText(path, textBoxFF39, 0xD, 0xB720, 0);
                backend.getText(path, textBoxFF40, 0x26, 0xB72E, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxFF1.MaxLength =  0x16;
            textBoxFF2.MaxLength =  0x15;
            textBoxFF3.MaxLength =  0x45;
            textBoxFF4.MaxLength =  0x58;
            textBoxFF5.MaxLength =  0x5B;
            textBoxFF6.MaxLength =  0x3F;
            textBoxFF7.MaxLength =  0x11;
            textBoxFF8.MaxLength =  0x2F;
            textBoxFF9.MaxLength =  0x49;
            textBoxFF10.MaxLength = 0x52;
            textBoxFF11.MaxLength = 0x53;
            textBoxFF12.MaxLength = 0x21;
            textBoxFF13.MaxLength = 0x53;
            textBoxFF14.MaxLength = 0x4C;
            textBoxFF15.MaxLength = 0x22;
            textBoxFF16.MaxLength = 0x1C;
            textBoxFF17.MaxLength = 0x2A;
            textBoxFF18.MaxLength = 0x55;
            textBoxFF19.MaxLength = 0x5A;
            textBoxFF20.MaxLength = 0x3F;
            textBoxFF21.MaxLength = 0x57;
            textBoxFF22.MaxLength = 0x3C;
            textBoxFF23.MaxLength = 0xF;
            textBoxFF24.MaxLength = 0x41;
            textBoxFF25.MaxLength = 0x10;
            textBoxFF26.MaxLength = 0x16;
            textBoxFF27.MaxLength = 0x9;
            textBoxFF28.MaxLength = 0x15;
            textBoxFF29.MaxLength = 0xE;
            textBoxFF30.MaxLength = 0x16;
            textBoxFF31.MaxLength = 0x1B;
            textBoxFF32.MaxLength = 0x25;
            textBoxFF33.MaxLength = 0x21;
            textBoxFF34.MaxLength = 0x19;
            textBoxFF35.MaxLength = 0x22;
            textBoxFF36.MaxLength = 0x20;
            textBoxFF37.MaxLength = 0x22;
            textBoxFF38.MaxLength = 0x3D;
            textBoxFF39.MaxLength = 0xD;
            textBoxFF40.MaxLength = 0x26;
        }
    }
}
