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
    public partial class Form17_gg : Form
    {

        string path = "";

        public Form17_gg()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x10, textBoxGG1,  0xB756, 0); //<Leave at once!'
                backend.updateROMText(absoluteFilename, 0x4, textBoxGG2,  0xB767, 0); //<$$'
                backend.updateROMText(absoluteFilename, 0xA, textBoxGG3,  0xB76C, 0); //<Really?'~
                backend.updateROMText(absoluteFilename, 0x40, textBoxGG4,  0xB777, 0); //<I am glad thou hast returned.~All our hopes are riding on thee>
                backend.updateROMText(absoluteFilename, 0x2B, textBoxGG5,  0xB7B9, 0); //<See me again when thy level has increased>
                backend.updateROMText(absoluteFilename, 0x26, textBoxGG6,  0xB7E6, 0); //The Dragonlord revealed his true self!
                backend.updateROMText(absoluteFilename, 0x22, textBoxGG7,  0xB80E, 0); //Thou hast found the Ball of Light.
                backend.updateROMText(absoluteFilename, 0x47, textBoxGG8,  0xB832, 0); //Radiance streams forth as thy hands touch the object and hold it aloft.
                backend.updateROMText(absoluteFilename, 0x5C, textBoxGG9,  0xB87B, 0); //Across the land spreads the brilliance until all shadows are banished and peace is restored.
                backend.updateROMText(absoluteFilename, 0x1E, textBoxGG10, 0xB8D8, 0); //<The legends have proven true>
                backend.updateROMText(absoluteFilename, 0x28, textBoxGG11, 0xB8F8, 0); //<Thou art indeed of the line of Erdrick>
                backend.updateROMText(absoluteFilename, 0x28, textBoxGG12, 0xB922, 0); //<It is thy right to rule over this land>
                backend.updateROMText(absoluteFilename, 0x1A, textBoxGG13, 0xB94C, 0); //<Will thou take my place?'
                backend.updateROMText(absoluteFilename, 0x25, textBoxGG14, 0xB968, 0); //ь thought carefully before answering.
                backend.updateROMText(absoluteFilename, 0x12, textBoxGG15, 0xB98F, 0); //I cannot,'~said ь.
                backend.updateROMText(absoluteFilename, 0x46, textBoxGG16, 0xB9A4, 0); //<If ever I am to rule a country, it must be a land that I myself find>
                backend.updateROMText(absoluteFilename, 0x1D, textBoxGG17, 0xB9EC, 0); //Gwaelin said:~<Please, wait>~
                backend.updateROMText(absoluteFilename, 0x27, textBoxGG18, 0xBA0A, 0); //<I wish to go with thee on thy journey>
                backend.updateROMText(absoluteFilename, 0x21, textBoxGG19, 0xBA33, 0); //<May I travel as thy companion?'~
                backend.updateROMText(absoluteFilename, 0x1F, textBoxGG20, 0xBA55, 0); //<Hurrah!~Hurrah!~Long live ь!'~
                backend.updateROMText(absoluteFilename, 0x23, textBoxGG21, 0xBA75, 0); //<Thou hast brought us peace, again>
                backend.updateROMText(absoluteFilename, 0x1D, textBoxGG22, 0xBA99, 0); //<Come now, King Lorik awaits>
                backend.updateROMText(absoluteFilename, 0x45,  textBoxGG23, 0xBAC5, 0); //And thus the tale comes to an end$$~unless the dragons return again.~
                backend.updateROMText(absoluteFilename, 0x41, textBoxGG24, 0xBB11, 0); //<Will thou tell me now of thy deeds so they won゜t be forgotten?'~
                backend.updateROMText(absoluteFilename, 0x3F, textBoxGG25, 0xBB53, 0); //<Thy deeds have been recorded on the Imperial Scrolls of Honor>
                backend.updateROMText(absoluteFilename, 0x28, textBoxGG26, 0xBB94, 0); //<Dost thou wish to continue thy quest?'~
                backend.updateROMText(absoluteFilename, 0x16,  textBoxGG27, 0xBBBD, 0); //<Rest then for awhile>
                backend.updateROMText(absoluteFilename, 0x7, textBoxGG28, 0xBBD5, 0); //<Go ь!'
                backend.updateROMText(absoluteFilename, 0x37,  textBoxGG29, 0xBBDD, 0); //Please push RESET, hold it in, then turn off the POWER.
                backend.updateROMText(absoluteFilename, 0x61, textBoxGG30, 0xBC16, 0); //If you turn the power off first, the Imperial Scroll of Honor containing your deeds may be lost.~
                backend.updateROMText(absoluteFilename, 0x42, textBoxGG31, 0xBC7C, 0); //Unfortunately, NO deeds were recorded on Imperial Scroll number Ɠ.
          /*      backend.updateROMText(absoluteFilename, 0x25, textBoxGG32, 0xB614, 0); //
                backend.updateROMText(absoluteFilename, 0x21, textBoxGG33, 0xB63B, 0); //
                backend.updateROMText(absoluteFilename, 0x19, textBoxGG34, 0xB65E, 0); //
                backend.updateROMText(absoluteFilename, 0x22, textBoxGG35, 0xB678, 0); //
                backend.updateROMText(absoluteFilename, 0x20, textBoxGG36, 0xB69C, 0); //
                backend.updateROMText(absoluteFilename, 0x22, textBoxGG37, 0xB6BE, 0); //
                backend.updateROMText(absoluteFilename, 0x3D, textBoxGG38, 0xB6E1, 0); //
                backend.updateROMText(absoluteFilename, 0xD,  textBoxGG39, 0xB720, 0); //
                backend.updateROMText(absoluteFilename, 0x26, textBoxGG40, 0xB72E, 0); //*/

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

                backend.getText(path, textBoxGG1,  0x10,  0xB756, 0);
                backend.getText(path, textBoxGG2,  0x4,  0xB767, 0);
                backend.getText(path, textBoxGG3,  0xA,  0xB76C, 0);
                backend.getText(path, textBoxGG4,  0x40,  0xB777, 0);
                backend.getText(path, textBoxGG5,  0x2B,  0xB7B9, 0);
                backend.getText(path, textBoxGG6,  0x26,  0xB7E6, 0);
                backend.getText(path, textBoxGG7,  0x22,  0xB80E, 0);
                backend.getText(path, textBoxGG8,  0x47,  0xB832, 0);
                backend.getText(path, textBoxGG9,  0x5C,  0xB87B, 0);
                backend.getText(path, textBoxGG10, 0x1E, 0xB8D8, 0);
                backend.getText(path, textBoxGG11, 0x28, 0xB8F8, 0);
                backend.getText(path, textBoxGG12, 0x28, 0xB922, 0);
                backend.getText(path, textBoxGG13, 0x1A, 0xB94C, 0);
                backend.getText(path, textBoxGG14, 0x25, 0xB968, 0);
                backend.getText(path, textBoxGG15, 0x12, 0xB98F, 0);
                backend.getText(path, textBoxGG16, 0x46, 0xB9A4, 0);
                backend.getText(path, textBoxGG17, 0x1D, 0xB9EC, 0);
                backend.getText(path, textBoxGG18, 0x27, 0xBA0A, 0);
                backend.getText(path, textBoxGG19, 0x21, 0xBA33, 0);
                backend.getText(path, textBoxGG20, 0x1F, 0xBA55, 0);
                backend.getText(path, textBoxGG21, 0x23, 0xBA75, 0);
                backend.getText(path, textBoxGG22, 0x1D, 0xBA99, 0);
                backend.getText(path, textBoxGG23, 0x45,  0xBAC5, 0);
                backend.getText(path, textBoxGG24, 0x41, 0xBB11, 0);
                backend.getText(path, textBoxGG25, 0x3F, 0xBB53, 0);
                backend.getText(path, textBoxGG26, 0x28, 0xBB94, 0);
                backend.getText(path, textBoxGG27, 0x16,  0xBBBD, 0);
                backend.getText(path, textBoxGG28, 0x7, 0xBBD5, 0);
                backend.getText(path, textBoxGG29, 0x37,  0xBBDD, 0);
                backend.getText(path, textBoxGG30, 0x61, 0xBC16, 0);
                backend.getText(path, textBoxGG31, 0x42, 0xBC7C, 0);
              /*  backend.getText(path, textBoxGG32, 0x25, 0xB614, 0);
                backend.getText(path, textBoxGG33, 0x21, 0xB63B, 0);
                backend.getText(path, textBoxGG34, 0x19, 0xB65E, 0);
                backend.getText(path, textBoxGG35, 0x22, 0xB678, 0);
                backend.getText(path, textBoxGG36, 0x20, 0xB69C, 0);
                backend.getText(path, textBoxGG37, 0x22, 0xB6BE, 0);
                backend.getText(path, textBoxGG38, 0x3D, 0xB6E1, 0);
                backend.getText(path, textBoxGG39, 0xD, 0xB720, 0);
                backend.getText(path, textBoxGG40, 0x26, 0xB72E, 0);*/

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxGG1.MaxLength =  0x10;
            textBoxGG2.MaxLength =  0x4;
            textBoxGG3.MaxLength =  0xA;
            textBoxGG4.MaxLength =  0x40;
            textBoxGG5.MaxLength =  0x2B;
            textBoxGG6.MaxLength =  0x26;
            textBoxGG7.MaxLength =  0x22;
            textBoxGG8.MaxLength =  0x47;
            textBoxGG9.MaxLength =  0x5C;
            textBoxGG10.MaxLength = 0x1E;
            textBoxGG11.MaxLength = 0x28;
            textBoxGG12.MaxLength = 0x28;
            textBoxGG13.MaxLength = 0x1A;
            textBoxGG14.MaxLength = 0x25;
            textBoxGG15.MaxLength = 0x12;
            textBoxGG16.MaxLength = 0x46;
            textBoxGG17.MaxLength = 0x1D;
            textBoxGG18.MaxLength = 0x27;
            textBoxGG19.MaxLength = 0x21;
            textBoxGG20.MaxLength = 0x1F;
            textBoxGG21.MaxLength = 0x23;
            textBoxGG22.MaxLength = 0x1D;
            textBoxGG23.MaxLength = 0x45;
            textBoxGG24.MaxLength = 0x41;
            textBoxGG25.MaxLength = 0x3F;
            textBoxGG26.MaxLength = 0x28;
            textBoxGG27.MaxLength = 0x16;
            textBoxGG28.MaxLength = 0x7;
            textBoxGG29.MaxLength = 0x37;
            textBoxGG30.MaxLength = 0x61;
            textBoxGG31.MaxLength = 0x42;
         /*   textBoxGG32.MaxLength = 0x25;
            textBoxGG33.MaxLength = 0x21;
            textBoxGG34.MaxLength = 0x19;
            textBoxGG35.MaxLength = 0x22;
            textBoxGG36.MaxLength = 0x20;
            textBoxGG37.MaxLength = 0x22;
            textBoxGG38.MaxLength = 0x3D;
            textBoxGG39.MaxLength = 0xD;
            textBoxGG40.MaxLength = 0x26;*/
        }
    }
}
