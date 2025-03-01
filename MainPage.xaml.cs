namespace MauiLabelBug
{
	public partial class MainPage : ContentPage
	{
		private Thickness m_MarginValue;
		public Thickness MarginValue
		{
			get => m_MarginValue;
			set
			{
				m_MarginValue = value;
				OnPropertyChanged();
			}
		}

		public MainPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
		{
			MarginValue = new Thickness(e.NewValue, 0, 0, 0);
		}
	}
}
