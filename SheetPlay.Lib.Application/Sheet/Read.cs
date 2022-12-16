using SheetPlay.Lib.Model.DefaultReturn;
using System.Globalization;

namespace SheetPlay.Lib.Application.Sheet
{
    public class Read
    {
        public static readonly CultureInfo CulturePtBr = new CultureInfo("pt-BR");

        public DefaultReturnList<SheetPlay.Lib.Model.Entity.TracePerTime> ReadExcel(string fileAddress)
        {
            DefaultReturnList<SheetPlay.Lib.Model.Entity.TracePerTime> returnObj = new();

            try
            {
                List<Lib.Model.Entity.TracePerTime> tracePerTimeList = new();

                var split = default(string[]);
                decimal previouslyTime = 0;
                decimal currentTime = 0;
                using (var sr = new StreamReader(fileAddress))
                {
                    while (true)
                    {
                        var line = sr.ReadLine();
                        if (string.IsNullOrEmpty(line))
                            break;

                        if (line.Contains("Time"))
                            continue;

                        split = line.Split(';');

                        if (tracePerTimeList.Count() > 0)
                        {
                            currentTime = Convert.ToDecimal(split[0].Trim(), CulturePtBr);
                            tracePerTimeList[tracePerTimeList.Count() - 1].Time = currentTime - previouslyTime;
                            previouslyTime = currentTime;
                        }

                        tracePerTimeList.Add(new Model.Entity.TracePerTime()
                        {
                            Time = currentTime,
                            Trace1 = (float)Convert.ToDecimal(split[1].Trim(), CulturePtBr),
                            Trace2 = (float)Convert.ToDecimal(split[2].Trim(), CulturePtBr),
                        });
                    }
                }

                returnObj.Value = tracePerTimeList;

            }
            catch (Exception ex)
            {
                returnObj.HttpStatusCode = System.Net.HttpStatusCode.InternalServerError;
                returnObj.Message = $"Error: {ex.Message} - InnerException: {ex.InnerException}";
            }

            return returnObj;
        }

    }
}
