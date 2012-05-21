using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace JSuperMarket.Utility
{
    sealed class JSCTextBox : TextBox
    {
        public JSCTextBox ()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
            MaxLength = 200;
        }

        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);
            string clearString = Text.Where(c => c != '\'').Aggregate("", (current, c) => current + c);
            Text = clearString;
            char[] charsToTrim = { ' ', '\'' };
            Text = Text.Trim(charsToTrim);

            BackColor = Text == "" ? Color.SkyBlue : Color.White;
        }

        private int _defaultNumber;
        [CategoryAttribute("Appearance"),
        DescriptionAttribute("Enter default number and press enter")]
        public int Number 
        {
            get
            {
                int d;
                int.TryParse(Text, out d);
                if (d==0) d = _defaultNumber;
                return d;
            }
            set { _defaultNumber = value;}
        }

        protected override void OnEnter(EventArgs e)
        {
            base.OnEnter(e);
            try
            {
                if (PersianText)
                {
                    var language = new System.Globalization.CultureInfo("fa-ir");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
                }
                else
                {
                    var language = new System.Globalization.CultureInfo("en-us");
                    InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
                }
            }
            catch (Exception){return;}
        }
        private bool _persianText = true;
        [CategoryAttribute("Appearance"),
        DescriptionAttribute("if true default input language is Persian else is English")]
        public bool PersianText
        {
            get { return _persianText; }
            set { _persianText = value; }
        }

    }

    sealed class JSBarCodeBox : TextBox
    {
        public JSBarCodeBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            TextAlign = HorizontalAlignment.Center;
            RightToLeft = RightToLeft.No;
            Enabled = false;
            ReadOnly = true;
            TabStop = false;
            MaxLength = 20;
            Font = new Font(FontFamily.GenericSansSerif, 12.0F);
            
        }
    }

    sealed class JSCDataGrid : DataGridView
    {
        public JSCDataGrid()
        {
            AllowUserToOrderColumns = true;
            BackgroundColor = Color.White;
            BorderStyle = BorderStyle.None;
            RightToLeft = RightToLeft.Yes;
            MultiSelect = false;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            GridColor = SystemColors.Menu;
            RowHeadersVisible = false;
            AutoGenerateColumns = false;
            
        }
        private bool _customSetting = true;
        [CategoryAttribute("Appearance"),
        DescriptionAttribute("if true default JS Custom setting is appear")]
        public bool JSCustomSetting
        {
            get { return _customSetting; }
            set 
            {
                _customSetting = value;
                if (_customSetting)
                {
                    ColumnHeadersVisible = false;
                    AllowUserToAddRows = false;
                    AllowUserToDeleteRows = false;
                    AllowUserToResizeColumns = false;
                    AllowUserToResizeRows = false;
                    ReadOnly = true;
                    SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                }
                else
                {
                    ColumnHeadersVisible = true;
                    AllowUserToAddRows = true;
                    AllowUserToDeleteRows = true;
                    //AllowUserToResizeColumns = true;
                    //AllowUserToResizeRows = true;
                    ReadOnly = false;
                    SelectionMode = DataGridViewSelectionMode.CellSelect;
                    EditMode = DataGridViewEditMode.EditOnEnter;
                }
            }
        }
    }

    sealed class JSCComboBox : ComboBox
    {
        public JSCComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
        [CategoryAttribute("Appearance"),
        DescriptionAttribute("return the selected value, if null return 0")]
        public int SValue
        {
            get
            {
                if (SelectedValue == null) return 0;
                int d;
                int.TryParse(SelectedValue.ToString(), out d);
                return d;
            }
        }
    }

    sealed class JSCLabel : Label
    {
        public JSCLabel()
        {
            BackColor = Color.Transparent;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
    }

    sealed class JSCCheckBox : CheckBox
    {
        public JSCCheckBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
            Appearance = Appearance.Button;
            TextAlign = ContentAlignment.MiddleCenter;
        }
    }

    sealed class JSCAdd : Button
    {
        public JSCAdd()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Olive;
            FlatStyle = FlatStyle.Flat;
            Image = Properties.Resources.Aadd;
            
            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft= RightToLeft.Yes;
        }
        public override string Text
        {
            get     { return base.Text; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.Text = @"اضافه کردن";
            }
        }
    }

    sealed class JSCUpdate : Button
    {
        public JSCUpdate()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.DeepSkyBlue;
            FlatStyle = FlatStyle.Flat;
            Image = Properties.Resources.Aedit;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.Text = @"به روزرسانی";
            }
        }
    }

    sealed class JSCDelete : Button
    {
        public JSCDelete()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Red;
            FlatStyle = FlatStyle.Flat;
            Image = Properties.Resources.Adelete;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.Text = @"حذف";
            }
        }
    }

    sealed class JSCHome : Button
    {
        public JSCHome()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            Image = Properties.Resources.Ahome;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.Text = @"بازگشت";
            }
        }
    }

    sealed class JSCClose : Button
    {
        public JSCClose()
        {
            BackColor = Color.Transparent;
            ForeColor = Color.Black;
            FlatStyle = FlatStyle.Flat;
            Image = Properties.Resources.Aclose;

            TextImageRelation = TextImageRelation.ImageBeforeText;
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            Size = new Size(95, 35);
            RightToLeft = RightToLeft.Yes;
        }
        public override string Text
        {
            get { return base.Text; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                base.Text = @"بستن";
            }
        }
    }

    sealed class JSCnTextBox : TextBox
    {
        public JSCnTextBox()
        {
            Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            RightToLeft = RightToLeft.Yes;
        }
        protected override void OnValidating(CancelEventArgs e)
        {
            base.OnValidating(e);

            BackColor = Text == "" ? Color.SkyBlue : Color.White;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }
    }

    class JSCTimer : Timer
    {
        [DescriptionAttribute("Count Tick of Timer!")]
        public int TickTimes { get; set; }

        private int _maxTickTimes = 7;

        public JSCTimer()
        {
            TickTimes = 0;
        }

        [DescriptionAttribute(@"Max Tick of Timer!" + @"\n" + @" 0 = extreme")]
        public int MaxTickTimes
        {
            get { return _maxTickTimes; }
            set { _maxTickTimes = value; }
        }

        protected override void OnTick(EventArgs e)
        {
            base.OnTick(e);
            TickTimes += 1;
            if (MaxTickTimes == 0) return;
            if (TickTimes > MaxTickTimes)
            {
                Enabled = false;
                TickTimes = 0;
            }

        }

    }
}
