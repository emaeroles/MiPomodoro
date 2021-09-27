
namespace MiPomodoro
{
    partial class FrmPomodoro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CboTmpPomodoro = new System.Windows.Forms.ComboBox();
            this.BtnComenzar = new System.Windows.Forms.Button();
            this.CboDesCorto = new System.Windows.Forms.ComboBox();
            this.CboDesLargo = new System.Windows.Forms.ComboBox();
            this.CboCantidad = new System.Windows.Forms.ComboBox();
            this.PnlTimer = new System.Windows.Forms.Panel();
            this.LblP8 = new System.Windows.Forms.Label();
            this.LblP7 = new System.Windows.Forms.Label();
            this.LblP6 = new System.Windows.Forms.Label();
            this.LblP5 = new System.Windows.Forms.Label();
            this.LblP4 = new System.Windows.Forms.Label();
            this.LblP3 = new System.Windows.Forms.Label();
            this.LblP2 = new System.Windows.Forms.Label();
            this.LblP1 = new System.Windows.Forms.Label();
            this.LblSegundos = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnPausePlay = new System.Windows.Forms.Button();
            this.BtnPaso = new System.Windows.Forms.Button();
            this.LblDosPuntos = new System.Windows.Forms.Label();
            this.LblMinutos = new System.Windows.Forms.Label();
            this.PnlAyuda = new System.Windows.Forms.Panel();
            this.BtnVolverAcercaDe = new System.Windows.Forms.Button();
            this.LblCreated = new System.Windows.Forms.Label();
            this.LblVersion = new System.Windows.Forms.Label();
            this.PnlEstadisticas = new System.Windows.Forms.Panel();
            this.LblProximamente = new System.Windows.Forms.Label();
            this.BtnVolverEstadisticas = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LblDescCorto = new System.Windows.Forms.Label();
            this.LblDescLargo = new System.Windows.Forms.Label();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.LblTP = new System.Windows.Forms.Label();
            this.LblMin2 = new System.Windows.Forms.Label();
            this.LblMin1 = new System.Windows.Forms.Label();
            this.LblMin3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlTimer.SuspendLayout();
            this.PnlAyuda.SuspendLayout();
            this.PnlEstadisticas.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CboTmpPomodoro
            // 
            this.CboTmpPomodoro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTmpPomodoro.FormattingEnabled = true;
            this.CboTmpPomodoro.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.CboTmpPomodoro.Location = new System.Drawing.Point(183, 101);
            this.CboTmpPomodoro.Name = "CboTmpPomodoro";
            this.CboTmpPomodoro.Size = new System.Drawing.Size(40, 21);
            this.CboTmpPomodoro.TabIndex = 3;
            // 
            // BtnComenzar
            // 
            this.BtnComenzar.Font = new System.Drawing.Font("Berlin Sans FB", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComenzar.Location = new System.Drawing.Point(365, 109);
            this.BtnComenzar.Name = "BtnComenzar";
            this.BtnComenzar.Size = new System.Drawing.Size(100, 100);
            this.BtnComenzar.TabIndex = 4;
            this.BtnComenzar.Text = "COMENZAR";
            this.BtnComenzar.UseVisualStyleBackColor = true;
            this.BtnComenzar.Click += new System.EventHandler(this.BtnComenzar_Click);
            // 
            // CboDesCorto
            // 
            this.CboDesCorto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDesCorto.FormattingEnabled = true;
            this.CboDesCorto.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.CboDesCorto.Location = new System.Drawing.Point(43, 211);
            this.CboDesCorto.Name = "CboDesCorto";
            this.CboDesCorto.Size = new System.Drawing.Size(40, 21);
            this.CboDesCorto.TabIndex = 5;
            // 
            // CboDesLargo
            // 
            this.CboDesLargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDesLargo.FormattingEnabled = true;
            this.CboDesLargo.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.CboDesLargo.Location = new System.Drawing.Point(183, 211);
            this.CboDesLargo.Name = "CboDesLargo";
            this.CboDesLargo.Size = new System.Drawing.Size(40, 21);
            this.CboDesLargo.TabIndex = 6;
            // 
            // CboCantidad
            // 
            this.CboCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCantidad.FormattingEnabled = true;
            this.CboCantidad.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.CboCantidad.Location = new System.Drawing.Point(43, 101);
            this.CboCantidad.Name = "CboCantidad";
            this.CboCantidad.Size = new System.Drawing.Size(40, 21);
            this.CboCantidad.TabIndex = 7;
            // 
            // PnlTimer
            // 
            this.PnlTimer.Controls.Add(this.LblP8);
            this.PnlTimer.Controls.Add(this.LblP7);
            this.PnlTimer.Controls.Add(this.LblP6);
            this.PnlTimer.Controls.Add(this.LblP5);
            this.PnlTimer.Controls.Add(this.LblP4);
            this.PnlTimer.Controls.Add(this.LblP3);
            this.PnlTimer.Controls.Add(this.LblP2);
            this.PnlTimer.Controls.Add(this.LblP1);
            this.PnlTimer.Controls.Add(this.LblSegundos);
            this.PnlTimer.Controls.Add(this.BtnStop);
            this.PnlTimer.Controls.Add(this.BtnPausePlay);
            this.PnlTimer.Controls.Add(this.BtnPaso);
            this.PnlTimer.Controls.Add(this.LblDosPuntos);
            this.PnlTimer.Controls.Add(this.LblMinutos);
            this.PnlTimer.Location = new System.Drawing.Point(440, 40);
            this.PnlTimer.Name = "PnlTimer";
            this.PnlTimer.Size = new System.Drawing.Size(28, 28);
            this.PnlTimer.TabIndex = 8;
            // 
            // LblP8
            // 
            this.LblP8.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP8.Location = new System.Drawing.Point(407, 50);
            this.LblP8.Name = "LblP8";
            this.LblP8.Size = new System.Drawing.Size(45, 30);
            this.LblP8.TabIndex = 12;
            this.LblP8.Text = "P8";
            this.LblP8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP8.Visible = false;
            // 
            // LblP7
            // 
            this.LblP7.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP7.Location = new System.Drawing.Point(356, 50);
            this.LblP7.Name = "LblP7";
            this.LblP7.Size = new System.Drawing.Size(45, 30);
            this.LblP7.TabIndex = 11;
            this.LblP7.Text = "P7";
            this.LblP7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP7.Visible = false;
            // 
            // LblP6
            // 
            this.LblP6.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP6.Location = new System.Drawing.Point(305, 50);
            this.LblP6.Name = "LblP6";
            this.LblP6.Size = new System.Drawing.Size(45, 30);
            this.LblP6.TabIndex = 10;
            this.LblP6.Text = "P6";
            this.LblP6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP6.Visible = false;
            // 
            // LblP5
            // 
            this.LblP5.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblP5.Location = new System.Drawing.Point(254, 50);
            this.LblP5.Name = "LblP5";
            this.LblP5.Size = new System.Drawing.Size(45, 30);
            this.LblP5.TabIndex = 9;
            this.LblP5.Text = "P5";
            this.LblP5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP5.Visible = false;
            // 
            // LblP4
            // 
            this.LblP4.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP4.Location = new System.Drawing.Point(203, 50);
            this.LblP4.Name = "LblP4";
            this.LblP4.Size = new System.Drawing.Size(45, 30);
            this.LblP4.TabIndex = 8;
            this.LblP4.Text = "P4";
            this.LblP4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP4.Visible = false;
            // 
            // LblP3
            // 
            this.LblP3.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP3.Location = new System.Drawing.Point(152, 50);
            this.LblP3.Name = "LblP3";
            this.LblP3.Size = new System.Drawing.Size(45, 30);
            this.LblP3.TabIndex = 7;
            this.LblP3.Text = "P3";
            this.LblP3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP3.Visible = false;
            // 
            // LblP2
            // 
            this.LblP2.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP2.Location = new System.Drawing.Point(101, 50);
            this.LblP2.Name = "LblP2";
            this.LblP2.Size = new System.Drawing.Size(45, 30);
            this.LblP2.TabIndex = 6;
            this.LblP2.Text = "P2";
            this.LblP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP2.Visible = false;
            // 
            // LblP1
            // 
            this.LblP1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblP1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblP1.Location = new System.Drawing.Point(50, 50);
            this.LblP1.Name = "LblP1";
            this.LblP1.Size = new System.Drawing.Size(45, 30);
            this.LblP1.TabIndex = 5;
            this.LblP1.Text = "P1";
            this.LblP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblP1.Visible = false;
            // 
            // LblSegundos
            // 
            this.LblSegundos.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSegundos.Location = new System.Drawing.Point(260, 130);
            this.LblSegundos.Name = "LblSegundos";
            this.LblSegundos.Size = new System.Drawing.Size(62, 41);
            this.LblSegundos.TabIndex = 3;
            this.LblSegundos.Text = "00";
            this.LblSegundos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnStop
            // 
            this.BtnStop.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.Location = new System.Drawing.Point(382, 221);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(75, 23);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
            // 
            // BtnPausePlay
            // 
            this.BtnPausePlay.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPausePlay.Location = new System.Drawing.Point(216, 221);
            this.BtnPausePlay.Name = "BtnPausePlay";
            this.BtnPausePlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPausePlay.TabIndex = 1;
            this.BtnPausePlay.Text = "Pause";
            this.BtnPausePlay.UseVisualStyleBackColor = true;
            this.BtnPausePlay.Click += new System.EventHandler(this.BtnPausePlay_Click);
            // 
            // BtnPaso
            // 
            this.BtnPaso.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPaso.Location = new System.Drawing.Point(50, 221);
            this.BtnPaso.Name = "BtnPaso";
            this.BtnPaso.Size = new System.Drawing.Size(75, 23);
            this.BtnPaso.TabIndex = 0;
            this.BtnPaso.Text = "Pomodoro";
            this.BtnPaso.UseVisualStyleBackColor = true;
            this.BtnPaso.Click += new System.EventHandler(this.BtnPaso_Click);
            // 
            // LblDosPuntos
            // 
            this.LblDosPuntos.AutoSize = true;
            this.LblDosPuntos.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDosPuntos.Location = new System.Drawing.Point(247, 127);
            this.LblDosPuntos.Name = "LblDosPuntos";
            this.LblDosPuntos.Size = new System.Drawing.Size(25, 41);
            this.LblDosPuntos.TabIndex = 1;
            this.LblDosPuntos.Text = ":";
            // 
            // LblMinutos
            // 
            this.LblMinutos.Font = new System.Drawing.Font("Berlin Sans FB", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinutos.Location = new System.Drawing.Point(192, 130);
            this.LblMinutos.Name = "LblMinutos";
            this.LblMinutos.Size = new System.Drawing.Size(62, 41);
            this.LblMinutos.TabIndex = 4;
            this.LblMinutos.Text = "00";
            this.LblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PnlAyuda
            // 
            this.PnlAyuda.Controls.Add(this.BtnVolverAcercaDe);
            this.PnlAyuda.Controls.Add(this.LblCreated);
            this.PnlAyuda.Controls.Add(this.LblVersion);
            this.PnlAyuda.Location = new System.Drawing.Point(320, 40);
            this.PnlAyuda.Name = "PnlAyuda";
            this.PnlAyuda.Size = new System.Drawing.Size(28, 28);
            this.PnlAyuda.TabIndex = 18;
            // 
            // BtnVolverAcercaDe
            // 
            this.BtnVolverAcercaDe.Location = new System.Drawing.Point(216, 190);
            this.BtnVolverAcercaDe.Name = "BtnVolverAcercaDe";
            this.BtnVolverAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.BtnVolverAcercaDe.TabIndex = 2;
            this.BtnVolverAcercaDe.Text = "Volver";
            this.BtnVolverAcercaDe.UseVisualStyleBackColor = true;
            this.BtnVolverAcercaDe.Click += new System.EventHandler(this.BtnVolverAcercaDe_Click);
            // 
            // LblCreated
            // 
            this.LblCreated.AutoSize = true;
            this.LblCreated.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCreated.Location = new System.Drawing.Point(158, 120);
            this.LblCreated.Name = "LblCreated";
            this.LblCreated.Size = new System.Drawing.Size(191, 21);
            this.LblCreated.TabIndex = 1;
            this.LblCreated.Text = "Created by Ema Eroles";
            // 
            // LblVersion
            // 
            this.LblVersion.AutoSize = true;
            this.LblVersion.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVersion.Location = new System.Drawing.Point(208, 70);
            this.LblVersion.Name = "LblVersion";
            this.LblVersion.Size = new System.Drawing.Size(92, 21);
            this.LblVersion.TabIndex = 0;
            this.LblVersion.Text = "Versión 1.0";
            // 
            // PnlEstadisticas
            // 
            this.PnlEstadisticas.Controls.Add(this.LblProximamente);
            this.PnlEstadisticas.Controls.Add(this.BtnVolverEstadisticas);
            this.PnlEstadisticas.Location = new System.Drawing.Point(380, 40);
            this.PnlEstadisticas.Name = "PnlEstadisticas";
            this.PnlEstadisticas.Size = new System.Drawing.Size(28, 28);
            this.PnlEstadisticas.TabIndex = 17;
            // 
            // LblProximamente
            // 
            this.LblProximamente.AutoSize = true;
            this.LblProximamente.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProximamente.Location = new System.Drawing.Point(190, 100);
            this.LblProximamente.Name = "LblProximamente";
            this.LblProximamente.Size = new System.Drawing.Size(128, 21);
            this.LblProximamente.TabIndex = 1;
            this.LblProximamente.Text = "Proximamente";
            // 
            // BtnVolverEstadisticas
            // 
            this.BtnVolverEstadisticas.Location = new System.Drawing.Point(216, 150);
            this.BtnVolverEstadisticas.Name = "BtnVolverEstadisticas";
            this.BtnVolverEstadisticas.Size = new System.Drawing.Size(75, 23);
            this.BtnVolverEstadisticas.TabIndex = 0;
            this.BtnVolverEstadisticas.Text = "Volver";
            this.BtnVolverEstadisticas.UseVisualStyleBackColor = true;
            this.BtnVolverEstadisticas.Click += new System.EventHandler(this.BtnVolverEstadisticas_Click);
            // 
            // LblDescCorto
            // 
            this.LblDescCorto.AutoSize = true;
            this.LblDescCorto.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescCorto.Location = new System.Drawing.Point(40, 190);
            this.LblDescCorto.Name = "LblDescCorto";
            this.LblDescCorto.Size = new System.Drawing.Size(107, 18);
            this.LblDescCorto.TabIndex = 9;
            this.LblDescCorto.Text = "Descanso Corto";
            // 
            // LblDescLargo
            // 
            this.LblDescLargo.AutoSize = true;
            this.LblDescLargo.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescLargo.Location = new System.Drawing.Point(180, 190);
            this.LblDescLargo.Name = "LblDescLargo";
            this.LblDescLargo.Size = new System.Drawing.Size(110, 18);
            this.LblDescLargo.TabIndex = 10;
            this.LblDescLargo.Text = "Descanso Largo";
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(40, 80);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(82, 18);
            this.LblCantidad.TabIndex = 11;
            this.LblCantidad.Text = "Pomodoros";
            // 
            // LblTP
            // 
            this.LblTP.AutoSize = true;
            this.LblTP.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTP.Location = new System.Drawing.Point(180, 80);
            this.LblTP.Name = "LblTP";
            this.LblTP.Size = new System.Drawing.Size(130, 18);
            this.LblTP.TabIndex = 12;
            this.LblTP.Text = "Tiempo Pomodoro";
            // 
            // LblMin2
            // 
            this.LblMin2.AutoSize = true;
            this.LblMin2.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMin2.Location = new System.Drawing.Point(90, 214);
            this.LblMin2.Name = "LblMin2";
            this.LblMin2.Size = new System.Drawing.Size(32, 18);
            this.LblMin2.TabIndex = 13;
            this.LblMin2.Text = "min";
            // 
            // LblMin1
            // 
            this.LblMin1.AutoSize = true;
            this.LblMin1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMin1.Location = new System.Drawing.Point(229, 104);
            this.LblMin1.Name = "LblMin1";
            this.LblMin1.Size = new System.Drawing.Size(32, 18);
            this.LblMin1.TabIndex = 14;
            this.LblMin1.Text = "min";
            // 
            // LblMin3
            // 
            this.LblMin3.AutoSize = true;
            this.LblMin3.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMin3.Location = new System.Drawing.Point(229, 214);
            this.LblMin3.Name = "LblMin3";
            this.LblMin3.Size = new System.Drawing.Size(32, 18);
            this.LblMin3.TabIndex = 15;
            this.LblMin3.Text = "min";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(508, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estadisticasToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.estadisticasToolStripMenuItem.Text = "Estadísticas";
            this.estadisticasToolStripMenuItem.Click += new System.EventHandler(this.estadisticasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de Mi Pomodoro";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // FrmPomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 294);
            this.Controls.Add(this.PnlTimer);
            this.Controls.Add(this.PnlAyuda);
            this.Controls.Add(this.PnlEstadisticas);
            this.Controls.Add(this.LblMin2);
            this.Controls.Add(this.LblTP);
            this.Controls.Add(this.LblMin3);
            this.Controls.Add(this.LblMin1);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.LblDescLargo);
            this.Controls.Add(this.LblDescCorto);
            this.Controls.Add(this.CboCantidad);
            this.Controls.Add(this.CboDesLargo);
            this.Controls.Add(this.CboDesCorto);
            this.Controls.Add(this.BtnComenzar);
            this.Controls.Add(this.CboTmpPomodoro);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPomodoro";
            this.Text = "Mi Pomodoro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPomodoro_FormClosing);
            this.Load += new System.EventHandler(this.FrmPomodoro_Load);
            this.PnlTimer.ResumeLayout(false);
            this.PnlTimer.PerformLayout();
            this.PnlAyuda.ResumeLayout(false);
            this.PnlAyuda.PerformLayout();
            this.PnlEstadisticas.ResumeLayout(false);
            this.PnlEstadisticas.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CboTmpPomodoro;
        private System.Windows.Forms.Button BtnComenzar;
        private System.Windows.Forms.ComboBox CboDesCorto;
        private System.Windows.Forms.ComboBox CboDesLargo;
        private System.Windows.Forms.ComboBox CboCantidad;
        private System.Windows.Forms.Panel PnlTimer;
        private System.Windows.Forms.Label LblSegundos;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnPausePlay;
        private System.Windows.Forms.Button BtnPaso;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LblMinutos;
        private System.Windows.Forms.Label LblDosPuntos;
        private System.Windows.Forms.Label LblDescCorto;
        private System.Windows.Forms.Label LblDescLargo;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Label LblTP;
        private System.Windows.Forms.Label LblP4;
        private System.Windows.Forms.Label LblP3;
        private System.Windows.Forms.Label LblP2;
        private System.Windows.Forms.Label LblP1;
        private System.Windows.Forms.Label LblP8;
        private System.Windows.Forms.Label LblP7;
        private System.Windows.Forms.Label LblP6;
        private System.Windows.Forms.Label LblP5;
        private System.Windows.Forms.Label LblMin2;
        private System.Windows.Forms.Label LblMin1;
        private System.Windows.Forms.Label LblMin3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel PnlEstadisticas;
        private System.Windows.Forms.Panel PnlAyuda;
        private System.Windows.Forms.Label LblProximamente;
        private System.Windows.Forms.Button BtnVolverEstadisticas;
        private System.Windows.Forms.Button BtnVolverAcercaDe;
        private System.Windows.Forms.Label LblCreated;
        private System.Windows.Forms.Label LblVersion;
    }
}

