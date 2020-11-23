using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace danielkarusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            ImageButton holer;
            ImageButton sangvin;
            ImageButton flegmat;
            ImageButton malenhol;
            Image img; 
            var StartContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {


                        new Label
                        {
                            Text = "Start",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },
                        new Image {Source = "bikini.jpg"}
                    }
                }
            };
            holer = new ImageButton
            {
                Source = "krabs.jpg"

            };
            holer.Clicked += Holer_Clicked;

            var HolerikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {


                        new Label
                        {
                            Text = "Holerik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },
                        holer
                    }
                }
            };



            sangvin = new ImageButton
            {
                Source = "gupkabob.jpg"

            };
            sangvin.Clicked += Sangvin_Clicked;

            var SangvinikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {


                        new Label
                        {
                            Text = "Sangvinik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },
                        sangvin

                    }
                }
            };
            flegmat = new ImageButton
            {
                Source = "gari.jpg"

            };
            flegmat.Clicked += Flegmat_Clicked;

            var FlegmatikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {


                        new Label
                        {
                            Text = "Flegmatik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },
                         
                        flegmat
                    }
                }
            };
            malenhol = new ImageButton
            {
                Source = "skvidi.jpg"

            };
            malenhol.Clicked += Malenhol_Clicked;
            var MelanholikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {


                        new Label
                        {
                            Text = "Melanholik",
                            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center

                        },
                       malenhol
                    }
                }
            };


            Children.Add(StartContentPage);
            Children.Add(HolerikContentPage);
            Children.Add(SangvinikContentPage);
            Children.Add(FlegmatikContentPage);
            Children.Add(MelanholikContentPage);

        }

        private async void Malenhol_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D0%BB%D0%B0%D0%BD%D1%85%D0%BE%D0%BB%D0%B8%D0%BA", BrowserLaunchMode.SystemPreferred);
        }

        private async void Flegmat_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%A4%D0%BB%D0%B5%D0%B3%D0%BC%D0%B0%D1%82%D0%B8%D0%BA", BrowserLaunchMode.SystemPreferred);
        }

        private async void Sangvin_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%A1%D0%B0%D0%BD%D0%B3%D0%B2%D0%B8%D0%BD%D0%B8%D0%BA", BrowserLaunchMode.SystemPreferred);
        }

        private async void Holer_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://ru.wikipedia.org/wiki/%D0%A5%D0%BE%D0%BB%D0%B5%D1%80%D0%B8%D0%BA", BrowserLaunchMode.SystemPreferred);
        }
    }
}
