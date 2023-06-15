using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KnjiznicaProjekt
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private string[] quotes;
        private int currentIndex;
        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            InitializeQuotes();
        }
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 5000; 
            timer.Tick += timer1_Tick;
            timer.Start();
        }
        private void InitializeQuotes()
        {
            quotes = new string[]
            {
                "„Oh, kako je dobro biti među ljudima koji čitaju knjige.” – Rainer Maria",
                "„Postoje gora zlodjela od paljenja knjiga. Jedno od njih je ne čitati knjige.” – Josip Brodsky",
                "„Knjiga je dar koji možeš otvarati opet i opet.” – Garrison Kellior",
                "„Onaj tko ne voli čitati nije pronašao pravu knjigu za sebe.” – J.K. Rowling",
                "„Čovjek koji ne čita dobre knjige nije nimalo bolji od čovjeka koji uopće ne čita.” – Mark Twain",
                "„Znaš da si pročitao dobru knjigu kada nakon što pročitaš zadnju stranicu se osjećaš kao da si izgubio prijatelja.” – Paul Sweeney",
                "„Dobra knjiga je događaj u mom životu.” – Stendhal",
                "„Jednog sam dana pročitao knjigu i cijeli mi se život promijenio.” – Orhan Pamuk",
                "„Klasik – knjiga koju ljudi hvale i ne čitaju.” – Mark Twain",
                "„Ne vjeruj nikome tko nije ponio knjigu sa sobom.” – Lemony Snicket"
            };
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= quotes.Length)
            {
                currentIndex = 0;
            }

            label2.Text = quotes[currentIndex];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayPopularBooks();
        }
        private void DisplayPopularBooks()
        {
            popularBooksRichTextBox.Text = ""; // Ocisti textbox

            string connectionString = "Data Source=f3ar13ss\\sqlexpress;Initial Catalog=KnjiznicaProjekt;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT TOP 10 Knjiga, BrojPosudbi FROM PopularneKnjige ORDER BY BrojPosudbi DESC";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string bookTitle = reader["Knjiga"].ToString();
                        int rentalCount = Convert.ToInt32(reader["BrojPosudbi"]);

                        //  informacije o knjizi u rich textbox
                        popularBooksRichTextBox.AppendText($"Knjiga: {bookTitle}, Broj posudbi: {rentalCount}\n");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                //iznimke koje se dogode prilikom pristupa bazi podataka
                MessageBox.Show("An error occurred while accessing the database: " + ex.Message);
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form form=new frmKnjige();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form= new frmPosuditelji();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form=new frmTransakcije();
            form.Show();
        }

        private void najpopularnijeKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form=new frmNajpopularnije();
            form.Show();
        }

        private void nevraćeneKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmNevracene();
            form.Show();
        }

        private void posuđeneKnjigeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmPosudjene();
            form.Show();
        }

        
    }
}
