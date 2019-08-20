﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

using ToDo.Makers;

namespace ToDo.Views
{
    public class MainPage: TabbedPage
    {
        public MainPage()
        {
            Children.Add(ElementMaker.NewNavigationpage(new ItemsPage(), VariablesTexts.PAGE_NAME_BROWSE, "icon_info.png"));
            Children.Add(ElementMaker.NewNavigationpage(new AboutPage(), VariablesTexts.PAGE_NAME_ABOUT, "icon_menu"));
        }
    }
}