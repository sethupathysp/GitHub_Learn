using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GridPrintPreviewLib;

namespace TestApp
{
    class MyGridDoc : GridPrintDocument
    {
        public MyGridDoc(DataGridView source, Font docFont, bool flagHeader)
            : base(source, docFont, flagHeader)
        {
        }

        protected override void onDrawCell(System.Drawing.Graphics g, string s, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat format, System.Drawing.Font font, System.Drawing.Brush brush, System.Drawing.Brush brushBack, System.Windows.Forms.DataGridViewAdvancedBorderStyle borderStyle)
        {
            borderStyle.Left = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
            borderStyle.Right = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
            base.onDrawCell(g, s, layoutRect, format, font, brush, brushBack, borderStyle);
        }

        protected override void onDrawColumnHeader(System.Drawing.Graphics g, string s, System.Drawing.RectangleF layoutRect, System.Drawing.StringFormat format, System.Drawing.Font font, System.Windows.Forms.DataGridViewAdvancedBorderStyle borderStyle)
        {
            borderStyle.All = System.Windows.Forms.DataGridViewAdvancedCellBorderStyle.Single;
            base.onDrawColumnHeader(g, s, layoutRect, format, font, borderStyle);
        }
    }
}
