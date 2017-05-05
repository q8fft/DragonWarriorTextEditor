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
namespace DragonWarriorTextEditor {
    public partial class Form9_rc : Form {

        string path = "";

        public Form9_rc() {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e) {
            try {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x2F,   textBoxRC1,  0xB14E,  0); //<Descendant of Erdrick, listen now to my words>
                backend.updateROMText(absoluteFilename, 0x49,   textBoxRC2,  0xB17F,  0); //<It is told that in ages past Erdrick fought demons with a Ball of Light>
                backend.updateROMText(absoluteFilename, 0x52,   textBoxRC3,  0xB1CA,  0); //<Then came the Dragonlord who stole the precious globe and hid it in the darkness>
                backend.updateROMText(absoluteFilename, 0x53,   textBoxRC4,  0xB21E,  0); //<Now, ь, thou must help us recover the Ball of Light and restore peace to our land>
                backend.updateROMText(absoluteFilename, 0x21,   textBoxRC5,  0xB273,  0); //<The Dragonlord must be defeated>
                backend.updateROMText(absoluteFilename, 0x53,   textBoxRC6,  0xB296,  0); //<Take now whatever thou may find in these Treasure Chests to aid thee in thy quest>
                backend.updateROMText(absoluteFilename, 0x4C,   textBoxRC7,  0xB2EB,  0); //<Then speak with the guards, for they have much knowledge that may aid thee>
                backend.updateROMText(absoluteFilename, 0x22,   textBoxRC8,  0xB339,  0); //<May the light shine upon thee, ь>
                backend.updateROMText(absoluteFilename, 0x10,   textBoxRC9,  0x8038, 0); //ё hath woken up.
                backend.updateROMText(absoluteFilename, 0xE,    textBoxRC10, 0x804B, 0); //Thou art dead.
                backend.updateROMText(absoluteFilename, 0x41,   textBoxRC11, 0x805A, 0); //<Thou art strong enough!~Why can thou not defeat the Dragonlord?'
                backend.updateROMText(absoluteFilename, 0x3B,   textBoxRC12, 0x809D, 0); //<If thou art planning to take a rest, first see King Lorik>
                backend.updateROMText(absoluteFilename, 0x28,   textBoxRC13, 0x80D9, 0); //ь held the Rainbow Drop toward the sky.~
                backend.updateROMText(absoluteFilename, 0x1D,   textBoxRC14, 0x8104, 0); //But no rainbow appeared here.
                backend.updateROMText(absoluteFilename, 0x39,   textBoxRC15, 0x8122, 0); //<Good morning.~Thou hast had a good night゜s sleep I hope>
                backend.updateROMText(absoluteFilename, 0x18,   textBoxRC16, 0x815D, 0); //<I shall see thee again>
                backend.updateROMText(absoluteFilename, 0x35,   textBoxRC17, 0x8176, 0); //<Good morning.~Thou seems to have spent a good night>
                backend.updateROMText(absoluteFilename, 0xD,    textBoxRC18, 0x81AD, 0); //<Good night>~
                backend.updateROMText(absoluteFilename, 0x1A,   textBoxRC19, 0x81BB, 0); //<Okay.~Good-bye, traveler>
                backend.updateROMText(absoluteFilename, 0x5C,   textBoxRC20, 0x81D6, 0); //<Welcome to the traveler゜s Inn.~Room and board is Ɠ GOLD per night.~Dost thou want a room?'~
                backend.updateROMText(absoluteFilename, 0x16,   textBoxRC21, 0x8233, 0); //<All the best to thee>
                backend.updateROMText(absoluteFilename, 0x1A,   textBoxRC22, 0x824A, 0); //<There are no stairs here>
                backend.updateROMText(absoluteFilename, 0x18,   textBoxRC23, 0x8265, 0); //<Thou cannot enter here>
                backend.updateROMText(absoluteFilename, 0x17,   textBoxRC24, 0x827E, 0); //<There is no one there>
                backend.updateROMText(absoluteFilename, 0x30,   textBoxRC25, 0x8296, 0); //<I thank thee.~Won゜t thou buy one more bottle?'~
                backend.updateROMText(absoluteFilename, 0x54,   textBoxRC26, 0x82C7, 0); //<Will thou buy some Fairy Water for 38 GOLD to keep the Dragonlord゜s minions away?'~
                backend.updateROMText(absoluteFilename, 0x17,   textBoxRC27, 0x831C, 0); //<I will see thee later>
                backend.updateROMText(absoluteFilename, 0x1C,   textBoxRC28, 0x8334, 0); //<Thou hast not enough money>
                backend.updateROMText(absoluteFilename, 0x2C,   textBoxRC29, 0x8352, 0); //<I am sorry, but I cannot sell thee anymore>
                backend.updateROMText(absoluteFilename, 0x37,   textBoxRC30, 0x837F, 0); //<Here,take this key.~Dost thou wish to purchase more?'~
                backend.updateROMText(absoluteFilename, 0x54,   textBoxRC31, 0x83B7, 0); //<Magic keys!~They will unlock any door.~Dost thou wish to purchase one for Ɠ GOLD?'~
                backend.updateROMText(absoluteFilename, 0xC,    textBoxRC32, 0x840C, 0); //<I am sorry>
                backend.updateROMText(absoluteFilename, 0x19,   textBoxRC33, 0x841A, 0); //A curse is upon thy body.

                backend.updateROMText(absoluteFilename, 0x1A,   textBoxRC34, 0x8435, 0); //<Thou hast no possessions>
                backend.updateROMText(absoluteFilename, 0x20,   textBoxRC35, 0x8450, 0); //<Wilt thou sell anything else?'~
                backend.updateROMText(absoluteFilename, 0x11,   textBoxRC36, 0x8471, 0); //<I cannot buy it>
                backend.updateROMText(absoluteFilename, 0x43,   textBoxRC37, 0x8483, 0); //<Thou said the ϊ.~I will buy thy ϊ for Ɠ GOLD.~Is that all right?'~
                backend.updateROMText(absoluteFilename, 0x19,   textBoxRC38, 0x84C7, 0); //<What art thou selling?'~
                backend.updateROMText(absoluteFilename, 0x26,   textBoxRC39, 0x84E1, 0); //<I will be waiting for thy next visit>
                backend.updateROMText(absoluteFilename, 0x20,   textBoxRC40, 0x8508, 0); //<Dost thou want anything else?'~

                MessageBox.Show("Updated Text!", "Dragon Warrior Text Editor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string sendPathToOtherForm {
            get {
                return path;
            }
            set {
                path = value;
            }
        }

        private void Form9_rc_Load(object sender, EventArgs e) {
            readRomText();
            setMaxLengthOfTextBoxes();
        }

        private void readRomText() {
            try {
                Backend backend = new Backend();

                backend.getText(path, textBoxRC1,  0x2F, 0xB14E, 0);
                backend.getText(path, textBoxRC2,  0x49, 0xB17F, 0);
                backend.getText(path, textBoxRC3,  0x52, 0xB1CA, 0);
                backend.getText(path, textBoxRC4,  0x53, 0xB21E, 0);
                backend.getText(path, textBoxRC5,  0x21, 0xB273, 0);
                backend.getText(path, textBoxRC6,  0x53, 0xB296, 0);
                backend.getText(path, textBoxRC7,  0x4C, 0xB2EB, 0);
                backend.getText(path, textBoxRC8,  0x22, 0xB339, 0);
                backend.getText(path, textBoxRC9,  0x10, 0x8038, 0);
                backend.getText(path, textBoxRC10, 0xE,  0x804B, 0);
                backend.getText(path, textBoxRC11, 0x41, 0x805A, 0);
                backend.getText(path, textBoxRC12, 0x3B, 0x809D, 0);
                backend.getText(path, textBoxRC13, 0x28, 0x80D9, 0);
                backend.getText(path, textBoxRC14, 0x1D, 0x8104, 0);
                backend.getText(path, textBoxRC15, 0x39, 0x8122, 0);
                backend.getText(path, textBoxRC16, 0x18, 0x815D, 0);
                backend.getText(path, textBoxRC17, 0x35, 0x8176, 0);
                backend.getText(path, textBoxRC18, 0xD,  0x81AD, 0);
                backend.getText(path, textBoxRC19, 0x1A, 0x81BB, 0);
                backend.getText(path, textBoxRC20, 0x5C, 0x81D6, 0);
                backend.getText(path, textBoxRC21, 0x16, 0x8233, 0);
                backend.getText(path, textBoxRC22, 0x1A, 0x824A, 0);
                backend.getText(path, textBoxRC23, 0x18, 0x8265, 0);
                backend.getText(path, textBoxRC24, 0x17, 0x827E, 0);
                backend.getText(path, textBoxRC25, 0x30, 0x8296, 0);
                backend.getText(path, textBoxRC26, 0x54, 0x82C7, 0);
                backend.getText(path, textBoxRC27, 0x17, 0x831C, 0);
                backend.getText(path, textBoxRC28, 0x1C, 0x8334, 0);
                backend.getText(path, textBoxRC29, 0x2C, 0x8352, 0);
                backend.getText(path, textBoxRC30, 0x37, 0x837F, 0);
                backend.getText(path, textBoxRC31, 0x54, 0x83B7, 0);
                backend.getText(path, textBoxRC32, 0xC,  0x840C, 0);
                backend.getText(path, textBoxRC33, 0x19, 0x841A, 0);

                backend.getText(path, textBoxRC34, 0x1A, 0x8435, 0);
                backend.getText(path, textBoxRC35, 0x20, 0x8450, 0);
                backend.getText(path, textBoxRC36, 0x11, 0x8471, 0);
                backend.getText(path, textBoxRC37, 0x43, 0x8483, 0);
                backend.getText(path, textBoxRC38, 0x19, 0x84C7, 0);
                backend.getText(path, textBoxRC39, 0x26, 0x84E1, 0);
                backend.getText(path, textBoxRC40, 0x20, 0x8508, 0);

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes() {
            textBoxRC1.MaxLength =  0x2F;
            textBoxRC2.MaxLength =  0x49;
            textBoxRC3.MaxLength =  0x52;
            textBoxRC4.MaxLength =  0x53;
            textBoxRC5.MaxLength =  0x21;
            textBoxRC6.MaxLength =  0x53;
            textBoxRC7.MaxLength =  0x4C;
            textBoxRC8.MaxLength =  0x22;
            textBoxRC9.MaxLength =  0x10;
            textBoxRC10.MaxLength = 0xE;
            textBoxRC11.MaxLength = 0x41;
            textBoxRC12.MaxLength = 0x3B;
            textBoxRC13.MaxLength = 0x28;
            textBoxRC14.MaxLength = 0x1D;
            textBoxRC15.MaxLength = 0x39;
            textBoxRC16.MaxLength = 0x18;
            textBoxRC17.MaxLength = 0x35;
            textBoxRC18.MaxLength = 0xD;
            textBoxRC19.MaxLength = 0x1A;
            textBoxRC20.MaxLength = 0x5C;
            textBoxRC21.MaxLength = 0x16;
            textBoxRC22.MaxLength = 0x1A;
            textBoxRC23.MaxLength = 0x18;
            textBoxRC24.MaxLength = 0x17;
            textBoxRC25.MaxLength = 0x30;
            textBoxRC26.MaxLength = 0x54;
            textBoxRC27.MaxLength = 0x17;
            textBoxRC28.MaxLength = 0x1C;
            textBoxRC29.MaxLength = 0x2C;
            textBoxRC30.MaxLength = 0x37;
            textBoxRC31.MaxLength = 0x54;
            textBoxRC32.MaxLength = 0xC;
            textBoxRC33.MaxLength = 0x19;

            textBoxRC34.MaxLength = 0x1A;
            textBoxRC35.MaxLength = 0x20;
            textBoxRC36.MaxLength = 0x11;
            textBoxRC37.MaxLength = 0x43;
            textBoxRC38.MaxLength = 0x19;
            textBoxRC39.MaxLength = 0x26;
            textBoxRC40.MaxLength = 0x20;
        }
    }
}
