﻿namespace Automatas
{
    partial class Main
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txts = new System.Windows.Forms.TextBox();
            this.txtSigma = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvDelta = new System.Windows.Forms.DataGridView();
            this.btnSaveDelta = new System.Windows.Forms.Button();
            this.cboAutomata = new System.Windows.Forms.ComboBox();
            this.tabInput = new System.Windows.Forms.TabPage();
            this.txtRE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.acceptedWords = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintDiagram = new System.Windows.Forms.Button();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.cboAutomaton = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvNFAE = new System.Windows.Forms.DataGridView();
            this.btnSaveNFA = new System.Windows.Forms.Button();
            this.cboAutomatonNFA = new System.Windows.Forms.ComboBox();
            this.dgvNFA = new System.Windows.Forms.DataGridView();
            this.dgvDFA = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelta)).BeginInit();
            this.tabInput.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFAE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDFA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(618, 254);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(115, 48);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabInput);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(969, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtName);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtF);
            this.tabPage1.Controls.Add(this.txts);
            this.tabPage1.Controls.Add(this.txtSigma);
            this.tabPage1.Controls.Add(this.txtQ);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreate);
            this.tabPage1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(961, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Automaton";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(334, 328);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "( separated by (,) )";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Location = new System.Drawing.Point(334, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "( separated by (,) )";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(139, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(189, 26);
            this.txtName.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(23, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name:";
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtF.Location = new System.Drawing.Point(139, 323);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(189, 26);
            this.txtF.TabIndex = 6;
            // 
            // txts
            // 
            this.txts.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txts.Location = new System.Drawing.Point(139, 266);
            this.txts.Name = "txts";
            this.txts.Size = new System.Drawing.Size(189, 26);
            this.txts.TabIndex = 5;
            // 
            // txtSigma
            // 
            this.txtSigma.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigma.Location = new System.Drawing.Point(139, 209);
            this.txtSigma.Name = "txtSigma";
            this.txtSigma.Size = new System.Drawing.Size(189, 26);
            this.txtSigma.TabIndex = 4;
            // 
            // txtQ
            // 
            this.txtQ.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQ.Location = new System.Drawing.Point(139, 152);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(189, 26);
            this.txtQ.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(82, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "F:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(84, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "s:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(82, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Σ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(76, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Q:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.dgvDelta);
            this.tabPage2.Controls.Add(this.btnSaveDelta);
            this.tabPage2.Controls.Add(this.cboAutomata);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(961, 473);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automata";
            // 
            // dgvDelta
            // 
            this.dgvDelta.AllowUserToAddRows = false;
            this.dgvDelta.AllowUserToDeleteRows = false;
            this.dgvDelta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelta.Location = new System.Drawing.Point(245, 147);
            this.dgvDelta.Name = "dgvDelta";
            this.dgvDelta.RowTemplate.Height = 24;
            this.dgvDelta.Size = new System.Drawing.Size(439, 263);
            this.dgvDelta.TabIndex = 2;
            this.dgvDelta.CurrentCellChanged += new System.EventHandler(this.dgvDelta_CurrentCellChanged);
            // 
            // btnSaveDelta
            // 
            this.btnSaveDelta.Location = new System.Drawing.Point(305, 79);
            this.btnSaveDelta.Name = "btnSaveDelta";
            this.btnSaveDelta.Size = new System.Drawing.Size(150, 36);
            this.btnSaveDelta.TabIndex = 1;
            this.btnSaveDelta.Text = "Save";
            this.btnSaveDelta.UseVisualStyleBackColor = true;
            this.btnSaveDelta.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cboAutomata
            // 
            this.cboAutomata.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutomata.DropDownWidth = 140;
            this.cboAutomata.FormattingEnabled = true;
            this.cboAutomata.Location = new System.Drawing.Point(102, 85);
            this.cboAutomata.Name = "cboAutomata";
            this.cboAutomata.Size = new System.Drawing.Size(140, 27);
            this.cboAutomata.TabIndex = 0;
            this.cboAutomata.SelectedIndexChanged += new System.EventHandler(this.cboAutomata_SelectedIndexChanged);
            // 
            // tabInput
            // 
            this.tabInput.BackColor = System.Drawing.Color.DimGray;
            this.tabInput.Controls.Add(this.txtRE);
            this.tabInput.Controls.Add(this.label7);
            this.tabInput.Controls.Add(this.acceptedWords);
            this.tabInput.Controls.Add(this.label5);
            this.tabInput.Controls.Add(this.btnPrintDiagram);
            this.tabInput.Controls.Add(this.txtWord);
            this.tabInput.Controls.Add(this.cboAutomaton);
            this.tabInput.Location = new System.Drawing.Point(4, 28);
            this.tabInput.Name = "tabInput";
            this.tabInput.Padding = new System.Windows.Forms.Padding(3);
            this.tabInput.Size = new System.Drawing.Size(961, 473);
            this.tabInput.TabIndex = 2;
            this.tabInput.Text = "Ingresar Palabra";
            // 
            // txtRE
            // 
            this.txtRE.Location = new System.Drawing.Point(312, 424);
            this.txtRE.Name = "txtRE";
            this.txtRE.ReadOnly = true;
            this.txtRE.Size = new System.Drawing.Size(411, 26);
            this.txtRE.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Location = new System.Drawing.Point(96, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Regular Expression:";
            // 
            // acceptedWords
            // 
            this.acceptedWords.Location = new System.Drawing.Point(312, 188);
            this.acceptedWords.Name = "acceptedWords";
            this.acceptedWords.ReadOnly = true;
            this.acceptedWords.Size = new System.Drawing.Size(227, 202);
            this.acceptedWords.TabIndex = 16;
            this.acceptedWords.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(339, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Accepted Words";
            // 
            // btnPrintDiagram
            // 
            this.btnPrintDiagram.Location = new System.Drawing.Point(621, 55);
            this.btnPrintDiagram.Name = "btnPrintDiagram";
            this.btnPrintDiagram.Size = new System.Drawing.Size(150, 36);
            this.btnPrintDiagram.TabIndex = 3;
            this.btnPrintDiagram.Text = "Print E.R.";
            this.btnPrintDiagram.UseVisualStyleBackColor = true;
            this.btnPrintDiagram.Click += new System.EventHandler(this.btnPrintDiagram_Click);
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(343, 51);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(165, 26);
            this.txtWord.TabIndex = 2;
            this.txtWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtWord_KeyPress);
            // 
            // cboAutomaton
            // 
            this.cboAutomaton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutomaton.DropDownWidth = 140;
            this.cboAutomaton.FormattingEnabled = true;
            this.cboAutomaton.Location = new System.Drawing.Point(100, 51);
            this.cboAutomaton.Name = "cboAutomaton";
            this.cboAutomaton.Size = new System.Drawing.Size(140, 27);
            this.cboAutomaton.TabIndex = 1;
            this.cboAutomaton.SelectedIndexChanged += new System.EventHandler(this.cboAutomaton_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.dgvDFA);
            this.tabPage3.Controls.Add(this.dgvNFA);
            this.tabPage3.Controls.Add(this.dgvNFAE);
            this.tabPage3.Controls.Add(this.btnSaveNFA);
            this.tabPage3.Controls.Add(this.cboAutomatonNFA);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(961, 473);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "NFA";
            // 
            // dgvNFAE
            // 
            this.dgvNFAE.AllowUserToAddRows = false;
            this.dgvNFAE.AllowUserToDeleteRows = false;
            this.dgvNFAE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNFAE.Location = new System.Drawing.Point(34, 181);
            this.dgvNFAE.Name = "dgvNFAE";
            this.dgvNFAE.RowTemplate.Height = 24;
            this.dgvNFAE.Size = new System.Drawing.Size(392, 167);
            this.dgvNFAE.TabIndex = 5;
            // 
            // btnSaveNFA
            // 
            this.btnSaveNFA.Location = new System.Drawing.Point(240, 54);
            this.btnSaveNFA.Name = "btnSaveNFA";
            this.btnSaveNFA.Size = new System.Drawing.Size(150, 36);
            this.btnSaveNFA.TabIndex = 4;
            this.btnSaveNFA.Text = "Generate equi.";
            this.btnSaveNFA.UseVisualStyleBackColor = true;
            this.btnSaveNFA.Click += new System.EventHandler(this.btnSaveNFA_Click);
            // 
            // cboAutomatonNFA
            // 
            this.cboAutomatonNFA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAutomatonNFA.DropDownWidth = 140;
            this.cboAutomatonNFA.FormattingEnabled = true;
            this.cboAutomatonNFA.Location = new System.Drawing.Point(37, 60);
            this.cboAutomatonNFA.Name = "cboAutomatonNFA";
            this.cboAutomatonNFA.Size = new System.Drawing.Size(140, 27);
            this.cboAutomatonNFA.TabIndex = 3;
            this.cboAutomatonNFA.SelectedIndexChanged += new System.EventHandler(this.cboAutomatonNFA_SelectedIndexChanged);
            // 
            // dgvNFA
            // 
            this.dgvNFA.AllowUserToAddRows = false;
            this.dgvNFA.AllowUserToDeleteRows = false;
            this.dgvNFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNFA.Location = new System.Drawing.Point(465, 45);
            this.dgvNFA.Name = "dgvNFA";
            this.dgvNFA.RowTemplate.Height = 24;
            this.dgvNFA.Size = new System.Drawing.Size(449, 152);
            this.dgvNFA.TabIndex = 6;
            // 
            // dgvDFA
            // 
            this.dgvDFA.AllowUserToAddRows = false;
            this.dgvDFA.AllowUserToDeleteRows = false;
            this.dgvDFA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDFA.Location = new System.Drawing.Point(465, 250);
            this.dgvDFA.Name = "dgvDFA";
            this.dgvDFA.RowTemplate.Height = 24;
            this.dgvDFA.Size = new System.Drawing.Size(449, 152);
            this.dgvDFA.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 534);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelta)).EndInit();
            this.tabInput.ResumeLayout(false);
            this.tabInput.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFAE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNFA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDFA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txts;
        private System.Windows.Forms.TextBox txtSigma;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboAutomata;
        private System.Windows.Forms.Button btnSaveDelta;
        private System.Windows.Forms.DataGridView dgvDelta;
        private System.Windows.Forms.TabPage tabInput;
        private System.Windows.Forms.ComboBox cboAutomaton;
        private System.Windows.Forms.Button btnPrintDiagram;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.RichTextBox acceptedWords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRE;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvNFAE;
        private System.Windows.Forms.Button btnSaveNFA;
        private System.Windows.Forms.ComboBox cboAutomatonNFA;
        private System.Windows.Forms.DataGridView dgvNFA;
        private System.Windows.Forms.DataGridView dgvDFA;
    }
}

