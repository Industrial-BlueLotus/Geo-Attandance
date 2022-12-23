using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attandance_App.ViewModels
{
    internal class Token
    {
        var body = @"{
            " + "\n" +
                @"    ""CompanyId"": 156,
            " + "\n" +
                @"    ""UserKey"" : 342922,
            " + "\n" +
                @"    ""EmpKy"" :874258,
            " + "\n" +
                @"    ""ShiftKy"" : 389916,
            " + "\n" +
                @"    ""Latitude"": 0.00,
            " + "\n" +
                @"    ""Longitude"" : 0.00,
            " + "\n" +
                @"    ""Location"":{
            " + "\n" +
                @"        ""CodeKey"":397113,
            " + "\n" +
                @"        ""CodeName"":""""
            " + "\n" +
                @"    },
            " + "\n" +
                @"    ""MultiAtnDetKy"":1,
            " + "\n" +
                @"    ""IsHoliday"":0,
            " + "\n" +
                @"    ""IsIn"":1,
            " + "\n" +
                @"    ""IsOut"":0,
            " + "\n" +
                @"    ""IsoutWithoutIn"":0
            " + "\n" +
                @"
            " + "\n" +
                 @"}";
    }
}
