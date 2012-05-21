// Type: System.Windows.Forms.DataGridViewComboBoxCell
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace System.Windows.Forms
{
    public class DataGridViewComboBoxCell : DataGridViewCell
    {
        public DataGridViewComboBoxCell();

        [DefaultValue(true)]
        public virtual bool AutoComplete { get; set; }

        public virtual object DataSource { get; set; }

        [DefaultValue("")]
        public virtual string DisplayMember { get; set; }

        [DefaultValue(DataGridViewComboBoxDisplayStyle.DropDownButton)]
        public DataGridViewComboBoxDisplayStyle DisplayStyle { get; set; }

        [DefaultValue(false)]
        public bool DisplayStyleForCurrentCellOnly { get; set; }

        [DefaultValue(1)]
        public virtual int DropDownWidth { get; set; }

        public override System.Type EditType { get; }

        [DefaultValue(FlatStyle.Standard)]
        public FlatStyle FlatStyle { get; set; }

        public override System.Type FormattedValueType { get; }

        [Browsable(false)]
        public virtual DataGridViewComboBoxCell.ObjectCollection Items { get; }

        [DefaultValue(8)]
        public virtual int MaxDropDownItems { get; set; }

        [DefaultValue(false)]
        public virtual bool Sorted { get; set; }

        [DefaultValue("")]
        public virtual string ValueMember { get; set; }

        public override System.Type ValueType { get; }
        public override object Clone();
        public override void DetachEditingControl();
        protected override Rectangle GetContentBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
        protected override Rectangle GetErrorIconBounds(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex);
        protected override object GetFormattedValue(object value, int rowIndex, ref DataGridViewCellStyle cellStyle, TypeConverter valueTypeConverter, TypeConverter formattedValueTypeConverter, DataGridViewDataErrorContexts context);
        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize);
        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle);
        public override bool KeyEntersEditMode(KeyEventArgs e);
        protected override void OnDataGridViewChanged();
        protected override void OnEnter(int rowIndex, bool throughMouseClick);
        protected override void OnLeave(int rowIndex, bool throughMouseClick);
        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e);
        protected override void OnMouseEnter(int rowIndex);
        protected override void OnMouseLeave(int rowIndex);
        protected override void OnMouseMove(DataGridViewCellMouseEventArgs e);
        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts);
        public override object ParseFormattedValue(object formattedValue, DataGridViewCellStyle cellStyle, TypeConverter formattedValueTypeConverter, TypeConverter valueTypeConverter);
        public override string ToString();

        #region Nested type: ObjectCollection

        [ListBindable(false)]
        public class ObjectCollection : IList, ICollection, IEnumerable
        {
            public ObjectCollection(DataGridViewComboBoxCell owner);

            #region IList Members

            int IList.Add(object item);
            public void Clear();
            public bool Contains(object value);
            void ICollection.CopyTo(Array destination, int index);
            public IEnumerator GetEnumerator();
            public int IndexOf(object value);
            public void Insert(int index, object item);
            public void Remove(object value);
            public void RemoveAt(int index);
            public int Count { get; }
            object ICollection.SyncRoot { get; }
            bool ICollection.IsSynchronized { get; }
            bool IList.IsFixedSize { get; }
            public bool IsReadOnly { get; }
            public virtual object this[int index] { get; set; }

            #endregion

            public int Add(object item);
            public void AddRange(params object[] items);
            public void AddRange(DataGridViewComboBoxCell.ObjectCollection value);
            public void CopyTo(object[] destination, int arrayIndex);
        }

        #endregion
    }
}
