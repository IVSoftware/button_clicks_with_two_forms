using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_clicks_with_two_forms
{
    public partial class Form1 : Form , INotifyPropertyChanged
    {
        public Form1()
        {
            InitializeComponent();

            // Show/Hide Form 2
            checkBoxShowForm2.CheckedChanged += (sender, e) =>
            {
                if (checkBoxShowForm2.Checked)
                {
                    if (_form2 == null)
                    {
                        _form2 = new Form2(binding: this);   
                        _form2.FormClosing += (sender, e) =>
                        {
                            // Prevent Form 2 from disposing its Handle (until
                            // this form closes and explicitly disposes it).
                            e.Cancel = true;
                            // Hide it instead
                            ((Form)sender).Visible = false;
                            checkBoxShowForm2.Checked = false;
                        };
                        _form2.Disposed += (sender, e) => Close();
                    }
                    _form2.Location = new Point(Location.X + Width + 10, Location.Y);
                    _form2.Show(this); // Passing 'this' ensures Form 2 will stay in front of Form 1
                }
                else _form2.Hide();
            };

            // Increment the click count
            buttonIncrementCount.Click += (sender, e) =>
            {
                checkBoxShowForm2.Checked = true;
                ClickCount++;
            };
        }
        private Form2 _form2 = null;

        public event PropertyChangedEventHandler PropertyChanged;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if ((_form2 != null) && !_form2.IsDisposed)
            {
                _form2?.Dispose();
            }
            base.OnFormClosing(e);
        }
        int _ClickCount = 0;
        public int ClickCount
        {
            get => _ClickCount;
            set
            {
                // Detect changes and notify when that happens
                if(_ClickCount != value)
                {
                    _ClickCount = value == 3 ? 0 : value;
                    PropertyChanged?.Invoke(
                        this,
                        new ClickCountPropertyChangedEventArgs(nameof(ClickCount), ClickCount));
                }
            }
        }
    }

    internal class ClickCountPropertyChangedEventArgs : PropertyChangedEventArgs
    {
        public int Count { get; }
        public ClickCountPropertyChangedEventArgs(string propertyName, int count) 
            : base(propertyName)
        {
            Count = count;
        }
    }
}
