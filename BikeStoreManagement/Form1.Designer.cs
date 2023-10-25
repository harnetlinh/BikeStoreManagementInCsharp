namespace BikeStoreManagement
{
    partial class Form1
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
            FirstName = new Label();
            LastName = new Label();
            City = new Label();
            Street = new Label();
            Email = new Label();
            Phone = new Label();
            tbFirstName = new TextBox();
            tbStreet = new TextBox();
            tbEmail = new TextBox();
            tbPhone = new TextBox();
            tbLastName = new TextBox();
            tbCity = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            dgv = new DataGridView();
            State = new Label();
            tbState = new TextBox();
            tbZipCode = new TextBox();
            label1 = new Label();
            lbChoosenId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(39, 79);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(122, 32);
            FirstName.TabIndex = 0;
            FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            LastName.AutoSize = true;
            LastName.Location = new Point(42, 142);
            LastName.Name = "LastName";
            LastName.Size = new Size(119, 32);
            LastName.TabIndex = 1;
            LastName.Text = "LastName";
            // 
            // City
            // 
            City.AutoSize = true;
            City.Location = new Point(44, 396);
            City.Name = "City";
            City.Size = new Size(55, 32);
            City.TabIndex = 2;
            City.Text = "City";
            // 
            // Street
            // 
            Street.AutoSize = true;
            Street.Location = new Point(42, 329);
            Street.Name = "Street";
            Street.Size = new Size(76, 32);
            Street.TabIndex = 3;
            Street.Text = "Street";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Location = new Point(44, 260);
            Email.Name = "Email";
            Email.Size = new Size(71, 32);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // Phone
            // 
            Phone.AutoSize = true;
            Phone.Location = new Point(42, 204);
            Phone.Name = "Phone";
            Phone.Size = new Size(82, 32);
            Phone.TabIndex = 5;
            Phone.Text = "Phone";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(209, 79);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(200, 39);
            tbFirstName.TabIndex = 6;
            // 
            // tbStreet
            // 
            tbStreet.Location = new Point(209, 326);
            tbStreet.Name = "tbStreet";
            tbStreet.Size = new Size(200, 39);
            tbStreet.TabIndex = 7;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(209, 260);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(200, 39);
            tbEmail.TabIndex = 8;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(209, 197);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(200, 39);
            tbPhone.TabIndex = 9;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(209, 142);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(200, 39);
            tbLastName.TabIndex = 10;
            // 
            // tbCity
            // 
            tbCity.Location = new Point(209, 389);
            tbCity.Name = "tbCity";
            tbCity.Size = new Size(200, 39);
            tbCity.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 46);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(39, 562);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(485, 46);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(389, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(209, 12);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(150, 46);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(565, 112);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 82;
            dgv.RowTemplate.Height = 41;
            dgv.Size = new Size(850, 496);
            dgv.TabIndex = 16;
            dgv.CellClick += dgv_CellClick;
            // 
            // State
            // 
            State.AutoSize = true;
            State.Location = new Point(44, 456);
            State.Name = "State";
            State.Size = new Size(67, 32);
            State.TabIndex = 17;
            State.Text = "State";
            // 
            // tbState
            // 
            tbState.Location = new Point(209, 449);
            tbState.Name = "tbState";
            tbState.Size = new Size(200, 39);
            tbState.TabIndex = 18;
            // 
            // tbZipCode
            // 
            tbZipCode.Location = new Point(209, 517);
            tbZipCode.Name = "tbZipCode";
            tbZipCode.Size = new Size(200, 39);
            tbZipCode.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 517);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 20;
            label1.Text = "Zip Code";
            // 
            // lbChoosenId
            // 
            lbChoosenId.AutoSize = true;
            lbChoosenId.Location = new Point(915, 42);
            lbChoosenId.Name = "lbChoosenId";
            lbChoosenId.Size = new Size(0, 32);
            lbChoosenId.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1427, 620);
            Controls.Add(lbChoosenId);
            Controls.Add(label1);
            Controls.Add(tbZipCode);
            Controls.Add(tbState);
            Controls.Add(State);
            Controls.Add(dgv);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(tbCity);
            Controls.Add(tbLastName);
            Controls.Add(tbPhone);
            Controls.Add(tbEmail);
            Controls.Add(tbStreet);
            Controls.Add(tbFirstName);
            Controls.Add(Phone);
            Controls.Add(Email);
            Controls.Add(Street);
            Controls.Add(City);
            Controls.Add(LastName);
            Controls.Add(FirstName);
            Name = "Form1";
            Text = "Customer Management";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FirstName;
        private Label LastName;
        private Label City;
        private Label Street;
        private Label Email;
        private Label Phone;
        private TextBox tbFirstName;
        private TextBox tbStreet;
        private TextBox tbEmail;
        private TextBox tbPhone;
        private TextBox tbLastName;
        private TextBox tbCity;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDelete;
        private Button btnEdit;
        private DataGridView dgv;
        private Label State;
        private TextBox tbState;
        private TextBox tbZipCode;
        private Label label1;
        private Label lbChoosenId;
    }
}