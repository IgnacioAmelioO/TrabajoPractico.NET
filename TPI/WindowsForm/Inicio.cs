using DTOs;
using System.Threading.Tasks;
namespace WindowsForm
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.Load += Personas_Load;
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void buscarButton_click(object sender, EventArgs e)
        {

            if (int.TryParse(inputIdAlumno.Text, out int idBuscado))
            {
                Persona persona = await PersonaApiClient.GetAsync(idBuscado);
                this.personasGrid.DataSource = persona != null ? new List<Persona> { persona } : new List<Persona>();

            }
            else
            {
                MessageBox.Show("Por favor ingresá un ID válido (número).");
            }
        }

        private async void GetAllAndLoad()
        {
            this.personasGrid.DataSource = null;
            var personas = await PersonaApiClient.GetAllAsync();

            this.personasGrid.DataSource = personas.ToList();

            if (this.personasGrid.Rows.Count > 0)
            {
                this.personasGrid.Rows[0].Selected = true;
                this.eliminarButton.Enabled = true;
                this.modificarButton.Enabled = true;
            }
            else
            {
                this.eliminarButton.Enabled = false;
                this.modificarButton.Enabled = false;
            }
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            this.GetAllAndLoad();
        }

        private async void eliminarButton_Click(object sender, EventArgs e)
        {
            int id;

            id = this.SelectedItem().Id_persona;
            await PersonaApiClient.DeleteAsync(id);

            this.GetAllAndLoad();
        }

        private Persona SelectedItem()
        {
            Persona persona;

            persona = (Persona)personasGrid.SelectedRows[0].DataBoundItem;

            return persona;
        }
    }
}
