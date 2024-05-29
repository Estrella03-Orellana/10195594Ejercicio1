namespace _10195594Ejercicio1;

public partial class NumInvertidos : ContentPage
{

    public NumInvertidos()
    {
        InitializeComponent();
    }

    /// <summary>
    /// El evento clicked del botón lo que realiza es que primero almacena 4 numeros y en las variables 
    /// a,,b,c,d, donde se hace una conversion de tipo string a double, luego mostramos los numeros ingresados 
    /// por el usuario de manera invertida metiante un Entry. Mediante un if se validan los campos, en caso que esten vacios 
    /// o inserten letras se muestra una ventana de alerta.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
        Double a, b, c, d;
        if (!string.IsNullOrEmpty(Num1.Text) && !string.IsNullOrEmpty(Num2.Text) && !string.IsNullOrEmpty(Num3.Text) && !string.IsNullOrEmpty(Num4.Text))
        {
            if (double.TryParse(Num1.Text, out a) && double.TryParse(Num2.Text, out b) && double.TryParse(Num3.Text, out c) && double.TryParse(Num4.Text, out d))
            {

                a = Convert.ToDouble(Num1.Text);
                b = Convert.ToDouble(Num2.Text);
                c = Convert.ToDouble(Num3.Text);
                d = Convert.ToDouble(Num4.Text);
                EntryResultado.Text = (b, d, c, a).ToString();
            }
            else
            {
                DisplayAlert("ERROR", "Introduce Número, no letras ni otro tipo de carácteres", "OK");
            }
        }
    }
}