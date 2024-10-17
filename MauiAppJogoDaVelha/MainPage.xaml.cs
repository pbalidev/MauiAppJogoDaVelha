namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.IsEnabled = false;
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            //VERIFICANDO SE O X GANHOU

            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }


            if (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn32.Text == "X" && btn21.Text == "X" && btn11.Text == "X")
            {
                DisplayAlert("Parabéns!", "O 'X' Ganhou!!!!", "OK");
                Zerar();
            }

            if (btn32.Text == "O" && btn21.Text == "O" && btn11.Text == "O")
            {
                DisplayAlert("Parabéns!", "O 'O' Ganhou!!!!", "OK");
                Zerar();
            }


            if (VerificarVelha())
            {
                DisplayAlert("Empate!", "Ninguém ganhou, deu velha!", "OK");
                Zerar();
                return;
            }


        }//FECHA MÉTODO
        private bool VerificarVelha()
        {
            // Se todos os botões estão preenchidos e ninguém venceu
            return !string.IsNullOrEmpty(btn10.Text) &&
                   !string.IsNullOrEmpty(btn11.Text) &&
                   !string.IsNullOrEmpty(btn12.Text) &&
                   !string.IsNullOrEmpty(btn20.Text) &&
                   !string.IsNullOrEmpty(btn21.Text) &&
                   !string.IsNullOrEmpty(btn22.Text) &&
                   !string.IsNullOrEmpty(btn30.Text) &&
                   !string.IsNullOrEmpty(btn31.Text) &&
                   !string.IsNullOrEmpty(btn32.Text);
        }
        void Zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;
        }

    }//FECHA CLASSE

}//FECHA NAMESPACE
