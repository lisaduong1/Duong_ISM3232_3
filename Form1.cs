using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
// programmer: Lisa Duong
// project: Duong_3
// due date: 4/12/2020
// description: individual assignment #3
// incomplete
namespace Duong_3
{
    public partial class Form1 : Form
    {
        // constant values of balloons
        double single = 9.95;
        double halfDozen = 35.95;
        double dozen = 65.95;
        double taxRate = .07;
        


        public Form1()
        {

            InitializeComponent();
            // get current date and input to delivery date textbox
            maskedTextBoxDelivery.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
            // output ext. files
            OccasionBox();
            // display birthday as default, list is in abc order
            comboBoxOccasions.SelectedIndex = 1;
            ExtraBox();
            // display default totals
            labelSubtotalAmount.Text = single.ToString("c");
            labelSalesTaxAmount.Text = (single * taxRate).ToString("c");
            labelOrderTotalAmount.Text = (single * taxRate + single).ToString("c");
            labelSinglePrice.Text = single.ToString("c");
            labelHalfDozenPrice.Text = halfDozen.ToString("c");
            labelDozenPrice.Text = dozen.ToString("c");
        }

        private void OccasionBox()
        {
            // occasions ext. text
            StreamReader InputFile;
            InputFile = File.OpenText("Occasions.txt");

            while (!InputFile.EndOfStream)
            {
                comboBoxOccasions.Items.Add(InputFile.ReadLine());
            }

        }

        private void ExtraBox()
        {
            // extras ext. text
            StreamReader InputFile;
            InputFile = File.OpenText("Extras.txt");

            while (!InputFile.EndOfStream)
            {
                listBoxExtras.Items.Add(InputFile.ReadLine());
            }

        }
        private void checkChange (object sender, EventArgs e)
            // custom method
        {
            if (checkBoxMessage.Checked)
            {
                textBoxPersonalMessage.Enabled = true;
                labelMaxLimit.Enabled = true;
            }
            else
            {
                textBoxPersonalMessage.Enabled = false;
                labelMaxLimit.Enabled = false;
                textBoxPersonalMessage.Text = "";
            }
               
            double subtotal;
            double salesTax;
            double orderTotal;
            double PersonalMessage = 2.50;
            double storePrice = 0;
            bool DeliveryButton = radioButtonDelivery.Checked;
            double Delivery = 7.50;
            double extPrices = 9.50;
            int numberOfExtras = +0;
            // count selected items & display price * selected items
            foreach (object extras in listBoxExtras.SelectedItems)
            {
                numberOfExtras++;
            }
            double extrasCount = extPrices * numberOfExtras;
            labelExtras.Text = extrasCount.ToString("c");
            // subtotal store pick up
            // store & single & extras
            if (radioButtonStore.Checked && radioButtonSingle.Checked)
            {
                labelSubtotalAmount.Text = (single + extrasCount).ToString("c");
                labelSalesTaxAmount.Text = ((single + extrasCount) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((single + extrasCount) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // store & single & extras & personal message
            if (radioButtonStore.Checked && radioButtonSingle.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (single + extrasCount + PersonalMessage).ToString("c");
                labelSalesTaxAmount.Text = ((single + extrasCount + PersonalMessage) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((single + extrasCount + PersonalMessage) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // store & halfdozen & extras
            if (radioButtonStore.Checked && radioButtonHalfDozen.Checked)
            {
                labelSubtotalAmount.Text = (halfDozen + extrasCount).ToString("c");
                labelSalesTaxAmount.Text = ((halfDozen + extrasCount) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((halfDozen + extrasCount) + (halfDozen + extrasCount) * taxRate)).ToString("c");
            }
            // store & halfdozen & extras & personal message
            if (radioButtonStore.Checked && radioButtonHalfDozen.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (halfDozen + extrasCount + PersonalMessage).ToString("c");
                labelSalesTaxAmount.Text = ((halfDozen + extrasCount + PersonalMessage) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((halfDozen + extrasCount + PersonalMessage) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // store & dozen & extras
            if (radioButtonStore.Checked && radioButtonDozen.Checked)
            {
                labelSubtotalAmount.Text = (dozen + extrasCount).ToString("c");
                labelSalesTaxAmount.Text = ((dozen + extrasCount) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((dozen + extrasCount) + (dozen + extrasCount) * taxRate)).ToString("c");
            }
            // store & dozen & extras & personal message
            if (radioButtonStore.Checked && radioButtonDozen.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (dozen + extrasCount + PersonalMessage).ToString("c");
                labelSalesTaxAmount.Text = ((dozen + extrasCount + PersonalMessage) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((dozen + extrasCount + PersonalMessage) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // delivery && single && extras
            if (DeliveryButton && radioButtonSingle.Checked)
            {
                labelSubtotalAmount.Text = (single + extrasCount + PersonalMessage + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((single + extrasCount + PersonalMessage + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((single + extrasCount + PersonalMessage + Delivery) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // delivery & single & extras & personal message
            if (radioButtonDelivery.Checked && radioButtonSingle.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (single + extrasCount + PersonalMessage + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((single + extrasCount + PersonalMessage + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((single + extrasCount + PersonalMessage + Delivery) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // delivery & halfdozen & extras
            if (radioButtonDelivery.Checked && radioButtonHalfDozen.Checked)
            {
                labelSubtotalAmount.Text = (halfDozen + extrasCount + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((halfDozen + extrasCount + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((halfDozen + extrasCount + Delivery) + (halfDozen + extrasCount) * taxRate)).ToString("c");
            }
            // delivery & halfdozen & extras & personal message
            if (radioButtonDelivery.Checked && radioButtonHalfDozen.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (halfDozen + extrasCount + PersonalMessage + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((halfDozen + extrasCount + PersonalMessage + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((halfDozen + extrasCount + PersonalMessage + Delivery) + (single + extrasCount) * taxRate)).ToString("c");
            }
            // delivery & dozen & extras
            if (radioButtonDelivery.Checked && radioButtonDozen.Checked)
            {
                labelSubtotalAmount.Text = (dozen + extrasCount + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((dozen + extrasCount + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((dozen + extrasCount + Delivery) + (dozen + extrasCount) * taxRate)).ToString("c");
            }
            // delivery & dozen & extras & personal message
            if (radioButtonDelivery.Checked && radioButtonDozen.Checked && checkBoxMessage.Checked)
            {
                labelSubtotalAmount.Text = (dozen + extrasCount + PersonalMessage + Delivery).ToString("c");
                labelSalesTaxAmount.Text = ((dozen + extrasCount + PersonalMessage + Delivery) * taxRate).ToString("c");
                labelOrderTotalAmount.Text = (((dozen + extrasCount + PersonalMessage + Delivery) + (single + extrasCount) * taxRate)).ToString("c");
            }
        }


        private void labelCompany_Click(object sender, EventArgs e)
        {

        }

        private void textBoxZip_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxDelivery_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBoxPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBoxOccasions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxExtras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            // ask if user is certain, if yes close form, if no stay on form
            // title, message, buttons & question icon
            string message = "Are you sure you wish to quit?";
            string title = "Exit form";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void toolTipSummary_Popup(object sender, PopupEventArgs e)
        {

        }

        private void labelSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void labelSubtotalAmount_Click(object sender, EventArgs e)
        {


        }

        private void textBoxPersonalMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //clear to default
            comboBoxTitle.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxStreet.Text = "";
            textBoxCity.Text = "";
            textBoxState.Text = "";
            textBoxZip.Text = "";
            maskedTextBoxPhone.Text = "";
            maskedTextBoxDelivery.Text = string.Format("{0:MM/dd/yyyy}", DateTime.Now);
            radioButtonStore.Checked = true;
            radioButtonSingle.Checked = true;
            labelSubtotalAmount.Text = single.ToString("c");
            labelSalesTaxAmount.Text = (single * taxRate).ToString("c");
            labelOrderTotalAmount.Text = (single * taxRate + single).ToString("c");
            labelSinglePrice.Text = single.ToString("c");
            labelHalfDozenPrice.Text = halfDozen.ToString("c");
            labelDozenPrice.Text = dozen.ToString("c");
            labelExtras.Text = "$0.00";
            comboBoxOccasions.SelectedIndex = 1;
            listBoxExtras.ClearSelected();
            comboBoxTitle.Focus();
            checkBoxMessage.Checked = false;
            textBoxPersonalMessage.Enabled = false;
            labelMaxLimit.Enabled = false;
            textBoxPersonalMessage.Text = "";
        }
    }
}


