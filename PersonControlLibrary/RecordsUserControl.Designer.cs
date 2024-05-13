namespace WorkShopControlLib
{
    partial class RecordsUserControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idText = new TextBox();
            Datetextbox = new TextBox();
            DeviceTextBox = new TextBox();
            DescTextBox = new TextBox();
            ErrorTextBox = new TextBox();
            buttonEdit = new Button();
            buttonDel = new Button();
            ClientTextBox = new TextBox();
            EMPtextbox = new TextBox();
            cmbStatus = new ComboBox();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // idText
            // 
            idText.BackColor = Color.White;
            idText.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(9, 16);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(53, 35);
            idText.TabIndex = 0;
            // 
            // Datetextbox
            // 
            Datetextbox.BackColor = Color.White;
            Datetextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Datetextbox.Location = new Point(78, 16);
            Datetextbox.Name = "Datetextbox";
            Datetextbox.ReadOnly = true;
            Datetextbox.Size = new Size(185, 35);
            Datetextbox.TabIndex = 2;
            // 
            // DeviceTextBox
            // 
            DeviceTextBox.BackColor = Color.White;
            DeviceTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeviceTextBox.Location = new Point(269, 16);
            DeviceTextBox.Name = "DeviceTextBox";
            DeviceTextBox.ReadOnly = true;
            DeviceTextBox.Size = new Size(160, 35);
            DeviceTextBox.TabIndex = 4;
            // 
            // DescTextBox
            // 
            DescTextBox.BackColor = Color.White;
            DescTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DescTextBox.Location = new Point(435, 16);
            DescTextBox.Name = "DescTextBox";
            DescTextBox.ReadOnly = true;
            DescTextBox.Size = new Size(150, 35);
            DescTextBox.TabIndex = 6;
            // 
            // ErrorTextBox
            // 
            ErrorTextBox.BackColor = Color.White;
            ErrorTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ErrorTextBox.Location = new Point(591, 16);
            ErrorTextBox.Name = "ErrorTextBox";
            ErrorTextBox.ReadOnly = true;
            ErrorTextBox.Size = new Size(136, 35);
            ErrorTextBox.TabIndex = 8;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(1176, 1);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(119, 37);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(1176, 44);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(119, 37);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // ClientTextBox
            // 
            ClientTextBox.BackColor = Color.White;
            ClientTextBox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ClientTextBox.Location = new Point(734, 16);
            ClientTextBox.Name = "ClientTextBox";
            ClientTextBox.ReadOnly = true;
            ClientTextBox.Size = new Size(130, 35);
            ClientTextBox.TabIndex = 12;
            // 
            // EMPtextbox
            // 
            EMPtextbox.BackColor = Color.White;
            EMPtextbox.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EMPtextbox.Location = new Point(872, 16);
            EMPtextbox.Name = "EMPtextbox";
            EMPtextbox.ReadOnly = true;
            EMPtextbox.Size = new Size(130, 35);
            EMPtextbox.TabIndex = 14;
            // 
            // cmbStatus
            // 
            cmbStatus.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(1009, 16);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(153, 36);
            cmbStatus.TabIndex = 21;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(9, 87);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1286, 10);
            progressBar1.TabIndex = 22;
            // 
            // RecordsUserControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(progressBar1);
            Controls.Add(cmbStatus);
            Controls.Add(EMPtextbox);
            Controls.Add(ClientTextBox);
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(ErrorTextBox);
            Controls.Add(DescTextBox);
            Controls.Add(DeviceTextBox);
            Controls.Add(Datetextbox);
            Controls.Add(idText);
            Name = "RecordsUserControl";
            Size = new Size(1298, 98);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private TextBox Datetextbox;
        private TextBox DeviceTextBox;
        private TextBox DescTextBox;
        private TextBox ErrorTextBox;
        private Button buttonEdit;
        private Button buttonDel;
        private TextBox ClientTextBox;
        private TextBox EMPtextbox;
        public ComboBox cmbStatus;
        private ProgressBar progressBar1;
    }
}