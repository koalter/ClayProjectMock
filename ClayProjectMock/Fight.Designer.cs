namespace ClayProjectMock
{
    partial class Fight
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
            this.lblName = new System.Windows.Forms.Label();
            this.myHP = new System.Windows.Forms.Label();
            this.lblMyHP = new System.Windows.Forms.Label();
            this.lblEnemyHP = new System.Windows.Forms.Label();
            this.enemyHP = new System.Windows.Forms.Label();
            this.lblEnemy = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.lbxAttacks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(58, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "You";
            // 
            // myHP
            // 
            this.myHP.AutoSize = true;
            this.myHP.Location = new System.Drawing.Point(16, 80);
            this.myHP.Name = "myHP";
            this.myHP.Size = new System.Drawing.Size(22, 13);
            this.myHP.TabIndex = 1;
            this.myHP.Text = "HP";
            // 
            // lblMyHP
            // 
            this.lblMyHP.AutoSize = true;
            this.lblMyHP.Location = new System.Drawing.Point(104, 80);
            this.lblMyHP.Name = "lblMyHP";
            this.lblMyHP.Size = new System.Drawing.Size(32, 13);
            this.lblMyHP.TabIndex = 2;
            this.lblMyHP.Text = "lblHP";
            // 
            // lblEnemyHP
            // 
            this.lblEnemyHP.AutoSize = true;
            this.lblEnemyHP.Location = new System.Drawing.Point(311, 80);
            this.lblEnemyHP.Name = "lblEnemyHP";
            this.lblEnemyHP.Size = new System.Drawing.Size(32, 13);
            this.lblEnemyHP.TabIndex = 5;
            this.lblEnemyHP.Text = "lblHP";
            // 
            // enemyHP
            // 
            this.enemyHP.AutoSize = true;
            this.enemyHP.Location = new System.Drawing.Point(223, 80);
            this.enemyHP.Name = "enemyHP";
            this.enemyHP.Size = new System.Drawing.Size(22, 13);
            this.enemyHP.TabIndex = 4;
            this.enemyHP.Text = "HP";
            // 
            // lblEnemy
            // 
            this.lblEnemy.AutoSize = true;
            this.lblEnemy.Location = new System.Drawing.Point(265, 24);
            this.lblEnemy.Name = "lblEnemy";
            this.lblEnemy.Size = new System.Drawing.Size(39, 13);
            this.lblEnemy.TabIndex = 3;
            this.lblEnemy.Text = "Enemy";
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(140, 217);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 23);
            this.btnAttack.TabIndex = 8;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // lbxAttacks
            // 
            this.lbxAttacks.FormattingEnabled = true;
            this.lbxAttacks.Location = new System.Drawing.Point(16, 113);
            this.lbxAttacks.Name = "lbxAttacks";
            this.lbxAttacks.Size = new System.Drawing.Size(120, 56);
            this.lbxAttacks.TabIndex = 9;
            // 
            // Fight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 269);
            this.Controls.Add(this.lbxAttacks);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblEnemyHP);
            this.Controls.Add(this.enemyHP);
            this.Controls.Add(this.lblEnemy);
            this.Controls.Add(this.lblMyHP);
            this.Controls.Add(this.myHP);
            this.Controls.Add(this.lblName);
            this.Name = "Fight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fight";
            this.Load += new System.EventHandler(this.Fight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label myHP;
        private System.Windows.Forms.Label lblMyHP;
        private System.Windows.Forms.Label lblEnemyHP;
        private System.Windows.Forms.Label enemyHP;
        private System.Windows.Forms.Label lblEnemy;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.ListBox lbxAttacks;
    }
}