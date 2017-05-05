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
    public partial class Form10_rr : Form
    {

        string path = "";

        public Form10_rr()
        {
            InitializeComponent();
        }

        private void buttonUpdateText_Click(object sender, EventArgs e)
        {
            try
            {
                string absoluteFilename = path;
                Backend backend = new Backend();

                backend.updateROMText(absoluteFilename, 0x1D, textBoxRR1,  0x8529, 0); //<Thou cannot hold more Herbs>
                backend.updateROMText(absoluteFilename, 0x1B, textBoxRR2,  0x8548, 0); //<Thou cannot carry anymore>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxRR3,  0x8565, 0); //<Thou hast not enough money>
                backend.updateROMText(absoluteFilename, 0x1C, textBoxRR4,  0x8583, 0); //<The ϊ?~Thank you very much>
                backend.updateROMText(absoluteFilename, 0x17, textBoxRR5,  0x85A1, 0); //<What dost thou want?'~
                backend.updateROMText(absoluteFilename, 0x35, textBoxRR6,  0x85B9, 0); //<Welcome.~We deal in tools.~What can I do for thee?'~
                backend.updateROMText(absoluteFilename, 0x19, textBoxRR7,  0x85EF, 0); //<Oh, yes?~That゜s too bad>
                backend.updateROMText(absoluteFilename, 0x12, textBoxRR8,  0x860A, 0); //<Is that Okay.?'~¢
                backend.updateROMText(absoluteFilename, 0x46, textBoxRR9,  0x861D, 0); //<We deal in weapons and armor.~Dost thou wish to buy anything today?'~
                backend.updateROMText(absoluteFilename, 0x8,  textBoxRR10, 0x8664, 0); //<The ϊ?'
                backend.updateROMText(absoluteFilename, 0x22, textBoxRR11, 0x866E, 0); //<Then I will buy thy ϊ for Ɠ GOLD>
                backend.updateROMText(absoluteFilename, 0x23, textBoxRR12, 0x8692, 0); //<Sorry.~Thou hast not enough money>
                backend.updateROMText(absoluteFilename, 0x27, textBoxRR13, 0x86B7, 0); //<Dost thou wish to buy anything more?'~
                backend.updateROMText(absoluteFilename, 0x1E, textBoxRR14, 0x86DF, 0); //<What dost thou wish to buy?'~
                backend.updateROMText(absoluteFilename, 0xF,  textBoxRR15, 0x86FE, 0); //<I thank thee>~
                backend.updateROMText(absoluteFilename, 0x14, textBoxRR16, 0x870E, 0); //<Please, come again>
                backend.updateROMText(absoluteFilename, 0x19, textBoxRR17, 0x8723, 0); //ь chanted the spell of Σ.
                backend.updateROMText(absoluteFilename, 0x1B, textBoxRR18, 0x873D, 0); //ь cannot yet use the spell.
                backend.updateROMText(absoluteFilename, 0x12, textBoxRR19, 0x8759, 0); //Thy MP is too low.
                backend.updateROMText(absoluteFilename, 0x15, textBoxRR20, 0x876E, 0); //But nothing happened.
                backend.updateROMText(absoluteFilename, 0x1A, textBoxRR21, 0x8784, 0); //REPEL has lost its effect.
                backend.updateROMText(absoluteFilename, 0x28, textBoxRR22, 0x879F, 0); //A torch can be used only in dark places.
                backend.updateROMText(absoluteFilename, 0x2A, textBoxRR23, 0x87C8, 0); //ь sprinkled the Fairy Water over his body.
                backend.updateROMText(absoluteFilename, 0x24, textBoxRR24, 0x87F3, 0); //The Fairy Water has lost its effect.
                backend.updateROMText(absoluteFilename, 0x2C, textBoxRR25, 0x8818, 0); //The Wings of the Wyvern cannot be used here.
                backend.updateROMText(absoluteFilename, 0x30, textBoxRR26, 0x8845, 0); //ь threw The Wings of the Wyvern up into the sky.
                backend.updateROMText(absoluteFilename, 0x21, textBoxRR27, 0x8876, 0); //ь donned the scale of the dragon.
                backend.updateROMText(absoluteFilename, 0x31, textBoxRR28, 0x8898, 0); //Thou art already wearing the scale of the dragon.
                backend.updateROMText(absoluteFilename, 0x1A, textBoxRR29, 0x88CA, 0); //ь blew the Fairies゜ Flute.
                backend.updateROMText(absoluteFilename, 0x2A, textBoxRR30, 0x88E5, 0); //Nothing of use has yet been given to thee.
                backend.updateROMText(absoluteFilename, 0x1C, textBoxRR31, 0x8910, 0); //ь put on the Fighter゜s Ring.
                backend.updateROMText(absoluteFilename, 0x2E, textBoxRR32, 0x892D, 0); //ь adjusted the position of the Fighter゜s Ring.
                backend.updateROMText(absoluteFilename, 0x15, textBoxRR33, 0x895C, 0); //ь held the ϊ tightly.
                backend.updateROMText(absoluteFilename, 0x24, textBoxRR34, 0x8972, 0); //ь played a sweet melody on the harp.
                backend.updateROMText(absoluteFilename, 0x1F, textBoxRR35, 0x8997, 0); //ь put on the ϊ and was cursed!.
                backend.updateROMText(absoluteFilename, 0x1B, textBoxRR36, 0x89B8, 0); //Thy body is being squeezed.
                backend.updateROMText(absoluteFilename, 0x1C, textBoxRR37, 0x89D4, 0); //The ϊ is squeezing thy body.
                backend.updateROMText(absoluteFilename, 0x15, textBoxRR38, 0x89F1, 0); //<Cursed one,be gone!'
                backend.updateROMText(absoluteFilename, 0x44, textBoxRR39, 0x8A07, 0); //<I am looking for the castle cellar.~I heard it is not easily found>
                backend.updateROMText(absoluteFilename, 0x25, textBoxRR40, 0x8A4C, 0); //<Thou must have a key to open a door>

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

                backend.getText(path, textBoxRR1,  0x1D, 0x8529, 0);
                backend.getText(path, textBoxRR2,  0x1B, 0x8548, 0);
                backend.getText(path, textBoxRR3,  0x1C, 0x8565, 0);
                backend.getText(path, textBoxRR4,  0x1C, 0x8583, 0);
                backend.getText(path, textBoxRR5,  0x17, 0x85A1, 0);
                backend.getText(path, textBoxRR6,  0x35, 0x85B9, 0);
                backend.getText(path, textBoxRR7,  0x19, 0x85EF, 0);
                backend.getText(path, textBoxRR8,  0x12, 0x860A, 0);
                backend.getText(path, textBoxRR9,  0x46, 0x861D, 0);
                backend.getText(path, textBoxRR10, 0x8,  0x8664, 0);
                backend.getText(path, textBoxRR11, 0x22, 0x866E, 0);
                backend.getText(path, textBoxRR12, 0x23, 0x8692, 0);
                backend.getText(path, textBoxRR13, 0x27, 0x86B7, 0);
                backend.getText(path, textBoxRR14, 0x1E, 0x86DF, 0);
                backend.getText(path, textBoxRR15, 0xF,  0x86FE, 0);
                backend.getText(path, textBoxRR16, 0x14, 0x870E, 0);
                backend.getText(path, textBoxRR17, 0x19, 0x8723, 0);
                backend.getText(path, textBoxRR18, 0x1B, 0x873D, 0);
                backend.getText(path, textBoxRR19, 0x12, 0x8759, 0);
                backend.getText(path, textBoxRR20, 0x15, 0x876E, 0);
                backend.getText(path, textBoxRR21, 0x1A, 0x8784, 0);
                backend.getText(path, textBoxRR22, 0x28, 0x879F, 0);
                backend.getText(path, textBoxRR23, 0x2A, 0x87C8, 0);
                backend.getText(path, textBoxRR24, 0x24, 0x87F3, 0);
                backend.getText(path, textBoxRR25, 0x2C, 0x8818, 0);
                backend.getText(path, textBoxRR26, 0x30, 0x8845, 0);
                backend.getText(path, textBoxRR27, 0x21, 0x8876, 0);
                backend.getText(path, textBoxRR28, 0x31, 0x8898, 0);
                backend.getText(path, textBoxRR29, 0x1A, 0x88CA, 0);
                backend.getText(path, textBoxRR30, 0x2A, 0x88E5, 0);
                backend.getText(path, textBoxRR31, 0x1C, 0x8910, 0);
                backend.getText(path, textBoxRR32, 0x2E, 0x892D, 0);
                backend.getText(path, textBoxRR33, 0x15, 0x895C, 0);
                backend.getText(path, textBoxRR34, 0x24, 0x8972, 0);
                backend.getText(path, textBoxRR35, 0x1F, 0x8997, 0);
                backend.getText(path, textBoxRR36, 0x1B, 0x89B8, 0);
                backend.getText(path, textBoxRR37, 0x1C, 0x89D4, 0);
                backend.getText(path, textBoxRR38, 0x15, 0x89F1, 0);
                backend.getText(path, textBoxRR39, 0x44, 0x8A07, 0);
                backend.getText(path, textBoxRR40, 0x25, 0x8A4C, 0);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void setMaxLengthOfTextBoxes()
        {
            textBoxRR1.MaxLength =  0x1D;
            textBoxRR2.MaxLength =  0x1B;
            textBoxRR3.MaxLength =  0x1C;
            textBoxRR4.MaxLength =  0x1C;
            textBoxRR5.MaxLength =  0x17;
            textBoxRR6.MaxLength =  0x35;
            textBoxRR7.MaxLength =  0x19;
            textBoxRR8.MaxLength =  0x12;
            textBoxRR9.MaxLength =  0x46;
            textBoxRR10.MaxLength = 0x8;
            textBoxRR11.MaxLength = 0x22;
            textBoxRR12.MaxLength = 0x23;
            textBoxRR13.MaxLength = 0x27;
            textBoxRR14.MaxLength = 0x1E;
            textBoxRR15.MaxLength = 0xF;
            textBoxRR16.MaxLength = 0x14;
            textBoxRR17.MaxLength = 0x19;
            textBoxRR18.MaxLength = 0x1B;
            textBoxRR19.MaxLength = 0x12;
            textBoxRR20.MaxLength = 0x15;
            textBoxRR21.MaxLength = 0x1A;
            textBoxRR22.MaxLength = 0x28;
            textBoxRR23.MaxLength = 0x2A;
            textBoxRR24.MaxLength = 0x24;
            textBoxRR25.MaxLength = 0x2C;
            textBoxRR26.MaxLength = 0x30;
            textBoxRR27.MaxLength = 0x21;
            textBoxRR28.MaxLength = 0x31;
            textBoxRR29.MaxLength = 0x1A;
            textBoxRR30.MaxLength = 0x2A;
            textBoxRR31.MaxLength = 0x1C;
            textBoxRR32.MaxLength = 0x2E;
            textBoxRR33.MaxLength = 0x15;
            textBoxRR34.MaxLength = 0x24;
            textBoxRR35.MaxLength = 0x1F;
            textBoxRR36.MaxLength = 0x1B;
            textBoxRR37.MaxLength = 0x1C;
            textBoxRR38.MaxLength = 0x15;
            textBoxRR39.MaxLength = 0x44;
            textBoxRR40.MaxLength = 0x25;
        }
    }
}
