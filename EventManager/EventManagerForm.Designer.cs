namespace EventManager
{
    partial class EventManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManager));
            this.updateButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.eventNameColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventStartColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLocation = new System.Windows.Forms.TextBox();
            this.eventName = new System.Windows.Forms.TextBox();
            this.eventNameLabel = new System.Windows.Forms.Label();
            this.eventLocationLabel = new System.Windows.Forms.Label();
            this.eventStartLabel = new System.Windows.Forms.Label();
            this.eventEndLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(404, 318);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(129, 67);
            this.updateButton.TabIndex = 7;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(78, 321);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(129, 67);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(241, 318);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(129, 67);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventNameColum,
            this.eventLocationColumn,
            this.eventStartColum,
            this.eventEndColumn});
            this.dataGridView.Location = new System.Drawing.Point(78, 145);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(618, 167);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseClick);
            // 
            // eventNameColum
            // 
            this.eventNameColum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.eventNameColum.HeaderText = "Name";
            this.eventNameColum.Name = "eventNameColum";
            // 
            // eventLocationColumn
            // 
            this.eventLocationColumn.HeaderText = "Location";
            this.eventLocationColumn.Name = "eventLocationColumn";
            // 
            // eventStartColum
            // 
            this.eventStartColum.HeaderText = "Start";
            this.eventStartColum.Name = "eventStartColum";
            // 
            // eventEndColumn
            // 
            this.eventEndColumn.HeaderText = "End";
            this.eventEndColumn.Name = "eventEndColumn";
            // 
            // eventLocation
            // 
            this.eventLocation.Location = new System.Drawing.Point(300, 38);
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.Size = new System.Drawing.Size(200, 20);
            this.eventLocation.TabIndex = 1;
            this.eventLocation.TextChanged += new System.EventHandler(this.eventLocation_TextChanged);
            // 
            // eventName
            // 
            this.eventName.Location = new System.Drawing.Point(300, 12);
            this.eventName.Name = "eventName";
            this.eventName.Size = new System.Drawing.Size(200, 20);
            this.eventName.TabIndex = 0;
            this.eventName.TextChanged += new System.EventHandler(this.eventName_TextChanged);
            // 
            // eventNameLabel
            // 
            this.eventNameLabel.AutoSize = true;
            this.eventNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventNameLabel.Location = new System.Drawing.Point(200, 12);
            this.eventNameLabel.Name = "eventNameLabel";
            this.eventNameLabel.Size = new System.Drawing.Size(68, 25);
            this.eventNameLabel.TabIndex = 8;
            this.eventNameLabel.Text = "Name";
            // 
            // eventLocationLabel
            // 
            this.eventLocationLabel.AutoSize = true;
            this.eventLocationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventLocationLabel.Location = new System.Drawing.Point(200, 38);
            this.eventLocationLabel.Name = "eventLocationLabel";
            this.eventLocationLabel.Size = new System.Drawing.Size(94, 25);
            this.eventLocationLabel.TabIndex = 9;
            this.eventLocationLabel.Text = "Location";
            // 
            // eventStartLabel
            // 
            this.eventStartLabel.AutoSize = true;
            this.eventStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventStartLabel.Location = new System.Drawing.Point(200, 76);
            this.eventStartLabel.Name = "eventStartLabel";
            this.eventStartLabel.Size = new System.Drawing.Size(57, 25);
            this.eventStartLabel.TabIndex = 10;
            this.eventStartLabel.Text = "Start";
            // 
            // eventEndLabel
            // 
            this.eventEndLabel.AutoSize = true;
            this.eventEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eventEndLabel.Location = new System.Drawing.Point(200, 102);
            this.eventEndLabel.Name = "eventEndLabel";
            this.eventEndLabel.Size = new System.Drawing.Size(50, 25);
            this.eventEndLabel.TabIndex = 11;
            this.eventEndLabel.Text = "End";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(567, 318);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(129, 67);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(300, 76);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 20);
            this.startTime.TabIndex = 12;
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(300, 107);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 20);
            this.endTime.TabIndex = 13;
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(732, 400);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.eventEndLabel);
            this.Controls.Add(this.eventStartLabel);
            this.Controls.Add(this.eventLocationLabel);
            this.Controls.Add(this.eventNameLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.eventName);
            this.Controls.Add(this.eventLocation);
            this.Name = "EventManager";
            this.Text = "EventManager";
            this.Load += new System.EventHandler(this.EventManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox eventLocation;
        private System.Windows.Forms.TextBox eventName;
        private System.Windows.Forms.Label eventNameLabel;
        private System.Windows.Forms.Label eventLocationLabel;
        private System.Windows.Forms.Label eventStartLabel;
        private System.Windows.Forms.Label eventEndLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventLocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventStartColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventEndColumn;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker endTime;
    }
}