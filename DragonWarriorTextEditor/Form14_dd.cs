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
    public partial class Form14_dd : Form
    {

        string path = "";

        public Form14_dd()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x40, textBoxDD1,  0xA32D, 0); //<Bring this to me and I will reward thee with the Staff of Rain>
                backend.updateROMText(absoluteFilename, 0x22, textBoxDD2,  0xA36E, 0); //<Thou hast brought the harp. Good>
                backend.updateROMText(absoluteFilename, 0x61, textBoxDD3,  0xA392, 0); //<In thy task thou hast failed. Alas, I fear thou art not the one Erdrick predicted would save us>
                backend.updateROMText(absoluteFilename, 0x9,  textBoxDD4,  0xA3F5, 0); //<Go now!'
                backend.updateROMText(absoluteFilename, 0x4C, textBoxDD5,  0xA3FF, 0); //<Now the sun and rain shall meet and the Rainbow Drop passes to thy keeping>
                backend.updateROMText(absoluteFilename, 0x27, textBoxDD6,  0xA44C, 0); //<Thou art brave indeed to rescue me, ь>
                backend.updateROMText(absoluteFilename, 0x21, textBoxDD7,  0xA475, 0); //<I am Gwaelin, daughter of Lorik>
                backend.updateROMText(absoluteFilename, 0xF,  textBoxDD8,  0xA498, 0); //<But thou must>
                backend.updateROMText(absoluteFilename, 0x20, textBoxDD9,  0xA4A9, 0); //Princess Gwaelin embraces thee.~
                backend.updateROMText(absoluteFilename, 0xF, textBoxDD10, 0xA4CB, 0); //<I゜m so happy!'
                backend.updateROMText(absoluteFilename, 0x63, textBoxDD11, 0xA4DB, 0); //<Forever shall I be grateful for the gift of my daughter returned to her home, ь.~Accept my thanks>
                backend.updateROMText(absoluteFilename, 0x1F, textBoxDD12, 0xA540, 0); //<Now, Gwaelin, come to my side>
                backend.updateROMText(absoluteFilename, 0x4A, textBoxDD13, 0xA561, 0); //Gwaelin then whispers:~<Wait a moment,please.~I would give a present to ь>
                backend.updateROMText(absoluteFilename, 0x1A, textBoxDD14, 0xA5AD, 0); //<Please accept my love, ь>
                backend.updateROMText(absoluteFilename, 0x36, textBoxDD15, 0xA5C9, 0); //<And I would like to have something of thine--a token>
                backend.updateROMText(absoluteFilename, 0x16, textBoxDD16, 0xA601, 0); //<Please give me thy ϊ>
                backend.updateROMText(absoluteFilename, 0x46, textBoxDD17, 0xA618, 0); //<Even when we two are parted by great distances, I shall be with thee>
                backend.updateROMText(absoluteFilename, 0xD, textBoxDD18, 0xA660, 0); //<Farewell, ь>
                backend.updateROMText(absoluteFilename, 0x11, textBoxDD19, 0xA66F, 0); //<I love thee, ь>~
                backend.updateROMText(absoluteFilename, 0x18, textBoxDD20, 0xA681, 0); //<Dost thou love me, ь?'~
                backend.updateROMText(absoluteFilename, 0x51, textBoxDD21, 0xA69A, 0); //<When thou art finished preparing for thy departure, please see me.~I shall wait>
                backend.updateROMText(absoluteFilename, 0x31, textBoxDD22, 0xA6EC, 0); //<I am greatly pleased that thou hast returned, ь>
                backend.updateROMText(absoluteFilename, 0x3F, textBoxDD23, 0xA71F, 0); //<Before reaching thy next level of experience thou must gain Ě>
                backend.updateROMText(absoluteFilename, 0x5A, textBoxDD24, 0xA760, 0); //<If thou dies I can bring thee back for another attempt without loss of thy deeds to date>
                backend.updateROMText(absoluteFilename, 0x33, textBoxDD25, 0xA7BD, 0); //<Goodbye now, ь.~Take care and tempt not the Fates>
                backend.updateROMText(absoluteFilename, 0x23, textBoxDD26, 0xA7F1, 0); //<Will thou take me to the castle?'~
                backend.updateROMText(absoluteFilename, 0x19, textBoxDD27, 0xA815, 0); //<Take the Treasure Chest>
                backend.updateROMText(absoluteFilename, 0x30, textBoxDD28, 0xA82F, 0); //<Welcome, ь.~I am the Dragonlord--King of Kings>
                backend.updateROMText(absoluteFilename, 0x66, textBoxDD29, 0xA861, 0); //<I give thee now a chance to share this world and to rule half of it if thou will now stand beside me>
                backend.updateROMText(absoluteFilename, 0x3A, textBoxDD30, 0xA8C9, 0); //<What sayest thou?~Will the great warrior stand with me?'~
                backend.updateROMText(absoluteFilename, 0x14, textBoxDD31, 0xA904, 0); //<Thou art a fool!®¢~
                backend.updateROMText(absoluteFilename, 0x3F, textBoxDD32, 0xA918, 0); //<Then half of this world is thine, half of the darkness, and$$'
                backend.updateROMText(absoluteFilename, 0x3B, textBoxDD33, 0xA959, 0); //Thy journey is over.~Take now a long, long rest.~Hahahaha$$
                backend.updateROMText(absoluteFilename, 0x5E, textBoxDD34, 0xA996, 0); //If thou would take the ϊ, thou must now discard some other item.~Dost thou wish to have the ϊ?
                backend.updateROMText(absoluteFilename, 0x19, textBoxDD35, 0xA9F5, 0); //Thou hast given up thy ϊ.
                backend.updateROMText(absoluteFilename, 0x15, textBoxDD36, 0xAA0F, 0); //What shall thou drop?
                backend.updateROMText(absoluteFilename, 0x18, textBoxDD37, 0xAA25, 0); //Thou hast dropped thy ϊ.
                backend.updateROMText(absoluteFilename, 0x13, textBoxDD38, 0xAA3E, 0); //And obtained the ϊ.
                backend.updateROMText(absoluteFilename, 0x29, textBoxDD39, 0xAA52, 0); //That is much too important to throw away.
                backend.updateROMText(absoluteFilename, 0x20, textBoxDD40, 0xAA7C, 0); //ь searched the ground all about.

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

                backend.getText(path, textBoxDD1,  0x40, 0xA32D, 0);
                backend.getText(path, textBoxDD2,  0x22, 0xA36E, 0);
                backend.getText(path, textBoxDD3,  0x61, 0xA392, 0);
                backend.getText(path, textBoxDD4,  0x9, 0xA3F5, 0);
                backend.getText(path, textBoxDD5,  0x4C, 0xA3FF, 0);
                backend.getText(path, textBoxDD6,  0x27, 0xA44C, 0);
                backend.getText(path, textBoxDD7,  0x21, 0xA475, 0);
                backend.getText(path, textBoxDD8,  0xF, 0xA498, 0);
                backend.getText(path, textBoxDD9,  0x20, 0xA4A9, 0);
                backend.getText(path, textBoxDD10, 0xF, 0xA4CB, 0);
                backend.getText(path, textBoxDD11, 0x63, 0xA4DB, 0);
                backend.getText(path, textBoxDD12, 0x1F, 0xA540, 0);
                backend.getText(path, textBoxDD13, 0x4A, 0xA561, 0);
                backend.getText(path, textBoxDD14, 0x1A, 0xA5AD, 0);
                backend.getText(path, textBoxDD15, 0x36, 0xA5C9, 0);
                backend.getText(path, textBoxDD16, 0x16, 0xA601, 0);
                backend.getText(path, textBoxDD17, 0x46, 0xA618, 0);
                backend.getText(path, textBoxDD18, 0xD, 0xA660, 0);
                backend.getText(path, textBoxDD19, 0x11, 0xA66F, 0);
                backend.getText(path, textBoxDD20, 0x18, 0xA681, 0);
                backend.getText(path, textBoxDD21, 0x51, 0xA69A, 0);
                backend.getText(path, textBoxDD22, 0x31, 0xA6EC, 0);
                backend.getText(path, textBoxDD23, 0x3F, 0xA71F, 0);
                backend.getText(path, textBoxDD24, 0x5A, 0xA760, 0);
                backend.getText(path, textBoxDD25, 0x33, 0xA7BD, 0);
                backend.getText(path, textBoxDD26, 0x23, 0xA7F1, 0);
                backend.getText(path, textBoxDD27, 0x19, 0xA815, 0);
                backend.getText(path, textBoxDD28, 0x30, 0xA82F, 0);
                backend.getText(path, textBoxDD29, 0x66, 0xA861, 0);
                backend.getText(path, textBoxDD30, 0x3A, 0xA8C9, 0);
                backend.getText(path, textBoxDD31, 0x14, 0xA904, 0);
                backend.getText(path, textBoxDD32, 0x3F, 0xA918, 0);
                backend.getText(path, textBoxDD33, 0x3B, 0xA959, 0);
                backend.getText(path, textBoxDD34, 0x5E, 0xA996, 0);
                backend.getText(path, textBoxDD35, 0x19, 0xA9F5, 0);
                backend.getText(path, textBoxDD36, 0x15, 0xAA0F, 0);
                backend.getText(path, textBoxDD37, 0x18,  0xAA25, 0);
                backend.getText(path, textBoxDD38, 0x13, 0xAA3E, 0);
                backend.getText(path, textBoxDD39, 0x29, 0xAA52, 0);
                backend.getText(path, textBoxDD40, 0x20, 0xAA7C, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxDD1.MaxLength =  0x40;
            textBoxDD2.MaxLength =  0x22;
            textBoxDD3.MaxLength =  0x61;
            textBoxDD4.MaxLength =  0x9;
            textBoxDD5.MaxLength =  0x4C;
            textBoxDD6.MaxLength =  0x27;
            textBoxDD7.MaxLength =  0x21;
            textBoxDD8.MaxLength =  0xF;
            textBoxDD9.MaxLength =  0x20;
            textBoxDD10.MaxLength = 0xF;
            textBoxDD11.MaxLength = 0x63;
            textBoxDD12.MaxLength = 0x1F;
            textBoxDD13.MaxLength = 0x4A;
            textBoxDD14.MaxLength = 0x1A;
            textBoxDD15.MaxLength = 0x36;
            textBoxDD16.MaxLength = 0x16;
            textBoxDD17.MaxLength = 0x46;
            textBoxDD18.MaxLength = 0xD;
            textBoxDD19.MaxLength = 0x11;
            textBoxDD20.MaxLength = 0x18;
            textBoxDD21.MaxLength = 0x51;
            textBoxDD22.MaxLength = 0x31;
            textBoxDD23.MaxLength = 0x3F;
            textBoxDD24.MaxLength = 0x5A;
            textBoxDD25.MaxLength = 0x33;
            textBoxDD26.MaxLength = 0x23;
            textBoxDD27.MaxLength = 0x19;
            textBoxDD28.MaxLength = 0x30;
            textBoxDD29.MaxLength = 0x66;
            textBoxDD30.MaxLength = 0x3A;
            textBoxDD31.MaxLength = 0x14;
            textBoxDD32.MaxLength = 0x3F;
            textBoxDD33.MaxLength = 0x3B;
            textBoxDD34.MaxLength = 0x5E;
            textBoxDD35.MaxLength = 0x19;
            textBoxDD36.MaxLength = 0x15;
            textBoxDD37.MaxLength = 0x18;
            textBoxDD38.MaxLength = 0x13;
            textBoxDD39.MaxLength = 0x29;
            textBoxDD40.MaxLength = 0x20;
        }
    }
}
