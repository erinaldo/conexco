using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConexcoFacturación
{
    public partial class ListColorBox : ComboBox
    {
        public ListColorBox()
        {
            InitializeComponent();
            DrawMode = DrawMode.OwnerDrawVariable; 
        }


        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            if (e.Index < 0)
                return;

            Control item = this.Items[e.Index] as Control;
            if (item == null)
                return;

            Graphics g = e.Graphics;
            Rectangle r = e.Bounds;
            if (item.ForeColor != SystemColors.WindowText)
                g.DrawString(item.ToString(), Parent.Font, new SolidBrush(item.ForeColor), r);

        }
    }

    public class LegendItem
    {
        public object Data { get; set; }
        public Color Color { get; set; }
    }

}
