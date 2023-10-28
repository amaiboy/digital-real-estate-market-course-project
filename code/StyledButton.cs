using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code
{
    public class StyledButton : Button
    {
        public StyledButton()
        {
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
        }
    }
}
