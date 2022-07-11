using System;
using System.Drawing;
using System.Windows.Forms;
sealed class MainClass
{
  static void Main()
  {
       Bitmap Image;
       Image = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
       Size s = new Size(Image.Width, Image.Height);
       Graphics ImageGraphics = Graphics.FromImage(Image);
       ImageGraphics.CopyFromScreen(0, 0, 0, 0, s);
       Image.Save("C:\Photos\ScreenShot.png");
  }
}
