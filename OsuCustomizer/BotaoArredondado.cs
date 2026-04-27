using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace OsuCustomizer
{
    public class BotaoArredondado : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // <--- CONTROLADOR DO ARREDONDAMENTO

            
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);

            
            this.Region = new Region(path);
        }
    }
}