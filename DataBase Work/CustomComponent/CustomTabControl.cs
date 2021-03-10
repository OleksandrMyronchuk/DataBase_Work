using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DataBase_Work.CustomComponent
{
    public class CustomTabControl : TabControl
    {
        public enum NumberOfTabs
        {
            VeryFew = 2,
            Few = 3,
            Many = 5
        }
        public enum CustomTabWidth
        {
            VeryNarrow = 80,
            Narrow = 140,
            Normal = 180,
            Wide = 240
        }
        public const int CustomTabHeight = 22;

        ButtonX buttonX = new ButtonX();

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SetParent(
            IntPtr hWndChild,
            IntPtr hWndNewParent
            );

        private void UpdateTabSize()
        {
            int width;

            if ((int)NumberOfTabs.VeryFew >= TabPages.Count)
            {
                width = (int)CustomTabWidth.Wide;
            }
            else if ((int)NumberOfTabs.Few >= TabPages.Count)
            {
                width = (int)CustomTabWidth.Normal;
            }
            else if ((int)NumberOfTabs.Many >= TabPages.Count)
            {
                width = (int)CustomTabWidth.Narrow;
            }
            else
            {
                width = (int)CustomTabWidth.VeryNarrow;
            }

            ItemSize = new Size(width, CustomTabHeight);
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UpdateTabSize();
            if (!buttonX.Visible)
            {
                buttonX.Show();
            }
        }

        public CustomTabControl()
        {
            SizeMode = TabSizeMode.Fixed;
            UpdateTabSize();
            DrawMode = TabDrawMode.OwnerDrawFixed;
            buttonX.Hide();
            buttonX.Click += OnCloseTab;
            SetParent(buttonX.Handle, Handle);
        }

        private void CloseSelectedTab(TabPage tp = null)
        {
            TabPages.Remove(tp == null ? SelectedTab : tp);
            UpdateTabSize();
            if (TabPages.Count == 0)
            {
                buttonX.Hide();
            }
        }

        private void OnCloseTab(object sender, EventArgs e)
        {
            CloseSelectedTab();
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            if (e.Button == MouseButtons.Middle)
            {
                for (int i = 0; i < TabCount; i++)
                {
                    if (GetTabRect(i).Contains(e.Location))
                    {
                        CloseSelectedTab(TabPages[i]);
                        break;
                    }
                }
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (SelectedTab == TabPages[e.Index])
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Tomato), e.Bounds);
                Rectangle rtCurrent =
                    GetTabRect(TabPages.IndexOf(SelectedTab));
                buttonX.Location = new Point(
                        rtCurrent.X + rtCurrent.Width - buttonX.Width,
                        rtCurrent.Y
                        );
            }
            else
            {
                e.Graphics.FillRectangle(new SolidBrush(Color.Tan), e.Bounds);
            }

            TabPages[e.Index].BorderStyle = BorderStyle.FixedSingle;
            TabPages[e.Index].ForeColor = SystemColors.ControlText;

            Rectangle paddedBounds = e.Bounds;
            paddedBounds.Inflate(-2, -3);

            e.Graphics.DrawString(
                TabPages[e.Index].Text,
                Font,
                SystemBrushes.HighlightText,
                paddedBounds);
        }
    }
}
