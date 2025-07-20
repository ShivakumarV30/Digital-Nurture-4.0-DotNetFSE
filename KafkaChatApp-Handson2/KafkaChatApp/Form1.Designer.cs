
namespace KafkaChatApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private TextBox txtMessage;
    private Button btnSend;
    private ListBox lstMessages;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
   private void InitializeComponent()
{
    this.txtMessage = new System.Windows.Forms.TextBox();
    this.btnSend = new System.Windows.Forms.Button();
    this.lstMessages = new System.Windows.Forms.ListBox();

    this.SuspendLayout();

    // txtMessage
    this.txtMessage.Location = new System.Drawing.Point(12, 360);
    this.txtMessage.Size = new System.Drawing.Size(600, 23);

    // btnSend
    this.btnSend.Location = new System.Drawing.Point(630, 360);
    this.btnSend.Size = new System.Drawing.Size(75, 23);
    this.btnSend.Text = "Send";
    this.btnSend.Click += new System.EventHandler(this.btnSend_Click);

    // lstMessages
    this.lstMessages.FormattingEnabled = true;
    this.lstMessages.ItemHeight = 15;
    this.lstMessages.Location = new System.Drawing.Point(12, 12);
    this.lstMessages.Size = new System.Drawing.Size(760, 320);

    // Form1
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.ClientSize = new System.Drawing.Size(800, 400);
    this.Controls.Add(this.txtMessage);
    this.Controls.Add(this.btnSend);
    this.Controls.Add(this.lstMessages);
    this.Name = "Form1";
    this.Text = "Kafka Chat App";
    this.ResumeLayout(false);
    this.PerformLayout();
}


    #endregion
}
