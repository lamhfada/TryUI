using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TryUI
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            InitializeComponent();
            StackLayout MainStack = new StackLayout
            {
                BackgroundColor = Color.Aqua,
                //HorizontalOptions = LayoutOptions.FillAndExpand
            };
            Label header = new Label
            {
                //VerticalOptions = LayoutOptions.FillAndExpand,

                Text = "SHKUI"
            };
            ScrollView MiddleView = new ScrollView
            {
                //HorizontalOptions = LayoutOptions.FillAndExpand

            };
            StackLayout MiddleStack = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            Label footer = new Label
            {
                //HorizontalOptions = LayoutOptions.FillAndExpand,
                Text = "FOoter"
            };
            StackLayout RowStack = null;

            for (int i = 10; i <= 90; i += 10)
            {
                if ((i - 10) % 30 == 0)
                {
                    RowStack = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal,
                        VerticalOptions = LayoutOptions.FillAndExpand


                    };
                    MiddleStack.Children.Add(RowStack);
                }
                /*
                Button EventButton = new Button();
                if(Device.RuntimePlatform == Device.Android)
                {
                    EventButton.Image = "010.png";

                }
                */
                /*
                BoxView EventBox = new BoxView();
                Frame EventFrame = new Frame();
                */
                Image EventImage = new Image
                {
                    Source = ImageSource.FromResource("SHKUI.Image.0" + i + ".png"),
                    StyleId = (i % 10).ToString(),
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };
                StackLayout temp = new StackLayout
                {
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };
                Label iconLabel = new Label
                {

                    Text = i.ToString(),
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalTextAlignment = TextAlignment.Center
                };
                temp.Children.Add(EventImage);
                temp.Children.Add(iconLabel);
                //"SHKUI.resource.0" + i.ToString() + ".png"

                RowStack.Children.Add(temp);
            }
            //MiddleView.Content = MiddleStack;
            //MainStack.Children.Add(header);
            //MainStack.Children.Add(MiddleView);
            MainStack.Children.Add(MiddleStack);
            MainStack.Children.Add(footer);
            Content = MainStack;
        }
	}
}
