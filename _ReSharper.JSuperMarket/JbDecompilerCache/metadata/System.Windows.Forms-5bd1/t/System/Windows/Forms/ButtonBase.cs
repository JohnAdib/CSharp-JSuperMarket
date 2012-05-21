// Type: System.Windows.Forms.ButtonBase
// Assembly: System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Windows.Forms.dll

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Security.Permissions;

namespace System.Windows.Forms
{
    [ComVisible(true)]
    [Designer("System.Windows.Forms.Design.ButtonBaseDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public abstract class ButtonBase : Control
    {
        [DefaultValue(false)]
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public bool AutoEllipsis { get; set; }

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override bool AutoSize { get; set; }

        public override Color BackColor { get; set; }
        protected override Size DefaultSize { get; }

        protected override CreateParams CreateParams { [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        get; }

        protected override ImeMode DefaultImeMode { get; }
        protected internal bool IsDefault { get; set; }

        [DefaultValue(FlatStyle.Standard)]
        [Localizable(true)]
        public FlatStyle FlatStyle { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Browsable(true)]
        public FlatButtonAppearance FlatAppearance { get; }

        [Localizable(true)]
        public Image Image { get; set; }

        [Localizable(true)]
        [DefaultValue(ContentAlignment.MiddleCenter)]
        public ContentAlignment ImageAlign { get; set; }

        [Localizable(true)]
        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
        [TypeConverter(typeof (ImageIndexConverter))]
        [DefaultValue(-1)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public int ImageIndex { get; set; }

        [Editor("System.Windows.Forms.Design.ImageIndexEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
        [Localizable(true)]
        [TypeConverter(typeof (ImageKeyConverter))]
        [DefaultValue("")]
        [RefreshProperties(RefreshProperties.Repaint)]
        public string ImageKey { get; set; }

        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public ImageList ImageList { get; set; }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new ImeMode ImeMode { get; set; }

        [SettingsBindable(true)]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof (UITypeEditor))]
        public override string Text { get; set; }

        [DefaultValue(ContentAlignment.MiddleCenter)]
        [Localizable(true)]
        public virtual ContentAlignment TextAlign { get; set; }

        [Localizable(true)]
        [DefaultValue(TextImageRelation.Overlay)]
        public TextImageRelation TextImageRelation { get; set; }

        [DefaultValue(true)]
        public bool UseMnemonic { get; set; }

        [DefaultValue(false)]
        public bool UseCompatibleTextRendering { get; set; }

        public bool UseVisualStyleBackColor { get; set; }
        protected override AccessibleObject CreateAccessibilityInstance();
        protected override void Dispose(bool disposing);
        protected override void OnGotFocus(EventArgs e);
        protected override void OnLostFocus(EventArgs e);
        protected override void OnMouseEnter(EventArgs eventargs);
        protected override void OnMouseLeave(EventArgs eventargs);
        protected override void OnMouseMove(MouseEventArgs mevent);
        protected override void OnMouseDown(MouseEventArgs mevent);
        protected override void OnMouseUp(MouseEventArgs mevent);
        protected void ResetFlagsandPaint();
        public override Size GetPreferredSize(Size proposedSize);
        protected override void OnEnabledChanged(EventArgs e);
        protected override void OnTextChanged(EventArgs e);
        protected override void OnKeyDown(KeyEventArgs kevent);
        protected override void OnKeyUp(KeyEventArgs kevent);
        protected override void OnPaint(PaintEventArgs pevent);
        protected override void OnParentChanged(EventArgs e);
        protected override void OnVisibleChanged(EventArgs e);

        [SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.UnmanagedCode)]
        protected override void WndProc(ref Message m);

        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public new event EventHandler AutoSizeChanged;

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public new event EventHandler ImeModeChanged;

        #region Nested type: ButtonBaseAccessibleObject

        [ComVisible(true)]
        public class ButtonBaseAccessibleObject : Control.ControlAccessibleObject
        {
            public ButtonBaseAccessibleObject(Control owner);

            public override AccessibleStates State { get; }

            [SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
            public override void DoDefaultAction();
        }

        #endregion
    }
}
