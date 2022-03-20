
namespace Cargo_Fleet_Tracking
{
    partial class CompletedTripReport
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
            this.plannedtripreportdataGridView1 = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plannedtripreportdataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // plannedtripreportdataGridView1
            // 
            this.plannedtripreportdataGridView1.AllowUserToAddRows = false;
            this.plannedtripreportdataGridView1.AllowUserToDeleteRows = false;
            this.plannedtripreportdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.plannedtripreportdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.plannedtripreportdataGridView1.Location = new System.Drawing.Point(12, 12);
            this.plannedtripreportdataGridView1.Name = "plannedtripreportdataGridView1";
            this.plannedtripreportdataGridView1.ReadOnly = true;
            this.plannedtripreportdataGridView1.Size = new System.Drawing.Size(776, 344);
            this.plannedtripreportdataGridView1.TabIndex = 0;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(324, 384);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 1;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(431, 384);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // CompletedTripReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.plannedtripreportdataGridView1);
            this.Name = "CompletedTripReport";
            this.Text = "Planned Trip Report";
            this.Load += new System.EventHandler(this.CompletedTripReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plannedtripreportdataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView plannedtripreportdataGridView1;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button exit;
    }
}