namespace memalloc
{
    partial class Form1
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.number_holes = new System.Windows.Forms.TextBox();
            this.starting_addresses = new System.Windows.Forms.TextBox();
            this.size_holes = new System.Windows.Forms.TextBox();
            this.memory_size = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.number_processes = new System.Windows.Forms.TextBox();
            this.size_processes = new System.Windows.Forms.TextBox();
            this.AllocateBtn = new System.Windows.Forms.Button();
            this.DeallocateBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Process_to_Allocate = new System.Windows.Forms.TextBox();
            this.Process_to_Deallocate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.algorithm_type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(23, 265);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(127, 48);
            this.StartBtn.TabIndex = 2;
            this.StartBtn.Text = "start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "no. of holes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "starting addresses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(643, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "sizes of holes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "memory size";
            // 
            // number_holes
            // 
            this.number_holes.Location = new System.Drawing.Point(142, 15);
            this.number_holes.Name = "number_holes";
            this.number_holes.Size = new System.Drawing.Size(100, 20);
            this.number_holes.TabIndex = 7;
            // 
            // starting_addresses
            // 
            this.starting_addresses.Location = new System.Drawing.Point(477, 15);
            this.starting_addresses.Name = "starting_addresses";
            this.starting_addresses.Size = new System.Drawing.Size(100, 20);
            this.starting_addresses.TabIndex = 8;
            // 
            // size_holes
            // 
            this.size_holes.Location = new System.Drawing.Point(760, 15);
            this.size_holes.Name = "size_holes";
            this.size_holes.Size = new System.Drawing.Size(100, 20);
            this.size_holes.TabIndex = 9;
            // 
            // memory_size
            // 
            this.memory_size.Location = new System.Drawing.Point(142, 76);
            this.memory_size.Name = "memory_size";
            this.memory_size.Size = new System.Drawing.Size(100, 20);
            this.memory_size.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "no. of processes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "size of processes";
            // 
            // number_processes
            // 
            this.number_processes.Location = new System.Drawing.Point(477, 79);
            this.number_processes.Name = "number_processes";
            this.number_processes.Size = new System.Drawing.Size(100, 20);
            this.number_processes.TabIndex = 13;
            // 
            // size_processes
            // 
            this.size_processes.Location = new System.Drawing.Point(760, 83);
            this.size_processes.Name = "size_processes";
            this.size_processes.Size = new System.Drawing.Size(100, 20);
            this.size_processes.TabIndex = 14;
            // 
            // AllocateBtn
            // 
            this.AllocateBtn.Location = new System.Drawing.Point(454, 395);
            this.AllocateBtn.Name = "AllocateBtn";
            this.AllocateBtn.Size = new System.Drawing.Size(123, 36);
            this.AllocateBtn.TabIndex = 15;
            this.AllocateBtn.Text = "Allocate";
            this.AllocateBtn.UseVisualStyleBackColor = true;
            this.AllocateBtn.Click += new System.EventHandler(this.AllocateBtn_Click);
            // 
            // DeallocateBtn
            // 
            this.DeallocateBtn.Location = new System.Drawing.Point(788, 395);
            this.DeallocateBtn.Name = "DeallocateBtn";
            this.DeallocateBtn.Size = new System.Drawing.Size(123, 36);
            this.DeallocateBtn.TabIndex = 16;
            this.DeallocateBtn.Text = "Deallocate";
            this.DeallocateBtn.UseVisualStyleBackColor = true;
            this.DeallocateBtn.Click += new System.EventHandler(this.DeallocateBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(314, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 17;
            // 
            // Process_to_Allocate
            // 
            this.Process_to_Allocate.Location = new System.Drawing.Point(307, 404);
            this.Process_to_Allocate.Name = "Process_to_Allocate";
            this.Process_to_Allocate.Size = new System.Drawing.Size(127, 20);
            this.Process_to_Allocate.TabIndex = 18;
            this.Process_to_Allocate.Text = "process to allocate...";
            this.Process_to_Allocate.Enter += new System.EventHandler(this.Process_to_Allocate_Enter);
            // 
            // Process_to_Deallocate
            // 
            this.Process_to_Deallocate.Location = new System.Drawing.Point(613, 404);
            this.Process_to_Deallocate.Name = "Process_to_Deallocate";
            this.Process_to_Deallocate.Size = new System.Drawing.Size(150, 20);
            this.Process_to_Deallocate.TabIndex = 19;
            this.Process_to_Deallocate.Text = "process to deallocate...";
            this.Process_to_Deallocate.Enter += new System.EventHandler(this.Process_to_Deallocate_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Algorithm Type";
            // 
            // algorithm_type
            // 
            this.algorithm_type.FormattingEnabled = true;
            this.algorithm_type.Items.AddRange(new object[] {
            "First Fit",
            "Best Fit"});
            this.algorithm_type.Location = new System.Drawing.Point(142, 142);
            this.algorithm_type.Name = "algorithm_type";
            this.algorithm_type.Size = new System.Drawing.Size(121, 21);
            this.algorithm_type.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 450);
            this.Controls.Add(this.algorithm_type);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Process_to_Deallocate);
            this.Controls.Add(this.Process_to_Allocate);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.DeallocateBtn);
            this.Controls.Add(this.AllocateBtn);
            this.Controls.Add(this.size_processes);
            this.Controls.Add(this.number_processes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.memory_size);
            this.Controls.Add(this.size_holes);
            this.Controls.Add(this.starting_addresses);
            this.Controls.Add(this.number_holes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox number_holes;
        private System.Windows.Forms.TextBox starting_addresses;
        private System.Windows.Forms.TextBox size_holes;
        private System.Windows.Forms.TextBox memory_size;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number_processes;
        private System.Windows.Forms.TextBox size_processes;
        private System.Windows.Forms.Button AllocateBtn;
        private System.Windows.Forms.Button DeallocateBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox Process_to_Allocate;
        private System.Windows.Forms.TextBox Process_to_Deallocate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox algorithm_type;
    }
}

