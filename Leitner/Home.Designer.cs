using System;
using System.Globalization;
using System.Windows.Forms;

namespace Leitner
{
    partial class Home
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Section 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Box 1", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Section 1");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Section 2");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Box 2", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Section 1");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Section 2");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Section 3");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Section 4");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Box 3", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Section 1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Section 2");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Section 3");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Section 4");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Section 5");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Section 6");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Section 7");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Section 8");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Box 4", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Section 1");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Section 2");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Section 3");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Section 4");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Section 5");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Section 6");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Section 7");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Section 8");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Section 9");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Section 10");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Section 11");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Section 12");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Section 13");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Section 14");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Section 15");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Section 16");
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Box 5", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24,
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30,
            treeNode31,
            treeNode32,
            treeNode33,
            treeNode34,
            treeNode35});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.EnglishDate = new System.Windows.Forms.Label();
            this.PersianDate = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.boxesGroupBox = new System.Windows.Forms.GroupBox();
            this.Boxes = new System.Windows.Forms.TreeView();
            this.allInSectionGroupBox = new System.Windows.Forms.GroupBox();
            this.allInSectionListBox = new System.Windows.Forms.ListBox();
            this.createGroupBox = new System.Windows.Forms.GroupBox();
            this.deleteGroupBox = new System.Windows.Forms.GroupBox();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.wrongAnswerButton = new System.Windows.Forms.Button();
            this.currectAnswerButton = new System.Windows.Forms.Button();
            this.descTextBox = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.showValueButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.valueLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.updateBoxesButton = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.cDescTextBox = new System.Windows.Forms.TextBox();
            this.cDescLabel = new System.Windows.Forms.Label();
            this.cValueTextBox = new System.Windows.Forms.TextBox();
            this.cValueLabel = new System.Windows.Forms.Label();
            this.cKeyTextBox = new System.Windows.Forms.TextBox();
            this.cKeyLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dKeyLabel = new System.Windows.Forms.Label();
            this.dSectionLabel = new System.Windows.Forms.Label();
            this.dBoxLabel = new System.Windows.Forms.Label();
            this.dBoxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dSectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dKeyTextBox = new System.Windows.Forms.TextBox();
            this.updateGroupBox = new System.Windows.Forms.GroupBox();
            this.uKeyTextBox = new System.Windows.Forms.TextBox();
            this.uSectionNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.uBoxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.updateButton = new System.Windows.Forms.Button();
            this.uKeyLabel = new System.Windows.Forms.Label();
            this.uSectionLabel = new System.Windows.Forms.Label();
            this.uBoxLabel = new System.Windows.Forms.Label();
            this.uValueTextBox = new System.Windows.Forms.TextBox();
            this.uValueLabel = new System.Windows.Forms.Label();
            this.uDescTextBox = new System.Windows.Forms.TextBox();
            this.uDescLabel = new System.Windows.Forms.Label();
            this.boxesGroupBox.SuspendLayout();
            this.allInSectionGroupBox.SuspendLayout();
            this.createGroupBox.SuspendLayout();
            this.deleteGroupBox.SuspendLayout();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBoxNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSectionNumericUpDown)).BeginInit();
            this.updateGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSectionNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBoxNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EnglishDate
            // 
            this.EnglishDate.AutoSize = true;
            this.EnglishDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishDate.Location = new System.Drawing.Point(83, 31);
            this.EnglishDate.Name = "EnglishDate";
            this.EnglishDate.Size = new System.Drawing.Size(0, 22);
            this.EnglishDate.TabIndex = 0;
            // 
            // PersianDate
            // 
            this.PersianDate.AutoSize = true;
            this.PersianDate.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersianDate.Location = new System.Drawing.Point(83, 9);
            this.PersianDate.Name = "PersianDate";
            this.PersianDate.Size = new System.Drawing.Size(0, 22);
            this.PersianDate.TabIndex = 1;
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.Location = new System.Drawing.Point(12, 22);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(65, 22);
            this.todayLabel.TabIndex = 2;
            this.todayLabel.Text = "Today:";
            // 
            // boxesGroupBox
            // 
            this.boxesGroupBox.Controls.Add(this.Boxes);
            this.boxesGroupBox.Location = new System.Drawing.Point(16, 56);
            this.boxesGroupBox.Name = "boxesGroupBox";
            this.boxesGroupBox.Size = new System.Drawing.Size(140, 380);
            this.boxesGroupBox.TabIndex = 3;
            this.boxesGroupBox.TabStop = false;
            // 
            // Boxes
            // 
            this.Boxes.ImageIndex = 0;
            this.Boxes.ImageList = this.imageList;
            this.Boxes.Location = new System.Drawing.Point(6, 15);
            this.Boxes.Name = "Boxes";
            treeNode1.Name = "";
            treeNode1.Text = "Section 1";
            treeNode2.ImageKey = "folderIcon.jpg";
            treeNode2.Name = "Box 1";
            treeNode2.NodeFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.SelectedImageKey = "folderIcon.jpg";
            treeNode2.Text = "Box 1";
            treeNode3.Name = "";
            treeNode3.Text = "Section 1";
            treeNode4.Name = "";
            treeNode4.Text = "Section 2";
            treeNode5.ImageKey = "folderIcon.jpg";
            treeNode5.Name = "Box 2";
            treeNode5.NodeFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode5.SelectedImageKey = "folderIcon.jpg";
            treeNode5.Text = "Box 2";
            treeNode6.Name = "";
            treeNode6.Text = "Section 1";
            treeNode7.Name = "";
            treeNode7.Text = "Section 2";
            treeNode8.Name = "";
            treeNode8.Text = "Section 3";
            treeNode9.Name = "";
            treeNode9.Text = "Section 4";
            treeNode10.ImageKey = "folderIcon.jpg";
            treeNode10.Name = "Box 3";
            treeNode10.NodeFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode10.SelectedImageKey = "folderIcon.jpg";
            treeNode10.Text = "Box 3";
            treeNode11.Name = "";
            treeNode11.Text = "Section 1";
            treeNode12.Name = "";
            treeNode12.Text = "Section 2";
            treeNode13.Name = "";
            treeNode13.Text = "Section 3";
            treeNode14.Name = "";
            treeNode14.Text = "Section 4";
            treeNode15.Name = "";
            treeNode15.Text = "Section 5";
            treeNode16.Name = "";
            treeNode16.Text = "Section 6";
            treeNode17.Name = "";
            treeNode17.Text = "Section 7";
            treeNode18.Name = "";
            treeNode18.Text = "Section 8";
            treeNode19.ImageKey = "folderIcon.jpg";
            treeNode19.Name = "Box 4";
            treeNode19.NodeFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode19.SelectedImageKey = "folderIcon.jpg";
            treeNode19.Text = "Box 4";
            treeNode20.Name = "";
            treeNode20.Text = "Section 1";
            treeNode21.Name = "";
            treeNode21.Text = "Section 2";
            treeNode22.Name = "";
            treeNode22.Text = "Section 3";
            treeNode23.Name = "";
            treeNode23.Text = "Section 4";
            treeNode24.Name = "";
            treeNode24.Text = "Section 5";
            treeNode25.Name = "";
            treeNode25.Text = "Section 6";
            treeNode26.Name = "";
            treeNode26.Text = "Section 7";
            treeNode27.Name = "";
            treeNode27.Text = "Section 8";
            treeNode28.Name = "";
            treeNode28.Text = "Section 9";
            treeNode29.Name = "";
            treeNode29.Text = "Section 10";
            treeNode30.Name = "";
            treeNode30.Text = "Section 11";
            treeNode31.Name = "";
            treeNode31.Text = "Section 12";
            treeNode32.Name = "";
            treeNode32.Text = "Section 13";
            treeNode33.Name = "";
            treeNode33.Text = "Section 14";
            treeNode34.Name = "";
            treeNode34.Text = "Section 15";
            treeNode35.Name = "";
            treeNode35.Text = "Section 16";
            treeNode36.ImageKey = "folderIcon.jpg";
            treeNode36.Name = "Box 5";
            treeNode36.NodeFont = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode36.SelectedImageKey = "folderIcon.jpg";
            treeNode36.Text = "Box 5";
            this.Boxes.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode5,
            treeNode10,
            treeNode19,
            treeNode36});
            this.Boxes.SelectedImageIndex = 0;
            this.Boxes.Size = new System.Drawing.Size(128, 355);
            this.Boxes.TabIndex = 0;
            this.Boxes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Boxes_AfterSelect);
            // 
            // allInSectionGroupBox
            // 
            this.allInSectionGroupBox.Controls.Add(this.allInSectionListBox);
            this.allInSectionGroupBox.Location = new System.Drawing.Point(162, 56);
            this.allInSectionGroupBox.Name = "allInSectionGroupBox";
            this.allInSectionGroupBox.Size = new System.Drawing.Size(200, 380);
            this.allInSectionGroupBox.TabIndex = 4;
            this.allInSectionGroupBox.TabStop = false;
            // 
            // allInSectionListBox
            // 
            this.allInSectionListBox.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allInSectionListBox.FormattingEnabled = true;
            this.allInSectionListBox.ItemHeight = 15;
            this.allInSectionListBox.Location = new System.Drawing.Point(6, 15);
            this.allInSectionListBox.Name = "allInSectionListBox";
            this.allInSectionListBox.Size = new System.Drawing.Size(188, 349);
            this.allInSectionListBox.TabIndex = 0;
            this.allInSectionListBox.SelectedIndexChanged += new System.EventHandler(this.AllInSectionListBox_SelectedIndexChanged);
            // 
            // createGroupBox
            // 
            this.createGroupBox.Controls.Add(this.createButton);
            this.createGroupBox.Controls.Add(this.cDescTextBox);
            this.createGroupBox.Controls.Add(this.cDescLabel);
            this.createGroupBox.Controls.Add(this.cValueTextBox);
            this.createGroupBox.Controls.Add(this.cValueLabel);
            this.createGroupBox.Controls.Add(this.cKeyTextBox);
            this.createGroupBox.Controls.Add(this.cKeyLabel);
            this.createGroupBox.Location = new System.Drawing.Point(368, 216);
            this.createGroupBox.Name = "createGroupBox";
            this.createGroupBox.Size = new System.Drawing.Size(420, 107);
            this.createGroupBox.TabIndex = 5;
            this.createGroupBox.TabStop = false;
            // 
            // deleteGroupBox
            // 
            this.deleteGroupBox.Controls.Add(this.dKeyTextBox);
            this.deleteGroupBox.Controls.Add(this.dSectionNumericUpDown);
            this.deleteGroupBox.Controls.Add(this.dBoxNumericUpDown);
            this.deleteGroupBox.Controls.Add(this.deleteButton);
            this.deleteGroupBox.Controls.Add(this.dKeyLabel);
            this.deleteGroupBox.Controls.Add(this.dSectionLabel);
            this.deleteGroupBox.Controls.Add(this.dBoxLabel);
            this.deleteGroupBox.Location = new System.Drawing.Point(368, 393);
            this.deleteGroupBox.Name = "deleteGroupBox";
            this.deleteGroupBox.Size = new System.Drawing.Size(420, 43);
            this.deleteGroupBox.TabIndex = 6;
            this.deleteGroupBox.TabStop = false;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Controls.Add(this.wrongAnswerButton);
            this.viewGroupBox.Controls.Add(this.currectAnswerButton);
            this.viewGroupBox.Controls.Add(this.descTextBox);
            this.viewGroupBox.Controls.Add(this.DescLabel);
            this.viewGroupBox.Controls.Add(this.showValueButton);
            this.viewGroupBox.Controls.Add(this.valueTextBox);
            this.viewGroupBox.Controls.Add(this.valueLabel);
            this.viewGroupBox.Controls.Add(this.keyTextBox);
            this.viewGroupBox.Controls.Add(this.keyLabel);
            this.viewGroupBox.Location = new System.Drawing.Point(368, 56);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(420, 154);
            this.viewGroupBox.TabIndex = 7;
            this.viewGroupBox.TabStop = false;
            // 
            // wrongAnswerButton
            // 
            this.wrongAnswerButton.Location = new System.Drawing.Point(278, 125);
            this.wrongAnswerButton.Name = "wrongAnswerButton";
            this.wrongAnswerButton.Size = new System.Drawing.Size(100, 23);
            this.wrongAnswerButton.TabIndex = 8;
            this.wrongAnswerButton.Text = "Answer is Wrong";
            this.wrongAnswerButton.UseVisualStyleBackColor = true;
            this.wrongAnswerButton.Click += new System.EventHandler(this.WrongAnswerButton_Click);
            // 
            // currectAnswerButton
            // 
            this.currectAnswerButton.Location = new System.Drawing.Point(172, 125);
            this.currectAnswerButton.Name = "currectAnswerButton";
            this.currectAnswerButton.Size = new System.Drawing.Size(100, 23);
            this.currectAnswerButton.TabIndex = 7;
            this.currectAnswerButton.Text = "Answer is Currect";
            this.currectAnswerButton.UseVisualStyleBackColor = true;
            this.currectAnswerButton.Click += new System.EventHandler(this.CurrectAnswerButton_Click);
            // 
            // descTextBox
            // 
            this.descTextBox.Location = new System.Drawing.Point(172, 33);
            this.descTextBox.Multiline = true;
            this.descTextBox.Name = "descTextBox";
            this.descTextBox.Size = new System.Drawing.Size(242, 86);
            this.descTextBox.TabIndex = 6;
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Location = new System.Drawing.Point(259, 17);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(60, 13);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Description";
            // 
            // showValueButton
            // 
            this.showValueButton.Location = new System.Drawing.Point(66, 125);
            this.showValueButton.Name = "showValueButton";
            this.showValueButton.Size = new System.Drawing.Size(100, 23);
            this.showValueButton.TabIndex = 4;
            this.showValueButton.Text = "Show Value";
            this.showValueButton.UseVisualStyleBackColor = true;
            this.showValueButton.Click += new System.EventHandler(this.ShowValueButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(37, 68);
            this.valueTextBox.Multiline = true;
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(129, 51);
            this.valueTextBox.TabIndex = 3;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(6, 71);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 2;
            this.valueLabel.Text = "Value";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(37, 17);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(129, 45);
            this.keyTextBox.TabIndex = 1;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(6, 20);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(25, 13);
            this.keyLabel.TabIndex = 0;
            this.keyLabel.Text = "Key";
            // 
            // updateBoxesButton
            // 
            this.updateBoxesButton.Location = new System.Drawing.Point(614, 14);
            this.updateBoxesButton.Name = "updateBoxesButton";
            this.updateBoxesButton.Size = new System.Drawing.Size(174, 41);
            this.updateBoxesButton.TabIndex = 8;
            this.updateBoxesButton.Text = "Update Boxes";
            this.updateBoxesButton.UseVisualStyleBackColor = true;
            this.updateBoxesButton.Click += new System.EventHandler(this.UpdateBoxesButton_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "fileIcon.png");
            this.imageList.Images.SetKeyName(1, "folderIcon.jpg");
            // 
            // cDescTextBox
            // 
            this.cDescTextBox.Location = new System.Drawing.Point(172, 31);
            this.cDescTextBox.Multiline = true;
            this.cDescTextBox.Name = "cDescTextBox";
            this.cDescTextBox.Size = new System.Drawing.Size(162, 70);
            this.cDescTextBox.TabIndex = 12;
            // 
            // cDescLabel
            // 
            this.cDescLabel.AutoSize = true;
            this.cDescLabel.Location = new System.Drawing.Point(232, 16);
            this.cDescLabel.Name = "cDescLabel";
            this.cDescLabel.Size = new System.Drawing.Size(60, 13);
            this.cDescLabel.TabIndex = 11;
            this.cDescLabel.Text = "Description";
            // 
            // cValueTextBox
            // 
            this.cValueTextBox.Location = new System.Drawing.Point(37, 53);
            this.cValueTextBox.Multiline = true;
            this.cValueTextBox.Name = "cValueTextBox";
            this.cValueTextBox.Size = new System.Drawing.Size(129, 48);
            this.cValueTextBox.TabIndex = 10;
            // 
            // cValueLabel
            // 
            this.cValueLabel.AutoSize = true;
            this.cValueLabel.Location = new System.Drawing.Point(6, 56);
            this.cValueLabel.Name = "cValueLabel";
            this.cValueLabel.Size = new System.Drawing.Size(34, 13);
            this.cValueLabel.TabIndex = 9;
            this.cValueLabel.Text = "Value";
            // 
            // cKeyTextBox
            // 
            this.cKeyTextBox.Location = new System.Drawing.Point(37, 13);
            this.cKeyTextBox.Multiline = true;
            this.cKeyTextBox.Name = "cKeyTextBox";
            this.cKeyTextBox.Size = new System.Drawing.Size(129, 34);
            this.cKeyTextBox.TabIndex = 8;
            // 
            // cKeyLabel
            // 
            this.cKeyLabel.AutoSize = true;
            this.cKeyLabel.Location = new System.Drawing.Point(6, 16);
            this.cKeyLabel.Name = "cKeyLabel";
            this.cKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.cKeyLabel.TabIndex = 7;
            this.cKeyLabel.Text = "Key";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(340, 31);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(74, 70);
            this.createButton.TabIndex = 13;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(340, 13);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(74, 21);
            this.deleteButton.TabIndex = 20;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // dKeyLabel
            // 
            this.dKeyLabel.AutoSize = true;
            this.dKeyLabel.Location = new System.Drawing.Point(181, 16);
            this.dKeyLabel.Name = "dKeyLabel";
            this.dKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.dKeyLabel.TabIndex = 18;
            this.dKeyLabel.Text = "Key";
            // 
            // dSectionLabel
            // 
            this.dSectionLabel.AutoSize = true;
            this.dSectionLabel.Location = new System.Drawing.Point(79, 16);
            this.dSectionLabel.Name = "dSectionLabel";
            this.dSectionLabel.Size = new System.Drawing.Size(43, 13);
            this.dSectionLabel.TabIndex = 16;
            this.dSectionLabel.Text = "Section";
            // 
            // dBoxLabel
            // 
            this.dBoxLabel.AutoSize = true;
            this.dBoxLabel.Location = new System.Drawing.Point(6, 16);
            this.dBoxLabel.Name = "dBoxLabel";
            this.dBoxLabel.Size = new System.Drawing.Size(25, 13);
            this.dBoxLabel.TabIndex = 14;
            this.dBoxLabel.Text = "Box";
            // 
            // dBoxNumericUpDown
            // 
            this.dBoxNumericUpDown.Location = new System.Drawing.Point(37, 14);
            this.dBoxNumericUpDown.Name = "dBoxNumericUpDown";
            this.dBoxNumericUpDown.Size = new System.Drawing.Size(31, 20);
            this.dBoxNumericUpDown.TabIndex = 21;
            this.dBoxNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dSectionNumericUpDown
            // 
            this.dSectionNumericUpDown.Location = new System.Drawing.Point(128, 14);
            this.dSectionNumericUpDown.Name = "dSectionNumericUpDown";
            this.dSectionNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.dSectionNumericUpDown.TabIndex = 22;
            this.dSectionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dKeyTextBox
            // 
            this.dKeyTextBox.Location = new System.Drawing.Point(212, 13);
            this.dKeyTextBox.Multiline = true;
            this.dKeyTextBox.Name = "dKeyTextBox";
            this.dKeyTextBox.Size = new System.Drawing.Size(122, 20);
            this.dKeyTextBox.TabIndex = 23;
            // 
            // updateGroupBox
            // 
            this.updateGroupBox.Controls.Add(this.uDescTextBox);
            this.updateGroupBox.Controls.Add(this.uDescLabel);
            this.updateGroupBox.Controls.Add(this.uValueTextBox);
            this.updateGroupBox.Controls.Add(this.uValueLabel);
            this.updateGroupBox.Controls.Add(this.uKeyTextBox);
            this.updateGroupBox.Controls.Add(this.uSectionNumericUpDown);
            this.updateGroupBox.Controls.Add(this.uBoxNumericUpDown);
            this.updateGroupBox.Controls.Add(this.updateButton);
            this.updateGroupBox.Controls.Add(this.uKeyLabel);
            this.updateGroupBox.Controls.Add(this.uSectionLabel);
            this.updateGroupBox.Controls.Add(this.uBoxLabel);
            this.updateGroupBox.Location = new System.Drawing.Point(368, 323);
            this.updateGroupBox.Name = "updateGroupBox";
            this.updateGroupBox.Size = new System.Drawing.Size(420, 64);
            this.updateGroupBox.TabIndex = 24;
            this.updateGroupBox.TabStop = false;
            // 
            // uKeyTextBox
            // 
            this.uKeyTextBox.Location = new System.Drawing.Point(212, 13);
            this.uKeyTextBox.Multiline = true;
            this.uKeyTextBox.Name = "uKeyTextBox";
            this.uKeyTextBox.Size = new System.Drawing.Size(122, 20);
            this.uKeyTextBox.TabIndex = 23;
            // 
            // uSectionNumericUpDown
            // 
            this.uSectionNumericUpDown.Location = new System.Drawing.Point(128, 14);
            this.uSectionNumericUpDown.Name = "uSectionNumericUpDown";
            this.uSectionNumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.uSectionNumericUpDown.TabIndex = 22;
            this.uSectionNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // uBoxNumericUpDown
            // 
            this.uBoxNumericUpDown.Location = new System.Drawing.Point(37, 14);
            this.uBoxNumericUpDown.Name = "uBoxNumericUpDown";
            this.uBoxNumericUpDown.Size = new System.Drawing.Size(31, 20);
            this.uBoxNumericUpDown.TabIndex = 21;
            this.uBoxNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(340, 13);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(74, 45);
            this.updateButton.TabIndex = 20;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // uKeyLabel
            // 
            this.uKeyLabel.AutoSize = true;
            this.uKeyLabel.Location = new System.Drawing.Point(181, 16);
            this.uKeyLabel.Name = "uKeyLabel";
            this.uKeyLabel.Size = new System.Drawing.Size(25, 13);
            this.uKeyLabel.TabIndex = 18;
            this.uKeyLabel.Text = "Key";
            // 
            // uSectionLabel
            // 
            this.uSectionLabel.AutoSize = true;
            this.uSectionLabel.Location = new System.Drawing.Point(79, 16);
            this.uSectionLabel.Name = "uSectionLabel";
            this.uSectionLabel.Size = new System.Drawing.Size(43, 13);
            this.uSectionLabel.TabIndex = 16;
            this.uSectionLabel.Text = "Section";
            // 
            // uBoxLabel
            // 
            this.uBoxLabel.AutoSize = true;
            this.uBoxLabel.Location = new System.Drawing.Point(6, 16);
            this.uBoxLabel.Name = "uBoxLabel";
            this.uBoxLabel.Size = new System.Drawing.Size(25, 13);
            this.uBoxLabel.TabIndex = 14;
            this.uBoxLabel.Text = "Box";
            // 
            // uValueTextBox
            // 
            this.uValueTextBox.Location = new System.Drawing.Point(37, 38);
            this.uValueTextBox.Multiline = true;
            this.uValueTextBox.Name = "uValueTextBox";
            this.uValueTextBox.Size = new System.Drawing.Size(108, 20);
            this.uValueTextBox.TabIndex = 25;
            // 
            // uValueLabel
            // 
            this.uValueLabel.AutoSize = true;
            this.uValueLabel.Location = new System.Drawing.Point(6, 41);
            this.uValueLabel.Name = "uValueLabel";
            this.uValueLabel.Size = new System.Drawing.Size(34, 13);
            this.uValueLabel.TabIndex = 24;
            this.uValueLabel.Text = "Value";
            // 
            // uDescTextBox
            // 
            this.uDescTextBox.Location = new System.Drawing.Point(212, 38);
            this.uDescTextBox.Multiline = true;
            this.uDescTextBox.Name = "uDescTextBox";
            this.uDescTextBox.Size = new System.Drawing.Size(122, 20);
            this.uDescTextBox.TabIndex = 27;
            // 
            // uDescLabel
            // 
            this.uDescLabel.AutoSize = true;
            this.uDescLabel.Location = new System.Drawing.Point(151, 41);
            this.uDescLabel.Name = "uDescLabel";
            this.uDescLabel.Size = new System.Drawing.Size(60, 13);
            this.uDescLabel.TabIndex = 26;
            this.uDescLabel.Text = "Description";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateGroupBox);
            this.Controls.Add(this.updateBoxesButton);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.deleteGroupBox);
            this.Controls.Add(this.createGroupBox);
            this.Controls.Add(this.allInSectionGroupBox);
            this.Controls.Add(this.boxesGroupBox);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.PersianDate);
            this.Controls.Add(this.EnglishDate);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.boxesGroupBox.ResumeLayout(false);
            this.allInSectionGroupBox.ResumeLayout(false);
            this.createGroupBox.ResumeLayout(false);
            this.createGroupBox.PerformLayout();
            this.deleteGroupBox.ResumeLayout(false);
            this.deleteGroupBox.PerformLayout();
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dBoxNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSectionNumericUpDown)).EndInit();
            this.updateGroupBox.ResumeLayout(false);
            this.updateGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uSectionNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBoxNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnglishDate;
        private System.Windows.Forms.Label PersianDate;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.GroupBox boxesGroupBox;
        private System.Windows.Forms.TreeView Boxes;
        private GroupBox allInSectionGroupBox;
        private ListBox allInSectionListBox;
        private GroupBox createGroupBox;
        private GroupBox deleteGroupBox;
        private GroupBox viewGroupBox;
        private Label DescLabel;
        private Button showValueButton;
        private TextBox valueTextBox;
        private Label valueLabel;
        private TextBox keyTextBox;
        private Label keyLabel;
        private TextBox descTextBox;
        private Button wrongAnswerButton;
        private Button currectAnswerButton;
        private Button updateBoxesButton;
        private ImageList imageList;
        private Button createButton;
        private TextBox cDescTextBox;
        private Label cDescLabel;
        private TextBox cValueTextBox;
        private Label cValueLabel;
        private TextBox cKeyTextBox;
        private Label cKeyLabel;
        private TextBox dKeyTextBox;
        private NumericUpDown dSectionNumericUpDown;
        private NumericUpDown dBoxNumericUpDown;
        private Button deleteButton;
        private Label dKeyLabel;
        private Label dSectionLabel;
        private Label dBoxLabel;
        private GroupBox updateGroupBox;
        private TextBox uKeyTextBox;
        private NumericUpDown uSectionNumericUpDown;
        private NumericUpDown uBoxNumericUpDown;
        private Button updateButton;
        private Label uKeyLabel;
        private Label uSectionLabel;
        private Label uBoxLabel;
        private TextBox uDescTextBox;
        private Label uDescLabel;
        private TextBox uValueTextBox;
        private Label uValueLabel;
    }
}