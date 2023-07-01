namespace EContact
{
    partial class EContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EContact));
            pictureBoxLogo = new PictureBox();
            lblContactID = new Label();
            txtBoxContactID = new TextBox();
            txtBoxFirstName = new TextBox();
            lblFirstName = new Label();
            txtBoxLastName = new TextBox();
            lblLastName = new Label();
            txtBoxContactNumber = new TextBox();
            lblContactNumber = new Label();
            txtBoxAddress = new TextBox();
            lblAddress = new Label();
            cmboxGender = new ComboBox();
            lblGender = new Label();
            txtBoxSearch = new TextBox();
            lblSearch = new Label();
            dgvTableList = new DataGridView();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            pictureBoxCloseWindow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTableList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseWindow).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.Transparent;
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(472, 13);
            pictureBoxLogo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(361, 129);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // lblContactID
            // 
            lblContactID.AutoSize = true;
            lblContactID.BackColor = Color.Transparent;
            lblContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactID.Location = new Point(45, 184);
            lblContactID.Name = "lblContactID";
            lblContactID.Size = new Size(104, 28);
            lblContactID.TabIndex = 1;
            lblContactID.Text = "Contact ID";
            lblContactID.Click += label1_Click;
            // 
            // txtBoxContactID
            // 
            txtBoxContactID.BackColor = Color.LightGray;
            txtBoxContactID.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContactID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxContactID.Location = new Point(189, 184);
            txtBoxContactID.Margin = new Padding(3, 4, 3, 4);
            txtBoxContactID.Name = "txtBoxContactID";
            txtBoxContactID.ReadOnly = true;
            txtBoxContactID.Size = new Size(321, 34);
            txtBoxContactID.TabIndex = 2;
            // 
            // txtBoxFirstName
            // 
            txtBoxFirstName.BackColor = SystemColors.Window;
            txtBoxFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxFirstName.Location = new Point(189, 255);
            txtBoxFirstName.Margin = new Padding(3, 4, 3, 4);
            txtBoxFirstName.Name = "txtBoxFirstName";
            txtBoxFirstName.Size = new Size(321, 34);
            txtBoxFirstName.TabIndex = 4;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.Transparent;
            lblFirstName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFirstName.Location = new Point(45, 255);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(106, 28);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name";
            lblFirstName.Click += label1_Click_1;
            // 
            // txtBoxLastName
            // 
            txtBoxLastName.BackColor = SystemColors.Window;
            txtBoxLastName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxLastName.Location = new Point(189, 320);
            txtBoxLastName.Margin = new Padding(3, 4, 3, 4);
            txtBoxLastName.Name = "txtBoxLastName";
            txtBoxLastName.Size = new Size(321, 34);
            txtBoxLastName.TabIndex = 6;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.Transparent;
            lblLastName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastName.Location = new Point(46, 320);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(103, 28);
            lblLastName.TabIndex = 5;
            lblLastName.Text = "Last Name";
            lblLastName.Click += label2_Click;
            // 
            // txtBoxContactNumber
            // 
            txtBoxContactNumber.BackColor = SystemColors.Window;
            txtBoxContactNumber.BorderStyle = BorderStyle.FixedSingle;
            txtBoxContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxContactNumber.Location = new Point(189, 391);
            txtBoxContactNumber.Margin = new Padding(3, 4, 3, 4);
            txtBoxContactNumber.Name = "txtBoxContactNumber";
            txtBoxContactNumber.Size = new Size(321, 34);
            txtBoxContactNumber.TabIndex = 8;
            // 
            // lblContactNumber
            // 
            lblContactNumber.AutoSize = true;
            lblContactNumber.BackColor = Color.Transparent;
            lblContactNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContactNumber.Location = new Point(45, 391);
            lblContactNumber.Name = "lblContactNumber";
            lblContactNumber.Size = new Size(116, 28);
            lblContactNumber.TabIndex = 7;
            lblContactNumber.Text = "Contact No.";
            // 
            // txtBoxAddress
            // 
            txtBoxAddress.BackColor = SystemColors.Window;
            txtBoxAddress.BorderStyle = BorderStyle.FixedSingle;
            txtBoxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxAddress.Location = new Point(189, 458);
            txtBoxAddress.Margin = new Padding(3, 4, 3, 4);
            txtBoxAddress.Multiline = true;
            txtBoxAddress.Name = "txtBoxAddress";
            txtBoxAddress.Size = new Size(321, 164);
            txtBoxAddress.TabIndex = 10;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.Location = new Point(46, 458);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address";
            // 
            // cmboxGender
            // 
            cmboxGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmboxGender.FormattingEnabled = true;
            cmboxGender.Items.AddRange(new object[] { "Male", "Female" });
            cmboxGender.Location = new Point(190, 645);
            cmboxGender.Name = "cmboxGender";
            cmboxGender.Size = new Size(320, 36);
            cmboxGender.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.BackColor = Color.Transparent;
            lblGender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGender.Location = new Point(46, 645);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(76, 28);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.BackColor = SystemColors.Window;
            txtBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            txtBoxSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxSearch.Location = new Point(663, 184);
            txtBoxSearch.Margin = new Padding(3, 4, 3, 4);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(548, 34);
            txtBoxSearch.TabIndex = 18;
            txtBoxSearch.TextChanged += txtBoxSearch_TextChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.Transparent;
            lblSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearch.Location = new Point(587, 184);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(70, 28);
            lblSearch.TabIndex = 17;
            lblSearch.Text = "Search";
            // 
            // dgvTableList
            // 
            dgvTableList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableList.Location = new Point(587, 247);
            dgvTableList.Name = "dgvTableList";
            dgvTableList.RowHeadersWidth = 51;
            dgvTableList.RowTemplate.Height = 29;
            dgvTableList.Size = new Size(624, 426);
            dgvTableList.TabIndex = 22;
            dgvTableList.CellContentClick += dgvTableList_CellContentClick;
            dgvTableList.RowHeaderMouseClick += dgvTableList_RowHeaderMouseClick;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Goldenrod;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(779, 706);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(156, 50);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Crimson;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(587, 706);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 50);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.CornflowerBlue;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(387, 706);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(156, 50);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(190, 706);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 50);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // pictureBoxCloseWindow
            // 
            pictureBoxCloseWindow.Image = (Image)resources.GetObject("pictureBoxCloseWindow.Image");
            pictureBoxCloseWindow.Location = new Point(1203, 0);
            pictureBoxCloseWindow.Name = "pictureBoxCloseWindow";
            pictureBoxCloseWindow.Size = new Size(48, 47);
            pictureBoxCloseWindow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCloseWindow.TabIndex = 27;
            pictureBoxCloseWindow.TabStop = false;
            pictureBoxCloseWindow.Click += pictureBoxCloseWindow_Click;
            // 
            // EContact
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1251, 795);
            Controls.Add(pictureBoxCloseWindow);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvTableList);
            Controls.Add(txtBoxSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblGender);
            Controls.Add(cmboxGender);
            Controls.Add(txtBoxAddress);
            Controls.Add(lblAddress);
            Controls.Add(txtBoxContactNumber);
            Controls.Add(lblContactNumber);
            Controls.Add(txtBoxLastName);
            Controls.Add(lblLastName);
            Controls.Add(txtBoxFirstName);
            Controls.Add(lblFirstName);
            Controls.Add(txtBoxContactID);
            Controls.Add(lblContactID);
            Controls.Add(pictureBoxLogo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "EContact";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EContact";
            Load += EContact_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTableList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCloseWindow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxLogo;
        private Label lblContactID;
        private TextBox txtBoxContactID;
        private TextBox txtBoxFirstName;
        private Label lblFirstName;
        private TextBox txtBoxLastName;
        private Label lblLastName;
        private TextBox txtBoxContactNumber;
        private Label lblContactNumber;
        private TextBox txtBoxAddress;
        private Label lblAddress;
        private ComboBox cmboxGender;
        private Label lblGender;
        private TextBox txtBoxSearch;
        private Label lblSearch;
        private DataGridView dgvTableList;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private PictureBox pictureBoxCloseWindow;
    }
}