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
    public partial class Form15_ee : Form
    {

        string path = "";

        public Form15_ee()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x18, textBoxEE1,  0xAA9F, 0); //But there found nothing.
                backend.updateROMText(absoluteFilename, 0x18, textBoxEE2,  0xAAB8, 0); //There is a treasure box.
                backend.updateROMText(absoluteFilename, 0x12, textBoxEE3,  0xAAD1, 0); //ь discovers the ϊ.
                backend.updateROMText(absoluteFilename, 0x2D, textBoxEE4,  0xAAE4, 0); //Feel the wind blowing from behind the throne.
                backend.updateROMText(absoluteFilename, 0x21, textBoxEE5,  0xAB12, 0); //There is nothing to take here, ь.
                backend.updateROMText(absoluteFilename, 0x1A, textBoxEE6,  0xAB34, 0); //Of GOLD thou hast gained Ɠ
                backend.updateROMText(absoluteFilename, 0x33, textBoxEE7,  0xAB4F, 0); //Fortune smiles upon thee, ь.~Thou hast found the ϊ.
                backend.updateROMText(absoluteFilename, 0x1B, textBoxEE8,  0xAB83, 0); //Unfortunately, it is empty.
                backend.updateROMText(absoluteFilename, 0x7B, textBoxEE9,  0xAB9F, 0); //Heed my voice,~<ь, for this is Gwaelin.~To reach the next level thou must raise thy Experienceϋ × by Ɠ.~My hope is with thee>
                backend.updateROMText(absoluteFilename, 0x29, textBoxEE10, 0xAC1C, 0); //<From where thou art now, my castle lies$
                backend.updateROMText(absoluteFilename, 0x13, textBoxEE11, 0xAC48, 0); //Ɠ to the north and$
                backend.updateROMText(absoluteFilename, 0x13, textBoxEE12, 0xAC5D, 0); //Ɠ to the south and$
                backend.updateROMText(absoluteFilename, 0xE, textBoxEE13, 0xAC72, 0); //Ɠ to the east>
                backend.updateROMText(absoluteFilename, 0xE, textBoxEE14, 0xAC83, 0); //Ɠ to the west>
                backend.updateROMText(absoluteFilename, 0xE, textBoxEE15, 0xAC93, 0); //Aш draws near!
                backend.updateROMText(absoluteFilename, 0x16, textBoxEE16, 0xACA4, 0); //The ё is running away.
                backend.updateROMText(absoluteFilename, 0x22, textBoxEE17, 0xACBD, 0); //The ё attacked before ь was ready.
                backend.updateROMText(absoluteFilename, 0xA, textBoxEE18, 0xACE0, 0); //ь attacks!
                backend.updateROMText(absoluteFilename, 0x24, textBoxEE19, 0xACEB, 0); //The ё゜s Hitϋ have been reduced by Ɠ.
                backend.updateROMText(absoluteFilename, 0x36, textBoxEE20, 0xAD10, 0); //The attack failed and there was no loss of Hit Points!
                backend.updateROMText(absoluteFilename, 0x8, textBoxEE21, 0xAD49, 0); //Command?
                backend.updateROMText(absoluteFilename, 0x1E, textBoxEE22, 0xAD52, 0); //That cannot be used in battle.
                backend.updateROMText(absoluteFilename, 0x21, textBoxEE23, 0xAD73, 0); //But that spell hath been blocked.
                backend.updateROMText(absoluteFilename, 0x18, textBoxEE24, 0xAD95, 0); //The spell will not work.
                backend.updateROMText(absoluteFilename, 0x1D, textBoxEE25, 0xADAE, 0); //Thou hast put the ё to sleep.
                backend.updateROMText(absoluteFilename, 0x20, textBoxEE26, 0xADCC, 0); //The ё゜s spell hath been blocked.
                backend.updateROMText(absoluteFilename, 0x28, textBoxEE27, 0xADEF, 0); //Thou hast done well in defeating the ё.~
                backend.updateROMText(absoluteFilename, 0x1E, textBoxEE28, 0xAE19, 0); //Thy Experience~increases by Ɠ.
                backend.updateROMText(absoluteFilename, 0x18, textBoxEE29, 0xAE38, 0); //Thy GOLD~increases by Ɠ.
                backend.updateROMText(absoluteFilename, 0x51, textBoxEE30, 0xAE54, 0); //Courage and wit have served thee well.~Thou hast been promoted to the next level.
                backend.updateROMText(absoluteFilename, 0x1E, textBoxEE31, 0xAEA9, 0); //Thou hast learned a new spell.
                backend.updateROMText(absoluteFilename, 0x35, textBoxEE32, 0xAEC8, 0); //Quietly Golem closes his eyes and settles into sleep.
                backend.updateROMText(absoluteFilename, 0xE, textBoxEE33, 0xAEFE, 0); //ё looks happy.
                backend.updateROMText(absoluteFilename, 0x16, textBoxEE34, 0xAF0F, 0); //ь started to run away.
                backend.updateROMText(absoluteFilename, 0x19, textBoxEE35, 0xAF26, 0); //But was blocked in front.
                backend.updateROMText(absoluteFilename, 0x10, textBoxEE36, 0xAF40, 0); //ь used the Herb.
                backend.updateROMText(absoluteFilename, 0x10, textBoxEE37, 0xAF53, 0); //The ё is asleep.
                backend.updateROMText(absoluteFilename, 0xE, textBoxEE38, 0xAF66, 0); //The ё attacks!
                backend.updateROMText(absoluteFilename, 0x18, textBoxEE39, 0xAF75, 0); //Thy Hitś decreased by Ɠ.
                backend.updateROMText(absoluteFilename, 0x28, textBoxEE40, 0xAF8E, 0); //A miss! No damage hath been scored!

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

                backend.getText(path, textBoxEE1,  0x18, 0xAA9F, 0);
                backend.getText(path, textBoxEE2,  0x18, 0xAAB8, 0);
                backend.getText(path, textBoxEE3,  0x12, 0xAAD1, 0);
                backend.getText(path, textBoxEE4,  0x2D,  0xAAE4, 0);
                backend.getText(path, textBoxEE5,  0x21, 0xAB12, 0);
                backend.getText(path, textBoxEE6,  0x1A, 0xAB34, 0);
                backend.getText(path, textBoxEE7,  0x33, 0xAB4F, 0);
                backend.getText(path, textBoxEE8,  0x1B,  0xAB83, 0);
                backend.getText(path, textBoxEE9,  0x7B, 0xAB9F, 0);
                backend.getText(path, textBoxEE10, 0x29,  0xAC1C, 0);
                backend.getText(path, textBoxEE11, 0x13, 0xAC48, 0);
                backend.getText(path, textBoxEE12, 0x13, 0xAC5D, 0);
                backend.getText(path, textBoxEE13, 0xE, 0xAC72, 0);
                backend.getText(path, textBoxEE14, 0xE, 0xAC83, 0);
                backend.getText(path, textBoxEE15, 0xE, 0xAC93, 0);
                backend.getText(path, textBoxEE16, 0x16, 0xACA4, 0);
                backend.getText(path, textBoxEE17, 0x22, 0xACBD, 0);
                backend.getText(path, textBoxEE18, 0xA,  0xACE0, 0);
                backend.getText(path, textBoxEE19, 0x24, 0xACEB, 0);
                backend.getText(path, textBoxEE20, 0x36, 0xAD10, 0);
                backend.getText(path, textBoxEE21, 0x8, 0xAD49, 0);
                backend.getText(path, textBoxEE22, 0x1E, 0xAD52, 0);
                backend.getText(path, textBoxEE23, 0x21, 0xAD73, 0);
                backend.getText(path, textBoxEE24, 0x18, 0xAD95, 0);
                backend.getText(path, textBoxEE25, 0x1D, 0xADAE, 0);
                backend.getText(path, textBoxEE26, 0x20, 0xADCC, 0);
                backend.getText(path, textBoxEE27, 0x28, 0xADEF, 0);
                backend.getText(path, textBoxEE28, 0x1E, 0xAE19, 0);
                backend.getText(path, textBoxEE29, 0x18, 0xAE38, 0);
                backend.getText(path, textBoxEE30, 0x51, 0xAE54, 0);
                backend.getText(path, textBoxEE31, 0x1E, 0xAEA9, 0);
                backend.getText(path, textBoxEE32, 0x35, 0xAEC8, 0);
                backend.getText(path, textBoxEE33, 0xE, 0xAEFE, 0);
                backend.getText(path, textBoxEE34, 0x16, 0xAF0F, 0);
                backend.getText(path, textBoxEE35, 0x19, 0xAF26, 0);
                backend.getText(path, textBoxEE36, 0x10, 0xAF40, 0);
                backend.getText(path, textBoxEE37, 0x10, 0xAF53, 0);
                backend.getText(path, textBoxEE38, 0xE, 0xAF66, 0);
                backend.getText(path, textBoxEE39, 0x18, 0xAF75, 0);
                backend.getText(path, textBoxEE40, 0x28, 0xAF8E, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxEE1.MaxLength =  0x18;
            textBoxEE2.MaxLength =  0x18;
            textBoxEE3.MaxLength =  0x12;
            textBoxEE4.MaxLength =  0x2D;
            textBoxEE5.MaxLength =  0x21;
            textBoxEE6.MaxLength =  0x1A;
            textBoxEE7.MaxLength =  0x33;
            textBoxEE8.MaxLength =  0x1B;
            textBoxEE9.MaxLength =  0x7B;
            textBoxEE10.MaxLength = 0x29;
            textBoxEE11.MaxLength = 0x13;
            textBoxEE12.MaxLength = 0x13;
            textBoxEE13.MaxLength = 0xE;
            textBoxEE14.MaxLength = 0xE;
            textBoxEE15.MaxLength = 0xE;
            textBoxEE16.MaxLength = 0x16;
            textBoxEE17.MaxLength = 0x22;
            textBoxEE18.MaxLength = 0xA;
            textBoxEE19.MaxLength = 0x24;
            textBoxEE20.MaxLength = 0x36;
            textBoxEE21.MaxLength = 0x8;
            textBoxEE22.MaxLength = 0x1E;
            textBoxEE23.MaxLength = 0x21;
            textBoxEE24.MaxLength = 0x18;
            textBoxEE25.MaxLength = 0x1D;
            textBoxEE26.MaxLength = 0x20;
            textBoxEE27.MaxLength = 0x28;
            textBoxEE28.MaxLength = 0x1E;
            textBoxEE29.MaxLength = 0x18;
            textBoxEE30.MaxLength = 0x51;
            textBoxEE31.MaxLength = 0x1E;
            textBoxEE32.MaxLength = 0x35;
            textBoxEE33.MaxLength = 0xE;
            textBoxEE34.MaxLength = 0x16;
            textBoxEE35.MaxLength = 0x19;
            textBoxEE36.MaxLength = 0x10;
            textBoxEE37.MaxLength = 0x10;
            textBoxEE38.MaxLength = 0xE;
            textBoxEE39.MaxLength = 0x18;
            textBoxEE40.MaxLength = 0x28;
        }
    }
}
