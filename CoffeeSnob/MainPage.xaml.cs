using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CoffeeSnob
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // Load app text
            addDescrptions();
        }

        /// <summary>
        /// Adds text to:
        ///  
        /// </summary>
        public void addDescrptions()
        {
            //Home page text
            tblHome.Text = @"Coffee Snobs was developed for the people who love coffee but actually dont know or understand how their coffees are made or the differences between them. We all have that friend who orders a skinny double shot vanilla latte but if you had to ask your friend to describe the difference between a latte and a cappuccino, they would probably say bubbles. 
Here is just a quick guide for all you coffee lovers out there. You can learn about the different types of coffee, the benifits of coffee, visit our gallery and explore more about coffee on our Find Out More page.";
            // types of coffees text
            tblEspresso.Text = @"Espresso:
Also known as a Short Black. It Contains 75ml of pure coffee essence
made from 24gm of fresh ground coffee beans. Traditionally served in
a short glass but now found in short ceramic cups too. It is the 
favourite coffee drink of the Italians.";
            tblAmericano.Text = @"Americano:
Also known as a Long Black in other parts of the world. It is made by
diluting 1-2 shots of espresso with hot water in order to approximate
the texture and flavour of an American-style drip coffee. Usually drank
by itself or with milk and sometimes sugar. Served in a Ceramic Cup.";
            tblCappuccino.Text = @"Cappuccino:
A traditional morning heart starter. its created with steamed foamed 
velvety milk poured over a shot of espresso made from 12gm of freshly 
ground beans. Finished with milky foam topping and chocolate powder.
Served in a Ceramic cup.";
            tblLatte.Text = @"Latte:
Freshy steamed milk without foam with a shot of espresso. Served in 
a tall glass.";
            tblMocha.Text = @"Mocha:
A combination of chocolate syrup and a shot of espresso, topped with
steamed milk and a small layer of foam and finally finished with a 
sprinkle of chocolate powder. Also served in a tall glass.";
            tblFlatwhite.Text = @"FlatWhite:
Most popular in Australia and New Zealand. It is made up of steamed 
microfoam milk poured through and under the espresso creme produced 
from one espresso shot. Famous for its latte art.";
            tblMacchiato.Text = @"Macchiato
Macchiato from the italian word for stained. Meant to mean coffee 
stained with spots of milk. A touch of steamed foamed milk added 
to a double shot of espresso. Served in short glass.";
            tblAffogato.Text = @"Affogato:
From the Italian meaning to be drowned. It is the description of a
shot of seperately served espresso that is then poured over the top of
a scoop of vanilla ice cream or gelato. Usually served in a short 
drinking glass.";         
            
            //Benifits text
            tblBenifets.Text = @"We all know the main benefits of coffee are Energy. It helps us greet the day, cram for exams and stops us from falling asleep at work but thats not all.
Recent research have shown that Coffee has great health Benifets and can in some cases save you from deadly diseases. Here are just a few:";
            tblBenifets1.Text = @"1)  Type 2 Diabetes: 
Research has shown that drinking coffee increases the Plasma levels of protein SHBG(sex hormone-binding globulin). SHBG controls the bodys sex hormones testosterone and estrogen which play a role in the development of diabetes.";
            tblBenifets2.Text = @"2)  Parkinsons Disease: 
Researchers in the U.S have carried out studies that assessed a link between coffee consumption and Parkinson's disease risk. Results concluded that higher coffee and caffeine intake is associated with significantly lower incidences of Parkinson's disease.";
            tblBenifets3.Text = @"3)  Liver Cancer: 
Italian researchers have discovered that coffee consumption actually lowers the risk of developing liver cancer by about 40 percent. In addition, some of the results suggest that if you drink three cups a day, the risk are reduced by more that 50 percent.";
        }

        //image tapped event to increase image size
        private void Image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Image mySmallMap = (Image)sender;
            imgBigger.Source = mySmallMap.Source;
            imgBigger.Width = Window.Current.Bounds.Width;
            imgBigger.Height = Window.Current.Bounds.Height;
            imgBigger.Visibility = Visibility.Visible;
        }
        //when imaged tapped again collapses the image
        private void imgBigger_Tapped(object sender, TappedRoutedEventArgs e)
        {

            imgBigger.Source = null;
            imgBigger.Visibility = Visibility.Collapsed;
        }
    }
}
