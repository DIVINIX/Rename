namespace Rename
{
    partial class Rename
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rename));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.renameCreate = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.extension = new System.Windows.Forms.Button();
            this.renameDelete = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(33, 340);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Dossier contenant les fichiers";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(432, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 48);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(505, 206);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(434, 420);
            this.listBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(33, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(210, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Choix de l\'extention sans le point";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(432, 30);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 22);
            this.textBox3.TabIndex = 5;
            // 
            // renameCreate
            // 
            this.renameCreate.Location = new System.Drawing.Point(33, 458);
            this.renameCreate.Name = "renameCreate";
            this.renameCreate.Size = new System.Drawing.Size(149, 63);
            this.renameCreate.TabIndex = 6;
            this.renameCreate.Text = "Renommer dans un sous-répertoire tmp";
            this.renameCreate.UseVisualStyleBackColor = true;
            this.renameCreate.Click += new System.EventHandler(this.renameCreate_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(33, 140);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 22);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Text à ajouter au début du fichier";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(279, 140);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(130, 22);
            this.textBox5.TabIndex = 8;
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(432, 127);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(48, 48);
            this.extension.TabIndex = 9;
            this.extension.Text = "OK";
            this.extension.UseVisualStyleBackColor = true;
            this.extension.Click += new System.EventHandler(this.extension_Click);
            // 
            // renameDelete
            // 
            this.renameDelete.Location = new System.Drawing.Point(342, 449);
            this.renameDelete.Name = "renameDelete";
            this.renameDelete.Size = new System.Drawing.Size(138, 80);
            this.renameDelete.TabIndex = 10;
            this.renameDelete.Text = "Rennomer dans le même répertoire en supprimant les anciens fichiers";
            this.renameDelete.UseVisualStyleBackColor = true;
            this.renameDelete.Click += new System.EventHandler(this.renameDelete_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(33, 240);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(210, 22);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "Texte à rajouter avant l\'extension";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(279, 240);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(130, 22);
            this.textBox7.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 227);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 48);
            this.button3.TabIndex = 13;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(505, 30);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(434, 164);
            this.listBox2.TabIndex = 14;
            // 
            // Rename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 664);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.renameDelete);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.renameCreate);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Rename";
            this.Text = "Rename";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button renameCreate;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button extension;
        private System.Windows.Forms.Button renameDelete;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
    }
}

