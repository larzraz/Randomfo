using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Randomfo
{
    public partial class MainPage : ContentPage
    {
        private string[] facts = {
        "Elephants are the only mammals that can't jump.",
        "Candles will burn longer and drip less if they are placed in the freezer a few hours before using.",
        "Potatoes have more chromosomes than humans.",
        "You burn more calories sleeping than you do watching television.",
        "Animals that lay eggs don't have belly buttons.",
         "Ants stretch when they wake up in the morning.",
        "Ostriches can run faster than horses.",
        "Olympic gold medals are actually made mostly of silver.",
        "You are born with 300 bones; by the time you are an adult you will have 206.",
        "It takes about 8 minutes for light from the Sun to reach Earth.",
        "Some bamboo plants can grow almost a meter in just one day.",
        "The state of Florida is bigger than England.",
        "Some penguins can leap 2-3 meters out of the water.",
        "On average, it takes 66 days to form a new habit.",
        "Mammoths still walked the earth when the Great Pyramid was being built."
    };

        Color[] colors = { new Color(255, 0, 255, 0.7), new Color(255, 255, 0, 0.8), Color.LimeGreen, Color.Navy, Color.Orchid,Color.Maroon, Color.LightSalmon, Color.IndianRed, Color.DeepSkyBlue };

        public MainPage()
        {
            InitializeComponent();
        }

        private void RandomInfoButton_Clicked(object sender, EventArgs e)
        {
                

            Resources["bgColor"] = colors[RandomColorPicker()];
            factsLabel.Text = facts[RandomPicker()];

        }

        private int RandomPicker()
        {
            Random random = new Random();
            int index = random.Next(facts.Count());
            return index;
        }
        private int RandomColorPicker()
        {
            Random random = new Random();
            int index = random.Next(colors.Count());
            return index;
        }
    }
}
