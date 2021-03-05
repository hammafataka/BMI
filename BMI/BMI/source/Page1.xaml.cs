﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMI.source
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            BindingContext = new classes.types();
            
        }
     

        private async void result_Clicked(object sender, EventArgs e)
        {
            if (picker1.SelectedIndex==0)
            {
                double BMI;
                double kg = double.Parse(weightEntry.Text);
                double m = double.Parse(heightEntry.Text);
                BMI = kg / ((m / 100) * (m / 100));

                if (BMI>18 && BMI<24)
                {
                    resultLbl.Text = BMI.ToString("N2") +" (Normal)";

                }
                else if (BMI<18)
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Underweight)";

                }
                else if (BMI>24)
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Overweight)";
                }
                else
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Obesity)";

                }

            }
            else if (picker1.SelectedIndex==2)
            {
                double BMI;
                double kg = double.Parse(weightEntry.Text);
                double m = double.Parse(heightEntry.Text);
                BMI =( kg / m  / m )*703;

                if (BMI > 18.5 && BMI < 24.9)
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Normal)";

                }
                else if (BMI < 18.5)
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Underweight )";

                }
                else if (BMI > 24.9)
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Overweight)";
                }
                else
                {
                    resultLbl.Text = BMI.ToString("N2") + " (Obesity)";

                }
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Error", "Please choose a Unit", "OK");
            }
           

        }

        private void resetBtn_Clicked(object sender, EventArgs e)
        {
            picker1.SelectedIndex = 1;
            weightEntry.Text = null;
            heightEntry.Text = null;
            resultLbl.Text = "00.00 (Normal)";
            cmLbl.Text = null;
            kgLbl.Text = null;
            

        }
    }
}