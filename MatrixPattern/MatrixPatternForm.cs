using Microsoft.VisualBasic.Logging;
using System.Threading;

namespace MatrixPattern
{
    public partial class MatrixPatternForm : Form
    {
        public MatrixPatternForm()
        {
            Init();
            InitializeComponent();
        }

        public void Init()
        {
            m_OffsetPoint = new Point(100, 100);
            m_CellWidth = 100;
            m_CellHeight = 100;
            m_Rows = 2;
            m_Cols = 2;

            logger = new Log();
        }

        public void onPaint(object sender, EventArgs e)
        {
            //drawMatrix(m_Rows, m_Cols);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (m_PrinterThread == null)
            {
                m_PrinterThread = new Thread(gridPainterWorker);
                m_PrinterThread.IsBackground = true;
                m_PrinterThread.Start();
                run = true;
                
            }
        }

        public void gridPainterWorker()
        {
            try
            {
                int Size = 0;
                int i = 2;
                while (true)
                {
                    drawMatrix(i, i);
                    gridCoundStatuStrip.Text = "Grid Count: " + i; 
                    Size = Math.Min(m_Rows, m_Cols);
                    Size = Math.Max(Size, 2);
                    i = CircularIncrement(2, Size, i);

                    for (int it = 0; it < 10 || !run; it++)
                    {
                        Thread.Sleep(50);
                    }

                    this.Refresh();

                }
            }
            catch (Exception e)
            {
                logger.WriteEntry("something went wrong!! " + e.Message);
            }
        }

        public int CircularIncrement(int start, int end, int i)
        {
            i = (i < start) ? start : i;
            return (i < end) ? ++i : start;
        }
        private void stopButton_Click(object sender, EventArgs e)
        {
            run = false;
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            run = true;
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 2;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 3;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 4;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 5;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 6;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 7;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }

        private void x8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_Rows = m_Cols = 8;
            dropMenu.Text = (sender as ToolStripMenuItem).Text;
        }



        public void drawMatrix(int rows, int cols)
        {

            Graphics board = this.CreateGraphics();
            Pen pen = new Pen(Color.DarkRed);
            pen.Width = 3;

            int x = m_OffsetPoint.X;
            int y = m_OffsetPoint.Y;
            int width = m_CellWidth;
            int height = m_CellHeight;


            Point start = new Point(x, y);
            Point end = new Point(x, y + rows * height + rows * (int)pen.Width);
            for (int i = 0; i <= cols; i++)
            {
                board.DrawLine(pen, start, end);
                start.X += width + (int)pen.Width;
                end.X = start.X;
            }

            start.X = x; start.Y = y;
            end.X = x + cols * width + cols * (int)pen.Width; end.Y = y;
            for (int i = 0; i <= rows; i++)
            {
                board.DrawLine(pen, start, end);
                start.Y += height + (int)pen.Width;
                end.Y = start.Y;
            }

        }


        public Point m_OffsetPoint;
        public int m_CellWidth;
        public int m_CellHeight;
        public int m_Rows;
        public int m_Cols;

        public Thread m_PrinterThread;

        private Log logger;

        private bool run;
        private bool m_ResumeThread;
        private ToolStripDropDownButton dropMenu;

        private void gridDropDown_Click(object sender, EventArgs e)
        {
            if(sender != null)
                dropMenu = sender as ToolStripDropDownButton;

        }
    }
}
