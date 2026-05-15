
namespace RomanNumeralConverter;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object sender, EventArgs e)
    {
        var oConvert = new Converter();
        int InputNumber;
        var IsNumber = Int32.TryParse(txtInput.Text, out InputNumber);

        if (IsNumber)
        {
            lblOutput.Text = oConvert.NumberToRoman(InputNumber);
        }
        else
        {
            lblOutput.Text = oConvert.RomanToNumber(txtInput.Text).ToString();
        }
    }
}