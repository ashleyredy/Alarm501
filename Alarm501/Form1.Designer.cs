
namespace Alarm501
{
    partial class Alarm501
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
            this.uxEdit = new System.Windows.Forms.Button();
            this.uxAlarms = new System.Windows.Forms.ListView();
            this.uxSnooze = new System.Windows.Forms.Button();
            this.uxStop = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Location = new System.Drawing.Point(33, 37);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(92, 35);
            this.uxEdit.TabIndex = 0;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            // 
            // uxAlarms
            // 
            this.uxAlarms.HideSelection = false;
            this.uxAlarms.Location = new System.Drawing.Point(33, 94);
            this.uxAlarms.Name = "uxAlarms";
            this.uxAlarms.Size = new System.Drawing.Size(220, 168);
            this.uxAlarms.TabIndex = 2;
            this.uxAlarms.UseCompatibleStateImageBehavior = false;
            // 
            // uxSnooze
            // 
            this.uxSnooze.Location = new System.Drawing.Point(33, 321);
            this.uxSnooze.Name = "uxSnooze";
            this.uxSnooze.Size = new System.Drawing.Size(92, 35);
            this.uxSnooze.TabIndex = 3;
            this.uxSnooze.Text = "Snooze";
            this.uxSnooze.UseVisualStyleBackColor = true;
            // 
            // uxStop
            // 
            this.uxStop.Location = new System.Drawing.Point(161, 321);
            this.uxStop.Name = "uxStop";
            this.uxStop.Size = new System.Drawing.Size(92, 35);
            this.uxStop.TabIndex = 4;
            this.uxStop.Text = "Stop";
            this.uxStop.UseVisualStyleBackColor = true;
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(161, 37);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(92, 35);
            this.uxAdd.TabIndex = 5;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            // 
            // Alarm501
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 385);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxStop);
            this.Controls.Add(this.uxSnooze);
            this.Controls.Add(this.uxAlarms);
            this.Controls.Add(this.uxEdit);
            this.Name = "Alarm501";
            this.Text = "Alarm501";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.ListView uxAlarms;
        private System.Windows.Forms.Button uxSnooze;
        private System.Windows.Forms.Button uxStop;
        private System.Windows.Forms.Button uxAdd;
    }
}

