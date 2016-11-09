namespace QueueForm
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
            this.listOrders = new System.Windows.Forms.ListBox();
            this.txtNewOrder = new System.Windows.Forms.TextBox();
            this.btnJoinQueue = new System.Windows.Forms.Button();
            this.btnTakeOrder = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOrders
            // 
            this.listOrders.FormattingEnabled = true;
            this.listOrders.Location = new System.Drawing.Point(13, 13);
            this.listOrders.Name = "listOrders";
            this.listOrders.Size = new System.Drawing.Size(160, 251);
            this.listOrders.TabIndex = 0;
            // 
            // txtNewOrder
            // 
            this.txtNewOrder.Location = new System.Drawing.Point(179, 13);
            this.txtNewOrder.Name = "txtNewOrder";
            this.txtNewOrder.Size = new System.Drawing.Size(121, 20);
            this.txtNewOrder.TabIndex = 1;
            // 
            // btnJoinQueue
            // 
            this.btnJoinQueue.Location = new System.Drawing.Point(179, 40);
            this.btnJoinQueue.Name = "btnJoinQueue";
            this.btnJoinQueue.Size = new System.Drawing.Size(121, 23);
            this.btnJoinQueue.TabIndex = 2;
            this.btnJoinQueue.Text = "Join Queue";
            this.btnJoinQueue.UseVisualStyleBackColor = true;
            this.btnJoinQueue.Click += new System.EventHandler(this.handleAll);
            // 
            // btnTakeOrder
            // 
            this.btnTakeOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnTakeOrder.Location = new System.Drawing.Point(179, 70);
            this.btnTakeOrder.Name = "btnTakeOrder";
            this.btnTakeOrder.Size = new System.Drawing.Size(121, 23);
            this.btnTakeOrder.TabIndex = 3;
            this.btnTakeOrder.Text = "Take Order";
            this.btnTakeOrder.UseVisualStyleBackColor = true;
            this.btnTakeOrder.Click += new System.EventHandler(this.handleAll);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(179, 100);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(121, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.handleAll);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnJoinQueue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 277);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnTakeOrder);
            this.Controls.Add(this.btnJoinQueue);
            this.Controls.Add(this.txtNewOrder);
            this.Controls.Add(this.listOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listOrders;
        private System.Windows.Forms.TextBox txtNewOrder;
        private System.Windows.Forms.Button btnJoinQueue;
        private System.Windows.Forms.Button btnTakeOrder;
        private System.Windows.Forms.Button btnPreview;
    }
}

