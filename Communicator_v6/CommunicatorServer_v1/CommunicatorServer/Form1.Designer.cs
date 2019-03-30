namespace CommunicatorServer
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lAddress = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.lbCommunique = new System.Windows.Forms.ListBox();
            this.wbMessages = new System.Windows.Forms.WebBrowser();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwConversation = new System.ComponentModel.BackgroundWorker();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.importConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFontWeight = new System.Windows.Forms.Button();
            this.bFontItalic = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bFontFamily = new System.Windows.Forms.Button();
            this.bCoralTheme = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(12, 9);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(58, 13);
            this.lAddress.TabIndex = 0;
            this.lAddress.Text = "Address IP";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 32);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Port";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(76, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(90, 20);
            this.tbAddress.TabIndex = 2;
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(76, 30);
            this.nudPort.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(56, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(172, 4);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(53, 48);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(231, 4);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(51, 48);
            this.bStop.TabIndex = 5;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // lbCommunique
            // 
            this.lbCommunique.FormattingEnabled = true;
            this.lbCommunique.Location = new System.Drawing.Point(12, 56);
            this.lbCommunique.Name = "lbCommunique";
            this.lbCommunique.Size = new System.Drawing.Size(270, 69);
            this.lbCommunique.TabIndex = 6;
            // 
            // wbMessages
            // 
            this.wbMessages.ContextMenuStrip = this.cmsOptions;
            this.wbMessages.IsWebBrowserContextMenuEnabled = false;
            this.wbMessages.Location = new System.Drawing.Point(12, 131);
            this.wbMessages.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessages.Name = "wbMessages";
            this.wbMessages.Size = new System.Drawing.Size(270, 156);
            this.wbMessages.TabIndex = 7;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(12, 312);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(213, 67);
            this.tbMessage.TabIndex = 8;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown_1);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(232, 312);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(50, 67);
            this.bSend.TabIndex = 9;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bwConnection
            // 
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bwConversation
            // 
            this.bwConversation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConversation_DoWork);
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.importConversationToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(184, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItem1.Text = "Export Conversation";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // importConversationToolStripMenuItem
            // 
            this.importConversationToolStripMenuItem.Name = "importConversationToolStripMenuItem";
            this.importConversationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importConversationToolStripMenuItem.Text = "Import Conversation";
            this.importConversationToolStripMenuItem.Click += new System.EventHandler(this.importConversationToolStripMenuItem_Click);
            // 
            // bFontWeight
            // 
            this.bFontWeight.BackColor = System.Drawing.Color.White;
            this.bFontWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontWeight.Location = new System.Drawing.Point(15, 283);
            this.bFontWeight.Name = "bFontWeight";
            this.bFontWeight.Size = new System.Drawing.Size(23, 23);
            this.bFontWeight.TabIndex = 10;
            this.bFontWeight.Text = "b";
            this.bFontWeight.UseVisualStyleBackColor = false;
            this.bFontWeight.Click += new System.EventHandler(this.bFontWeight_Click);
            // 
            // bFontItalic
            // 
            this.bFontItalic.BackColor = System.Drawing.Color.White;
            this.bFontItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontItalic.Location = new System.Drawing.Point(44, 283);
            this.bFontItalic.Name = "bFontItalic";
            this.bFontItalic.Size = new System.Drawing.Size(26, 23);
            this.bFontItalic.TabIndex = 11;
            this.bFontItalic.Text = "/";
            this.bFontItalic.UseVisualStyleBackColor = false;
            this.bFontItalic.Click += new System.EventHandler(this.bFontItalic_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(76, 283);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "(-_-)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bFontFamily
            // 
            this.bFontFamily.BackColor = System.Drawing.Color.White;
            this.bFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontFamily.Location = new System.Drawing.Point(124, 283);
            this.bFontFamily.Name = "bFontFamily";
            this.bFontFamily.Size = new System.Drawing.Size(62, 23);
            this.bFontFamily.TabIndex = 13;
            this.bFontFamily.Text = "Impact";
            this.bFontFamily.UseVisualStyleBackColor = false;
            this.bFontFamily.Click += new System.EventHandler(this.bFontFamily_Click);
            // 
            // bCoralTheme
            // 
            this.bCoralTheme.BackColor = System.Drawing.Color.White;
            this.bCoralTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCoralTheme.Location = new System.Drawing.Point(192, 283);
            this.bCoralTheme.Name = "bCoralTheme";
            this.bCoralTheme.Size = new System.Drawing.Size(90, 23);
            this.bCoralTheme.TabIndex = 14;
            this.bCoralTheme.Text = "Coral Theme";
            this.bCoralTheme.UseVisualStyleBackColor = false;
            this.bCoralTheme.Click += new System.EventHandler(this.bCoralTheme_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(294, 391);
            this.Controls.Add(this.bCoralTheme);
            this.Controls.Add(this.bFontFamily);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bFontItalic);
            this.Controls.Add(this.bFontWeight);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.wbMessages);
            this.Controls.Add(this.lbCommunique);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lAddress);
            this.Name = "mainWindow";
            this.Text = "Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.ListBox lbCommunique;
        private System.Windows.Forms.WebBrowser wbMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSend;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwConversation;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button bFontWeight;
        private System.Windows.Forms.Button bFontItalic;
        private System.Windows.Forms.ToolStripMenuItem importConversationToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bFontFamily;
        private System.Windows.Forms.Button bCoralTheme;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

