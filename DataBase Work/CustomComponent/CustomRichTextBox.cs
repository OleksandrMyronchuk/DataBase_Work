using System;
using System.Windows.Forms;

namespace DataBase_Work.CustomComponent
{
    public class CustomRichTextBox : RichTextBox
    {
        bool updatingText;

        protected override void OnTextChanged(EventArgs e)
        {
            if (updatingText)
            {
                return;
            }
            updatingText = true;
            try
            {
                var i = SelectionStart;
                var text = Text;
                Rtf = "";
                Text = text;
                SelectionStart = i;
            }
            catch (Exception) { }
            updatingText = false;
        }


        //protected override void OnKeyDown(KeyEventArgs e)
        //{
        //    if (e.Control && e.KeyCode == Keys.V)
        //    {
        //        // suspend layout to avoid blinking
        //        SuspendLayout();

        //        // get insertion point
        //        int insPt = SelectionStart;

        //        // preserve text from after insertion pont to end of RTF content
        //        string postRTFContent = Text.Substring(insPt);

        //        // remove the content after the insertion point
        //        Text = Text.Substring(0, insPt);

        //        // add the clipboard content and then the preserved postRTF content
        //        Text += (string)Clipboard.GetData("Text") + postRTFContent;

        //        // adjust the insertion point to just after the inserted text
        //        SelectionStart = TextLength - postRTFContent.Length;

        //        // restore layout
        //        ResumeLayout();

        //        // cancel the paste
        //        e.Handled = true;
        //    }
        //    base.OnKeyDown(e);
        //}

        protected override void OnHandleCreated(EventArgs e)
        {
            // For some reason it worked for me only if I manipulated the created
            // handle before calling the base method.
            base.OnHandleCreated(e);
        }

        /*** END Paste without a style ***/

        /*** Context menu ***/

        public CustomRichTextBox()
        {
            if (ContextMenuStrip == null)
            {
                ContextMenuStrip cms = new ContextMenuStrip()
                {
                    ShowImageMargin = false
                };

                ToolStripMenuItem tsmiUndo = new ToolStripMenuItem("Undo");
                tsmiUndo.Click += (sender, e) => Undo();
                cms.Items.Add(tsmiUndo);

                ToolStripMenuItem tsmiRedo = new ToolStripMenuItem("Redo");
                tsmiRedo.Click += (sender, e) => Redo();
                cms.Items.Add(tsmiRedo);

                cms.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem tsmiCut = new ToolStripMenuItem("Cut");
                tsmiCut.Click += (sender, e) => Cut();
                cms.Items.Add(tsmiCut);

                ToolStripMenuItem tsmiCopy = new ToolStripMenuItem("Copy");
                tsmiCopy.Click += (sender, e) => Copy();
                cms.Items.Add(tsmiCopy);

                ToolStripMenuItem tsmiPaste = new ToolStripMenuItem("Paste");
                tsmiPaste.Click += (sender, e) => Paste();
                cms.Items.Add(tsmiPaste);

                ToolStripMenuItem tsmiDelete = new ToolStripMenuItem("Delete");
                tsmiDelete.Click += (sender, e) => SelectedText = "";
                cms.Items.Add(tsmiDelete);

                cms.Items.Add(new ToolStripSeparator());

                ToolStripMenuItem tsmiSelectAll = new ToolStripMenuItem("Select All");
                tsmiSelectAll.Click += (sender, e) => SelectAll();
                cms.Items.Add(tsmiSelectAll);

                cms.Opening += (sender, e) =>
                {
                    tsmiUndo.Enabled = !ReadOnly && CanUndo;
                    tsmiRedo.Enabled = !ReadOnly && CanRedo;
                    tsmiCut.Enabled = !ReadOnly && SelectionLength > 0;
                    tsmiCopy.Enabled = SelectionLength > 0;
                    tsmiPaste.Enabled = !ReadOnly && Clipboard.ContainsText();
                    tsmiDelete.Enabled = !ReadOnly && SelectionLength > 0;
                    tsmiSelectAll.Enabled = TextLength > 0 && SelectionLength < TextLength;
                };
                ContextMenuStrip = cms;
            }
        }

        /*** END Context menu ***/

    }
}

/*
richtextbox how to make selected text always highlighted



I want a selected text to be constantly highlighted, regardless of the passive or active form.

For example: A form have two richtextboxes. In the first richtextbox, I select a string, then I move focus to the second richtextbox and start typing some text. The first richtextbox must keep highlighted text (and now the highlighting disappears after losing focus). How to do it?

By "highlight" I mean the blue standard fill text when highlighting.
*/
