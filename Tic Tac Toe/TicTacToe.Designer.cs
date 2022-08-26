namespace Tic_Tac_Toe
{
    partial class TicTacToe
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
            this.newGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.zeroZero = new System.Windows.Forms.Label();
            this.zeroOne = new System.Windows.Forms.Label();
            this.zeroTwo = new System.Windows.Forms.Label();
            this.oneZero = new System.Windows.Forms.Label();
            this.oneOne = new System.Windows.Forms.Label();
            this.oneTwo = new System.Windows.Forms.Label();
            this.twoZero = new System.Windows.Forms.Label();
            this.twoOne = new System.Windows.Forms.Label();
            this.twoTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.newGameButton.Location = new System.Drawing.Point(72, 318);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(75, 23);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.Location = new System.Drawing.Point(153, 318);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(69, 282);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(159, 23);
            this.outputLabel.TabIndex = 2;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroZero
            // 
            this.zeroZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zeroZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroZero.Location = new System.Drawing.Point(23, 26);
            this.zeroZero.Name = "zeroZero";
            this.zeroZero.Size = new System.Drawing.Size(75, 75);
            this.zeroZero.TabIndex = 3;
            this.zeroZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroOne
            // 
            this.zeroOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zeroOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroOne.Location = new System.Drawing.Point(109, 26);
            this.zeroOne.Name = "zeroOne";
            this.zeroOne.Size = new System.Drawing.Size(75, 75);
            this.zeroOne.TabIndex = 4;
            this.zeroOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // zeroTwo
            // 
            this.zeroTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.zeroTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroTwo.Location = new System.Drawing.Point(195, 26);
            this.zeroTwo.Name = "zeroTwo";
            this.zeroTwo.Size = new System.Drawing.Size(75, 75);
            this.zeroTwo.TabIndex = 5;
            this.zeroTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneZero
            // 
            this.oneZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneZero.Location = new System.Drawing.Point(23, 111);
            this.oneZero.Name = "oneZero";
            this.oneZero.Size = new System.Drawing.Size(75, 75);
            this.oneZero.TabIndex = 6;
            this.oneZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneOne
            // 
            this.oneOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneOne.Location = new System.Drawing.Point(109, 111);
            this.oneOne.Name = "oneOne";
            this.oneOne.Size = new System.Drawing.Size(75, 75);
            this.oneOne.TabIndex = 7;
            this.oneOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // oneTwo
            // 
            this.oneTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oneTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oneTwo.Location = new System.Drawing.Point(195, 111);
            this.oneTwo.Name = "oneTwo";
            this.oneTwo.Size = new System.Drawing.Size(75, 75);
            this.oneTwo.TabIndex = 8;
            this.oneTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoZero
            // 
            this.twoZero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoZero.Location = new System.Drawing.Point(23, 196);
            this.twoZero.Name = "twoZero";
            this.twoZero.Size = new System.Drawing.Size(75, 75);
            this.twoZero.TabIndex = 9;
            this.twoZero.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoOne
            // 
            this.twoOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoOne.Location = new System.Drawing.Point(109, 196);
            this.twoOne.Name = "twoOne";
            this.twoOne.Size = new System.Drawing.Size(75, 75);
            this.twoOne.TabIndex = 10;
            this.twoOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // twoTwo
            // 
            this.twoTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twoTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twoTwo.Location = new System.Drawing.Point(195, 196);
            this.twoTwo.Name = "twoTwo";
            this.twoTwo.Size = new System.Drawing.Size(75, 75);
            this.twoTwo.TabIndex = 11;
            this.twoTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(294, 351);
            this.Controls.Add(this.twoTwo);
            this.Controls.Add(this.twoOne);
            this.Controls.Add(this.twoZero);
            this.Controls.Add(this.oneTwo);
            this.Controls.Add(this.oneOne);
            this.Controls.Add(this.oneZero);
            this.Controls.Add(this.zeroTwo);
            this.Controls.Add(this.zeroOne);
            this.Controls.Add(this.zeroZero);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label zeroZero;
        private System.Windows.Forms.Label zeroOne;
        private System.Windows.Forms.Label zeroTwo;
        private System.Windows.Forms.Label oneZero;
        private System.Windows.Forms.Label oneOne;
        private System.Windows.Forms.Label oneTwo;
        private System.Windows.Forms.Label twoZero;
        private System.Windows.Forms.Label twoOne;
        private System.Windows.Forms.Label twoTwo;
    }
}

