namespace pathFinding
{
    partial class Form1
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
            this.findPathButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startMapTB = new System.Windows.Forms.TextBox();
            this.endMapTB = new System.Windows.Forms.TextBox();
            this.endRoomTB = new System.Windows.Forms.TextBox();
            this.startRoomTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.northernCB = new System.Windows.Forms.CheckBox();
            this.westCB = new System.Windows.Forms.CheckBox();
            this.eastCB = new System.Windows.Forms.CheckBox();
            this.southCB = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.outputToFileButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.statusTB = new System.Windows.Forms.TextBox();
            this.pathingControls = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.loopGeneratorDG = new System.Windows.Forms.DataGridView();
            this.generateLoopButton = new System.Windows.Forms.Button();
            this.startMapCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startRoomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopMapCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stopRoomCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.stepsCountTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.directionLB = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.pathingControls.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loopGeneratorDG)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // findPathButton
            // 
            this.findPathButton.Location = new System.Drawing.Point(8, 18);
            this.findPathButton.Margin = new System.Windows.Forms.Padding(2);
            this.findPathButton.Name = "findPathButton";
            this.findPathButton.Size = new System.Drawing.Size(102, 25);
            this.findPathButton.TabIndex = 0;
            this.findPathButton.Text = "Find Path";
            this.findPathButton.UseVisualStyleBackColor = true;
            this.findPathButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Map:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Map:";
            // 
            // startMapTB
            // 
            this.startMapTB.Location = new System.Drawing.Point(65, 13);
            this.startMapTB.Margin = new System.Windows.Forms.Padding(2);
            this.startMapTB.Name = "startMapTB";
            this.startMapTB.Size = new System.Drawing.Size(41, 20);
            this.startMapTB.TabIndex = 4;
            this.startMapTB.Text = "1";
            // 
            // endMapTB
            // 
            this.endMapTB.Location = new System.Drawing.Point(62, 13);
            this.endMapTB.Margin = new System.Windows.Forms.Padding(2);
            this.endMapTB.Name = "endMapTB";
            this.endMapTB.Size = new System.Drawing.Size(41, 20);
            this.endMapTB.TabIndex = 5;
            this.endMapTB.Text = "1";
            // 
            // endRoomTB
            // 
            this.endRoomTB.Location = new System.Drawing.Point(174, 13);
            this.endRoomTB.Margin = new System.Windows.Forms.Padding(2);
            this.endRoomTB.Name = "endRoomTB";
            this.endRoomTB.Size = new System.Drawing.Size(42, 20);
            this.endRoomTB.TabIndex = 9;
            this.endRoomTB.Text = "1";
            // 
            // startRoomTB
            // 
            this.startRoomTB.Location = new System.Drawing.Point(174, 13);
            this.startRoomTB.Margin = new System.Windows.Forms.Padding(2);
            this.startRoomTB.Name = "startRoomTB";
            this.startRoomTB.Size = new System.Drawing.Size(42, 20);
            this.startRoomTB.TabIndex = 8;
            this.startRoomTB.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "End Room:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 16);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Start Room";
            // 
            // northernCB
            // 
            this.northernCB.AutoSize = true;
            this.northernCB.Location = new System.Drawing.Point(105, 19);
            this.northernCB.Name = "northernCB";
            this.northernCB.Size = new System.Drawing.Size(52, 17);
            this.northernCB.TabIndex = 12;
            this.northernCB.Text = "North";
            this.northernCB.UseVisualStyleBackColor = true;
            // 
            // westCB
            // 
            this.westCB.AutoSize = true;
            this.westCB.Location = new System.Drawing.Point(55, 42);
            this.westCB.Name = "westCB";
            this.westCB.Size = new System.Drawing.Size(51, 17);
            this.westCB.TabIndex = 13;
            this.westCB.Text = "West";
            this.westCB.UseVisualStyleBackColor = true;
            // 
            // eastCB
            // 
            this.eastCB.AutoSize = true;
            this.eastCB.Location = new System.Drawing.Point(145, 42);
            this.eastCB.Name = "eastCB";
            this.eastCB.Size = new System.Drawing.Size(47, 17);
            this.eastCB.TabIndex = 14;
            this.eastCB.Text = "East";
            this.eastCB.UseVisualStyleBackColor = true;
            // 
            // southCB
            // 
            this.southCB.AutoSize = true;
            this.southCB.Location = new System.Drawing.Point(105, 65);
            this.southCB.Name = "southCB";
            this.southCB.Size = new System.Drawing.Size(54, 17);
            this.southCB.TabIndex = 15;
            this.southCB.Text = "South";
            this.southCB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.southCB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.northernCB);
            this.groupBox1.Controls.Add(this.southCB);
            this.groupBox1.Controls.Add(this.eastCB);
            this.groupBox1.Controls.Add(this.westCB);
            this.groupBox1.Location = new System.Drawing.Point(6, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Direction Weights";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.startMapTB);
            this.groupBox2.Controls.Add(this.startRoomTB);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 45);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Start Room";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.endRoomTB);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.endMapTB);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(6, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 42);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stop Room";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(172, 26);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.copyToClipboardToolStripMenuItem.Text = "Copy to Clipboard";
            // 
            // outputToFileButton
            // 
            this.outputToFileButton.Location = new System.Drawing.Point(8, 48);
            this.outputToFileButton.Name = "outputToFileButton";
            this.outputToFileButton.Size = new System.Drawing.Size(101, 25);
            this.outputToFileButton.TabIndex = 21;
            this.outputToFileButton.Text = "Output to File";
            this.outputToFileButton.UseVisualStyleBackColor = true;
            this.outputToFileButton.Click += new System.EventHandler(this.outputToFileButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.findPathButton);
            this.groupBox5.Controls.Add(this.outputToFileButton);
            this.groupBox5.Location = new System.Drawing.Point(6, 224);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 163);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Controls";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.statusTB);
            this.groupBox6.Location = new System.Drawing.Point(6, 393);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(612, 51);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Status";
            // 
            // statusTB
            // 
            this.statusTB.Location = new System.Drawing.Point(10, 19);
            this.statusTB.Name = "statusTB";
            this.statusTB.Size = new System.Drawing.Size(596, 20);
            this.statusTB.TabIndex = 0;
            // 
            // pathingControls
            // 
            this.pathingControls.Controls.Add(this.tabPage1);
            this.pathingControls.Controls.Add(this.tabPage2);
            this.pathingControls.Location = new System.Drawing.Point(12, 12);
            this.pathingControls.Name = "pathingControls";
            this.pathingControls.SelectedIndex = 0;
            this.pathingControls.Size = new System.Drawing.Size(480, 476);
            this.pathingControls.TabIndex = 24;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 450);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Single Path(s)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.generateLoopButton);
            this.tabPage2.Controls.Add(this.loopGeneratorDG);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 450);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Loop Generator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // loopGeneratorDG
            // 
            this.loopGeneratorDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loopGeneratorDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.startMapCol,
            this.startRoomCol,
            this.stopMapCol,
            this.stopRoomCol});
            this.loopGeneratorDG.Location = new System.Drawing.Point(6, 6);
            this.loopGeneratorDG.Name = "loopGeneratorDG";
            this.loopGeneratorDG.Size = new System.Drawing.Size(450, 409);
            this.loopGeneratorDG.TabIndex = 0;
            // 
            // generateLoopButton
            // 
            this.generateLoopButton.Location = new System.Drawing.Point(6, 421);
            this.generateLoopButton.Name = "generateLoopButton";
            this.generateLoopButton.Size = new System.Drawing.Size(106, 23);
            this.generateLoopButton.TabIndex = 1;
            this.generateLoopButton.Text = "Generate";
            this.generateLoopButton.UseVisualStyleBackColor = true;
            this.generateLoopButton.Click += new System.EventHandler(this.generateLoopButton_Click);
            // 
            // startMapCol
            // 
            this.startMapCol.HeaderText = "Start Map";
            this.startMapCol.Name = "startMapCol";
            // 
            // startRoomCol
            // 
            this.startRoomCol.HeaderText = "Start Room";
            this.startRoomCol.Name = "startRoomCol";
            // 
            // stopMapCol
            // 
            this.stopMapCol.HeaderText = "Stop Map";
            this.stopMapCol.Name = "stopMapCol";
            // 
            // stopRoomCol
            // 
            this.stopRoomCol.HeaderText = "Stop Room";
            this.stopRoomCol.Name = "stopRoomCol";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.stepsCountTB);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.directionLB);
            this.groupBox4.Location = new System.Drawing.Point(498, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(222, 476);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Path Output";
            // 
            // stepsCountTB
            // 
            this.stepsCountTB.Location = new System.Drawing.Point(72, 13);
            this.stepsCountTB.Margin = new System.Windows.Forms.Padding(2);
            this.stepsCountTB.Name = "stepsCountTB";
            this.stepsCountTB.Size = new System.Drawing.Size(101, 20);
            this.stepsCountTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Step Count:";
            // 
            // directionLB
            // 
            this.directionLB.FormattingEnabled = true;
            this.directionLB.Location = new System.Drawing.Point(8, 37);
            this.directionLB.Margin = new System.Windows.Forms.Padding(2);
            this.directionLB.Name = "directionLB";
            this.directionLB.Size = new System.Drawing.Size(191, 407);
            this.directionLB.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(736, 502);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pathingControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Majormud Path Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.pathingControls.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loopGeneratorDG)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findPathButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startMapTB;
        private System.Windows.Forms.TextBox endMapTB;
        private System.Windows.Forms.TextBox endRoomTB;
        private System.Windows.Forms.TextBox startRoomTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox northernCB;
        private System.Windows.Forms.CheckBox westCB;
        private System.Windows.Forms.CheckBox eastCB;
        private System.Windows.Forms.CheckBox southCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.Button outputToFileButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox statusTB;
        private System.Windows.Forms.TabControl pathingControls;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView loopGeneratorDG;
        private System.Windows.Forms.Button generateLoopButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn startMapCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn startRoomCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopMapCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn stopRoomCol;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox stepsCountTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox directionLB;
    }
}

