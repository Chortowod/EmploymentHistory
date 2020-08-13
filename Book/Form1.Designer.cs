namespace Book
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addWorker = new System.Windows.Forms.Button();
            this.personsListView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delWorker = new System.Windows.Forms.Button();
            this.addWorkPlace = new System.Windows.Forms.Button();
            this.workPlacesListView1 = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.deleteWorkPlace = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addWorker
            // 
            this.addWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWorker.Location = new System.Drawing.Point(9, 678);
            this.addWorker.Name = "addWorker";
            this.addWorker.Size = new System.Drawing.Size(206, 49);
            this.addWorker.TabIndex = 0;
            this.addWorker.Text = "Добавить работника";
            this.addWorker.UseVisualStyleBackColor = true;
            this.addWorker.Click += new System.EventHandler(this.addWorker_Click);
            // 
            // personsListView1
            // 
            this.personsListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.personsListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.personsListView1.HideSelection = false;
            this.personsListView1.Location = new System.Drawing.Point(0, 0);
            this.personsListView1.MultiSelect = false;
            this.personsListView1.Name = "personsListView1";
            this.personsListView1.Size = new System.Drawing.Size(472, 667);
            this.personsListView1.TabIndex = 2;
            this.personsListView1.UseCompatibleStateImageBehavior = false;
            this.personsListView1.View = System.Windows.Forms.View.Details;
            this.personsListView1.VirtualMode = true;
            this.personsListView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.personsListView1_ColumnClick);
            this.personsListView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.personsListView1_ItemSelectionChanged);
            this.personsListView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.personsListView1_RetrieveVirtualItem);
            this.personsListView1.SelectedIndexChanged += new System.EventHandler(this.personsListView1_SelectedIndexChanged);
            this.personsListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.personsListView1_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Фамилия";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Имя";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Отчество";
            this.columnHeader3.Width = 128;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата рождения";
            this.columnHeader4.Width = 104;
            // 
            // delWorker
            // 
            this.delWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delWorker.Location = new System.Drawing.Point(258, 678);
            this.delWorker.Name = "delWorker";
            this.delWorker.Size = new System.Drawing.Size(206, 49);
            this.delWorker.TabIndex = 3;
            this.delWorker.Text = "Удалить работника";
            this.delWorker.UseVisualStyleBackColor = true;
            this.delWorker.Click += new System.EventHandler(this.delWorker_Click);
            // 
            // addWorkPlace
            // 
            this.addWorkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addWorkPlace.Location = new System.Drawing.Point(60, 677);
            this.addWorkPlace.Name = "addWorkPlace";
            this.addWorkPlace.Size = new System.Drawing.Size(240, 49);
            this.addWorkPlace.TabIndex = 5;
            this.addWorkPlace.Text = "Добавить место работы";
            this.addWorkPlace.UseVisualStyleBackColor = true;
            this.addWorkPlace.Click += new System.EventHandler(this.addWorkPlace_Click);
            // 
            // workPlacesListView1
            // 
            this.workPlacesListView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.workPlacesListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.workPlacesListView1.HideSelection = false;
            this.workPlacesListView1.Location = new System.Drawing.Point(0, 0);
            this.workPlacesListView1.MultiSelect = false;
            this.workPlacesListView1.Name = "workPlacesListView1";
            this.workPlacesListView1.Size = new System.Drawing.Size(1242, 667);
            this.workPlacesListView1.TabIndex = 4;
            this.workPlacesListView1.UseCompatibleStateImageBehavior = false;
            this.workPlacesListView1.View = System.Windows.Forms.View.Details;
            this.workPlacesListView1.VirtualMode = true;
            this.workPlacesListView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.workPlacesListView1_RetrieveVirtualItem);
            this.workPlacesListView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.workPlacesListView1_MouseDoubleClick);
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "№";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата приема";
            this.columnHeader6.Width = 94;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Организация";
            this.columnHeader7.Width = 97;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Должность";
            this.columnHeader8.Width = 90;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Документ";
            this.columnHeader9.Width = 92;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Комментарий";
            this.columnHeader10.Width = 96;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Дата увольнения/переврда";
            this.columnHeader11.Width = 181;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Причина увольнения";
            this.columnHeader12.Width = 138;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Документ";
            this.columnHeader13.Width = 116;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 829);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.personsListView1);
            this.splitContainer1.Panel1.Controls.Add(this.delWorker);
            this.splitContainer1.Panel1.Controls.Add(this.addWorker);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.deleteWorkPlace);
            this.splitContainer1.Panel2.Controls.Add(this.workPlacesListView1);
            this.splitContainer1.Panel2.Controls.Add(this.addWorkPlace);
            this.splitContainer1.Size = new System.Drawing.Size(1718, 804);
            this.splitContainer1.SplitterDistance = 472;
            this.splitContainer1.TabIndex = 8;
            // 
            // deleteWorkPlace
            // 
            this.deleteWorkPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteWorkPlace.Location = new System.Drawing.Point(322, 677);
            this.deleteWorkPlace.Name = "deleteWorkPlace";
            this.deleteWorkPlace.Size = new System.Drawing.Size(240, 50);
            this.deleteWorkPlace.TabIndex = 6;
            this.deleteWorkPlace.Text = "Удалить место работы";
            this.deleteWorkPlace.UseVisualStyleBackColor = true;
            this.deleteWorkPlace.Click += new System.EventHandler(this.deleteWorkPlace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 829);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Электронная трудовая книжка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addWorker;
        private System.Windows.Forms.ListView personsListView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button delWorker;
        private System.Windows.Forms.Button addWorkPlace;
        private System.Windows.Forms.ListView workPlacesListView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button deleteWorkPlace;
    }
}

