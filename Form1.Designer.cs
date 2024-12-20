﻿namespace Traffic_Lights_V6
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
            components = new System.ComponentModel.Container();
            pb_area = new PictureBox();
            tmr_state = new System.Windows.Forms.Timer(components);
            Start_Button = new Button();
            Stop_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_area).BeginInit();
            SuspendLayout();
            // 
            // pb_area
            // 
            pb_area.Location = new Point(0, 0);
            pb_area.Name = "pb_area";
            pb_area.Size = new Size(695, 314);
            pb_area.TabIndex = 0;
            pb_area.TabStop = false;
            pb_area.Paint += pb_area_Paint;
            // 
            // tmr_state
            // 
            tmr_state.Enabled = true;
            tmr_state.Interval = 4000;
            tmr_state.Tick += tmr_state_Tick;
            // 
            // Start_Button
            // 
            Start_Button.Location = new Point(239, 360);
            Start_Button.Name = "Start_Button";
            Start_Button.Size = new Size(75, 23);
            Start_Button.TabIndex = 1;
            Start_Button.Text = "START";
            Start_Button.UseVisualStyleBackColor = true;
            Start_Button.Click += Start_Button_Click;
            // 
            // Stop_Button
            // 
            Stop_Button.Location = new Point(434, 360);
            Stop_Button.Name = "Stop_Button";
            Stop_Button.Size = new Size(75, 23);
            Stop_Button.TabIndex = 2;
            Stop_Button.Text = "STOP";
            Stop_Button.UseVisualStyleBackColor = true;
            Stop_Button.Click += Stop_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Stop_Button);
            Controls.Add(Start_Button);
            Controls.Add(pb_area);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_area).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_area;
        private System.Windows.Forms.Timer tmr_state;
        private Button Start_Button;
        private Button Stop_Button;
    }
}