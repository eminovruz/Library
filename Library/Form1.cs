using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        SqlConnection? connection = null;
        SqlDataReader? reader = null;

        public Form1()
        {
            InitializeComponent();

            string? connectionString = "Data Source=DESKTOP-8V8B7U4\\MSSQLSERVER01;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectionString);
            BringData();
        }

        private void BringData()
        {

            try
            {
                connection?.Open();

                using SqlCommand command = new("SELECT * FROM AUTHORS", connection);
                reader = command.ExecuteReader();


                while (reader.Read())
                {
                    author_cmbx.Items.Add(reader[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }
        }

        private void author_cmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();

                using SqlCommand command = new("SELECT * FROM CATEGORIES", connection);
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    book_cmbx.Items.Add(reader[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }

        }

        private void execute_btn_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();


                string commandText = @"SELECT  * FROM Books
JOIN Authors ON Authors.Id = Books.Id_Author
JOIN Categories ON Categories.Id = Books.Id_Category
WHERE Authors.FirstName = @p1 AND Categories.[Name] = @p2";

                using SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@p1", author_cmbx.SelectedItem.ToString());
                command.Parameters.AddWithValue("@p2", book_cmbx.SelectedItem.ToString());

                reader = command.ExecuteReader();

                bookinfo_listbox.Items.Clear();
                while (reader.Read())
                {
                    bookinfo_listbox.Items.Add(reader[1]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();

                string? commandText = @"DELETE FROM Books WHERE [Name] = @p1";

                using SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@p1", bookinfo_listbox.SelectedItem);

                command.ExecuteNonQuery();

                bookinfo_listbox.Items.Remove(bookinfo_listbox.SelectedItem);

                MessageBox.Show("FK_Constraint ERROR");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();

                string? commandText = @"INSERT INTO Authors(Id, FirstName, LastName) VALUES(18, @a1, @a2)";

                using SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@a1", textBox1.Text);
                command.Parameters.AddWithValue("@a2", textBox2.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Succesfully added!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection?.Open();

                string? commandText = @"DELETE FROM AUTHORS WHERE [FirstName] = @a1 AND [LastName] = @a2";

                using SqlCommand command = new SqlCommand(commandText, connection);

                command.Parameters.AddWithValue("@a1", textBox1.Text);
                command.Parameters.AddWithValue("@a2", textBox2.Text);

                command.ExecuteNonQuery();

                MessageBox.Show("Succesfully deleted!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally { connection?.Close(); reader?.Close(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            author_cmbx.Items.Clear();
            BringData();
        }
    }
}