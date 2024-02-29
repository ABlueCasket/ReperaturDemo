namespace Reperatur
{
    partial class Form2
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 36);
            label1.Name = "label1";
            label1.Size = new Size(875, 150);
            label1.TabIndex = 0;
            label1.Text = "Yo, checkt mal dieses mega coole Programm, das von der CoolGang, geproggt wurde!!\r\n\r\nDas sind Johann, Max und Paula\r\n\r\nEs ist abslout insane!!!!!111\r\n";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1072, 272);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Opacity = 0.8D;
            Text = "Cooles Fenster";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}