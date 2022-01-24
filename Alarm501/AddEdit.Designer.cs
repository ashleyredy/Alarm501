
namespace Alarm501
{
    partial class AddEdit
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
            this.uxTime = new System.Windows.Forms.DateTimePicker();
            this.uxOn = new System.Windows.Forms.CheckBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxSet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTime
            // 
            this.uxTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.uxTime.Location = new System.Drawing.Point(23, 35);
            this.uxTime.Name = "uxTime";
            this.uxTime.Size = new System.Drawing.Size(151, 23);
            this.uxTime.TabIndex = 0;
            this.uxTime.Value = new System.DateTime(2022, 1, 24, 15, 49, 0, 0);
            // 
            // uxOn
            // 
            this.uxOn.AutoSize = true;
            this.uxOn.Location = new System.Drawing.Point(194, 39);
            this.uxOn.Name = "uxOn";
            this.uxOn.Size = new System.Drawing.Size(42, 19);
            this.uxOn.TabIndex = 1;
            this.uxOn.Text = "On";
            this.uxOn.UseVisualStyleBackColor = true;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(23, 122);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 31);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            // 
            // uxSet
            // 
            this.uxSet.Location = new System.Drawing.Point(161, 122);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(75, 31);
            this.uxSet.TabIndex = 3;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 199);
            this.Controls.Add(this.uxSet);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOn);
            this.Controls.Add(this.uxTime);
            this.Name = "AddEdit";
            this.Text = "Add/Edit Alarm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker uxTime;
        private System.Windows.Forms.CheckBox uxOn;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxSet;
    }
}