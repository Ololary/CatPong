
namespace CatPong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.background = new System.Windows.Forms.Panel();
            this.gameball = new System.Windows.Forms.PictureBox();
            this.gamepanel = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.result = new System.Windows.Forms.Label();
            this.loselable = new System.Windows.Forms.Label();
            this.restartlable = new System.Windows.Forms.Label();
            this.background.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Controls.Add(this.restartlable);
            this.background.Controls.Add(this.loselable);
            this.background.Controls.Add(this.result);
            this.background.Controls.Add(this.gameball);
            this.background.Controls.Add(this.gamepanel);
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(933, 525);
            this.background.TabIndex = 0;
            // 
            // gameball
            // 
            this.gameball.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gameball.BackgroundImage")));
            this.gameball.Location = new System.Drawing.Point(349, 223);
            this.gameball.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameball.Name = "gameball";
            this.gameball.Size = new System.Drawing.Size(70, 69);
            this.gameball.TabIndex = 1;
            this.gameball.TabStop = false;
            // 
            // gamepanel
            // 
            this.gamepanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gamepanel.BackgroundImage")));
            this.gamepanel.Location = new System.Drawing.Point(204, 405);
            this.gamepanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gamepanel.Name = "gamepanel";
            this.gamepanel.Size = new System.Drawing.Size(378, 82);
            this.gamepanel.TabIndex = 0;
            this.gamepanel.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Lucida Sans Unicode", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(710, 9);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(151, 28);
            this.result.TabIndex = 1;
            this.result.Text = "Результат: 0";
            // 
            // loselable
            // 
            this.loselable.AutoSize = true;
            this.loselable.Font = new System.Drawing.Font("Microsoft YaHei", 30.45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loselable.Location = new System.Drawing.Point(308, 278);
            this.loselable.Name = "loselable";
            this.loselable.Size = new System.Drawing.Size(432, 54);
            this.loselable.TabIndex = 2;
            this.loselable.Text = "КЛУБОК ПОТЕРЯН!";
            // 
            // restartlable
            // 
            this.restartlable.AutoSize = true;
            this.restartlable.Font = new System.Drawing.Font("Microsoft JhengHei Light", 25.35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartlable.Location = new System.Drawing.Point(-7, 332);
            this.restartlable.Name = "restartlable";
            this.restartlable.Size = new System.Drawing.Size(987, 39);
            this.restartlable.TabIndex = 3;
            this.restartlable.Text = "Для выхода нажмите ESC, для продолжения нажмите ENTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 525);
            this.Controls.Add(this.background);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.background.ResumeLayout(false);
            this.background.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel background;
        private System.Windows.Forms.PictureBox gamepanel;
        private System.Windows.Forms.PictureBox gameball;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label loselable;
        private System.Windows.Forms.Label restartlable;
    }
}

