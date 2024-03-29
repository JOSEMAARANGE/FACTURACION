﻿using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace FACTURACION
{
    public partial class AsientoContable : Form
    {
        public AsientoContable()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {

        }

        private void Emitirbutton_Click(object sender, EventArgs e)
        {
        }

        public class ExcelProcessor
        {
            public void ProcessExcel(string filePath)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);
                Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Excel.Range xlRange = xlWorksheet.UsedRange;

                // Validar la fecha del asiento
                DateTime date;
                if (!DateTime.TryParse(xlRange.Cells[1, 2].Value2.ToString(), out date))
                {
                    MessageBox.Show("Formato de fecha incorrecto en la celda B1");
                    return;
                }

                // Validar el encabezado del asiento
                string header = xlRange.Cells[2, 2].Value2.ToString();
                if (string.IsNullOrEmpty(header))
                {
                    MessageBox.Show("Falta el encabezado del asiento en la celda B2");
                    return;
                }

                // Procesar las filas a partir de la fila 5
                for (int i = 5; i <= xlRange.Rows.Count; i++)
                {
                    string accountCode = xlRange.Cells[i, 1].Value2.ToString();
                    string accountDescription = xlRange.Cells[i, 2].Value2.ToString();
                    decimal debitAmount = Convert.ToDecimal(xlRange.Cells[i, 3].Value2);
                    decimal creditAmount = Convert.ToDecimal(xlRange.Cells[i, 4].Value2);

                    // Crear el asiento contable
                    CreateAccountingEntry(accountCode, accountDescription, debitAmount, creditAmount);
                }

                MessageBox.Show("Asiento contable creado exitosamente");

                // Limpiar
                GC.Collect();
                GC.WaitForPendingFinalizers();

                Marshal.ReleaseComObject(xlRange);
                Marshal.ReleaseComObject(xlWorksheet);

                xlWorkbook.Close();
                Marshal.ReleaseComObject(xlWorkbook);

                xlApp.Quit();
                Marshal.ReleaseComObject(xlApp);
            }
            private void CreateAccountingEntry(string accountCode, string accountDescription, decimal debitAmount, decimal creditAmount)
            {


            }

            public class Asiento
            {
                public string Propiedad1 { get; set; }
                public string Propiedad2 { get; set; }
                // Agrega todas las propiedades necesarias
            }
        }

    }
}