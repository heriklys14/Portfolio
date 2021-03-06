﻿using SmartDoku.Main.Controller;
using SmartDoku.Main.Model;
using System;
using System.Windows.Forms;

namespace SmartDoku
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    public SDUtils sdUtils {
      get
      {
        if (_sdUtils == null)
          _sdUtils = new SDUtils();

        return _sdUtils;
      }
    }
    private SDUtils _sdUtils;

    private void ResetaMatriz()
    {
      SDMatrizModel matriz = new SDMatrizModel();
      this.sdMatrixGrid.Matriz = matriz;
      this.sdMatrixGrid.AmarraMatrizAoGrid();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      ResetaMatriz();
    }

    private void btnGeraMatriz_Click(object sender, EventArgs e)
    {
      ResetaMatriz();
      this.sdMatrixGrid.Matriz = sdUtils.MontaGrid();
      //sdUtils.GeraDigitosIniciais(this.sdMatrixGrid.Matriz, Convert.ToInt32(this.tbDigitsIniciais.Text));
      this.sdMatrixGrid.AmarraMatrizAoGrid();
    }

    private void btnResetaMatriz_Click(object sender, EventArgs e)
    {
      ResetaMatriz();
    }

    private void btnResolveSudoku_Click(object sender, EventArgs e)
    {
      sdUtils.ResolveSudoku(this.sdMatrixGrid.Matriz);
      this.sdMatrixGrid.AmarraMatrizAoGrid();
    }
  }
}
