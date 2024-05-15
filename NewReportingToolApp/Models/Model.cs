using NewReportingToolApp.Properties;
using System.Collections.Generic;

namespace NewReportingToolApp.Models
{
    public class Model : IModel
    {
        public List<IMemberInfo> ReturnData()
        {

            ParseAllData parse = new ParseAllData();

            //retrieve data from LoadFiles
            publicwhip regmem = new LoadFiles<publicwhip>().LoadFile(Resources.AllData);
            ArrayOfIPartyAffiliation partyAff = new LoadFiles<ArrayOfIPartyAffiliation>().LoadFile(Resources.myFileName);

            // Process data using the DataProcessor
            List<IMemberInfo> displayList = parse.ProcessData(regmem, partyAff);

            

            return displayList;
        }

       
    }
}
