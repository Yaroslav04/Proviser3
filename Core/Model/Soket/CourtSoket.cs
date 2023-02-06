using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proviser3.Core.Model.Soket
{
    public class CourtSoket : CourtClass
    {
        public string PrisonDate { get; set; }
        public string Header { get; set; }
        public string Note { get; set; }

        public CourtSoket(CourtClass courtClass)
        {
            N = courtClass.N;
            SaveDate = courtClass.SaveDate;

            Date = courtClass.Date;
            Judge = courtClass.Judge;
            Case = courtClass.Case;
            Court = courtClass.Court;
            Littigans = courtClass.Littigans;
            Category = courtClass.Category;
            Origin = courtClass.Origin;        
        }
    }
}
