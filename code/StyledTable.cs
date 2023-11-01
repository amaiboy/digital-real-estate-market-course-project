using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public class StyledTable : DataGridView
    {
        public StyledTable()
        {
            this.AllowUserToAddRows = false;
            this.AllowUserToDeleteRows = false;
            this.AllowUserToOrderColumns = true;
            this.AllowUserToResizeRows = false;
            this.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BackgroundColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ColumnHeadersHeight = 35;
            this.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EnableHeadersVisualStyles = false;
            this.Location = new System.Drawing.Point(5, 66);
            this.Name = "dataGridViewListings";
            this.ReadOnly = true;
            this.RowHeadersVisible = false;
            this.RowTemplate.Height = 50;
            this.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Size = new System.Drawing.Size(758, 429);
            this.TabIndex = 4;
        }
    }
}
