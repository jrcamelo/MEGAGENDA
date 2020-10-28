using MEGAGENDA.CONTROLLER;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MEGAGENDA.VIEW
{
    public partial class Ajuda : Form
    {
        public Ajuda()
        {
            InitializeComponent();

            foreach (KeyValuePair<string, string> word in Editor.Preparar_Keywords())
                listBox1.Items.Add(word.Key);
        }
    }
}
