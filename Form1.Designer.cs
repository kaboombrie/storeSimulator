namespace Week8
{
    partial class assignment8a
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
            this.NinaDesign = new System.Windows.Forms.Label();
            this.SelectCookies = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.cookieType = new System.Windows.Forms.Panel();
            this.omrDzn = new System.Windows.Forms.Label();
            this.sdDzn = new System.Windows.Forms.Label();
            this.ccDzn = new System.Windows.Forms.Label();
            this.omr = new System.Windows.Forms.RadioButton();
            this.sd = new System.Windows.Forms.RadioButton();
            this.cc = new System.Windows.Forms.RadioButton();
            this.ppDzn = new System.Windows.Forms.Label();
            this.cookie = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.displayCost = new System.Windows.Forms.Label();
            this.fnlCost = new System.Windows.Forms.Label();
            this.threeDzn = new System.Windows.Forms.RadioButton();
            this.twoDzn = new System.Windows.Forms.RadioButton();
            this.oneDzn = new System.Windows.Forms.RadioButton();
            this.halfDzn = new System.Windows.Forms.RadioButton();
            this.quantity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.delvDate = new System.Windows.Forms.Label();
            this.eta = new System.Windows.Forms.Label();
            this.ordr = new System.Windows.Forms.Label();
            this.orderCalendar = new System.Windows.Forms.MonthCalendar();
            this.cookieType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NinaDesign
            // 
            this.NinaDesign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NinaDesign.AutoSize = true;
            this.NinaDesign.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NinaDesign.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NinaDesign.Location = new System.Drawing.Point(221, 19);
            this.NinaDesign.Name = "NinaDesign";
            this.NinaDesign.Size = new System.Drawing.Size(553, 38);
            this.NinaDesign.TabIndex = 0;
            this.NinaDesign.Text = "Welcome to Nina\'s Cookie Source!";
            this.NinaDesign.Click += new System.EventHandler(this.label1_Click);
            // 
            // SelectCookies
            // 
            this.SelectCookies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SelectCookies.AutoSize = true;
            this.SelectCookies.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectCookies.Location = new System.Drawing.Point(200, 57);
            this.SelectCookies.Name = "SelectCookies";
            this.SelectCookies.Size = new System.Drawing.Size(603, 33);
            this.SelectCookies.TabIndex = 8;
            this.SelectCookies.Text = "Please select which type of cookie you\'d like to order:";
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.Location = new System.Drawing.Point(97, 331);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(110, 35);
            this.exit.TabIndex = 21;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // cookieType
            // 
            this.cookieType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cookieType.Controls.Add(this.omrDzn);
            this.cookieType.Controls.Add(this.sdDzn);
            this.cookieType.Controls.Add(this.ccDzn);
            this.cookieType.Controls.Add(this.omr);
            this.cookieType.Controls.Add(this.sd);
            this.cookieType.Controls.Add(this.cc);
            this.cookieType.Controls.Add(this.ppDzn);
            this.cookieType.Controls.Add(this.cookie);
            this.cookieType.Location = new System.Drawing.Point(75, 110);
            this.cookieType.Name = "cookieType";
            this.cookieType.Size = new System.Drawing.Size(850, 125);
            this.cookieType.TabIndex = 22;
            // 
            // omrDzn
            // 
            this.omrDzn.AutoSize = true;
            this.omrDzn.Location = new System.Drawing.Point(682, 54);
            this.omrDzn.Name = "omrDzn";
            this.omrDzn.Size = new System.Drawing.Size(60, 23);
            this.omrDzn.TabIndex = 7;
            this.omrDzn.Text = "$3.99";
            this.omrDzn.Click += new System.EventHandler(this.label5_Click);
            // 
            // sdDzn
            // 
            this.sdDzn.AutoSize = true;
            this.sdDzn.Location = new System.Drawing.Point(497, 54);
            this.sdDzn.Name = "sdDzn";
            this.sdDzn.Size = new System.Drawing.Size(60, 23);
            this.sdDzn.TabIndex = 6;
            this.sdDzn.Text = "$5.99";
            // 
            // ccDzn
            // 
            this.ccDzn.AutoSize = true;
            this.ccDzn.Location = new System.Drawing.Point(310, 54);
            this.ccDzn.Name = "ccDzn";
            this.ccDzn.Size = new System.Drawing.Size(60, 23);
            this.ccDzn.TabIndex = 5;
            this.ccDzn.Text = "$4.99";
            // 
            // omr
            // 
            this.omr.AutoSize = true;
            this.omr.Location = new System.Drawing.Point(660, 30);
            this.omr.Name = "omr";
            this.omr.Size = new System.Drawing.Size(165, 27);
            this.omr.TabIndex = 4;
            this.omr.TabStop = true;
            this.omr.Text = "Oatmeal Raisin";
            this.omr.UseVisualStyleBackColor = true;
            this.omr.CheckedChanged += new System.EventHandler(this.omr_CheckedChanged);
            // 
            // sd
            // 
            this.sd.AutoSize = true;
            this.sd.Location = new System.Drawing.Point(475, 30);
            this.sd.Name = "sd";
            this.sd.Size = new System.Drawing.Size(155, 27);
            this.sd.TabIndex = 3;
            this.sd.TabStop = true;
            this.sd.Text = "Snickerdoodle";
            this.sd.UseVisualStyleBackColor = true;
            this.sd.CheckedChanged += new System.EventHandler(this.sd_CheckedChanged);
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(290, 30);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(164, 27);
            this.cc.TabIndex = 2;
            this.cc.TabStop = true;
            this.cc.Text = "Chocolate Chip";
            this.cc.UseVisualStyleBackColor = true;
            this.cc.CheckedChanged += new System.EventHandler(this.cc_CheckedChanged);
            // 
            // ppDzn
            // 
            this.ppDzn.AutoSize = true;
            this.ppDzn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppDzn.Location = new System.Drawing.Point(3, 53);
            this.ppDzn.Name = "ppDzn";
            this.ppDzn.Size = new System.Drawing.Size(165, 24);
            this.ppDzn.TabIndex = 1;
            this.ppDzn.Text = "Price per dozen:";
            // 
            // cookie
            // 
            this.cookie.AutoSize = true;
            this.cookie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookie.Location = new System.Drawing.Point(3, 30);
            this.cookie.Name = "cookie";
            this.cookie.Size = new System.Drawing.Size(281, 24);
            this.cookie.TabIndex = 0;
            this.cookie.Text = "Please select type of cookie:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.displayCost);
            this.panel1.Controls.Add(this.fnlCost);
            this.panel1.Controls.Add(this.threeDzn);
            this.panel1.Controls.Add(this.twoDzn);
            this.panel1.Controls.Add(this.oneDzn);
            this.panel1.Controls.Add(this.halfDzn);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Location = new System.Drawing.Point(46, 253);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 232);
            this.panel1.TabIndex = 23;
            // 
            // displayCost
            // 
            this.displayCost.AutoSize = true;
            this.displayCost.Location = new System.Drawing.Point(157, 167);
            this.displayCost.Name = "displayCost";
            this.displayCost.Size = new System.Drawing.Size(0, 23);
            this.displayCost.TabIndex = 6;
            this.displayCost.Click += new System.EventHandler(this.displayCost_Click);
            // 
            // fnlCost
            // 
            this.fnlCost.AutoSize = true;
            this.fnlCost.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnlCost.Location = new System.Drawing.Point(39, 167);
            this.fnlCost.Name = "fnlCost";
            this.fnlCost.Size = new System.Drawing.Size(112, 24);
            this.fnlCost.TabIndex = 5;
            this.fnlCost.Text = "Final Cost:";
            // 
            // threeDzn
            // 
            this.threeDzn.AutoSize = true;
            this.threeDzn.Location = new System.Drawing.Point(39, 133);
            this.threeDzn.Name = "threeDzn";
            this.threeDzn.Size = new System.Drawing.Size(103, 27);
            this.threeDzn.TabIndex = 4;
            this.threeDzn.TabStop = true;
            this.threeDzn.Text = "3 Dozen";
            this.threeDzn.UseVisualStyleBackColor = true;
            this.threeDzn.CheckedChanged += new System.EventHandler(this.threeDzn_CheckedChanged);
            // 
            // twoDzn
            // 
            this.twoDzn.AutoSize = true;
            this.twoDzn.Location = new System.Drawing.Point(39, 99);
            this.twoDzn.Name = "twoDzn";
            this.twoDzn.Size = new System.Drawing.Size(103, 27);
            this.twoDzn.TabIndex = 3;
            this.twoDzn.TabStop = true;
            this.twoDzn.Text = "2 Dozen";
            this.twoDzn.UseVisualStyleBackColor = true;
            this.twoDzn.CheckedChanged += new System.EventHandler(this.twoDzn_CheckedChanged);
            // 
            // oneDzn
            // 
            this.oneDzn.AutoSize = true;
            this.oneDzn.Location = new System.Drawing.Point(39, 65);
            this.oneDzn.Name = "oneDzn";
            this.oneDzn.Size = new System.Drawing.Size(103, 27);
            this.oneDzn.TabIndex = 2;
            this.oneDzn.TabStop = true;
            this.oneDzn.Text = "1 Dozen";
            this.oneDzn.UseVisualStyleBackColor = true;
            this.oneDzn.CheckedChanged += new System.EventHandler(this.oneDzn_CheckedChanged);
            // 
            // halfDzn
            // 
            this.halfDzn.AutoSize = true;
            this.halfDzn.Location = new System.Drawing.Point(39, 31);
            this.halfDzn.Name = "halfDzn";
            this.halfDzn.Size = new System.Drawing.Size(120, 27);
            this.halfDzn.TabIndex = 1;
            this.halfDzn.TabStop = true;
            this.halfDzn.Text = "1/2 Dozen";
            this.halfDzn.UseVisualStyleBackColor = true;
            this.halfDzn.CheckedChanged += new System.EventHandler(this.halfDzn_CheckedChanged);
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity.Location = new System.Drawing.Point(35, 4);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(224, 24);
            this.quantity.TabIndex = 0;
            this.quantity.Text = "Please select quantity:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.delvDate);
            this.panel2.Controls.Add(this.eta);
            this.panel2.Controls.Add(this.ordr);
            this.panel2.Controls.Add(this.exit);
            this.panel2.Controls.Add(this.orderCalendar);
            this.panel2.Location = new System.Drawing.Point(389, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(538, 366);
            this.panel2.TabIndex = 24;
            // 
            // delvDate
            // 
            this.delvDate.AutoSize = true;
            this.delvDate.Location = new System.Drawing.Point(25, 271);
            this.delvDate.Name = "delvDate";
            this.delvDate.Size = new System.Drawing.Size(0, 23);
            this.delvDate.TabIndex = 3;
            // 
            // eta
            // 
            this.eta.AutoSize = true;
            this.eta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eta.Location = new System.Drawing.Point(25, 247);
            this.eta.Name = "eta";
            this.eta.Size = new System.Drawing.Size(238, 24);
            this.eta.TabIndex = 2;
            this.eta.Text = "Estimated delivery date:";
            // 
            // ordr
            // 
            this.ordr.AutoSize = true;
            this.ordr.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordr.Location = new System.Drawing.Point(8, 4);
            this.ordr.Name = "ordr";
            this.ordr.Size = new System.Drawing.Size(274, 24);
            this.ordr.TabIndex = 1;
            this.ordr.Text = "Please select an order date:";
            // 
            // orderCalendar
            // 
            this.orderCalendar.Location = new System.Drawing.Point(12, 31);
            this.orderCalendar.MaxSelectionCount = 1;
            this.orderCalendar.Name = "orderCalendar";
            this.orderCalendar.TabIndex = 0;
            this.orderCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.orderCalendar_DateChanged);
            // 
            // assignment8a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cookieType);
            this.Controls.Add(this.SelectCookies);
            this.Controls.Add(this.NinaDesign);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "assignment8a";
            this.Text = "Nina\'s Cookie Source";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cookieType.ResumeLayout(false);
            this.cookieType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NinaDesign;
        private System.Windows.Forms.Label SelectCookies;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel cookieType;
        private System.Windows.Forms.Label omrDzn;
        private System.Windows.Forms.Label sdDzn;
        private System.Windows.Forms.Label ccDzn;
        private System.Windows.Forms.RadioButton omr;
        private System.Windows.Forms.RadioButton sd;
        private System.Windows.Forms.RadioButton cc;
        private System.Windows.Forms.Label ppDzn;
        private System.Windows.Forms.Label cookie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label displayCost;
        private System.Windows.Forms.Label fnlCost;
        private System.Windows.Forms.RadioButton threeDzn;
        private System.Windows.Forms.RadioButton twoDzn;
        private System.Windows.Forms.RadioButton oneDzn;
        private System.Windows.Forms.RadioButton halfDzn;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label delvDate;
        private System.Windows.Forms.Label eta;
        private System.Windows.Forms.Label ordr;
        private System.Windows.Forms.MonthCalendar orderCalendar;
    }
}

