using System;
using System.Drawing;
using System.Windows.Forms;

namespace RandomNamePicker
{
    public partial class Index : Form
    {
        //------------------------------Variables------------------------------\\
        public ToolTip ToolTipMenu = new ToolTip();
        public ToolTip ToolTipInsert = new ToolTip();
        public ToolTip ToolTipDelete = new ToolTip();
        public ToolTip ToolTipRandomizer = new ToolTip();

        //Variables para la animación
        public int LimitePositivo = 266, LimiteNegativo = 110;
        public int AnimationSmooth = 15;
        public bool isOpen = true;

        //RNG o suerte del programa (Factor "al azar")
        Random rng = new Random();
        string[] OutputtingArray = null;
        int tickCounter = 0;

        public Index()
        { InitializeComponent(); }

        #region Botones
        #region Boton Salir
        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult Dialogo =
                MessageBox.Show("¿Está seguro que desea salir de la aplicación?", "¡Saliendo de la app!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (Dialogo == DialogResult.Yes) //Sí presiono si, pues sal de la aplicación
                Application.Exit();
        }
        #endregion

        #region Maximize
        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            switch (WindowState)
            {
                case FormWindowState.Normal:
                    WindowState = FormWindowState.Maximized;
                    break;

                case FormWindowState.Maximized:
                    WindowState = FormWindowState.Normal;
                    break;
            }
        }
        #endregion

        #region Minimize
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Menu
        private void Menu_Click(object sender, EventArgs e)
        { AnimationDespliegueMenu.Enabled = true; }

        #endregion

        #region Borrar
        private void Delete_Click(object sender, EventArgs e)
        {
            try
            { UserList.Items.RemoveAt(UserList.SelectedIndex); }
            catch (Exception error)
            { MessageBox.Show("No se pudo eliminar el participante correctamente\n\nCausa del error: " + error.Message + "\n" + error.HResult + "\n\nAyuda: Intente seleccionar primero un participante valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        #endregion

        #region Insertar
        private void Insert_Click(object sender, EventArgs e)
        {
            string Output =
            Microsoft.VisualBasic.Interaction.InputBox("Dígite el nombre de la persona que quiera insertar", "Insertar", "ej... Juan");

            try
            {
                UserList.Items.Add(Output);
                //MessageBox.Show("Participante: \"" + Output + "\" se ha insertado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (Exception error)
            { MessageBox.Show("No se pudo insertar el participante \"" + Output + "\" correctamente\nCausa del error: " + error.Message + "\n" + error.HResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Randomizar
        private void Randomizer_Click(object sender, EventArgs e)
        { OutputArray(); }

        public string[] OutputArray()
        {
            OutputtingArray = new string[UserList.Items.Count];
            int count = UserList.Items.Count;

            try
            {
                for (int i = 0; i < count; i++)
                {
                    OutputtingArray[i] = UserList.Items[i].ToString();
                }

                //Ejecutando la animación de tomar al azar...
                RandomAnim.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show("No se pudo tomar a un participante :(\n\nCausa del error:\n\n" + error.Message + "\n" + error.HResult, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return OutputtingArray;
        }

        //Animación
        private void RandomAnim_Tick(object sender, EventArgs e)
        {
            try
            {
                tickCounter++;
                SelectedUser.Text = OutputtingArray[rng.Next(0, OutputtingArray.Length)];

                winFeedback.BackColor = Color.Red;

                if (tickCounter >= 50)
                {
                    RandomAnim.Enabled = false;
                    winFeedback.BackColor = Color.Green;
                    tickCounter = 0;
                }
            }
            catch (Exception error)
            {
                RandomAnim.Enabled = false;
                MessageBox.Show("No se pudo tomar a un participante :(\n\nCausa del error:\n\n" + error.Message + "\n" + error.HResult, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #endregion

        //-----------------------Comportamientos-----------------------//
        #region Menu
        private void AnimationDespliegueMenu_Tick(object sender, EventArgs e)
        {
            int anchura = LeftPanel.Size.Width;

            //si está abierto, escondelo
            if (isOpen)
            {
                //que no se pase del rango
                if (LeftPanel.Size.Width <= LimiteNegativo)
                {
                    AnimationDespliegueMenu.Enabled = false;
                    LeftPanel.Size = new System.Drawing.Size(LimiteNegativo, LeftPanel.Size.Height);
                    isOpen = false;
                    return;
                }

                LeftPanel.Size = new System.Drawing.Size(anchura - AnimationSmooth, LeftPanel.Size.Height);
            }
            //si está cerrado, ábrelo
            else
            {
                //que no se pase del rango
                if (LeftPanel.Size.Width >= LimitePositivo)
                {
                    AnimationDespliegueMenu.Enabled = false;
                    LeftPanel.Size = new System.Drawing.Size(LimitePositivo, LeftPanel.Size.Height);
                    isOpen = true;
                    return;
                }

                LeftPanel.Size = new System.Drawing.Size(anchura + AnimationSmooth, LeftPanel.Size.Height);
            }

        }
        #endregion

        #region Al Cargar Formulario
        private void Index_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("¡Bienvenido al sistema de randomización!", "¡Welcome!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ToolTipMenu.SetToolTip(Menu, "Plegar o desplegar el menu");
            ToolTipInsert.SetToolTip(Insert, "Inserta los participantes para randomizar");
            ToolTipDelete.SetToolTip(Delete, "Borra el ultimo participante ya insertado de la lista");
            ToolTipRandomizer.SetToolTip(Randomizer, "Poner al azar los participantes actuales");
        }
        #endregion
    }
}
