using System.Net.Mail;
using System.Net.Security;
using System.Text;

namespace IT488_TheBigThreeServiceTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    
                if (comboBox1.SelectedText == "Account") 
                {
                    try
                    {
                        MailMessage mm = new MailMessage();
                        SmtpClient sc = new SmtpClient("smtp-mail.outlook.com");
                        mm.From = new MailAddress("");
                        mm.To.Add("bigthree.accountservice@gmail.com");
                        mm.Subject = "Test-account";
                        var sb = new StringBuilder();
                        sb.Append("Name:" + textBox1.Text + textBox2.Text);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(textBox3.Text);
                        mm.Body = sb.ToString();
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("", "");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                        MessageBox.Show("Ticket Submitted. Your ticket number is");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (comboBox1.SelectedText == "Hardware")
                {
                    try
                    {
                        MailMessage mm = new MailMessage();
                        SmtpClient sc = new SmtpClient("smtp-mail.outlook.com");
                        mm.From = new MailAddress("");
                        mm.To.Add("bigthree.hardwareservice@gmail.com");
                        mm.Subject = "Test-hardware";
                        var sb = new StringBuilder();
                        sb.Append("Name:" + textBox1.Text + textBox2.Text);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(textBox3.Text);
                        mm.Body = sb.ToString();
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("", "");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                        MessageBox.Show("Ticket Submitted. Your ticket number is");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else if (comboBox1.SelectedText == "Software")
                {
                    try
                    {
                        MailMessage mm = new MailMessage();
                        SmtpClient sc = new SmtpClient("smtp-mail.outlook.com");
                        mm.From = new MailAddress("");
                        mm.To.Add("bigthree.softwareservice@gmail.com");
                        mm.Subject = "Test-software";
                        var sb = new StringBuilder();
                        sb.Append("Name:" + textBox1.Text + textBox2.Text);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(textBox3.Text);
                        mm.Body = sb.ToString();
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("", "");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                        MessageBox.Show("Ticket Submitted. Your ticket number is");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
                }
                else if (comboBox1.SelectedText == "Store")
                {
                    try
                    {
                        MailMessage mm = new MailMessage();
                        SmtpClient sc = new SmtpClient("smtp-mail.outlook.com");
                        mm.From = new MailAddress("");
                        mm.To.Add("bigthree.storeservice@gmail.com");
                        mm.Subject = "Test-store";
                        var sb = new StringBuilder();
                        sb.Append("Name:" + textBox1.Text + textBox2.Text);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(Environment.NewLine);
                        sb.Append(textBox3.Text);
                        mm.Body = sb.ToString();
                        sc.Port = 587;
                        sc.Credentials = new System.Net.NetworkCredential("", "");
                        sc.EnableSsl = true;
                        sc.Send(mm);
                        MessageBox.Show("Ticket Submitted. Your ticket number is");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                
                }
                
            
            
        }
    }
}
