using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Levi_fitness
{
    public partial class Swimming : Form
    {
        private string connectionString = "Data Source=fitdatabase.db;Version=3;";
        public Swimming()
        {
            InitializeComponent();
        }

        private void goHome_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            if (getTime.Text != "" && getHeart.Text != "")
            {
                int lap;
                int heart;
                int time;

                bool vallap = int.TryParse(levellap.Value.ToString(), out lap);
                bool valheart = int.TryParse(getHeart.Text, out heart);
                bool valtime = int.TryParse(getTime.Text, out time);

                int calory = (lap * heart * time) / 100;

                if (valtime && vallap && valheart)
                {
                    using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                    {
                        conn.Open();

                        string selectDataQuery = "SELECT value FROM calory WHERE id = 1 ";
                        using (SQLiteCommand cmd = new SQLiteCommand(selectDataQuery, conn))
                        {
                            object fetchedData = cmd.ExecuteScalar();
                            if (fetchedData != null)
                            {
                                string data = fetchedData.ToString();
                                int calory_value = int.Parse(data);
                                if (calory >= calory_value)
                                {
                                    MessageBox.Show("You have Successfully burn " + calory + " calories, and exceeded your calory limits",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("You have not reached your calory limit: " + calory, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                }

                            }
                            else
                            {
                                MessageBox.Show("There is no Set Calory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }

                        }

                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Numbers are Expected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                MessageBox.Show("Input fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
