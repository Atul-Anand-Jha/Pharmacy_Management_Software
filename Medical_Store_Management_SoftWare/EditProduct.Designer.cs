namespace Medical_Store_Management_SoftWare
{
    partial class EditProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProduct));
            this.lbl_Item = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.lbl_Manufacturer = new System.Windows.Forms.Label();
            this.lbl_Quantity = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.txt_Manufacturer = new System.Windows.Forms.TextBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_Item = new System.Windows.Forms.ComboBox();
            this.lbl_message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Item
            // 
            this.lbl_Item.AutoSize = true;
            this.lbl_Item.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Item.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Item.Location = new System.Drawing.Point(34, 21);
            this.lbl_Item.Name = "lbl_Item";
            this.lbl_Item.Size = new System.Drawing.Size(72, 30);
            this.lbl_Item.TabIndex = 0;
            this.lbl_Item.Text = "Item :";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Add.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(50, 233);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(88, 34);
            this.btn_Add.TabIndex = 2;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lbl_Manufacturer
            // 
            this.lbl_Manufacturer.AutoSize = true;
            this.lbl_Manufacturer.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Manufacturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Manufacturer.Location = new System.Drawing.Point(34, 68);
            this.lbl_Manufacturer.Name = "lbl_Manufacturer";
            this.lbl_Manufacturer.Size = new System.Drawing.Size(169, 30);
            this.lbl_Manufacturer.TabIndex = 3;
            this.lbl_Manufacturer.Text = "Manufacturer :";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.AutoSize = true;
            this.lbl_Quantity.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Quantity.Location = new System.Drawing.Point(34, 115);
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(121, 30);
            this.lbl_Quantity.TabIndex = 4;
            this.lbl_Quantity.Text = "Quantity :";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Price.Location = new System.Drawing.Point(34, 161);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(80, 30);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price :";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(220, 122);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(196, 20);
            this.txt_Quantity.TabIndex = 6;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(220, 168);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(196, 20);
            this.txt_Price.TabIndex = 7;
            // 
            // txt_Manufacturer
            // 
            this.txt_Manufacturer.Location = new System.Drawing.Point(220, 75);
            this.txt_Manufacturer.Name = "txt_Manufacturer";
            this.txt_Manufacturer.Size = new System.Drawing.Size(196, 20);
            this.txt_Manufacturer.TabIndex = 8;
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Reset.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(312, 233);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(88, 34);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Tomato;
            this.btn_Delete.Font = new System.Drawing.Font("Poor Richard", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(178, 233);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(88, 34);
            this.btn_Delete.TabIndex = 10;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(115, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter only Item to Delete them ....";
            // 
            // cBox_Item
            // 
            this.cBox_Item.FormattingEnabled = true;
            this.cBox_Item.Location = new System.Drawing.Point(220, 28);
            this.cBox_Item.Name = "cBox_Item";
            this.cBox_Item.Size = new System.Drawing.Size(196, 21);
            this.cBox_Item.TabIndex = 12;
            this.cBox_Item.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Location = new System.Drawing.Point(115, 9);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(0, 13);
            this.lbl_message.TabIndex = 13;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(458, 281);
            this.Controls.Add(this.lbl_message);
            this.Controls.Add(this.cBox_Item);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_Manufacturer);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Quantity);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.lbl_Manufacturer);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Item);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProduct";
            this.Text = "EditProduct";
            this.Load += new System.EventHandler(this.EditProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Item;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label lbl_Manufacturer;
        private System.Windows.Forms.Label lbl_Quantity;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.TextBox txt_Manufacturer;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cBox_Item;
        private System.Windows.Forms.Label lbl_message;
    }
}