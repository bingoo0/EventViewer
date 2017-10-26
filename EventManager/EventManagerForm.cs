using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace EventManager
{
    public partial class EventManager : Form
    {
        
        public EventManager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Delete Button
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\OneDrive\Documents\EventViewerDB.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();


            var delete = @"Delete from newEventViewer Where 
                          (Eventname = '" + eventName.Text + "')";
            SqlCommand createCommand = new SqlCommand(delete, connection);


            if (MessageBox.Show("Do you want to remove the event","Remove event" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                createCommand.ExecuteNonQuery();               
                MessageBox.Show("Deleted Succsesfully Saved");
                connection.Close();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Event not removed","Remove event", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Create Button
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\OneDrive\Documents\EventViewerDB.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();


            var create = @"INSERT INTO newEventViewer VALUES 
                          ('" + eventName.Text + "', '" 
                          + eventLocation.Text + "', '" 
                          + startTime.Value.ToString() + "', '" 
                          + endTime.Value.ToString() + "')";
            SqlCommand createCommand = new SqlCommand(create,connection);



            createCommand.ExecuteNonQuery();
           
            connection.Close();
            MessageBox.Show("Succsesfully Saved");
            eventName.Clear();
            eventLocation.Clear();
            DisplayData();
            
        }

        public void DisplayData()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\OneDrive\Documents\EventViewerDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select * from newEventViewer", connection);
            DataTable dt = new DataTable();
            dataGridView.Rows.Clear();
            sda.Fill(dt);
            foreach (DataRow item in dt.Rows)
            {
                var makeNRows = dataGridView.Rows.Add();
                dataGridView.Rows[makeNRows].Cells[0].Value = item[0].ToString();
                dataGridView.Rows[makeNRows].Cells[1].Value = item[1].ToString();
                dataGridView.Rows[makeNRows].Cells[2].Value = item[2].ToString();
                dataGridView.Rows[makeNRows].Cells[3].Value = item[3].ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Update Button
            SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mehme\OneDrive\Documents\EventViewerDB.mdf;Integrated Security=True;Connect Timeout=30");
            connection.Open();


            var update = @" UPDATE newEventViewer SET Eventname ='" + eventName.Text
               + "' Where (Eventname = '" + eventName.Text + "')";
            SqlCommand createCommand = new SqlCommand(update, connection);


            if (MessageBox.Show("Do you want to update the event", "Update event", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                createCommand.ExecuteNonQuery();
                MessageBox.Show("Updated Succsesfully ");
                connection.Close();
                DisplayData();
            }
            else
            {
                MessageBox.Show("Event not updated", "Update event", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void eventLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void eventName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            eventName.Text = string.Empty;
            eventLocation.Text = string.Empty;
            endTime.Text = string.Empty;
            startTime.Text = string.Empty;
        }

        private void EventManager_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            eventName.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            eventLocation.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            
        }
    }
}
