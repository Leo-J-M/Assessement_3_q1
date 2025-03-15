namespace Assessement_3_q1
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
        private void InitializeComponent() {
            txtInitialList = new TextBox();
            button1 = new Button();
            txtSortedList = new TextBox();
            txtFind = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnSort = new Button();
            label3 = new Label();
            txtResult = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // txtInitialList
            // 
            txtInitialList.Location = new Point(163, 75);
            txtInitialList.Name = "txtInitialList";
            txtInitialList.Size = new Size(1164, 31);
            txtInitialList.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(360, 295);
            button1.Name = "button1";
            button1.Size = new Size(190, 34);
            button1.TabIndex = 1;
            button1.Text = "Find Word Position";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtSortedList
            // 
            txtSortedList.Location = new Point(163, 193);
            txtSortedList.Name = "txtSortedList";
            txtSortedList.Size = new Size(1164, 31);
            txtSortedList.TabIndex = 2;
            // 
            // txtFind
            // 
            txtFind.Location = new Point(163, 298);
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(164, 31);
            txtFind.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 78);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 4;
            label1.Text = "Initia List";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 196);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 5;
            label2.Text = "Sorted List";
            // 
            // btnSort
            // 
            btnSort.Location = new Point(735, 123);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(112, 34);
            btnSort.TabIndex = 6;
            btnSort.Text = "Sort List";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 304);
            label3.Name = "label3";
            label3.Size = new Size(106, 25);
            label3.TabIndex = 7;
            label3.Text = "Enter Word ";
            // 
            // txtResult
            // 
            txtResult.Location = new Point(717, 297);
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(610, 31);
            txtResult.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 301);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 9;
            label4.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 618);
            Controls.Add(label4);
            Controls.Add(txtResult);
            Controls.Add(label3);
            Controls.Add(btnSort);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFind);
            Controls.Add(txtSortedList);
            Controls.Add(button1);
            Controls.Add(txtInitialList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInitialList;
        private Button button1;
        private TextBox txtSortedList;
        private TextBox txtFind;
        private Label label1;
        private Label label2;
        private Button btnSort;
        private Label label3;
        private TextBox txtResult;
        private Label label4;
    }
}
