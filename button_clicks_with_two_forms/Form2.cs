using System.ComponentModel;
using System.Windows.Forms;

namespace button_clicks_with_two_forms
{
    public partial class Form2 : Form
    {
        public Form2(INotifyPropertyChanged binding)
        {
            InitializeComponent();
            binding.PropertyChanged += Binding_PropertyChanged;
        }
        /// <summary>
        /// This handler is called when a property is changed in Form 1
        /// </summary>
        private void Binding_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Form1.ClickCount):
                    // Obtain the specialized event handler.
                    if (e is ClickCountPropertyChangedEventArgs ePlus)
                    {
                        onClickCountChanged(ePlus.Count);
                    }
                    break;
            }
        }
        /// <summary>
        /// This form manages its own button visibility based on count
        /// </summary>
        private void onClickCountChanged(int count)
        {
            labelClickCount.Text = $"Click Count = {count}";
            buttonShowOrHideA.Visible = count == 1;
            buttonShowOrHideB.Visible = count == 2;
        }
        /// <summary>
        /// When the buttons aren't coming and going all the time it 
        ///makes it possible to subscribe only ONCE to the Click event
        /// </summary>
        private void buttonShowOrHideA_Click(object sender, System.EventArgs e) =>
            MessageBox.Show("Red one clicked");

        private void buttonShowOrHideB_Click(object sender, System.EventArgs e) =>
            MessageBox.Show("Green one clicked");
    }
}
