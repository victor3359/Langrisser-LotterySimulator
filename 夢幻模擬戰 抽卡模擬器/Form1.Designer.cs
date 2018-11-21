namespace 夢幻模擬戰_抽卡模擬器
{
    partial class Langrisser_lottery
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lottery_once = new System.Windows.Forms.Button();
            this.lottery_ten = new System.Windows.Forms.Button();
            this.lottery_results = new System.Windows.Forms.ListView();
            this.lottery_pools = new System.Windows.Forms.ComboBox();
            this.lbl_lottery_pools = new System.Windows.Forms.Label();
            this.lbl_lottery_result = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_SSRC = new System.Windows.Forms.Label();
            this.lbl_SRC = new System.Windows.Forms.Label();
            this.lbl_RC = new System.Windows.Forms.Label();
            this.lbl_total_count = new System.Windows.Forms.Label();
            this.lbl_SSR_count = new System.Windows.Forms.Label();
            this.lbl_SR_count = new System.Windows.Forms.Label();
            this.lbl_R_count = new System.Windows.Forms.Label();
            this.lbl_SSR_r = new System.Windows.Forms.Label();
            this.lbl_SR_r = new System.Windows.Forms.Label();
            this.lbl_SSR_ratio = new System.Windows.Forms.Label();
            this.lbl_SR_ratio = new System.Windows.Forms.Label();
            this.lbl_SSR_percent = new System.Windows.Forms.Label();
            this.lbl_SR_percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lottery_once
            // 
            this.lottery_once.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lottery_once.Location = new System.Drawing.Point(12, 12);
            this.lottery_once.Name = "lottery_once";
            this.lottery_once.Size = new System.Drawing.Size(144, 52);
            this.lottery_once.TabIndex = 0;
            this.lottery_once.Text = "單抽";
            this.lottery_once.UseVisualStyleBackColor = true;
            this.lottery_once.Click += new System.EventHandler(this.lottery_once_Click);
            // 
            // lottery_ten
            // 
            this.lottery_ten.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lottery_ten.Location = new System.Drawing.Point(162, 12);
            this.lottery_ten.Name = "lottery_ten";
            this.lottery_ten.Size = new System.Drawing.Size(144, 52);
            this.lottery_ten.TabIndex = 1;
            this.lottery_ten.Text = "十連抽";
            this.lottery_ten.UseVisualStyleBackColor = true;
            this.lottery_ten.Click += new System.EventHandler(this.lottery_ten_Click);
            // 
            // lottery_results
            // 
            this.lottery_results.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lottery_results.Location = new System.Drawing.Point(326, 39);
            this.lottery_results.Name = "lottery_results";
            this.lottery_results.Size = new System.Drawing.Size(355, 415);
            this.lottery_results.TabIndex = 2;
            this.lottery_results.UseCompatibleStateImageBehavior = false;
            this.lottery_results.View = System.Windows.Forms.View.Details;
            // 
            // lottery_pools
            // 
            this.lottery_pools.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lottery_pools.FormattingEnabled = true;
            this.lottery_pools.Location = new System.Drawing.Point(12, 134);
            this.lottery_pools.Name = "lottery_pools";
            this.lottery_pools.Size = new System.Drawing.Size(144, 32);
            this.lottery_pools.TabIndex = 3;
            this.lottery_pools.SelectedIndexChanged += new System.EventHandler(this.lottery_pools_SelectedIndexChanged);
            // 
            // lbl_lottery_pools
            // 
            this.lbl_lottery_pools.AutoSize = true;
            this.lbl_lottery_pools.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_lottery_pools.Location = new System.Drawing.Point(12, 100);
            this.lbl_lottery_pools.Name = "lbl_lottery_pools";
            this.lbl_lottery_pools.Size = new System.Drawing.Size(105, 24);
            this.lbl_lottery_pools.TabIndex = 4;
            this.lbl_lottery_pools.Text = "選擇卡池：";
            // 
            // lbl_lottery_result
            // 
            this.lbl_lottery_result.AutoSize = true;
            this.lbl_lottery_result.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_lottery_result.Location = new System.Drawing.Point(326, 12);
            this.lbl_lottery_result.Name = "lbl_lottery_result";
            this.lbl_lottery_result.Size = new System.Drawing.Size(67, 24);
            this.lbl_lottery_result.TabIndex = 5;
            this.lbl_lottery_result.Text = "結果：";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_total.Location = new System.Drawing.Point(12, 294);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(105, 24);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "總抽卡數：";
            // 
            // lbl_SSRC
            // 
            this.lbl_SSRC.AutoSize = true;
            this.lbl_SSRC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SSRC.Location = new System.Drawing.Point(34, 340);
            this.lbl_SSRC.Name = "lbl_SSRC";
            this.lbl_SSRC.Size = new System.Drawing.Size(83, 24);
            this.lbl_SSRC.TabIndex = 7;
            this.lbl_SSRC.Text = "SSR數：";
            // 
            // lbl_SRC
            // 
            this.lbl_SRC.AutoSize = true;
            this.lbl_SRC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SRC.Location = new System.Drawing.Point(45, 387);
            this.lbl_SRC.Name = "lbl_SRC";
            this.lbl_SRC.Size = new System.Drawing.Size(72, 24);
            this.lbl_SRC.TabIndex = 8;
            this.lbl_SRC.Text = "SR數：";
            // 
            // lbl_RC
            // 
            this.lbl_RC.AutoSize = true;
            this.lbl_RC.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_RC.Location = new System.Drawing.Point(56, 431);
            this.lbl_RC.Name = "lbl_RC";
            this.lbl_RC.Size = new System.Drawing.Size(61, 24);
            this.lbl_RC.TabIndex = 9;
            this.lbl_RC.Text = "R數：";
            // 
            // lbl_total_count
            // 
            this.lbl_total_count.AutoSize = true;
            this.lbl_total_count.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_total_count.Location = new System.Drawing.Point(123, 297);
            this.lbl_total_count.Name = "lbl_total_count";
            this.lbl_total_count.Size = new System.Drawing.Size(20, 21);
            this.lbl_total_count.TabIndex = 10;
            this.lbl_total_count.Text = "0";
            // 
            // lbl_SSR_count
            // 
            this.lbl_SSR_count.AutoSize = true;
            this.lbl_SSR_count.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SSR_count.Location = new System.Drawing.Point(123, 343);
            this.lbl_SSR_count.Name = "lbl_SSR_count";
            this.lbl_SSR_count.Size = new System.Drawing.Size(20, 21);
            this.lbl_SSR_count.TabIndex = 11;
            this.lbl_SSR_count.Text = "0";
            // 
            // lbl_SR_count
            // 
            this.lbl_SR_count.AutoSize = true;
            this.lbl_SR_count.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SR_count.Location = new System.Drawing.Point(123, 390);
            this.lbl_SR_count.Name = "lbl_SR_count";
            this.lbl_SR_count.Size = new System.Drawing.Size(20, 21);
            this.lbl_SR_count.TabIndex = 12;
            this.lbl_SR_count.Text = "0";
            // 
            // lbl_R_count
            // 
            this.lbl_R_count.AutoSize = true;
            this.lbl_R_count.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_R_count.Location = new System.Drawing.Point(123, 434);
            this.lbl_R_count.Name = "lbl_R_count";
            this.lbl_R_count.Size = new System.Drawing.Size(20, 21);
            this.lbl_R_count.TabIndex = 13;
            this.lbl_R_count.Text = "0";
            // 
            // lbl_SSR_r
            // 
            this.lbl_SSR_r.AutoSize = true;
            this.lbl_SSR_r.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SSR_r.Location = new System.Drawing.Point(34, 189);
            this.lbl_SSR_r.Name = "lbl_SSR_r";
            this.lbl_SSR_r.Size = new System.Drawing.Size(83, 24);
            this.lbl_SSR_r.TabIndex = 14;
            this.lbl_SSR_r.Text = "SSR率：";
            // 
            // lbl_SR_r
            // 
            this.lbl_SR_r.AutoSize = true;
            this.lbl_SR_r.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SR_r.Location = new System.Drawing.Point(45, 231);
            this.lbl_SR_r.Name = "lbl_SR_r";
            this.lbl_SR_r.Size = new System.Drawing.Size(72, 24);
            this.lbl_SR_r.TabIndex = 15;
            this.lbl_SR_r.Text = "SR率：";
            // 
            // lbl_SSR_ratio
            // 
            this.lbl_SSR_ratio.AutoSize = true;
            this.lbl_SSR_ratio.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SSR_ratio.Location = new System.Drawing.Point(123, 192);
            this.lbl_SSR_ratio.Name = "lbl_SSR_ratio";
            this.lbl_SSR_ratio.Size = new System.Drawing.Size(20, 21);
            this.lbl_SSR_ratio.TabIndex = 16;
            this.lbl_SSR_ratio.Text = "0";
            // 
            // lbl_SR_ratio
            // 
            this.lbl_SR_ratio.AutoSize = true;
            this.lbl_SR_ratio.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SR_ratio.Location = new System.Drawing.Point(123, 234);
            this.lbl_SR_ratio.Name = "lbl_SR_ratio";
            this.lbl_SR_ratio.Size = new System.Drawing.Size(20, 21);
            this.lbl_SR_ratio.TabIndex = 17;
            this.lbl_SR_ratio.Text = "0";
            // 
            // lbl_SSR_percent
            // 
            this.lbl_SSR_percent.AutoSize = true;
            this.lbl_SSR_percent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SSR_percent.Location = new System.Drawing.Point(187, 192);
            this.lbl_SSR_percent.Name = "lbl_SSR_percent";
            this.lbl_SSR_percent.Size = new System.Drawing.Size(24, 21);
            this.lbl_SSR_percent.TabIndex = 18;
            this.lbl_SSR_percent.Text = "%";
            this.lbl_SSR_percent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_SR_percent
            // 
            this.lbl_SR_percent.AutoSize = true;
            this.lbl_SR_percent.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_SR_percent.Location = new System.Drawing.Point(187, 234);
            this.lbl_SR_percent.Name = "lbl_SR_percent";
            this.lbl_SR_percent.Size = new System.Drawing.Size(24, 21);
            this.lbl_SR_percent.TabIndex = 19;
            this.lbl_SR_percent.Text = "%";
            this.lbl_SR_percent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Langrisser_lottery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 466);
            this.Controls.Add(this.lbl_SR_percent);
            this.Controls.Add(this.lbl_SSR_percent);
            this.Controls.Add(this.lbl_SR_ratio);
            this.Controls.Add(this.lbl_SSR_ratio);
            this.Controls.Add(this.lbl_SR_r);
            this.Controls.Add(this.lbl_SSR_r);
            this.Controls.Add(this.lbl_R_count);
            this.Controls.Add(this.lbl_SR_count);
            this.Controls.Add(this.lbl_SSR_count);
            this.Controls.Add(this.lbl_total_count);
            this.Controls.Add(this.lbl_RC);
            this.Controls.Add(this.lbl_SRC);
            this.Controls.Add(this.lbl_SSRC);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.lbl_lottery_result);
            this.Controls.Add(this.lbl_lottery_pools);
            this.Controls.Add(this.lottery_pools);
            this.Controls.Add(this.lottery_results);
            this.Controls.Add(this.lottery_ten);
            this.Controls.Add(this.lottery_once);
            this.Name = "Langrisser_lottery";
            this.Text = "Langrisser 抽卡模擬器";
            this.Load += new System.EventHandler(this.Langrisser_lottery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lottery_once;
        private System.Windows.Forms.Button lottery_ten;
        private System.Windows.Forms.ListView lottery_results;
        private System.Windows.Forms.ComboBox lottery_pools;
        private System.Windows.Forms.Label lbl_lottery_pools;
        private System.Windows.Forms.Label lbl_lottery_result;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_SSRC;
        private System.Windows.Forms.Label lbl_SRC;
        private System.Windows.Forms.Label lbl_RC;
        private System.Windows.Forms.Label lbl_total_count;
        private System.Windows.Forms.Label lbl_SSR_count;
        private System.Windows.Forms.Label lbl_SR_count;
        private System.Windows.Forms.Label lbl_R_count;
        private System.Windows.Forms.Label lbl_SSR_r;
        private System.Windows.Forms.Label lbl_SR_r;
        private System.Windows.Forms.Label lbl_SSR_ratio;
        private System.Windows.Forms.Label lbl_SR_ratio;
        private System.Windows.Forms.Label lbl_SSR_percent;
        private System.Windows.Forms.Label lbl_SR_percent;
    }
}

