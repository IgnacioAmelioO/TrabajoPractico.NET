namespace WindowsForm
{
    partial class Inicio
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
            personaButton = new Button();
            planButton = new Button();
            especificacionButton = new Button();
            SuspendLayout();
            // 
            // personaButton
            // 
            personaButton.Location = new Point(86, 209);
            personaButton.Name = "personaButton";
            personaButton.Size = new Size(153, 47);
            personaButton.TabIndex = 0;
            personaButton.Text = "Persona";
            personaButton.UseVisualStyleBackColor = true;
            // 
            // planButton
            // 
            planButton.Location = new Point(330, 209);
            planButton.Name = "planButton";
            planButton.Size = new Size(153, 47);
            planButton.TabIndex = 1;
            planButton.Text = "Plan";
            planButton.UseVisualStyleBackColor = true;
            // 
            // especificacionButton
            // 
            especificacionButton.Location = new Point(595, 209);
            especificacionButton.Name = "especificacionButton";
            especificacionButton.Size = new Size(153, 47);
            especificacionButton.TabIndex = 2;
            especificacionButton.Text = "Especificacion";
            especificacionButton.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(especificacionButton);
            Controls.Add(planButton);
            Controls.Add(personaButton);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
        }

        #endregion

        private Button personaButton;
        private Button planButton;
        private Button especificacionButton;
    }
}
