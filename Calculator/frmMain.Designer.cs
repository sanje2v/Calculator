namespace Calculator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblDisplay = new System.Windows.Forms.Label();
            this.panelStandard = new System.Windows.Forms.Panel();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnSquareRoot = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPercentage = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMS = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelEntry = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.panelScientific = new System.Windows.Forms.Panel();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnRoR = new System.Windows.Forms.Button();
            this.btnRoL = new System.Windows.Forms.Button();
            this.btnRsh = new System.Windows.Forms.Button();
            this.btnLsh = new System.Windows.Forms.Button();
            this.btnXOR = new System.Windows.Forms.Button();
            this.btnOR = new System.Windows.Forms.Button();
            this.btnAND = new System.Windows.Forms.Button();
            this.btnNOT = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnTensPower = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnCosInverse = new System.Windows.Forms.Button();
            this.btnSinInverse = new System.Windows.Forms.Button();
            this.btnTanInverse = new System.Windows.Forms.Button();
            this.btnePower = new System.Windows.Forms.Button();
            this.grpBase = new System.Windows.Forms.GroupBox();
            this.optBinary = new System.Windows.Forms.RadioButton();
            this.optHex = new System.Windows.Forms.RadioButton();
            this.optDecimal = new System.Windows.Forms.RadioButton();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updownHistory = new System.Windows.Forms.DomainUpDown();
            this.lblMemoryData = new System.Windows.Forms.Label();
            this.lnklblMyBlog = new System.Windows.Forms.LinkLabel();
            this.panelStandard.SuspendLayout();
            this.panelScientific.SuspendLayout();
            this.grpBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.Window;
            this.lblDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplay.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(12, 32);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(442, 37);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Text = "0";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblDisplay.UseMnemonic = false;
            this.lblDisplay.TextChanged += new System.EventHandler(this.lblDisplay_TextChanged);
            // 
            // panelStandard
            // 
            this.panelStandard.BackColor = System.Drawing.SystemColors.Control;
            this.panelStandard.Controls.Add(this.btnMod);
            this.panelStandard.Controls.Add(this.btnPi);
            this.panelStandard.Controls.Add(this.btnExp);
            this.panelStandard.Controls.Add(this.btnF);
            this.panelStandard.Controls.Add(this.btnE);
            this.panelStandard.Controls.Add(this.btnD);
            this.panelStandard.Controls.Add(this.btnC);
            this.panelStandard.Controls.Add(this.btnB);
            this.panelStandard.Controls.Add(this.btnA);
            this.panelStandard.Controls.Add(this.btnAdd);
            this.panelStandard.Controls.Add(this.btnDecimal);
            this.panelStandard.Controls.Add(this.btnMMinus);
            this.panelStandard.Controls.Add(this.btnMPlus);
            this.panelStandard.Controls.Add(this.btnSquareRoot);
            this.panelStandard.Controls.Add(this.btnPlusMinus);
            this.panelStandard.Controls.Add(this.btnPercentage);
            this.panelStandard.Controls.Add(this.btnDivide);
            this.panelStandard.Controls.Add(this.btnInverse);
            this.panelStandard.Controls.Add(this.btnMultiply);
            this.panelStandard.Controls.Add(this.btnEquals);
            this.panelStandard.Controls.Add(this.btnSubtract);
            this.panelStandard.Controls.Add(this.btnMS);
            this.panelStandard.Controls.Add(this.btnMR);
            this.panelStandard.Controls.Add(this.btnMC);
            this.panelStandard.Controls.Add(this.btnCancel);
            this.panelStandard.Controls.Add(this.btnCancelEntry);
            this.panelStandard.Controls.Add(this.btnBackspace);
            this.panelStandard.Controls.Add(this.btn9);
            this.panelStandard.Controls.Add(this.btn8);
            this.panelStandard.Controls.Add(this.btn7);
            this.panelStandard.Controls.Add(this.btn6);
            this.panelStandard.Controls.Add(this.btn5);
            this.panelStandard.Controls.Add(this.btn4);
            this.panelStandard.Controls.Add(this.btn3);
            this.panelStandard.Controls.Add(this.btn2);
            this.panelStandard.Controls.Add(this.btn1);
            this.panelStandard.Controls.Add(this.btn0);
            this.panelStandard.Location = new System.Drawing.Point(12, 98);
            this.panelStandard.Name = "panelStandard";
            this.panelStandard.Size = new System.Drawing.Size(220, 321);
            this.panelStandard.TabIndex = 3;
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMod.Location = new System.Drawing.Point(135, 83);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(38, 34);
            this.btnMod.TabIndex = 26;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPi.Location = new System.Drawing.Point(179, 83);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(38, 34);
            this.btnPi.TabIndex = 27;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExp.Location = new System.Drawing.Point(179, 43);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(38, 34);
            this.btnExp.TabIndex = 31;
            this.btnExp.Text = "e";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.btnExp_Click);
            // 
            // btnF
            // 
            this.btnF.Enabled = false;
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnF.Location = new System.Drawing.Point(91, 83);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(39, 34);
            this.btnF.TabIndex = 25;
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnF_Click);
            // 
            // btnE
            // 
            this.btnE.Enabled = false;
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnE.Location = new System.Drawing.Point(47, 83);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(38, 34);
            this.btnE.TabIndex = 24;
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnE_Click);
            // 
            // btnD
            // 
            this.btnD.Enabled = false;
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.Location = new System.Drawing.Point(3, 83);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(38, 34);
            this.btnD.TabIndex = 23;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Enabled = false;
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(91, 123);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(38, 34);
            this.btnC.TabIndex = 20;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Enabled = false;
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.Location = new System.Drawing.Point(47, 123);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(38, 34);
            this.btnB.TabIndex = 19;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Enabled = false;
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.Location = new System.Drawing.Point(3, 123);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(38, 34);
            this.btnA.TabIndex = 18;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(135, 283);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(38, 34);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecimal.Location = new System.Drawing.Point(91, 283);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(38, 34);
            this.btnDecimal.TabIndex = 1;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = true;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnMMinus
            // 
            this.btnMMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMMinus.Location = new System.Drawing.Point(179, 3);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(38, 34);
            this.btnMMinus.TabIndex = 36;
            this.btnMMinus.Text = "M-";
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.btnMMinus_Click);
            // 
            // btnMPlus
            // 
            this.btnMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMPlus.Location = new System.Drawing.Point(135, 3);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(38, 34);
            this.btnMPlus.TabIndex = 35;
            this.btnMPlus.Text = "M+";
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.btnMPlus_Click);
            // 
            // btnSquareRoot
            // 
            this.btnSquareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquareRoot.Location = new System.Drawing.Point(179, 123);
            this.btnSquareRoot.Name = "btnSquareRoot";
            this.btnSquareRoot.Size = new System.Drawing.Size(38, 34);
            this.btnSquareRoot.TabIndex = 22;
            this.btnSquareRoot.Text = "√";
            this.btnSquareRoot.UseVisualStyleBackColor = false;
            this.btnSquareRoot.Click += new System.EventHandler(this.btnSquareRoot_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(135, 123);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(38, 34);
            this.btnPlusMinus.TabIndex = 21;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // btnPercentage
            // 
            this.btnPercentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPercentage.Location = new System.Drawing.Point(179, 163);
            this.btnPercentage.Name = "btnPercentage";
            this.btnPercentage.Size = new System.Drawing.Size(38, 34);
            this.btnPercentage.TabIndex = 17;
            this.btnPercentage.Text = "%";
            this.btnPercentage.UseVisualStyleBackColor = false;
            this.btnPercentage.Click += new System.EventHandler(this.btnPercentage_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivide.Location = new System.Drawing.Point(135, 163);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(38, 34);
            this.btnDivide.TabIndex = 16;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInverse.Location = new System.Drawing.Point(179, 203);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(38, 34);
            this.btnInverse.TabIndex = 12;
            this.btnInverse.Text = "⅟ₓ";
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(135, 203);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(38, 34);
            this.btnMultiply.TabIndex = 11;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(179, 243);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(38, 74);
            this.btnEquals.TabIndex = 3;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(135, 243);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(38, 34);
            this.btnSubtract.TabIndex = 7;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMS
            // 
            this.btnMS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMS.Location = new System.Drawing.Point(91, 3);
            this.btnMS.Name = "btnMS";
            this.btnMS.Size = new System.Drawing.Size(38, 34);
            this.btnMS.TabIndex = 34;
            this.btnMS.Text = "MS";
            this.btnMS.UseVisualStyleBackColor = false;
            this.btnMS.Click += new System.EventHandler(this.btnMS_Click);
            // 
            // btnMR
            // 
            this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMR.Location = new System.Drawing.Point(47, 3);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(38, 34);
            this.btnMR.TabIndex = 33;
            this.btnMR.Text = "MR";
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.btnMR_Click);
            // 
            // btnMC
            // 
            this.btnMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMC.Location = new System.Drawing.Point(3, 3);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(38, 34);
            this.btnMC.TabIndex = 32;
            this.btnMC.Text = "MC";
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.btnMC_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(91, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 30;
            this.btnCancel.Text = "C";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelEntry
            // 
            this.btnCancelEntry.BackColor = System.Drawing.Color.Silver;
            this.btnCancelEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelEntry.Location = new System.Drawing.Point(47, 43);
            this.btnCancelEntry.Name = "btnCancelEntry";
            this.btnCancelEntry.Size = new System.Drawing.Size(39, 34);
            this.btnCancelEntry.TabIndex = 29;
            this.btnCancelEntry.Text = "CE";
            this.btnCancelEntry.UseVisualStyleBackColor = false;
            this.btnCancelEntry.Click += new System.EventHandler(this.btnCancelEntry_Click);
            // 
            // btnBackspace
            // 
            this.btnBackspace.BackColor = System.Drawing.Color.Silver;
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackspace.Location = new System.Drawing.Point(3, 43);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(39, 34);
            this.btnBackspace.TabIndex = 28;
            this.btnBackspace.Text = "←";
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(91, 163);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(38, 34);
            this.btn9.TabIndex = 15;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(47, 163);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(38, 34);
            this.btn8.TabIndex = 14;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(3, 163);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(38, 34);
            this.btn7.TabIndex = 13;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(91, 203);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(38, 34);
            this.btn6.TabIndex = 10;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(47, 203);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(38, 34);
            this.btn5.TabIndex = 9;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(3, 203);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(38, 34);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(91, 243);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(38, 34);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(47, 243);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(38, 34);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(3, 243);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(38, 34);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(3, 283);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(82, 34);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // panelScientific
            // 
            this.panelScientific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelScientific.Controls.Add(this.btnFactorial);
            this.panelScientific.Controls.Add(this.btnRoR);
            this.panelScientific.Controls.Add(this.btnRoL);
            this.panelScientific.Controls.Add(this.btnRsh);
            this.panelScientific.Controls.Add(this.btnLsh);
            this.panelScientific.Controls.Add(this.btnXOR);
            this.panelScientific.Controls.Add(this.btnOR);
            this.panelScientific.Controls.Add(this.btnAND);
            this.panelScientific.Controls.Add(this.btnNOT);
            this.panelScientific.Controls.Add(this.btnCosh);
            this.panelScientific.Controls.Add(this.btnSinh);
            this.panelScientific.Controls.Add(this.btnTanh);
            this.panelScientific.Controls.Add(this.btnTensPower);
            this.panelScientific.Controls.Add(this.btnCube);
            this.panelScientific.Controls.Add(this.btnLn);
            this.panelScientific.Controls.Add(this.btnCosInverse);
            this.panelScientific.Controls.Add(this.btnSinInverse);
            this.panelScientific.Controls.Add(this.btnTanInverse);
            this.panelScientific.Controls.Add(this.btnePower);
            this.panelScientific.Controls.Add(this.grpBase);
            this.panelScientific.Controls.Add(this.btnSquare);
            this.panelScientific.Controls.Add(this.btnCos);
            this.panelScientific.Controls.Add(this.btnSin);
            this.panelScientific.Controls.Add(this.btnLog);
            this.panelScientific.Controls.Add(this.btnTan);
            this.panelScientific.Location = new System.Drawing.Point(254, 98);
            this.panelScientific.Name = "panelScientific";
            this.panelScientific.Size = new System.Drawing.Size(206, 288);
            this.panelScientific.TabIndex = 5;
            // 
            // btnFactorial
            // 
            this.btnFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactorial.Location = new System.Drawing.Point(150, 83);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(38, 34);
            this.btnFactorial.TabIndex = 8;
            this.btnFactorial.Text = "n!";
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.btnFactorial_Click);
            // 
            // btnRoR
            // 
            this.btnRoR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoR.Enabled = false;
            this.btnRoR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoR.Location = new System.Drawing.Point(150, 243);
            this.btnRoR.Name = "btnRoR";
            this.btnRoR.Size = new System.Drawing.Size(38, 34);
            this.btnRoR.TabIndex = 24;
            this.btnRoR.Text = "RoR";
            this.btnRoR.UseVisualStyleBackColor = false;
            this.btnRoR.Click += new System.EventHandler(this.btnRoR_Click);
            // 
            // btnRoL
            // 
            this.btnRoL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRoL.Enabled = false;
            this.btnRoL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoL.Location = new System.Drawing.Point(106, 243);
            this.btnRoL.Name = "btnRoL";
            this.btnRoL.Size = new System.Drawing.Size(38, 34);
            this.btnRoL.TabIndex = 23;
            this.btnRoL.Text = "RoL";
            this.btnRoL.UseVisualStyleBackColor = false;
            this.btnRoL.Click += new System.EventHandler(this.btnRoL_Click);
            // 
            // btnRsh
            // 
            this.btnRsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRsh.Enabled = false;
            this.btnRsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRsh.Location = new System.Drawing.Point(62, 243);
            this.btnRsh.Name = "btnRsh";
            this.btnRsh.Size = new System.Drawing.Size(38, 34);
            this.btnRsh.TabIndex = 22;
            this.btnRsh.Text = "Rsh";
            this.btnRsh.UseVisualStyleBackColor = false;
            this.btnRsh.Click += new System.EventHandler(this.btnRsh_Click);
            // 
            // btnLsh
            // 
            this.btnLsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLsh.Enabled = false;
            this.btnLsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLsh.Location = new System.Drawing.Point(18, 243);
            this.btnLsh.Name = "btnLsh";
            this.btnLsh.Size = new System.Drawing.Size(38, 34);
            this.btnLsh.TabIndex = 21;
            this.btnLsh.Text = "Lsh";
            this.btnLsh.UseVisualStyleBackColor = false;
            this.btnLsh.Click += new System.EventHandler(this.btnLsh_Click);
            // 
            // btnXOR
            // 
            this.btnXOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnXOR.Enabled = false;
            this.btnXOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOR.Location = new System.Drawing.Point(150, 203);
            this.btnXOR.Name = "btnXOR";
            this.btnXOR.Size = new System.Drawing.Size(38, 34);
            this.btnXOR.TabIndex = 20;
            this.btnXOR.Text = "XOR";
            this.btnXOR.UseVisualStyleBackColor = false;
            this.btnXOR.Click += new System.EventHandler(this.btnXOR_Click);
            // 
            // btnOR
            // 
            this.btnOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnOR.Enabled = false;
            this.btnOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOR.Location = new System.Drawing.Point(62, 203);
            this.btnOR.Name = "btnOR";
            this.btnOR.Size = new System.Drawing.Size(38, 34);
            this.btnOR.TabIndex = 18;
            this.btnOR.Text = "OR";
            this.btnOR.UseVisualStyleBackColor = false;
            this.btnOR.Click += new System.EventHandler(this.btnOR_Click);
            // 
            // btnAND
            // 
            this.btnAND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAND.Enabled = false;
            this.btnAND.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAND.Location = new System.Drawing.Point(18, 203);
            this.btnAND.Name = "btnAND";
            this.btnAND.Size = new System.Drawing.Size(38, 34);
            this.btnAND.TabIndex = 17;
            this.btnAND.Text = "AND";
            this.btnAND.UseVisualStyleBackColor = false;
            this.btnAND.Click += new System.EventHandler(this.btnAND_Click);
            // 
            // btnNOT
            // 
            this.btnNOT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNOT.Enabled = false;
            this.btnNOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOT.Location = new System.Drawing.Point(106, 203);
            this.btnNOT.Name = "btnNOT";
            this.btnNOT.Size = new System.Drawing.Size(38, 34);
            this.btnNOT.TabIndex = 19;
            this.btnNOT.Text = "NOT";
            this.btnNOT.UseVisualStyleBackColor = false;
            this.btnNOT.Click += new System.EventHandler(this.btnNOT_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosh.Location = new System.Drawing.Point(62, 163);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(38, 34);
            this.btnCosh.TabIndex = 14;
            this.btnCosh.Text = "cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinh.Location = new System.Drawing.Point(18, 163);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(38, 34);
            this.btnSinh.TabIndex = 13;
            this.btnSinh.Text = "sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanh.Location = new System.Drawing.Point(106, 163);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(38, 34);
            this.btnTanh.TabIndex = 15;
            this.btnTanh.Text = "tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnTensPower
            // 
            this.btnTensPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnTensPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTensPower.Location = new System.Drawing.Point(106, 43);
            this.btnTensPower.Name = "btnTensPower";
            this.btnTensPower.Size = new System.Drawing.Size(38, 34);
            this.btnTensPower.TabIndex = 3;
            this.btnTensPower.Text = "10ⁿ";
            this.btnTensPower.UseVisualStyleBackColor = false;
            this.btnTensPower.Click += new System.EventHandler(this.btnTensPower_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.Location = new System.Drawing.Point(62, 43);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(38, 34);
            this.btnCube.TabIndex = 2;
            this.btnCube.Text = "x³";
            this.btnCube.UseVisualStyleBackColor = false;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnLn
            // 
            this.btnLn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLn.Location = new System.Drawing.Point(150, 163);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(38, 34);
            this.btnLn.TabIndex = 16;
            this.btnLn.Text = "ln";
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.btnLn_Click);
            // 
            // btnCosInverse
            // 
            this.btnCosInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCosInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCosInverse.Location = new System.Drawing.Point(62, 123);
            this.btnCosInverse.Name = "btnCosInverse";
            this.btnCosInverse.Size = new System.Drawing.Size(38, 34);
            this.btnCosInverse.TabIndex = 10;
            this.btnCosInverse.Text = "cos⁻¹";
            this.btnCosInverse.UseVisualStyleBackColor = false;
            this.btnCosInverse.Click += new System.EventHandler(this.btnCosInverse_Click);
            // 
            // btnSinInverse
            // 
            this.btnSinInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSinInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinInverse.Location = new System.Drawing.Point(18, 123);
            this.btnSinInverse.Name = "btnSinInverse";
            this.btnSinInverse.Size = new System.Drawing.Size(38, 34);
            this.btnSinInverse.TabIndex = 9;
            this.btnSinInverse.Text = "sin⁻¹";
            this.btnSinInverse.UseVisualStyleBackColor = false;
            this.btnSinInverse.Click += new System.EventHandler(this.btnSinInverse_Click);
            // 
            // btnTanInverse
            // 
            this.btnTanInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTanInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTanInverse.Location = new System.Drawing.Point(106, 123);
            this.btnTanInverse.Name = "btnTanInverse";
            this.btnTanInverse.Size = new System.Drawing.Size(38, 34);
            this.btnTanInverse.TabIndex = 11;
            this.btnTanInverse.Text = "tan⁻¹";
            this.btnTanInverse.UseVisualStyleBackColor = false;
            this.btnTanInverse.Click += new System.EventHandler(this.btnTanInverse_Click);
            // 
            // btnePower
            // 
            this.btnePower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnePower.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnePower.Location = new System.Drawing.Point(150, 43);
            this.btnePower.Name = "btnePower";
            this.btnePower.Size = new System.Drawing.Size(38, 34);
            this.btnePower.TabIndex = 4;
            this.btnePower.Text = "eⁿ";
            this.btnePower.UseVisualStyleBackColor = false;
            this.btnePower.Click += new System.EventHandler(this.btnePower_Click);
            // 
            // grpBase
            // 
            this.grpBase.Controls.Add(this.optBinary);
            this.grpBase.Controls.Add(this.optHex);
            this.grpBase.Controls.Add(this.optDecimal);
            this.grpBase.Location = new System.Drawing.Point(8, 3);
            this.grpBase.Name = "grpBase";
            this.grpBase.Size = new System.Drawing.Size(189, 35);
            this.grpBase.TabIndex = 0;
            this.grpBase.TabStop = false;
            // 
            // optBinary
            // 
            this.optBinary.Location = new System.Drawing.Point(126, 10);
            this.optBinary.Name = "optBinary";
            this.optBinary.Size = new System.Drawing.Size(55, 24);
            this.optBinary.TabIndex = 2;
            this.optBinary.Text = "Binary";
            this.optBinary.UseVisualStyleBackColor = true;
            this.optBinary.CheckedChanged += new System.EventHandler(this.optBinary_CheckedChanged);
            // 
            // optHex
            // 
            this.optHex.Location = new System.Drawing.Point(78, 10);
            this.optHex.Name = "optHex";
            this.optHex.Size = new System.Drawing.Size(47, 24);
            this.optHex.TabIndex = 1;
            this.optHex.Text = "Hex";
            this.optHex.UseVisualStyleBackColor = true;
            this.optHex.CheckedChanged += new System.EventHandler(this.optHex_CheckedChanged);
            // 
            // optDecimal
            // 
            this.optDecimal.Checked = true;
            this.optDecimal.Location = new System.Drawing.Point(7, 10);
            this.optDecimal.Name = "optDecimal";
            this.optDecimal.Size = new System.Drawing.Size(65, 24);
            this.optDecimal.TabIndex = 0;
            this.optDecimal.TabStop = true;
            this.optDecimal.Text = "Decimal";
            this.optDecimal.UseVisualStyleBackColor = true;
            this.optDecimal.CheckedChanged += new System.EventHandler(this.optDecimal_CheckedChanged);
            // 
            // btnSquare
            // 
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(18, 43);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(38, 34);
            this.btnSquare.TabIndex = 1;
            this.btnSquare.Text = "x²";
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCos.Location = new System.Drawing.Point(62, 83);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(38, 34);
            this.btnCos.TabIndex = 6;
            this.btnCos.Text = "cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSin.Location = new System.Drawing.Point(18, 83);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(38, 34);
            this.btnSin.TabIndex = 5;
            this.btnSin.Text = "sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(150, 123);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(38, 34);
            this.btnLog.TabIndex = 12;
            this.btnLog.Text = "log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTan.Location = new System.Drawing.Point(106, 83);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(38, 34);
            this.btnTan.TabIndex = 7;
            this.btnTan.Text = "tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(238, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(10, 320);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // updownHistory
            // 
            this.updownHistory.BackColor = System.Drawing.Color.Gray;
            this.updownHistory.ForeColor = System.Drawing.Color.White;
            this.updownHistory.Location = new System.Drawing.Point(12, 9);
            this.updownHistory.Name = "updownHistory";
            this.updownHistory.ReadOnly = true;
            this.updownHistory.Size = new System.Drawing.Size(442, 20);
            this.updownHistory.TabIndex = 0;
            this.updownHistory.Text = "Press down button for history";
            this.updownHistory.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblMemoryData
            // 
            this.lblMemoryData.AutoSize = true;
            this.lblMemoryData.Location = new System.Drawing.Point(12, 79);
            this.lblMemoryData.Name = "lblMemoryData";
            this.lblMemoryData.Size = new System.Drawing.Size(82, 13);
            this.lblMemoryData.TabIndex = 2;
            this.lblMemoryData.Tag = "Memory Data: ";
            this.lblMemoryData.Text = "Memory Data: 0";
            // 
            // lnklblMyBlog
            // 
            this.lnklblMyBlog.AutoSize = true;
            this.lnklblMyBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblMyBlog.LinkArea = new System.Windows.Forms.LinkArea(22, 14);
            this.lnklblMyBlog.Location = new System.Drawing.Point(290, 392);
            this.lnklblMyBlog.Name = "lnklblMyBlog";
            this.lnklblMyBlog.Size = new System.Drawing.Size(146, 30);
            this.lnklblMyBlog.TabIndex = 6;
            this.lnklblMyBlog.TabStop = true;
            this.lnklblMyBlog.Tag = "http://sanje2v.wordpress.com/";
            this.lnklblMyBlog.Text = "Freeware\r\nWritten By: Sanjeev Sharma";
            this.lnklblMyBlog.UseCompatibleTextRendering = true;
            this.lnklblMyBlog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblMyBlog_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 430);
            this.Controls.Add(this.lnklblMyBlog);
            this.Controls.Add(this.lblMemoryData);
            this.Controls.Add(this.updownHistory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelScientific);
            this.Controls.Add(this.panelStandard);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.panelStandard.ResumeLayout(false);
            this.panelScientific.ResumeLayout(false);
            this.grpBase.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Panel panelStandard;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnMS;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelEntry;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnSquareRoot;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPercentage;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Panel panelScientific;
        private System.Windows.Forms.GroupBox grpBase;
        private System.Windows.Forms.RadioButton optBinary;
        private System.Windows.Forms.RadioButton optHex;
        private System.Windows.Forms.RadioButton optDecimal;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnTensPower;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnCosInverse;
        private System.Windows.Forms.Button btnSinInverse;
        private System.Windows.Forms.Button btnTanInverse;
        private System.Windows.Forms.Button btnePower;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCosh;
        private System.Windows.Forms.Button btnSinh;
        private System.Windows.Forms.Button btnTanh;
        private System.Windows.Forms.Button btnF;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.DomainUpDown updownHistory;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnExp;
        private System.Windows.Forms.Button btnRoR;
        private System.Windows.Forms.Button btnRoL;
        private System.Windows.Forms.Button btnRsh;
        private System.Windows.Forms.Button btnLsh;
        private System.Windows.Forms.Button btnXOR;
        private System.Windows.Forms.Button btnOR;
        private System.Windows.Forms.Button btnAND;
        private System.Windows.Forms.Button btnNOT;
        private System.Windows.Forms.Label lblMemoryData;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.LinkLabel lnklblMyBlog;
    }
}

