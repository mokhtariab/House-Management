namespace HouseManagement_Prj
{
    partial class UserPassWeb_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPassWeb_frm));
            this.button_OK = new DevComponents.DotNetBar.ButtonX();
            this.button_Cancel = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel_EnterPass = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label_ExpChargeDate = new DevComponents.DotNetBar.LabelX();
            this.label_LastChargeDate = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel_NewPass = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.pictureBox_Pass = new System.Windows.Forms.PictureBox();
            this.checkBox_SaveCodePass = new System.Windows.Forms.CheckBox();
            this.textBox_AgencyPass = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBox_AgencyCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX_NewPass = new DevComponents.DotNetBar.LabelX();
            this.labelX_PrePass = new DevComponents.DotNetBar.LabelX();
            this.groupPanel_EnterPass.SuspendLayout();
            this.groupPanel_NewPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).BeginInit();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_OK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_OK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_OK.ForeColor = System.Drawing.Color.Black;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.Location = new System.Drawing.Point(170, 168);
            this.button_OK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_OK.Name = "button_OK";
            this.button_OK.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F2);
            this.button_OK.Size = new System.Drawing.Size(122, 24);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "تایید";
            this.button_OK.Tooltip = "F2";
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_Cancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.ForeColor = System.Drawing.Color.Black;
            this.button_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("button_Cancel.Image")));
            this.button_Cancel.Location = new System.Drawing.Point(42, 168);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(122, 24);
            this.button_Cancel.TabIndex = 2;
            this.button_Cancel.Text = "انصراف";
            this.button_Cancel.Tooltip = "Esc";
            // 
            // groupPanel_EnterPass
            // 
            this.groupPanel_EnterPass.CanvasColor = System.Drawing.Color.Empty;
            this.groupPanel_EnterPass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_EnterPass.Controls.Add(this.label_ExpChargeDate);
            this.groupPanel_EnterPass.Controls.Add(this.label_LastChargeDate);
            this.groupPanel_EnterPass.Controls.Add(this.labelX1);
            this.groupPanel_EnterPass.Controls.Add(this.labelX3);
            this.groupPanel_EnterPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_EnterPass.Location = new System.Drawing.Point(0, 0);
            this.groupPanel_EnterPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_EnterPass.Name = "groupPanel_EnterPass";
            this.groupPanel_EnterPass.Size = new System.Drawing.Size(334, 64);
            // 
            // 
            // 
            this.groupPanel_EnterPass.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupPanel_EnterPass.Style.BackColor2 = System.Drawing.SystemColors.ButtonHighlight;
            this.groupPanel_EnterPass.Style.BackColorGradientAngle = 90;
            this.groupPanel_EnterPass.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderBottomWidth = 1;
            this.groupPanel_EnterPass.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_EnterPass.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderLeftWidth = 1;
            this.groupPanel_EnterPass.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderRightWidth = 1;
            this.groupPanel_EnterPass.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_EnterPass.Style.BorderTopWidth = 1;
            this.groupPanel_EnterPass.Style.CornerDiameter = 4;
            this.groupPanel_EnterPass.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_EnterPass.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_EnterPass.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_EnterPass.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_EnterPass.TabIndex = 7;
            // 
            // label_ExpChargeDate
            // 
            this.label_ExpChargeDate.BackColor = System.Drawing.Color.Transparent;
            this.label_ExpChargeDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_ExpChargeDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.label_ExpChargeDate.Location = new System.Drawing.Point(39, 28);
            this.label_ExpChargeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_ExpChargeDate.Name = "label_ExpChargeDate";
            this.label_ExpChargeDate.Size = new System.Drawing.Size(110, 22);
            this.label_ExpChargeDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.label_ExpChargeDate.TabIndex = 15;
            this.label_ExpChargeDate.Text = "تاریخ تمدید";
            this.label_ExpChargeDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // label_LastChargeDate
            // 
            this.label_LastChargeDate.BackColor = System.Drawing.Color.Transparent;
            this.label_LastChargeDate.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label_LastChargeDate.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label_LastChargeDate.Location = new System.Drawing.Point(177, 28);
            this.label_LastChargeDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.label_LastChargeDate.Name = "label_LastChargeDate";
            this.label_LastChargeDate.Size = new System.Drawing.Size(124, 22);
            this.label_LastChargeDate.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.label_LastChargeDate.TabIndex = 14;
            this.label_LastChargeDate.Text = "تاریخ آخرین شارژ";
            this.label_LastChargeDate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX1.ForeColor = System.Drawing.Color.Maroon;
            this.labelX1.Location = new System.Drawing.Point(42, 4);
            this.labelX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(107, 22);
            this.labelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "تمدید تا تاریخ:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Font = new System.Drawing.Font("Tahoma", 10.18868F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX3.ForeColor = System.Drawing.Color.Maroon;
            this.labelX3.Location = new System.Drawing.Point(178, 4);
            this.labelX3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(107, 22);
            this.labelX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "تاریخ آخرین شارژ:";
            this.labelX3.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // groupPanel_NewPass
            // 
            this.groupPanel_NewPass.CanvasColor = System.Drawing.Color.Empty;
            this.groupPanel_NewPass.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel_NewPass.Controls.Add(this.pictureBox_Pass);
            this.groupPanel_NewPass.Controls.Add(this.checkBox_SaveCodePass);
            this.groupPanel_NewPass.Controls.Add(this.textBox_AgencyPass);
            this.groupPanel_NewPass.Controls.Add(this.textBox_AgencyCode);
            this.groupPanel_NewPass.Controls.Add(this.labelX_NewPass);
            this.groupPanel_NewPass.Controls.Add(this.labelX_PrePass);
            this.groupPanel_NewPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel_NewPass.Location = new System.Drawing.Point(0, 64);
            this.groupPanel_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupPanel_NewPass.Name = "groupPanel_NewPass";
            this.groupPanel_NewPass.Size = new System.Drawing.Size(334, 95);
            // 
            // 
            // 
            this.groupPanel_NewPass.Style.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupPanel_NewPass.Style.BackColor2 = System.Drawing.SystemColors.Menu;
            this.groupPanel_NewPass.Style.BackColorGradientAngle = 90;
            this.groupPanel_NewPass.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_NewPass.Style.BorderBottomWidth = 1;
            this.groupPanel_NewPass.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel_NewPass.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_NewPass.Style.BorderLeftWidth = 1;
            this.groupPanel_NewPass.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_NewPass.Style.BorderRightWidth = 1;
            this.groupPanel_NewPass.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel_NewPass.Style.BorderTopWidth = 1;
            this.groupPanel_NewPass.Style.CornerDiameter = 4;
            this.groupPanel_NewPass.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel_NewPass.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel_NewPass.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel_NewPass.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel_NewPass.TabIndex = 0;
            // 
            // pictureBox_Pass
            // 
            this.pictureBox_Pass.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Pass.Image")));
            this.pictureBox_Pass.Location = new System.Drawing.Point(19, 40);
            this.pictureBox_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Pass.Name = "pictureBox_Pass";
            this.pictureBox_Pass.Size = new System.Drawing.Size(29, 25);
            this.pictureBox_Pass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Pass.TabIndex = 19;
            this.pictureBox_Pass.TabStop = false;
            // 
            // checkBox_SaveCodePass
            // 
            this.checkBox_SaveCodePass.AutoSize = true;
            this.checkBox_SaveCodePass.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_SaveCodePass.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_SaveCodePass.Location = new System.Drawing.Point(122, 71);
            this.checkBox_SaveCodePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox_SaveCodePass.Name = "checkBox_SaveCodePass";
            this.checkBox_SaveCodePass.Size = new System.Drawing.Size(120, 17);
            this.checkBox_SaveCodePass.TabIndex = 2;
            this.checkBox_SaveCodePass.Text = "کد و رمز ذخیره شوند";
            this.checkBox_SaveCodePass.UseVisualStyleBackColor = false;
            // 
            // textBox_AgencyPass
            // 
            // 
            // 
            // 
            this.textBox_AgencyPass.Border.Class = "TextBoxBorder";
            this.textBox_AgencyPass.Location = new System.Drawing.Point(55, 41);
            this.textBox_AgencyPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgencyPass.Name = "textBox_AgencyPass";
            this.textBox_AgencyPass.PasswordChar = '*';
            this.textBox_AgencyPass.Size = new System.Drawing.Size(172, 22);
            this.textBox_AgencyPass.TabIndex = 1;
            // 
            // textBox_AgencyCode
            // 
            // 
            // 
            // 
            this.textBox_AgencyCode.Border.Class = "TextBoxBorder";
            this.textBox_AgencyCode.Location = new System.Drawing.Point(55, 10);
            this.textBox_AgencyCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_AgencyCode.Name = "textBox_AgencyCode";
            this.textBox_AgencyCode.Size = new System.Drawing.Size(172, 22);
            this.textBox_AgencyCode.TabIndex = 0;
            // 
            // labelX_NewPass
            // 
            this.labelX_NewPass.BackColor = System.Drawing.Color.Transparent;
            this.labelX_NewPass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_NewPass.ForeColor = System.Drawing.Color.Black;
            this.labelX_NewPass.Location = new System.Drawing.Point(233, 40);
            this.labelX_NewPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_NewPass.Name = "labelX_NewPass";
            this.labelX_NewPass.Size = new System.Drawing.Size(56, 22);
            this.labelX_NewPass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_NewPass.TabIndex = 17;
            this.labelX_NewPass.Text = "رمز ورود:";
            // 
            // labelX_PrePass
            // 
            this.labelX_PrePass.BackColor = System.Drawing.Color.Transparent;
            this.labelX_PrePass.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX_PrePass.ForeColor = System.Drawing.Color.Black;
            this.labelX_PrePass.Location = new System.Drawing.Point(233, 9);
            this.labelX_PrePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelX_PrePass.Name = "labelX_PrePass";
            this.labelX_PrePass.Size = new System.Drawing.Size(57, 22);
            this.labelX_PrePass.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.labelX_PrePass.TabIndex = 12;
            this.labelX_PrePass.Text = "کد آژانس:";
            // 
            // UserPassWeb_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 202);
            this.Controls.Add(this.groupPanel_NewPass);
            this.Controls.Add(this.groupPanel_EnterPass);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Cancel);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserPassWeb_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سایت";
            this.Load += new System.EventHandler(this.UserPassWeb_frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UserPassWeb_frm_KeyDown);
            this.groupPanel_EnterPass.ResumeLayout(false);
            this.groupPanel_NewPass.ResumeLayout(false);
            this.groupPanel_NewPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Pass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX_NewPass;
        private DevComponents.DotNetBar.LabelX labelX_PrePass;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX label_ExpChargeDate;
        private DevComponents.DotNetBar.LabelX label_LastChargeDate;
        private System.Windows.Forms.CheckBox checkBox_SaveCodePass;
        private System.Windows.Forms.PictureBox pictureBox_Pass;
        private DevComponents.DotNetBar.ButtonX button_OK;
        private DevComponents.DotNetBar.ButtonX button_Cancel;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_EnterPass;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel_NewPass;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgencyPass;
        private DevComponents.DotNetBar.Controls.TextBoxX textBox_AgencyCode;
    }
}