﻿namespace PriceCompare
{
    partial class PriceCompareForm
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
            this._cBoxChain = new System.Windows.Forms.ComboBox();
            this._cBoxStores = new System.Windows.Forms.ComboBox();
            this._items = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._shoppingCart = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Compare = new System.Windows.Forms.Button();
            this._checkBoxToRemoveItem = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._cBoxStoresToCompare = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this._checkBoxSelectStoresToCompare = new System.Windows.Forms.CheckBox();
            this.Save = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _cBoxChain
            // 
            this._cBoxChain.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._cBoxChain.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cBoxChain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._cBoxChain.FormattingEnabled = true;
            this._cBoxChain.Location = new System.Drawing.Point(12, 82);
            this._cBoxChain.Name = "_cBoxChain";
            this._cBoxChain.Size = new System.Drawing.Size(159, 137);
            this._cBoxChain.Sorted = true;
            this._cBoxChain.TabIndex = 0;
            this._cBoxChain.SelectedIndexChanged += new System.EventHandler(this.CBoxChains_SelectedIndexChanged);
            // 
            // _cBoxStores
            // 
            this._cBoxStores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._cBoxStores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cBoxStores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._cBoxStores.FormattingEnabled = true;
            this._cBoxStores.Location = new System.Drawing.Point(201, 82);
            this._cBoxStores.Name = "_cBoxStores";
            this._cBoxStores.Size = new System.Drawing.Size(159, 137);
            this._cBoxStores.Sorted = true;
            this._cBoxStores.TabIndex = 1;
            this._cBoxStores.SelectedIndexChanged += new System.EventHandler(this.CBoxStores_SelectedIndexChanged);
            // 
            // _items
            // 
            this._items.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._items.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._items.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._items.ForeColor = System.Drawing.SystemColors.InfoText;
            this._items.FormattingEnabled = true;
            this._items.Location = new System.Drawing.Point(390, 82);
            this._items.Name = "_items";
            this._items.Size = new System.Drawing.Size(157, 137);
            this._items.Sorted = true;
            this._items.TabIndex = 6;
            this._items.SelectedIndexChanged += new System.EventHandler(this.Items_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(451, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "מוצרים";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _shoppingCart
            // 
            this._shoppingCart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._shoppingCart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._shoppingCart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._shoppingCart.ForeColor = System.Drawing.SystemColors.InfoText;
            this._shoppingCart.FormattingEnabled = true;
            this._shoppingCart.Location = new System.Drawing.Point(291, 261);
            this._shoppingCart.Name = "_shoppingCart";
            this._shoppingCart.Size = new System.Drawing.Size(155, 137);
            this._shoppingCart.Sorted = true;
            this._shoppingCart.TabIndex = 8;
            this._shoppingCart.SelectedIndexChanged += new System.EventHandler(this.ShoppingCart_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(333, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "סל הקניות";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Compare
            // 
            this.Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Compare.Location = new System.Drawing.Point(12, 12);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(101, 33);
            this.Compare.TabIndex = 10;
            this.Compare.Text = "Compare";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // _checkBoxToRemoveItem
            // 
            this._checkBoxToRemoveItem.AutoSize = true;
            this._checkBoxToRemoveItem.BackColor = System.Drawing.Color.Transparent;
            this._checkBoxToRemoveItem.Location = new System.Drawing.Point(399, 236);
            this._checkBoxToRemoveItem.Name = "_checkBoxToRemoveItem";
            this._checkBoxToRemoveItem.Size = new System.Drawing.Size(15, 14);
            this._checkBoxToRemoveItem.TabIndex = 11;
            this._checkBoxToRemoveItem.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(72, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "רשתות";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(262, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "סניפים";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cBoxStoresToCompare
            // 
            this._cBoxStoresToCompare.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this._cBoxStoresToCompare.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this._cBoxStoresToCompare.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this._cBoxStoresToCompare.ForeColor = System.Drawing.SystemColors.InfoText;
            this._cBoxStoresToCompare.FormattingEnabled = true;
            this._cBoxStoresToCompare.Location = new System.Drawing.Point(97, 261);
            this._cBoxStoresToCompare.Name = "_cBoxStoresToCompare";
            this._cBoxStoresToCompare.Size = new System.Drawing.Size(157, 137);
            this._cBoxStoresToCompare.Sorted = true;
            this._cBoxStoresToCompare.TabIndex = 14;
            this._cBoxStoresToCompare.SelectedIndexChanged += new System.EventHandler(this.CBoxStoresToCompare_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(106, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "סניפים נבחרים להשוואה";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _checkBoxSelectStoresToCompare
            // 
            this._checkBoxSelectStoresToCompare.AutoSize = true;
            this._checkBoxSelectStoresToCompare.BackColor = System.Drawing.Color.Transparent;
            this._checkBoxSelectStoresToCompare.Location = new System.Drawing.Point(311, 62);
            this._checkBoxSelectStoresToCompare.Name = "_checkBoxSelectStoresToCompare";
            this._checkBoxSelectStoresToCompare.Size = new System.Drawing.Size(15, 14);
            this._checkBoxSelectStoresToCompare.TabIndex = 16;
            this._checkBoxSelectStoresToCompare.UseVisualStyleBackColor = false;
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Save.Location = new System.Drawing.Point(139, 12);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 33);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Load.Location = new System.Drawing.Point(265, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(101, 33);
            this.Load.TabIndex = 18;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // PriceCompareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProjectPriceCompare.Properties.Resources.רשת_שיווק_364x245;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 409);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Save);
            this.Controls.Add(this._checkBoxSelectStoresToCompare);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cBoxStoresToCompare);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._checkBoxToRemoveItem);
            this.Controls.Add(this.Compare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this._shoppingCart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._items);
            this.Controls.Add(this._cBoxStores);
            this.Controls.Add(this._cBoxChain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PriceCompareForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Price Compare";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _cBoxChain;
        private System.Windows.Forms.ComboBox _cBoxStores;
        private System.Windows.Forms.ComboBox _items;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox _shoppingCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.CheckBox _checkBoxToRemoveItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cBoxStoresToCompare;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox _checkBoxSelectStoresToCompare;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;
    }
}

