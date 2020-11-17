using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace danielkarusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
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
                        new BoxView
                        {
                            Color = Color.Red,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
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
                        new BoxView
                        {
                            Color = Color.Green,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
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
                        new Image{Source = "gupkabob.jpg"}

                    }
                }
            };
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
                        new BoxView
                        {
                            Color = Color.Blue,
                            WidthRequest = 200,
                            HeightRequest = 200,
                            HorizontalOptions = LayoutOptions.Center,
                            VerticalOptions = LayoutOptions.CenterAndExpand
                        }
                    }
                }
            };
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
                       new Image {Source = "skvidi.jpg"}
                    }
                }
            };
            Children.Add(StartContentPage);
            Children.Add(HolerikContentPage);
            Children.Add(SangvinikContentPage);
            Children.Add(FlegmatikContentPage);
            Children.Add(MelanholikContentPage);
        }
    }
}
