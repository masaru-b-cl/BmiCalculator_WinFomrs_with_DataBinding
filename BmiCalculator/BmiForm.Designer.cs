namespace BmiCalculator
{
  partial class BmiForm
  {
    /// <summary>
    /// 必要なデザイナー変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナーで生成されたコード

    /// <summary>
    /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディターで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.bmiViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiViewModelBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(184, 98);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(75, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "クリア";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(184, 68);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 3;
      this.button1.Text = "計算";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(135, 80);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(17, 12);
      this.label6.TabIndex = 8;
      this.label6.Text = "kg";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(135, 55);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(20, 12);
      this.label5.TabIndex = 9;
      this.label5.Text = "cm";
      // 
      // label4
      // 
      this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiViewModelBindingSource, "Bmi", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N2"));
      this.label4.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", this.bmiViewModelBindingSource, "BmiBackColor", true, System.Windows.Forms.DataSourceUpdateMode.Never));
      this.label4.Location = new System.Drawing.Point(76, 109);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(53, 12);
      this.label4.TabIndex = 10;
      this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(33, 109);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(25, 12);
      this.label3.TabIndex = 11;
      this.label3.Text = "BMI";
      // 
      // textBox2
      // 
      this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiViewModelBindingSource, "Weight", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
      this.textBox2.Location = new System.Drawing.Point(74, 77);
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(55, 19);
      this.textBox2.TabIndex = 2;
      this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(33, 80);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 12);
      this.label2.TabIndex = 4;
      this.label2.Text = "体重";
      // 
      // textBox1
      // 
      this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bmiViewModelBindingSource, "Height", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N1"));
      this.textBox1.Location = new System.Drawing.Point(74, 52);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(55, 19);
      this.textBox1.TabIndex = 0;
      this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(33, 55);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(29, 12);
      this.label1.TabIndex = 5;
      this.label1.Text = "身長";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      this.errorProvider1.DataSource = this.bmiViewModelBindingSource;
      // 
      // bmiViewModelBindingSource
      // 
      this.bmiViewModelBindingSource.DataSource = typeof(BmiCalculator.BmiViewModel);
      // 
      // BmiForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(293, 172);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.label1);
      this.Name = "BmiForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "BMI計算機";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bmiViewModelBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.BindingSource bmiViewModelBindingSource;
    private System.Windows.Forms.ErrorProvider errorProvider1;

  }
}

