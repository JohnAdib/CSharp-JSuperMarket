using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace JSuperMarket
{
    class JSCTextBox : TextBox
    {
        public JSCTextBox ()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
            MaxLength = 200;
        }

        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);
            string ClearString = "";
            foreach (char c in Text.ToCharArray())
            {
                if (c != '\'')
                    ClearString += c;
            }
            Text = ClearString;
            char[] charsToTrim = { ' ', '\'' };
            Text = Text.Trim(charsToTrim);

            if (Text == "")
                BackColor = Color.SkyBlue;
            else
                BackColor = Color.White;
        }
        private int _DefaultNumber = 0;
        [CategoryAttribute("Appearance"),
        DescriptionAttribute("Enter default number and press enter")]
        public int Number 
        {
            get
            {
                int d;
                int.TryParse(Text, out d);
                if (d==0) d = _DefaultNumber;
                return d;
            }
            set { _DefaultNumber = value;}
        }

    }
    class JSBarCodeBox : TextBox
    {
        public JSBarCodeBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TextAlign = HorizontalAlignment.Center;
            Enabled = false;
            ReadOnly = true;
            Font = new Font(FontFamily.GenericSansSerif, 12.0F);
            
        }
    }

    class JSCDataGrid : DataGridView
    {
        public JSCDataGrid()
        {
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.None;
            ColumnHeadersVisible = false;
            GridColor = SystemColors.Menu;
            RowHeadersVisible = false;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            AllowUserToOrderColumns = true;
            AllowUserToAddRows = false;
            AllowUserToDeleteRows = false;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            ReadOnly = true;
            MultiSelect = false;
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            StandardTab = true;
            VirtualMode = true;
            RightToLeft = RightToLeft.Yes;
        }
    }

    class JSCComboBox : ComboBox
    {
        public JSCComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
        public int SValue
        {
            get
            {
                int d = 0;
                int.TryParse(SelectedValue.ToString(), out d);
                return d;
            }
        }
    }

    class JSCLabel : Label
    {
        public JSCLabel()
        {
            BackColor = Color.Transparent;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
    }

    class JSCCheckBox : CheckBox
    {
        public JSCCheckBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
            Appearance = Appearance.Button;
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }

    class JSCAdd : Button
    {
        public JSCAdd()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Olive;
            FlatStyle = FlatStyle.Flat;
            Image = JSuperMarket.Properties.Resources.Aadd;
            
            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft= RightToLeft.Yes;
        }
        public override string Text
        {
            get     { return base.Text; }
            set     { base.Text = "اضافه کردن"; }
        }
    }
    class JSCUpdate : Button
    {
        public JSCUpdate()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.DeepSkyBlue;
            FlatStyle = FlatStyle.Flat;
            Image = JSuperMarket.Properties.Resources.Aedit;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = "به روزرسانی"; }
        }
    }

    class JSCDelete : Button
    {
        public JSCDelete()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Red;
            FlatStyle = FlatStyle.Flat;
            Image = JSuperMarket.Properties.Resources.Adelete;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = "حذف"; }
        }
    }

    class JSCHome : Button
    {
        public JSCHome()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            Image = JSuperMarket.Properties.Resources.Ahome;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = "بازگشت"; }
        }
    }

    class JSCClose : Button
    {
        public JSCClose()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            Image = JSuperMarket.Properties.Resources.Aclose;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = "بستن"; }
        }
    }

    class JSNTextBox : TextBox
    {
        public JSNTextBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
        protected override void OnValidating(System.ComponentModel.CancelEventArgs e)
        {
            base.OnValidating(e);

            if (Text == "")
                BackColor = Color.SkyBlue;
            else
                BackColor = Color.White;
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }

}
