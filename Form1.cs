using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace Inventory_Management
{
    public partial class Form1 : Form
    {
        string SearchDetails = "{0, -10} {1, -10} {2, -10} {3, -10}";
        public Form1()
        {
            InitializeComponent();
            /*List<string> itemList = new List<string>();
            itemList.Add("Mac");
            itemList.Add("HP-Envy");
            itemList.Add("Chromebook");
            itemList.Add("Dell-Inspiron");*/
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confrim if you want to exit", "Inventory_Managment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addNewItem_Click(object sender, EventArgs e)
        {
            List<string> itemList = new List<string>();
            itemList.Add("Mac");
            itemList.Add("HP-Envy");
            itemList.Add("Chromebook");
            itemList.Add("Dell-Inspiron");
            itemList.Add("Nitro 5");


            MessageBox.Show("The List has " + itemList.Count + " objects stored in it.");

            for (int index = 0; index < itemList.Count; index++)
            {
                MessageBox.Show(itemList[index]);
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            for (int i = itemsListBox.SelectedIndices.Count - 1; i >= 0; i--)
            {
                MessageBox.Show("Do you want to remove item");
                itemsListBox.Items.RemoveAt(itemsListBox.SelectedIndices[i]);
            }
        }

        

        private void itemsgroupBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outPutBox.Items.Add(String.Format(SearchDetails, "ID", "Name", "Select Date", "Price"));
        }

        public string ReturnValue1 { get; set; }
        public string ReturnValue2 { get; set; }

        private void restockButton_Click(object sender, EventArgs e)
        {
            this.ReturnValue1 = "Mac";
            this.ReturnValue2 = DateTime.Now.ToString(); 
            this.DialogResult = DialogResult.OK;
            this.Close();
            //List<string> itemList = new List<string>();


            /*if (itemList.item)
            {
                itemList.Add("Mac");
                string message = "Do you want to restock item";
                MessageBox.Show(message);
            }
            else if (cbHpEnvy.Checked)
            {
                itemList = new List<string>();
                itemList.Add("HP-Envy");
            }*/

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cbMac.Checked = false;
            cbHpEnvy.Checked = false;
            cbChromeBook.Checked = false;
            cbDellInspiron.Checked = false;

            rbOne.Checked = false;
            rbTwo.Checked = false;
            rbThree.Checked = false;
            rbFour.Checked = false;

            //brandGroupBox.SelectedItem.Clear();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            String ID, Name, SelectDate, Price;

            ID = txtCustomerID.Text;
            Name = txtName.Text;
            SelectDate = dateTimePicker1.Text;

            if(brandGroupBox.Text == "")
            {
                MessageBox.Show("You must select a brands", "Brand", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if((cbMac.Checked == false) && (cbHpEnvy.Checked == false) && (cbChromeBook.Checked == false) && (cbDellInspiron.Checked == false) && (cbNitro5.Checked == false))
            {
                MessageBox.Show("You must select an item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if((rbOne.Checked == false) && (rbTwo.Checked == false) && (rbThree.Checked == false) && (rbFour.Checked))
            {
                MessageBox.Show("You must select quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
