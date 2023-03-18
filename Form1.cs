namespace FirstUI;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;

public partial class Form1 : Form
{

    public Form1()
    {
        InitializeComponent();
    }

    private void btnHello_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    public void txtPlayerName_TextChanged(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }
    public string userInputMode()
    {
        return txtMode.Text.ToLower();
    }
    public async void btnCalculate_Click(object sender, EventArgs e)
    {
        FetchStats fetchStats = new FetchStats();
        lblStats.Text = "fetching stats...";
        await fetchStats.mkObj(txtMode.Text, txtPlayerName.Text);

        System.Diagnostics.Debug.WriteLine("form: " + fetchStats.GetFinalKills());
        double dblFkdr = (double)fetchStats.GetFinalKills() / (double)fetchStats.GetFinalDeaths();
        double dblBblr = (double)fetchStats.GetBedsBroken() / (double)fetchStats.GetBedsLost();
        double dblWlr = (double)fetchStats.GetWins() / (double)fetchStats.GetLosses();
        lblStats.Text = $"FKDR: {Math.Round(dblFkdr, 2)} \nBBLR: {Math.Round(dblBblr), 2} \nWLR: {Math.Round(dblWlr), 2} \nKills: {fetchStats.GetKills()} \nDeaths: {fetchStats.GetDeaths()} \nWins: {fetchStats.GetWins()} \nLosses: {fetchStats.GetLosses()} \nFinals: {fetchStats.GetFinalKills()} \nFinal Deaths: {fetchStats.GetFinalDeaths()}";

    }





}