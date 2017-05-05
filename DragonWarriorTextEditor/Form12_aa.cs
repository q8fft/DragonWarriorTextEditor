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
    public partial class Form12_aa : Form
    {

        string path = "";

        public Form12_aa()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x23, textBoxAA1,  0x9301, 0); //<I゜m too busy.~Ask the other guard>
                backend.updateROMText(absoluteFilename, 0x3C, textBoxAA2,  0x9325, 0); //<I suggest making a map if thy path leads into the darkness>
                backend.updateROMText(absoluteFilename, 0x5E, textBoxAA3,  0x9362, 0); //<Once there was a town called Hauksness far to the south,but I do not know if it still exists>
                backend.updateROMText(absoluteFilename, 0x1E, textBoxAA4,  0x93C1, 0); //<I hate people!~Go! Leave me!゜
                backend.updateROMText(absoluteFilename, 0x33, textBoxAA5,  0x93E0, 0); //<They say that Erdrick゜s armor was hidden long ago>
                backend.updateROMText(absoluteFilename, 0x3D, textBoxAA6,  0x9414, 0); //<Many believe that Princess Gwaelin is hidden away in a cave>
                backend.updateROMText(absoluteFilename, 0x3E, textBoxAA7,  0x9452, 0); //<I have heard of one named Nester.~Dost thou know such a one?゜
                backend.updateROMText(absoluteFilename, 0x50, textBoxAA8,  0x9491, 0); //<Garin, a wandering minstrel of legendary fame, is said to have built this town>
                backend.updateROMText(absoluteFilename, 0x35, textBoxAA9,  0x94E2, 0); //<Welcome to Garinham.~May thy stay be a peaceful one>
                backend.updateROMText(absoluteFilename, 0x3F, textBoxAA10, 0x9518, 0); //<It is said that the Princess was kidnapped and taken eastward>
                backend.updateROMText(absoluteFilename, 0x49, textBoxAA11, 0x9558, 0); //<Come buy my radishes! They are fresh and cheap.~Buy thy radishes today!'
                backend.updateROMText(absoluteFilename, 0x69, textBoxAA12, 0x95A2, 0); //<To learn how proof may be obtained that thy ancestor was the great Erdrick, see a man in this very town>
                backend.updateROMText(absoluteFilename, 0x33, textBoxAA13, 0x960C, 0); //<ﾟTis said that Erdrick゜s sword could cleave steel>
                backend.updateROMText(absoluteFilename, 0x25, textBoxAA14, 0x9640, 0); //<Welcome to Cantlin, the castle town>
                backend.updateROMText(absoluteFilename, 0x22, textBoxAA15, 0x9666, 0); //<What shall I get for thy dinner?'
                backend.updateROMText(absoluteFilename, 0x10, textBoxAA16, 0x9689, 0); //<I know nothing>
                backend.updateROMText(absoluteFilename, 0x31, textBoxAA17, 0x969A, 0); //<I゜m Nester.~Hey, where am I? No, don゜t tell me!'
                backend.updateROMText(absoluteFilename, 0x7A, textBoxAA18, 0x96CC, 0); //<Grandfather used to say that his friend, Wynn, had buried something of great value at the foot of a tree behind his shop>
                backend.updateROMText(absoluteFilename, 0x30, textBoxAA19, 0x9747, 0); //<It is said that many have held Erdrick゜s armor>
                backend.updateROMText(absoluteFilename, 0x2D, textBoxAA20, 0x9779, 0); //<The last to have it was a fellow named Wynn>
                backend.updateROMText(absoluteFilename, 0x43, textBoxAA21, 0x97A7, 0); //<My Grandfather Wynn once had a shop on the east side of Hauksness>
                backend.updateROMText(absoluteFilename, 0xA,  textBoxAA22, 0x97EB, 0); //<Welcome!'
                backend.updateROMText(absoluteFilename, 0x37, textBoxAA23, 0x97F6, 0); //<Who art thou?~Leave at once or I will call my friends>
                backend.updateROMText(absoluteFilename, 0x32, textBoxAA24, 0x982E, 0); //<I am Orwick, and I am waiting for my girl friend>
                backend.updateROMText(absoluteFilename, 0x33, textBoxAA25, 0x9861, 0); //<The scales of the Dragonlord are as hard as steel>
                backend.updateROMText(absoluteFilename, 0x40, textBoxAA26, 0x9895, 0); //<Over the western part of this island Erdrick created a rainbow>
                backend.updateROMText(absoluteFilename, 0x62, textBoxAA27, 0x98D7, 0); //<ﾟTis also said that he entered the darkness from a hidden entrance in the room of the Dragonlord>
                backend.updateROMText(absoluteFilename, 0x5B, textBoxAA28, 0x993A, 0); //<Thou shalt find the Stones of Sunlight in Tantegel Castle,~if thou has not found them yet>
                backend.updateROMText(absoluteFilename, 0x21, textBoxAA29, 0x9996, 0); //<Welcome to the town of Rimuldar>
                backend.updateROMText(absoluteFilename, 0x32, textBoxAA30, 0x99B8, 0); //<No, I have no tomatoes.~I have no tomatoes today>
                backend.updateROMText(absoluteFilename, 0x2F, textBoxAA31, 0x99EB, 0); //<You are ь?~It has been long since last we met>
                backend.updateROMText(absoluteFilename, 0x58, textBoxAA32, 0x9A1B, 0); //<Good day,I am Howard. Four steps south of the bath in Kol thou shalt find a magic item>
                backend.updateROMText(absoluteFilename, 0x23, textBoxAA33, 0x9A74, 0); //<Before long the enemy will arrive>
                backend.updateROMText(absoluteFilename, 0x59, textBoxAA34, 0x9A98, 0); //<Heed my warning! Travel not to the south for there the monsters are fierce and terrible>
                backend.updateROMText(absoluteFilename, 0x50, textBoxAA35, 0x9AF2, 0); //<In this world is there any sword that can pierce the scales of the Dragonlord?'
                backend.updateROMText(absoluteFilename, 0x24, textBoxAA36, 0x9B43, 0); //<Orwick is late again. I゜m starving>
                backend.updateROMText(absoluteFilename, 0x3D, textBoxAA37, 0x9B68, 0); //<Many have been the warriors who have perished on this quest>
                backend.updateROMText(absoluteFilename, 0x20, textBoxAA38, 0x9BA7, 0); //<But for thee I wish success, ь>
                backend.updateROMText(absoluteFilename, 0x1D, textBoxAA39, 0x9BC8, 0); //<Hast thou found the flute?'~
                backend.updateROMText(absoluteFilename, 0x29, textBoxAA40, 0x9BE6, 0); //<Hast thou been to the southern island?'~

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

                backend.getText(path, textBoxAA1,  0x23, 0x9301, 0);
                backend.getText(path, textBoxAA2,  0x3C, 0x9325, 0);
                backend.getText(path, textBoxAA3,  0x5E, 0x9362, 0);
                backend.getText(path, textBoxAA4,  0x1E, 0x93C1, 0);
                backend.getText(path, textBoxAA5,  0x33, 0x93E0, 0);
                backend.getText(path, textBoxAA6,  0x3D, 0x9414, 0);
                backend.getText(path, textBoxAA7,  0x3E, 0x9452, 0);
                backend.getText(path, textBoxAA8,  0x50, 0x9491, 0);
                backend.getText(path, textBoxAA9,  0x35, 0x94E2, 0);
                backend.getText(path, textBoxAA10, 0x3F, 0x9518, 0);
                backend.getText(path, textBoxAA11, 0x49, 0x9558, 0);
                backend.getText(path, textBoxAA12, 0x69, 0x95A2, 0);
                backend.getText(path, textBoxAA13, 0x33, 0x960C, 0);
                backend.getText(path, textBoxAA14, 0x25, 0x9640, 0);
                backend.getText(path, textBoxAA15, 0x22, 0x9666, 0);
                backend.getText(path, textBoxAA16, 0x10, 0x9689, 0);
                backend.getText(path, textBoxAA17, 0x31, 0x969A, 0);
                backend.getText(path, textBoxAA18, 0x7A, 0x96CC, 0);
                backend.getText(path, textBoxAA19, 0x30, 0x9747, 0);
                backend.getText(path, textBoxAA20, 0x2D, 0x9779, 0);
                backend.getText(path, textBoxAA21, 0x43, 0x97A7, 0);
                backend.getText(path, textBoxAA22, 0xA,  0x97EB, 0);
                backend.getText(path, textBoxAA23, 0x37, 0x97F6, 0);
                backend.getText(path, textBoxAA24, 0x32, 0x982E, 0);
                backend.getText(path, textBoxAA25, 0x33, 0x9861, 0);
                backend.getText(path, textBoxAA26, 0x40, 0x9895, 0);
                backend.getText(path, textBoxAA27, 0x62, 0x98D7, 0);
                backend.getText(path, textBoxAA28, 0x5B, 0x993A, 0);
                backend.getText(path, textBoxAA29, 0x21, 0x9996, 0);
                backend.getText(path, textBoxAA30, 0x32, 0x99B8, 0);
                backend.getText(path, textBoxAA31, 0x2F, 0x99EB, 0);
                backend.getText(path, textBoxAA32, 0x58, 0x9A1B, 0);
                backend.getText(path, textBoxAA33, 0x23, 0x9A74, 0);
                backend.getText(path, textBoxAA34, 0x59, 0x9A98, 0);
                backend.getText(path, textBoxAA35, 0x50, 0x9AF2, 0);
                backend.getText(path, textBoxAA36, 0x24, 0x9B43, 0);
                backend.getText(path, textBoxAA37, 0x3D, 0x9B68, 0);
                backend.getText(path, textBoxAA38, 0x20, 0x9BA7, 0);
                backend.getText(path, textBoxAA39, 0x1D, 0x9BC8, 0);
                backend.getText(path, textBoxAA40, 0x29, 0x9BE6, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxAA1.MaxLength =  0x23;
            textBoxAA2.MaxLength =  0x3C;
            textBoxAA3.MaxLength =  0x5E;
            textBoxAA4.MaxLength =  0x1E;
            textBoxAA5.MaxLength =  0x33;
            textBoxAA6.MaxLength =  0x3D;
            textBoxAA7.MaxLength =  0x3E;
            textBoxAA8.MaxLength =  0x50;
            textBoxAA9.MaxLength =  0x35;
            textBoxAA10.MaxLength = 0x3F;
            textBoxAA11.MaxLength = 0x49;
            textBoxAA12.MaxLength = 0x69;
            textBoxAA13.MaxLength = 0x33;
            textBoxAA14.MaxLength = 0x25;
            textBoxAA15.MaxLength = 0x22;
            textBoxAA16.MaxLength = 0x10;
            textBoxAA17.MaxLength = 0x31;
            textBoxAA18.MaxLength = 0x7A;
            textBoxAA19.MaxLength = 0x30;
            textBoxAA20.MaxLength = 0x2D;
            textBoxAA21.MaxLength = 0x43;
            textBoxAA22.MaxLength = 0xA;
            textBoxAA23.MaxLength = 0x37;
            textBoxAA24.MaxLength = 0x32;
            textBoxAA25.MaxLength = 0x33;
            textBoxAA26.MaxLength = 0x40;
            textBoxAA27.MaxLength = 0x62;
            textBoxAA28.MaxLength = 0x5B;
            textBoxAA29.MaxLength = 0x21;
            textBoxAA30.MaxLength = 0x32;
            textBoxAA31.MaxLength = 0x2F;
            textBoxAA32.MaxLength = 0x58;
            textBoxAA33.MaxLength = 0x23;
            textBoxAA34.MaxLength = 0x59;
            textBoxAA35.MaxLength = 0x50;
            textBoxAA36.MaxLength = 0x24;
            textBoxAA37.MaxLength = 0x3D;
            textBoxAA38.MaxLength = 0x20;
            textBoxAA39.MaxLength = 0x1D;
            textBoxAA40.MaxLength = 0x29;
        }
    }
}
