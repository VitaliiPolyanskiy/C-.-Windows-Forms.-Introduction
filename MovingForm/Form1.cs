namespace MovingForm
{
    public partial class Form1 : Form
    {
        static int left;
        static int top;
        public Form1()
        {
            InitializeComponent();
            Width = 400;
            Height = 300;
            StartPosition = FormStartPosition.Manual;
            left = (Screen.PrimaryScreen.Bounds.Width - 300) / 2;
            top = (Screen.PrimaryScreen.Bounds.Height - 300) / 2;
            Location = new Point(left, top);
        }

        /*
            public delegate void KeyEventHandler(
               Object sender,- ссылка на тот объект, которому пришло событие.
               KeyEventArgs e - содержит дополнительную информацию о клавиатурном сообщении.
           );
 
           Свойства KeyEventArgs.
           public int KeyValue { get; } - код клавиши
           public Keys KeyCode { get; } - название клавиши
           public Keys KeyData { get; } - название нажатой клавиши вместе с любыми флагами, показывающими, 
                                          какие из клавиш CTRL, SHIFT и ALT были одновременно нажаты 
           public enum Keys - название клавиши (например, Keys.Return, Keys.Left, Keys.A и т.д.)
       */
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Form frm = (Form)sender;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    left -= 5;
                    break;
                case Keys.Right:
                    left += 5;
                    break;
                case Keys.Up:
                    top -= 5;
                    break;
                case Keys.Down:
                    top += 5;
                    break;
            }
            frm.Location = new Point(left, top);
        }
    }
}
