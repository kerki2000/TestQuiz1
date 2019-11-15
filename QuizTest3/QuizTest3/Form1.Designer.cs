namespace QuizTest3
{
    partial class frmCarWash
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
            this.radioOwner = new System.Windows.Forms.RadioButton();
            this.groupCar = new System.Windows.Forms.GroupBox();
            this.groupOwner = new System.Windows.Forms.GroupBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.groupCar.SuspendLayout();
            this.groupOwner.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioOwner
            // 
            this.radioOwner.AutoSize = true;
            this.radioOwner.Location = new System.Drawing.Point(744, 99);
            this.radioOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioOwner.Name = "radioOwner";
            this.radioOwner.Size = new System.Drawing.Size(69, 20);
            this.radioOwner.TabIndex = 1;
            this.radioOwner.TabStop = true;
            this.radioOwner.Text = "Owner";
            this.radioOwner.UseVisualStyleBackColor = true;
            this.radioOwner.CheckedChanged += new System.EventHandler(this.radioOwner_CheckedChanged);
            // 
            // groupCar
            // 
            this.groupCar.Controls.Add(this.cmbYear);
            this.groupCar.Controls.Add(this.cmbModel);
            this.groupCar.Controls.Add(this.cmbMake);
            this.groupCar.Controls.Add(this.lblYear);
            this.groupCar.Controls.Add(this.lblModel);
            this.groupCar.Controls.Add(this.lblMake);
            this.groupCar.Location = new System.Drawing.Point(104, 145);
            this.groupCar.Name = "groupCar";
            this.groupCar.Size = new System.Drawing.Size(358, 307);
            this.groupCar.TabIndex = 2;
            this.groupCar.TabStop = false;
            this.groupCar.Text = "Car Registration";
            // 
            // groupOwner
            // 
            this.groupOwner.Controls.Add(this.txtPhone);
            this.groupOwner.Controls.Add(this.txtLastName);
            this.groupOwner.Controls.Add(this.txtFirstName);
            this.groupOwner.Controls.Add(this.lblPhone);
            this.groupOwner.Controls.Add(this.lblLastName);
            this.groupOwner.Controls.Add(this.lblFirstName);
            this.groupOwner.Location = new System.Drawing.Point(554, 145);
            this.groupOwner.Name = "groupOwner";
            this.groupOwner.Size = new System.Drawing.Size(349, 292);
            this.groupOwner.TabIndex = 3;
            this.groupOwner.TabStop = false;
            this.groupOwner.Text = "Owner";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(74, 46);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 16);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(69, 135);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(51, 16);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(79, 232);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(41, 16);
            this.lblYear.TabIndex = 2;
            this.lblYear.Text = "Year";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(50, 55);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(83, 16);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(50, 138);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(82, 16);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(80, 242);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 16);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone";
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(179, 43);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(121, 24);
            this.cmbMake.TabIndex = 3;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(179, 127);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 4;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(179, 224);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 5;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(190, 49);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(190, 132);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 22);
            this.txtLastName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(190, 236);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPhone.TabIndex = 5;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(283, 492);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(167, 42);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(580, 492);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(145, 42);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(283, 99);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(50, 20);
            this.radioCar.TabIndex = 6;
            this.radioCar.TabStop = true;
            this.radioCar.Text = "Car";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.radioCar_CheckedChanged);
            // 
            // frmCarWash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 593);
            this.Controls.Add(this.radioCar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupOwner);
            this.Controls.Add(this.groupCar);
            this.Controls.Add(this.radioOwner);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCarWash";
            this.Text = "Carwash System";
            this.Load += new System.EventHandler(this.frmCarWash_Load);
            this.groupCar.ResumeLayout(false);
            this.groupCar.PerformLayout();
            this.groupOwner.ResumeLayout(false);
            this.groupOwner.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioOwner;
        private System.Windows.Forms.GroupBox groupCar;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.GroupBox groupOwner;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton radioCar;
    }
}

