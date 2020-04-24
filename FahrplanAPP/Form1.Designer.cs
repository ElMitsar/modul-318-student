namespace FahrplanAPP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.EingabeAbfahrtsstation = new System.Windows.Forms.ComboBox();
            this.EingabeZielstation = new System.Windows.Forms.ComboBox();
            this.RoutenAnzeige = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonAbfahrtsPlan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EingabeAbfahrtsstation
            // 
            this.EingabeAbfahrtsstation.FormattingEnabled = true;
            this.EingabeAbfahrtsstation.Location = new System.Drawing.Point(442, 86);
            this.EingabeAbfahrtsstation.Name = "EingabeAbfahrtsstation";
            this.EingabeAbfahrtsstation.Size = new System.Drawing.Size(140, 33);
            this.EingabeAbfahrtsstation.TabIndex = 1;
            this.EingabeAbfahrtsstation.SelectedIndexChanged += new System.EventHandler(this.EingabeAbfahrtsstation_SelectedIndexChanged);
            this.EingabeAbfahrtsstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EingabeAbfahrtsstation_KeyUp);
            // 
            // EingabeZielstation
            // 
            this.EingabeZielstation.FormattingEnabled = true;
            this.EingabeZielstation.Location = new System.Drawing.Point(1162, 86);
            this.EingabeZielstation.Name = "EingabeZielstation";
            this.EingabeZielstation.Size = new System.Drawing.Size(140, 33);
            this.EingabeZielstation.TabIndex = 2;
            this.EingabeZielstation.SelectedIndexChanged += new System.EventHandler(this.EingabeZielstation_SelectedIndexChanged_1);
            this.EingabeZielstation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EingabeZielstation_KeyUp);
            // 
            // RoutenAnzeige
            // 
            this.RoutenAnzeige.FormattingEnabled = true;
            this.RoutenAnzeige.ItemHeight = 25;
            this.RoutenAnzeige.Location = new System.Drawing.Point(437, 234);
            this.RoutenAnzeige.Name = "RoutenAnzeige";
            this.RoutenAnzeige.Size = new System.Drawing.Size(856, 554);
            this.RoutenAnzeige.TabIndex = 3;
            this.RoutenAnzeige.SelectedIndexChanged += new System.EventHandler(this.RoutenAnzeige_SelectedIndexChanged);
            this.RoutenAnzeige.KeyUp += new System.Windows.Forms.KeyEventHandler(this.RoutenAnzeige_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(437, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abfahrt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1172, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ziel";
            // 
            // ButtonAbfahrtsPlan
            // 
            this.ButtonAbfahrtsPlan.Location = new System.Drawing.Point(605, 86);
            this.ButtonAbfahrtsPlan.Name = "ButtonAbfahrtsPlan";
            this.ButtonAbfahrtsPlan.Size = new System.Drawing.Size(176, 51);
            this.ButtonAbfahrtsPlan.TabIndex = 6;
            this.ButtonAbfahrtsPlan.Text = "Abfahrsplan";
            this.ButtonAbfahrtsPlan.UseVisualStyleBackColor = true;
            this.ButtonAbfahrtsPlan.Click += new System.EventHandler(this.ButtonAbfahrtsPlan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 862);
            this.Controls.Add(this.ButtonAbfahrtsPlan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoutenAnzeige);
            this.Controls.Add(this.EingabeZielstation);
            this.Controls.Add(this.EingabeAbfahrtsstation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox EingabeAbfahrtsstation;
        private System.Windows.Forms.ComboBox EingabeZielstation;
        private System.Windows.Forms.ListBox RoutenAnzeige;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonAbfahrtsPlan;
    }
}

