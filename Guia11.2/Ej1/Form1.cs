using Ej1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.ConstrainedExecution;

namespace Ej1
{
    public partial class Form1 : Form
    {

        FiscalizadorVTV FiscalizadorVTV = new FiscalizadorVTV();
        VTV vtv;
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs = null;
            try
            {
                if (File.Exists("fiscalizador.dat"))
                {
                    fs = new FileStream("fiscalizador.dat", FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();
                    FiscalizadorVTV = bf.Deserialize(fs) as FiscalizadorVTV;
                }
                for (int i = 0; i < FiscalizadorVTV.CantidadVTV; i++)
                {
                    FormVer ver = new FormVer();
                    vtv = FiscalizadorVTV[i];
                    ver.tBdatos.Text += vtv.ToString();
                }
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        #endregion 
       
        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                Propietario p = null;
                string nom = tBnombre.Text;
                int dni = Convert.ToInt32(tBdni.Text);
                string email = tBemail.Text;              
                string pat = tBpatente.Text;
                p = new Propietario(dni, nom, email);
                vtv = new VTV(pat, p);
                int i = 0;
                FormEvaluacion ev;
                FormVer ver = new FormVer();
                while (i < vtv.CantidadVerificaciones)
                {
                    ev = new FormEvaluacion();
                    Evaluacion eval = vtv[i];
                    ev.tBnombre.Text = eval.Nombre;
                    ev.tBdesc.Text = eval.Descripcion;

                    if (eval is EvaluacionParametrica)
                    {
                        EvaluacionParametrica evalu = (EvaluacionParametrica)eval;
                        ev.lUnidad.Text = evalu.Unidad;
                        ev.groupBox2.Enabled = false;
                        ev.tBminimo.Enabled = false;
                        ev.tBmaximo.Enabled = false;
                        ev.tBminimo.Text = evalu.ValorMinimo.ToString();
                        ev.tBmaximo.Text = evalu.ValorMaximo.ToString();

                        if (ev.ShowDialog() == DialogResult.OK)
                        {

                            double med = Convert.ToDouble(ev.tBmedido.Text);
                            evalu.ValorMedido = med;
                        }
                    }
                    else
                    {
                        EvaluacionSimple evalu = (EvaluacionSimple)eval;
                        ev.groupBox1.Enabled = false;
                        if (ev.ShowDialog() == DialogResult.OK)
                        {
                            bool correcto = ev.cBfunciona.Checked;
                            evalu.HaVerificado = correcto;
                        }
                    }
                    ver.tBdatos.Text += eval.ToString();
                    i++;
                }
                ver.tBdatos.Text += vtv.ToString();
                FiscalizadorVTV.AgregarVTV(p, pat).Aprobacion=vtv.Aprobacion;
                ver.ShowDialog();
            }                      
            catch (DniInvalidoException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
            catch (PatenteInvalidaException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
            catch(EmailInvalidoException ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message+Environment.NewLine+ ex.StackTrace);
            }            
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            FormVer ver = new FormVer();
            FiscalizadorVTV.VTVs.Sort();
            for(int i = 0; i < FiscalizadorVTV.CantidadVTV; i++)
            {
                ver.tBdatos.Text += FiscalizadorVTV[i].ToString();
            }
            ver.ShowDialog();            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream("fiscalizador.dat", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, FiscalizadorVTV);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void bImportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos csv|*.csv";
            try
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);
                    sr.ReadLine();
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        string[] campos = sr.ReadLine().Split(';');
                        string patente = campos[1];
                        Propietario p = new Propietario(Convert.ToInt32(campos[2]), campos[3], $"{campos[3].Trim()}@gmail.com");
                        vtv = new VTV(patente, p);
                        for (int i = 0; i < 6; i++)
                        {
                            campos = sr.ReadLine().Split(';');
                            EvaluacionSimple es;
                            EvaluacionParametrica ep;
                            if (Convert.ToInt32(campos[1]) == 5)
                            {
                                es = vtv[5] as EvaluacionSimple;
                                es.HaVerificado = Convert.ToBoolean(Convert.ToInt32(campos[2]));
                            }
                            else
                            {
                                ep = vtv[i] as EvaluacionParametrica;
                                ep.ValorMedido = Convert.ToDouble(campos[2]);
                            }
                        }
                        FiscalizadorVTV.AgregarVTV(p, patente);
                    }
                    
                }
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
            }
         
        }

        private void bExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Archivos CSV|*.csv";
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                if (save.ShowDialog() == DialogResult.OK)
                {
                    fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                    sw = new StreamWriter(fs);
                    sw.WriteLine("Patente; DNI Propietario; Nombre Propietario");
                    for (int i = 0; i < FiscalizadorVTV.CantidadVTV; i++)
                    {
                        vtv = FiscalizadorVTV[i];
                        sw.WriteLine($"{vtv.Patente};{vtv.propietario.DNI};{vtv.propietario.ApellidoNombres}");
                    }
                    
                }
            }
            finally
            {
                if (sw != null) sw.Close();
                if (fs != null) fs.Close();
            }
            
        }
    }
}
