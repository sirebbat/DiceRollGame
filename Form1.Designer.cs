namespace DiceRollGame
{
    partial class dice_roll
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
            this.btn_roll = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lv_dice_roll = new System.Windows.Forms.ListView();
            this.lw_dice_one = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_dice_two = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_sequence = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btn_roll
            // 
            this.btn_roll.AutoSize = true;
            this.btn_roll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_roll.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btn_roll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_roll.Location = new System.Drawing.Point(234, 12);
            this.btn_roll.Name = "btn_roll";
            this.btn_roll.Size = new System.Drawing.Size(75, 65);
            this.btn_roll.TabIndex = 1;
            this.btn_roll.Text = "Roll";
            this.btn_roll.UseVisualStyleBackColor = false;
            this.btn_roll.Click += new System.EventHandler(this.btn_roll_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Location = new System.Drawing.Point(234, 322);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 62);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lv_dice_roll
            // 
            this.lv_dice_roll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lv_dice_roll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lw_dice_one,
            this.lv_dice_two,
            this.lv_sequence});
            this.lv_dice_roll.Dock = System.Windows.Forms.DockStyle.Left;
            this.lv_dice_roll.FullRowSelect = true;
            this.lv_dice_roll.GridLines = true;
            this.lv_dice_roll.Location = new System.Drawing.Point(0, 0);
            this.lv_dice_roll.Name = "lv_dice_roll";
            this.lv_dice_roll.Size = new System.Drawing.Size(208, 396);
            this.lv_dice_roll.TabIndex = 2;
            this.lv_dice_roll.UseCompatibleStateImageBehavior = false;
            this.lv_dice_roll.View = System.Windows.Forms.View.Details;
            // 
            // lw_dice_one
            // 
            this.lw_dice_one.Text = "Dice One";
            // 
            // lv_dice_two
            // 
            this.lv_dice_two.Text = "Dice Two";
            // 
            // lv_sequence
            // 
            this.lv_sequence.Text = "Sequence";
            this.lv_sequence.Width = 70;
            // 
            // dice_roll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(357, 396);
            this.Controls.Add(this.lv_dice_roll);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_roll);
            this.Name = "dice_roll";
            this.ShowIcon = false;
            this.Text = "Dice Roll Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_roll;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.ListView lv_dice_roll;
        private System.Windows.Forms.ColumnHeader lw_dice_one;
        private System.Windows.Forms.ColumnHeader lv_dice_two;
        private System.Windows.Forms.ColumnHeader lv_sequence;
    }
}

