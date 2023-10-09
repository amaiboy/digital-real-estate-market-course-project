using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace digital_real_estate_market_course_project;
public class HeadingLabel : Label
{
    public HeadingLabel()
    {
        Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
    }
}