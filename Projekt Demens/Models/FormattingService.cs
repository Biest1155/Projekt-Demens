using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Globalization;

namespace Projekt_Demens.Models
{
    public class FormattingService
    {
        public string DateFormat(DateTime date)
        {
            //   var cultureInfo = CultureInfo.CreateSpecificCulture("da-DK");
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("da-DK");
            //if (date.Date==DateTime.Today)
            //{
            //    return "Idag";
            //}
         /*  else */if ((date.Date-DateTime.Today).Days<7)
            {
                return date.DayOfWeek.ToString();
            }

            return date.ToString("dd MMMM yyyy");


        }

        public string TimeFormat(DateTime time)
        {
            return time.ToString("hh.mm");

        }

        

        
    }
}
