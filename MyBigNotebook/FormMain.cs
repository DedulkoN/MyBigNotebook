﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBigNotebook
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            ClassData data = new ClassData();
            data.SaveData();
            data.LoadData();

            
            GoogleDriveClass google = new GoogleDriveClass();
            google.Authorize();
            bool a = google.FileUpdate("File1", "asdasfgdsfgda");
           
        }
    }
}
