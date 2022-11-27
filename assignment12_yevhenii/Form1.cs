using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment12_yevhenii
{
    public partial class Form1 : Form
    {

        List<ProductionWorker> productionWorkers = new List<ProductionWorker>();
        public Form1()
        {
            InitializeComponent();
            loadShifts();
        }

        private void loadShifts()
        {
            foreach (Shift shift in Enum.GetValues(typeof(Shift)))
            {
                this.select_shift.Items.Add(shift);
            }
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            Shift shift;
            if (Enum.TryParse<Shift>(this.select_shift.Text, out shift))
            {
                productionWorkers.Add(new ProductionWorker(this.input_name.Text, int.Parse(this.input_emp_num.Value.ToString()), shift, int.Parse(this.input_hourly_pay.Value.ToString())));
                displayEmployees();
            }
            else
            {
                MessageBox.Show("Wrong input", "Wrong input", MessageBoxButtons.OK);
            }
        }

        private void displayEmployees()
        {
            this.label_list.Text = "";
            foreach (ProductionWorker productionWorker in productionWorkers)
            {
                this.label_list.Text += productionWorker.ToString() + "\n";
            }
        }
    }
}
