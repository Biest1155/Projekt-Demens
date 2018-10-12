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
            TimeSpan difference = DateTime.Now - date;

            if (date.Date == DateTime.Today)
            {
                return "Idag";
            }
            else if (difference.Days<7)
            {
             return   date.ToString("dddd", new CultureInfo("da-DK"));

            }
            else
            {
                return date.ToString("dd MMMM yyyy", new CultureInfo("da-DK"));

            }
        
            
        }

        public string TimeFormat(DateTime time)
        {

            return time.ToString("hh.mm");

        }

       
        

        
    }
}
