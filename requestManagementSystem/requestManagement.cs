using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class requestManagement : Form
    {
        private string sid;
        Form main;
        public requestManagement(string sid,Form main)
        {
            this.main = main;
            this.sid = sid;
            InitializeComponent();
            dgvReload();

        }
        void dgvReload()
        {
            RequestManagementEntities rme = new RequestManagementEntities();
            transfer tf = new transfer();
            studyingLiecense sl = new studyingLiecense();
            string[] allSplited;
            string[] dateSplited;
            string date;
            foreach (var trans in rme.transfers.ToList())
            {
                if (trans.id == sid)
                {
                    allSplited = Convert.ToString(trans.sendDate).Split(' ');
                    dateSplited = Convert.ToString(allSplited[0]).Split('/');
                    date = dateSplited[2] + "/" + dateSplited[1] + "/" + dateSplited[0];
                    studentRequestManagementDgv.Rows.Add("درخواست انتقالی", date, trans.accepted);
                }
            }
            foreach (var sls in rme.studyingLiecenses.ToList())
            {
                if (sls.id == sid)
                {
                    allSplited = Convert.ToString(sls.sendDate).Split(' ');
                    dateSplited = Convert.ToString(allSplited[0]).Split('/');
                    date = dateSplited[2] + "/" + dateSplited[1] + "/" + dateSplited[0];
                    studentRequestManagementDgv.Rows.Add("درخواست اشتغال به تحصیل", date, sls.accepted);
                }
            }
        }
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3 && senderGrid.Rows[e.RowIndex].Cells[0].Value == "درخواست انتقالی")
            {
                RequestManagementEntities rme = new RequestManagementEntities();
                rme.transfers.Remove(rme.transfers.Where(x => x.id == sid).FirstOrDefault());
                rme.SaveChanges();
                senderGrid.Rows.RemoveAt(e.RowIndex);
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 3 && (string)senderGrid.Rows[e.RowIndex].Cells[0].Value == "درخواست اشتغال به تحصیل")
            {
                RequestManagementEntities rme = new RequestManagementEntities();
                rme.studyingLiecenses.Remove(rme.studyingLiecenses.Where(x => x.id == sid).FirstOrDefault());
                rme.SaveChanges();
                senderGrid.Rows.RemoveAt(e.RowIndex);
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4 && (string)senderGrid.Rows[e.RowIndex].Cells[0].Value == "درخواست اشتغال به تحصیل")
            {
                eshteghalTahsilReqForm etrf = new eshteghalTahsilReqForm(sid,main);
                etrf.Show();
                etrf.setForEdit();
                
            }
            else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0 && e.ColumnIndex == 4 && senderGrid.Rows[e.RowIndex].Cells[0].Value == "درخواست انتقالی")
            {
                EnteghalForm tr = new EnteghalForm(sid, main);
                tr.Show();
                tr.setForEdit();

            }
        }


    
    }
}
