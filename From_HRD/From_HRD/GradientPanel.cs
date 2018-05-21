using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace From_HRD
{
    class GradientPanel :Panel
    {
        public Color colorAtas{get;set;}
        public Color colorBawah{get;set;}

        protected override void OnPaint(PaintEventArgs e){
        LinearGradientBrush lgb = new LinearGradientBrush(this.ClientRectangle,this.colorAtas,this.colorBawah,90F);
            Graphics g = e.Graphics;
            g.FillRectangle(lgb,this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
