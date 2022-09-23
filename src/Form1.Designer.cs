namespace WorkoutApp
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
            this.workoutTypeBox = new System.Windows.Forms.GroupBox();
            this.cardioBtn = new System.Windows.Forms.RadioButton();
            this.toneBtn = new System.Windows.Forms.RadioButton();
            this.muscleBtn = new System.Windows.Forms.RadioButton();
            this.generateWorkoutBtn = new System.Windows.Forms.Button();
            this.muscleGroupBox = new System.Windows.Forms.GroupBox();
            this.absBtn = new System.Windows.Forms.RadioButton();
            this.legsBtn = new System.Windows.Forms.RadioButton();
            this.armsBtn = new System.Windows.Forms.RadioButton();
            this.heightBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WorkoutCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RepsTimeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeightCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutTypeBox.SuspendLayout();
            this.muscleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // workoutTypeBox
            // 
            this.workoutTypeBox.Controls.Add(this.cardioBtn);
            this.workoutTypeBox.Controls.Add(this.toneBtn);
            this.workoutTypeBox.Controls.Add(this.muscleBtn);
            this.workoutTypeBox.Location = new System.Drawing.Point(12, 98);
            this.workoutTypeBox.Name = "workoutTypeBox";
            this.workoutTypeBox.Size = new System.Drawing.Size(490, 88);
            this.workoutTypeBox.TabIndex = 0;
            this.workoutTypeBox.TabStop = false;
            this.workoutTypeBox.Text = "Workout Type";
            // 
            // cardioBtn
            // 
            this.cardioBtn.AutoSize = true;
            this.cardioBtn.Location = new System.Drawing.Point(363, 42);
            this.cardioBtn.Name = "cardioBtn";
            this.cardioBtn.Size = new System.Drawing.Size(101, 29);
            this.cardioBtn.TabIndex = 2;
            this.cardioBtn.TabStop = true;
            this.cardioBtn.Text = "Burn Fat";
            this.cardioBtn.UseVisualStyleBackColor = true;
            // 
            // toneBtn
            // 
            this.toneBtn.AutoSize = true;
            this.toneBtn.Location = new System.Drawing.Point(179, 42);
            this.toneBtn.Name = "toneBtn";
            this.toneBtn.Size = new System.Drawing.Size(142, 29);
            this.toneBtn.TabIndex = 1;
            this.toneBtn.TabStop = true;
            this.toneBtn.Text = "Tone Muscles";
            this.toneBtn.UseVisualStyleBackColor = true;
            // 
            // muscleBtn
            // 
            this.muscleBtn.AutoSize = true;
            this.muscleBtn.Location = new System.Drawing.Point(6, 42);
            this.muscleBtn.Name = "muscleBtn";
            this.muscleBtn.Size = new System.Drawing.Size(136, 29);
            this.muscleBtn.TabIndex = 0;
            this.muscleBtn.TabStop = true;
            this.muscleBtn.Text = "Build Muscle";
            this.muscleBtn.UseVisualStyleBackColor = true;
            // 
            // generateWorkoutBtn
            // 
            this.generateWorkoutBtn.Location = new System.Drawing.Point(12, 307);
            this.generateWorkoutBtn.Name = "generateWorkoutBtn";
            this.generateWorkoutBtn.Size = new System.Drawing.Size(180, 34);
            this.generateWorkoutBtn.TabIndex = 1;
            this.generateWorkoutBtn.Text = "Generate Workout";
            this.generateWorkoutBtn.UseVisualStyleBackColor = true;
            this.generateWorkoutBtn.Click += new System.EventHandler(this.generateWorkoutBtn_Click);
            // 
            // muscleGroupBox
            // 
            this.muscleGroupBox.Controls.Add(this.absBtn);
            this.muscleGroupBox.Controls.Add(this.legsBtn);
            this.muscleGroupBox.Controls.Add(this.armsBtn);
            this.muscleGroupBox.Location = new System.Drawing.Point(12, 203);
            this.muscleGroupBox.Name = "muscleGroupBox";
            this.muscleGroupBox.Size = new System.Drawing.Size(490, 83);
            this.muscleGroupBox.TabIndex = 2;
            this.muscleGroupBox.TabStop = false;
            this.muscleGroupBox.Text = "Muscle Group";
            // 
            // absBtn
            // 
            this.absBtn.AutoSize = true;
            this.absBtn.Location = new System.Drawing.Point(363, 39);
            this.absBtn.Name = "absBtn";
            this.absBtn.Size = new System.Drawing.Size(68, 29);
            this.absBtn.TabIndex = 2;
            this.absBtn.TabStop = true;
            this.absBtn.Text = "Abs";
            this.absBtn.UseVisualStyleBackColor = true;
            // 
            // legsBtn
            // 
            this.legsBtn.AutoSize = true;
            this.legsBtn.Location = new System.Drawing.Point(179, 39);
            this.legsBtn.Name = "legsBtn";
            this.legsBtn.Size = new System.Drawing.Size(73, 29);
            this.legsBtn.TabIndex = 1;
            this.legsBtn.TabStop = true;
            this.legsBtn.Text = "Legs";
            this.legsBtn.UseVisualStyleBackColor = true;
            // 
            // armsBtn
            // 
            this.armsBtn.AutoSize = true;
            this.armsBtn.Location = new System.Drawing.Point(6, 39);
            this.armsBtn.Name = "armsBtn";
            this.armsBtn.Size = new System.Drawing.Size(79, 29);
            this.armsBtn.TabIndex = 0;
            this.armsBtn.TabStop = true;
            this.armsBtn.Text = "Arms";
            this.armsBtn.UseVisualStyleBackColor = true;
            // 
            // heightBox
            // 
            this.heightBox.Location = new System.Drawing.Point(18, 52);
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(150, 31);
            this.heightBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weight";
            // 
            // weightBox
            // 
            this.weightBox.Location = new System.Drawing.Point(209, 52);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(150, 31);
            this.weightBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WorkoutCol,
            this.RepsTimeCol,
            this.WeightCol});
            this.dataGridView1.Location = new System.Drawing.Point(12, 393);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(708, 357);
            this.dataGridView1.TabIndex = 7;
            // 
            // WorkoutCol
            // 
            this.WorkoutCol.HeaderText = "Workout";
            this.WorkoutCol.MinimumWidth = 8;
            this.WorkoutCol.Name = "WorkoutCol";
            this.WorkoutCol.Width = 150;
            // 
            // RepsTimeCol
            // 
            this.RepsTimeCol.HeaderText = "Reps/Time";
            this.RepsTimeCol.MinimumWidth = 8;
            this.RepsTimeCol.Name = "RepsTimeCol";
            this.RepsTimeCol.Width = 150;
            // 
            // WeightCol
            // 
            this.WeightCol.HeaderText = "Weight";
            this.WeightCol.MinimumWidth = 8;
            this.WeightCol.Name = "WeightCol";
            this.WeightCol.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 813);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.weightBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.muscleGroupBox);
            this.Controls.Add(this.generateWorkoutBtn);
            this.Controls.Add(this.workoutTypeBox);
            this.Name = "Form1";
            this.Text = "Workout Builder";
            this.workoutTypeBox.ResumeLayout(false);
            this.workoutTypeBox.PerformLayout();
            this.muscleGroupBox.ResumeLayout(false);
            this.muscleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox workoutTypeBox;
        private RadioButton cardioBtn;
        private RadioButton toneBtn;
        private RadioButton muscleBtn;
        private Button generateWorkoutBtn;
        private GroupBox muscleGroupBox;
        private TextBox heightBox;
        private Label label1;
        private Label label2;
        private TextBox weightBox;
        private RadioButton absBtn;
        private RadioButton legsBtn;
        private RadioButton armsBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn WorkoutCol;
        private DataGridViewTextBoxColumn RepsTimeCol;
        private DataGridViewTextBoxColumn WeightCol;
    }
}