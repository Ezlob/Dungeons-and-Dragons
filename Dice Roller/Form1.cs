using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice_Roller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            Random rng = new Random();

            int rollNum = rng.Next(1,21);

            //show correct dice roll based on number generated
            switch (rollNum)
            {
                case 1:
                    dice.Image = Properties.Resources.d20_1;
                    break;
                case 2:
                    dice.Image = Properties.Resources.d20_2;
                    break;
                case 3:
                    dice.Image = Properties.Resources.d20_3;
                    break;
                case 4:
                    dice.Image = Properties.Resources.d20_4;
                    break;
                case 5:
                    dice.Image = Properties.Resources.d20_5;
                    break;
                case 6:
                    dice.Image = Properties.Resources.d20_6;
                    break;
                case 7:
                    dice.Image = Properties.Resources.d20_7;
                    break;
                case 8:
                    dice.Image = Properties.Resources.d20_8;
                    break;
                case 9:
                    dice.Image = Properties.Resources.d20_9;
                    break;
                case 10:
                    dice.Image = Properties.Resources.d20_10;
                    break;
                case 11:
                    dice.Image = Properties.Resources.d20_11;
                    break;
                case 12:
                    dice.Image = Properties.Resources.d20_12;
                    break;
                case 13:
                    dice.Image = Properties.Resources.d20_13;
                    break;
                case 14:
                    dice.Image = Properties.Resources.d20_14;
                    break;
                case 15:
                    dice.Image = Properties.Resources.d20_15;
                    break;
                case 16:
                    dice.Image = Properties.Resources.d20_16;
                    break;
                case 17:
                    dice.Image = Properties.Resources.d20_17;
                    break;
                case 18:
                    dice.Image = Properties.Resources.d20_18;
                    break;
                case 19:
                    dice.Image = Properties.Resources.d20_19;
                    break;
                case 20:
                    dice.Image = Properties.Resources.d20_20;
                    break;
                default:
                    dice.Image = Properties.Resources.d20_blank;
                    break;
            }

            int modified;


            //based on dropdown, have modifier added to dice roll
            switch (cmbCheck.SelectedItem.ToString().Trim())
            {
                case "Strength":
                    modified = int.Parse(strengthNum.Text);
                    break;
                case "Athletics":
                    modified = int.Parse(strengthNum.Text);
                    break;
                case "Dexterity":
                    modified = int.Parse(dexterityNum.Text);
                    break;
                case "Acrobatics":
                    modified = int.Parse(dexterityNum.Text);
                    break;
                case "Sleight of Hand":
                    modified = int.Parse(dexterityNum.Text);
                    break;
                case "Stealth":
                    modified = int.Parse(dexterityNum.Text);
                    break;
                case "Constitution":
                    modified = int.Parse(constitutionNum.Text);
                    break;
                case "Intelligence":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "Arcana":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "History":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "Investigation":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "Nature":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "Religion":
                    modified = int.Parse(intelligenceNum.Text);
                    break;
                case "Wisdom":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Animal Handling":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Insight":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Medicine":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Perception":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Survival":
                    modified = int.Parse(wisdomNum.Text);
                    break;
                case "Charisma":
                    modified = int.Parse(charismaNum.Text);
                    break;
                case "Deception":
                    modified = int.Parse(charismaNum.Text);
                    break;
                case "Intimidation":
                    modified = int.Parse(charismaNum.Text);
                    break;
                case "Performance":
                    modified = int.Parse(charismaNum.Text);
                    break;
                case "Persuasion":
                    modified = int.Parse(charismaNum.Text);
                    break;
                default:
                    modified = 0;
                    break;
            }

            modified = (modified - 10) / 2;

            if (proficientCheck.Checked)
            {
                modified += int.Parse(proficiency.Text);
            }

            results.Text = (modified + rollNum).ToString();
        }
    }
}
