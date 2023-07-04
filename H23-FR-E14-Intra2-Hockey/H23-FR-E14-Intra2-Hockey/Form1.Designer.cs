namespace H23_FR_E14_Intra2_Hockey
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
            listView1 = new ListView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(515, 426);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            button1.Location = new Point(547, 12);
            button1.Name = "button1";
            button1.Size = new Size(160, 60);
            button1.TabIndex = 1;
            button1.Text = "Mise en échec";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(547, 78);
            button2.Name = "button2";
            button2.Size = new Size(160, 60);
            button2.TabIndex = 2;
            button2.Text = "Lancer";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(547, 144);
            button3.Name = "button3";
            button3.Size = new Size(160, 60);
            button3.TabIndex = 3;
            button3.Text = "But";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(547, 210);
            button4.Name = "button4";
            button4.Size = new Size(160, 60);
            button4.TabIndex = 4;
            button4.Text = "Aide";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSalmon;
            button5.Location = new Point(547, 378);
            button5.Name = "button5";
            button5.Size = new Size(160, 60);
            button5.TabIndex = 5;
            button5.Text = "Arrêt de jeu";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listView1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}