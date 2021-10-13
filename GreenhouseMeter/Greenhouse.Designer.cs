
namespace GreenhouseMeter
{
    partial class Greenhouse
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
            this.label1 = new System.Windows.Forms.Label();
            this.Sensors = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Identificator = new System.Windows.Forms.TextBox();
            this.PosX = new System.Windows.Forms.TextBox();
            this.PosY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labeln = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.humidity = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TempPage = new System.Windows.Forms.TabPage();
            this.TempMap = new System.Windows.Forms.DataGridView();
            this.humidityPage = new System.Windows.Forms.TabPage();
            this.HumidityMap = new System.Windows.Forms.DataGridView();
            this.LogBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.TempPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TempMap)).BeginInit();
            this.humidityPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HumidityMap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sensors";
            // 
            // Sensors
            // 
            this.Sensors.FormattingEnabled = true;
            this.Sensors.Location = new System.Drawing.Point(12, 35);
            this.Sensors.Name = "Sensors";
            this.Sensors.Size = new System.Drawing.Size(292, 277);
            this.Sensors.TabIndex = 2;
            this.Sensors.SelectedIndexChanged += new System.EventHandler(this.Sensors_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sensor\'s positions";
            // 
            // Identificator
            // 
            this.Identificator.Location = new System.Drawing.Point(75, 350);
            this.Identificator.Name = "Identificator";
            this.Identificator.Size = new System.Drawing.Size(229, 20);
            this.Identificator.TabIndex = 4;
            // 
            // PosX
            // 
            this.PosX.Location = new System.Drawing.Point(75, 376);
            this.PosX.Name = "PosX";
            this.PosX.Size = new System.Drawing.Size(229, 20);
            this.PosX.TabIndex = 4;
            // 
            // PosY
            // 
            this.PosY.Location = new System.Drawing.Point(75, 402);
            this.PosY.Name = "PosY";
            this.PosY.Size = new System.Drawing.Size(229, 20);
            this.PosY.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Identificator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Position X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 405);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Position Y";
            // 
            // labeln
            // 
            this.labeln.AutoSize = true;
            this.labeln.Location = new System.Drawing.Point(2, 431);
            this.labeln.Name = "labeln";
            this.labeln.Size = new System.Drawing.Size(67, 13);
            this.labeln.TabIndex = 6;
            this.labeln.Text = "Temperature";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Humidity";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Location = new System.Drawing.Point(75, 431);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(13, 13);
            this.temp.TabIndex = 7;
            this.temp.Text = "0";
            // 
            // humidity
            // 
            this.humidity.AutoSize = true;
            this.humidity.Location = new System.Drawing.Point(75, 459);
            this.humidity.Name = "humidity";
            this.humidity.Size = new System.Drawing.Size(13, 13);
            this.humidity.TabIndex = 7;
            this.humidity.Text = "0";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(12, 486);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(292, 23);
            this.Save.TabIndex = 8;
            this.Save.Text = "Save sensor information";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TempPage);
            this.TabControl.Controls.Add(this.humidityPage);
            this.TabControl.Location = new System.Drawing.Point(323, 13);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(652, 702);
            this.TabControl.TabIndex = 9;
            // 
            // TempPage
            // 
            this.TempPage.Controls.Add(this.TempMap);
            this.TempPage.Location = new System.Drawing.Point(4, 22);
            this.TempPage.Name = "TempPage";
            this.TempPage.Padding = new System.Windows.Forms.Padding(3);
            this.TempPage.Size = new System.Drawing.Size(644, 676);
            this.TempPage.TabIndex = 0;
            this.TempPage.Text = "Temperature";
            this.TempPage.UseVisualStyleBackColor = true;
            // 
            // TempMap
            // 
            this.TempMap.AllowUserToAddRows = false;
            this.TempMap.AllowUserToDeleteRows = false;
            this.TempMap.AllowUserToResizeColumns = false;
            this.TempMap.AllowUserToResizeRows = false;
            this.TempMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TempMap.Location = new System.Drawing.Point(6, 6);
            this.TempMap.Name = "TempMap";
            this.TempMap.ReadOnly = true;
            this.TempMap.Size = new System.Drawing.Size(632, 664);
            this.TempMap.TabIndex = 0;
            // 
            // humidityPage
            // 
            this.humidityPage.Controls.Add(this.HumidityMap);
            this.humidityPage.Location = new System.Drawing.Point(4, 22);
            this.humidityPage.Name = "humidityPage";
            this.humidityPage.Padding = new System.Windows.Forms.Padding(3);
            this.humidityPage.Size = new System.Drawing.Size(644, 676);
            this.humidityPage.TabIndex = 1;
            this.humidityPage.Text = "Humidiy";
            this.humidityPage.UseVisualStyleBackColor = true;
            // 
            // HumidityMap
            // 
            this.HumidityMap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HumidityMap.Location = new System.Drawing.Point(6, 6);
            this.HumidityMap.Name = "HumidityMap";
            this.HumidityMap.Size = new System.Drawing.Size(632, 664);
            this.HumidityMap.TabIndex = 0;
            // 
            // LogBox
            // 
            this.LogBox.Location = new System.Drawing.Point(12, 538);
            this.LogBox.Name = "LogBox";
            this.LogBox.Size = new System.Drawing.Size(292, 167);
            this.LogBox.TabIndex = 10;
            this.LogBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 516);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Log information";
            // 
            // Greenhouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 727);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LogBox);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.humidity);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labeln);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PosY);
            this.Controls.Add(this.PosX);
            this.Controls.Add(this.Identificator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sensors);
            this.Controls.Add(this.label1);
            this.Name = "Greenhouse";
            this.Text = "Greenhouse meter";
            this.TabControl.ResumeLayout(false);
            this.TempPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TempMap)).EndInit();
            this.humidityPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HumidityMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Sensors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Identificator;
        private System.Windows.Forms.TextBox PosX;
        private System.Windows.Forms.TextBox PosY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labeln;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label humidity;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TempPage;
        private System.Windows.Forms.DataGridView TempMap;
        private System.Windows.Forms.TabPage humidityPage;
        private System.Windows.Forms.DataGridView HumidityMap;
        private System.Windows.Forms.RichTextBox LogBox;
        private System.Windows.Forms.Label label7;
    }
}

