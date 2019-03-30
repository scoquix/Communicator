namespace CommunicatorClient
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
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.nudPort = new System.Windows.Forms.NumericUpDown();
            this.bConnect = new System.Windows.Forms.Button();
            this.lbCommunique = new System.Windows.Forms.ListBox();
            this.wbMessages = new System.Windows.Forms.WebBrowser();
            this.tbMessage = new System.Windows.Forms.TextBox();
            this.bSendMessage = new System.Windows.Forms.Button();
            this.bwConnection = new System.ComponentModel.BackgroundWorker();
            this.bwConversation = new System.ComponentModel.BackgroundWorker();
            this.bFontWeight = new System.Windows.Forms.Button();
            this.bFontItalic = new System.Windows.Forms.Button();
            this.cmsOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importConversationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.bFontFamily = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).BeginInit();
            this.cmsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(76, 6);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(90, 20);
            this.tbAddress.TabIndex = 0;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Location = new System.Drawing.Point(12, 9);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(58, 13);
            this.lAddress.TabIndex = 1;
            this.lAddress.Text = "Address IP";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(12, 31);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(26, 13);
            this.lPort.TabIndex = 2;
            this.lPort.Text = "Port";
            // 
            // nudPort
            // 
            this.nudPort.Location = new System.Drawing.Point(76, 29);
            this.nudPort.Maximum = new decimal(new int[] {
            64000,
            0,
            0,
            0});
            this.nudPort.Name = "nudPort";
            this.nudPort.Size = new System.Drawing.Size(57, 20);
            this.nudPort.TabIndex = 3;
            this.nudPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // bConnect
            // 
            this.bConnect.Location = new System.Drawing.Point(172, 6);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(110, 43);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = true;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // lbCommunique
            // 
            this.lbCommunique.FormattingEnabled = true;
            this.lbCommunique.Location = new System.Drawing.Point(13, 55);
            this.lbCommunique.Name = "lbCommunique";
            this.lbCommunique.Size = new System.Drawing.Size(269, 69);
            this.lbCommunique.TabIndex = 5;
            // 
            // wbMessages
            // 
            this.wbMessages.Location = new System.Drawing.Point(15, 130);
            this.wbMessages.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMessages.Name = "wbMessages";
            this.wbMessages.Size = new System.Drawing.Size(267, 154);
            this.wbMessages.TabIndex = 6;
            // 
            // tbMessage
            // 
            this.tbMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbMessage.Location = new System.Drawing.Point(12, 335);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.Size = new System.Drawing.Size(223, 60);
            this.tbMessage.TabIndex = 7;
            this.tbMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMessage_KeyDown);
            // 
            // bSendMessage
            // 
            this.bSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)), true);
            this.bSendMessage.Location = new System.Drawing.Point(242, 335);
            this.bSendMessage.Name = "bSendMessage";
            this.bSendMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSendMessage.Size = new System.Drawing.Size(40, 60);
            this.bSendMessage.TabIndex = 8;
            this.bSendMessage.Text = "Send";
            this.bSendMessage.UseVisualStyleBackColor = true;
            this.bSendMessage.Click += new System.EventHandler(this.bSendMessage_Click);
            // 
            // bwConnection
            // 
            this.bwConnection.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConnection_DoWork);
            // 
            // bwConversation
            // 
            this.bwConversation.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwConversation_DoWork);
            // 
            // bFontWeight
            // 
            this.bFontWeight.BackColor = System.Drawing.Color.White;
            this.bFontWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontWeight.Location = new System.Drawing.Point(12, 306);
            this.bFontWeight.Name = "bFontWeight";
            this.bFontWeight.Size = new System.Drawing.Size(26, 23);
            this.bFontWeight.TabIndex = 9;
            this.bFontWeight.Text = "b";
            this.bFontWeight.UseVisualStyleBackColor = false;
            this.bFontWeight.Click += new System.EventHandler(this.bFontWeight_Click);
            // 
            // bFontItalic
            // 
            this.bFontItalic.BackColor = System.Drawing.Color.White;
            this.bFontItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontItalic.Location = new System.Drawing.Point(44, 306);
            this.bFontItalic.Name = "bFontItalic";
            this.bFontItalic.Size = new System.Drawing.Size(26, 23);
            this.bFontItalic.TabIndex = 10;
            this.bFontItalic.Text = "/";
            this.bFontItalic.UseVisualStyleBackColor = false;
            this.bFontItalic.Click += new System.EventHandler(this.bFontItalic_Click);
            // 
            // cmsOptions
            // 
            this.cmsOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportConversationToolStripMenuItem,
            this.importConversationToolStripMenuItem});
            this.cmsOptions.Name = "cmsOptions";
            this.cmsOptions.Size = new System.Drawing.Size(184, 48);
            // 
            // exportConversationToolStripMenuItem
            // 
            this.exportConversationToolStripMenuItem.Name = "exportConversationToolStripMenuItem";
            this.exportConversationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.exportConversationToolStripMenuItem.Text = "Export Conversation";
            this.exportConversationToolStripMenuItem.Click += new System.EventHandler(this.exportConversationToolStripMenuItem_Click);
            // 
            // importConversationToolStripMenuItem
            // 
            this.importConversationToolStripMenuItem.Name = "importConversationToolStripMenuItem";
            this.importConversationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.importConversationToolStripMenuItem.Text = "Import Conversation";
            this.importConversationToolStripMenuItem.Click += new System.EventHandler(this.importConversationToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(76, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "(-_-)";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bFontFamily
            // 
            this.bFontFamily.BackColor = System.Drawing.Color.White;
            this.bFontFamily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bFontFamily.Location = new System.Drawing.Point(124, 306);
            this.bFontFamily.Name = "bFontFamily";
            this.bFontFamily.Size = new System.Drawing.Size(58, 23);
            this.bFontFamily.TabIndex = 12;
            this.bFontFamily.Text = "Impact";
            this.bFontFamily.UseVisualStyleBackColor = false;
            this.bFontFamily.Click += new System.EventHandler(this.bFontFamily_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(188, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Coral Theme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(294, 415);
            this.ContextMenuStrip = this.cmsOptions;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bFontFamily);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bFontItalic);
            this.Controls.Add(this.bFontWeight);
            this.Controls.Add(this.bSendMessage);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.wbMessages);
            this.Controls.Add(this.lbCommunique);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.nudPort);
            this.Controls.Add(this.lPort);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.tbAddress);
            this.Name = "mainWindow";
            this.Text = "Communicator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPort)).EndInit();
            this.cmsOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.NumericUpDown nudPort;
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.ListBox lbCommunique;
        private System.Windows.Forms.WebBrowser wbMessages;
        private System.Windows.Forms.TextBox tbMessage;
        private System.Windows.Forms.Button bSendMessage;
        private System.ComponentModel.BackgroundWorker bwConnection;
        private System.ComponentModel.BackgroundWorker bwConversation;
        private System.Windows.Forms.Button bFontWeight;
        private System.Windows.Forms.Button bFontItalic;
        private System.Windows.Forms.ContextMenuStrip cmsOptions;
        private System.Windows.Forms.ToolStripMenuItem exportConversationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importConversationToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bFontFamily;
        private System.Windows.Forms.Button button1;
    }
}

