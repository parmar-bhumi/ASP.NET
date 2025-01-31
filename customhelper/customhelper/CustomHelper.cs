﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace customhelper
{
    public static class CustomHelper
    {
        public static IHtmlString Mytag(string txt)
        {
            //string ans = "<b>" + txt + "</b>";
            string ans = "<img src='"+txt+"' alt='no data'>"; 
            return new MvcHtmlString(ans);
        }

        public static IHtmlString my(this HtmlHelper helper,string txt)
        {
            //string ans = "<b>" + txt + "</b>";
            string ans = "<img src='"+txt+"' alt='no data'>" ;
            return new MvcHtmlString(ans);
        }

        public static IHtmlString myt(this HtmlHelper helper, string txt)
        {
            TagBuilder t = new TagBuilder("img");
            t.Attributes.Add("src", txt);
            t.Attributes.Add("a","b");
            t.Attributes.Add("alt","no data");
            return new MvcHtmlString(t.ToString());

        }

        public static MvcHtmlString lst(string [] country)
        {
            var nm = new StringBuilder("<ul>");
            foreach (var mn in country)
            {
                nm.AppendFormat("<li>{0}</li>", mn);
            }
            return new MvcHtmlString(nm.ToString());
        }
    }
}

