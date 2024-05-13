namespace WorkShop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            AddButton = new Button();
            RecordListLabel = new Label();
            Amounttextbox = new TextBox();
            PanelUsers = new FlowLayoutPanel();
            TimeAVG = new TextBox();
            SumAgeLabel = new Label();
            progressBar1 = new ProgressBar();
            lbID = new Label();
            lbDate = new Label();
            lbDevice = new Label();
            lbDescription = new Label();
            lbDefect = new Label();
            lbClient = new Label();
            lbEmployee = new Label();
            lbStatus = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(11, 12);
            AddButton.Margin = new Padding(2, 3, 2, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(161, 56);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += Add_button;
            // 
            // RecordListLabel
            // 
            RecordListLabel.AutoSize = true;
            RecordListLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            RecordListLabel.Location = new Point(1084, 48);
            RecordListLabel.Margin = new Padding(2, 0, 2, 0);
            RecordListLabel.Name = "RecordListLabel";
            RecordListLabel.Size = new Size(335, 28);
            RecordListLabel.TabIndex = 1;
            RecordListLabel.Text = "Количество выполненных заявок";
            // 
            // Amounttextbox
            // 
            Amounttextbox.BackColor = Color.White;
            Amounttextbox.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Amounttextbox.Location = new Point(1423, 48);
            Amounttextbox.Margin = new Padding(2, 3, 2, 3);
            Amounttextbox.Name = "Amounttextbox";
            Amounttextbox.ReadOnly = true;
            Amounttextbox.Size = new Size(70, 28);
            Amounttextbox.TabIndex = 2;
            // 
            // PanelUsers
            // 
            PanelUsers.AutoScroll = true;
            PanelUsers.BackColor = Color.White;
            PanelUsers.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            PanelUsers.Location = new Point(28, 136);
            PanelUsers.Margin = new Padding(2, 3, 2, 3);
            PanelUsers.MaximumSize = new Size(1487, 740);
            PanelUsers.Name = "PanelUsers";
            PanelUsers.Size = new Size(1487, 731);
            PanelUsers.TabIndex = 3;
            // 
            // TimeAVG
            // 
            TimeAVG.BackColor = Color.White;
            TimeAVG.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            TimeAVG.Location = new Point(1353, 2);
            TimeAVG.Margin = new Padding(2, 3, 2, 3);
            TimeAVG.Name = "TimeAVG";
            TimeAVG.ReadOnly = true;
            TimeAVG.Size = new Size(140, 28);
            TimeAVG.TabIndex = 5;
            // 
            // SumAgeLabel
            // 
            SumAgeLabel.AutoSize = true;
            SumAgeLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SumAgeLabel.Location = new Point(1069, 2);
            SumAgeLabel.Margin = new Padding(2, 0, 2, 0);
            SumAgeLabel.Name = "SumAgeLabel";
            SumAgeLabel.Size = new Size(280, 28);
            SumAgeLabel.TabIndex = 4;
            SumAgeLabel.Text = "Среднее время выполнения";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 120);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(1540, 10);
            progressBar1.TabIndex = 6;
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbID.Location = new Point(51, 86);
            lbID.Name = "lbID";
            lbID.Size = new Size(37, 28);
            lbID.TabIndex = 7;
            lbID.Text = "ID";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(177, 86);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(56, 28);
            lbDate.TabIndex = 8;
            lbDate.Text = "Дата";
            // 
            // lbDevice
            // 
            lbDevice.AutoSize = true;
            lbDevice.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDevice.Location = new Point(362, 86);
            lbDevice.Name = "lbDevice";
            lbDevice.Size = new Size(121, 28);
            lbDevice.TabIndex = 9;
            lbDevice.Text = "Устройство";
            // 
            // lbDescription
            // 
            lbDescription.AutoSize = true;
            lbDescription.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDescription.Location = new Point(547, 86);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(109, 28);
            lbDescription.TabIndex = 10;
            lbDescription.Text = "Описание";
            // 
            // lbDefect
            // 
            lbDefect.AutoSize = true;
            lbDefect.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDefect.Location = new Point(722, 86);
            lbDefect.Name = "lbDefect";
            lbDefect.Size = new Size(102, 28);
            lbDefect.TabIndex = 11;
            lbDefect.Text = "Поломка";
            // 
            // lbClient
            // 
            lbClient.AutoSize = true;
            lbClient.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbClient.Location = new Point(889, 86);
            lbClient.Name = "lbClient";
            lbClient.Size = new Size(82, 28);
            lbClient.TabIndex = 12;
            lbClient.Text = "Клиент";
            // 
            // lbEmployee
            // 
            lbEmployee.AutoSize = true;
            lbEmployee.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmployee.Location = new Point(1037, 86);
            lbEmployee.Name = "lbEmployee";
            lbEmployee.Size = new Size(112, 28);
            lbEmployee.TabIndex = 13;
            lbEmployee.Text = "Сотрудник";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatus.Location = new Point(1196, 86);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(72, 28);
            lbStatus.TabIndex = 14;
            lbStatus.Text = "Статус";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1540, 881);
            Controls.Add(lbStatus);
            Controls.Add(lbEmployee);
            Controls.Add(lbClient);
            Controls.Add(lbDefect);
            Controls.Add(lbDescription);
            Controls.Add(lbDevice);
            Controls.Add(lbDate);
            Controls.Add(lbID);
            Controls.Add(progressBar1);
            Controls.Add(TimeAVG);
            Controls.Add(SumAgeLabel);
            Controls.Add(PanelUsers);
            Controls.Add(Amounttextbox);
            Controls.Add(RecordListLabel);
            Controls.Add(AddButton);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MainForm";
            Text = "Список пользователей";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label RecordListLabel;
        private TextBox Amounttextbox;
        private FlowLayoutPanel PanelUsers;
        private TextBox TimeAVG;
        private Label SumAgeLabel;
        private ProgressBar progressBar1;
        private Label lbID;
        private Label lbDate;
        private Label lbDevice;
        private Label lbDescription;
        private Label lbDefect;
        private Label lbClient;
        private Label lbEmployee;
        private Label lbStatus;
    }
}