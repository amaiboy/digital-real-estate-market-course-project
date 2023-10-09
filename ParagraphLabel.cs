using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace digital_real_estate_market_course_project;
public class ParagraphLabel : Label
{
    public ParagraphLabel()
    {
        Font = new Font("Segoe UI", 10F, GraphicsUnit.Point);
        Size = new Size(839, 20);
        AutoSize = false;
    }
}
