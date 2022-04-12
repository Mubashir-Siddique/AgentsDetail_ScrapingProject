
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Drawing;
using CsvHelper;
using System.Globalization;

namespace AgentsDetail_ScrapingTask
{
    public class Agent
    {
        public String Name { get; set; }
        public String MTD_Submit { get; set; }
        public String MTD_Paid { get; set; }
        public String YTD_Submit { get; set; }
        public String YTD_Paid { get; set; }
        public String Last_7_Submit { get; set; }
        public String Last_7_Paid { get; set; }
    }

    class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        string textFile = @"D:\Work Space\CellshopperScrapingTask\CellshopperScrapingTask\PracticeScrappingTask\html.txt";

        //        if (File.Exists(textFile))
        //        {
        //            // Read entire text file content in one string    
        //            string text = File.ReadAllText(textFile);
        //            Work(text);

        //            Console.WriteLine();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //static void Work(string html)
        //{
        //    try
        //    {
        //        List<Agent> agents = new List<Agent>();
        //        HtmlDocument Doc = new HtmlDocument();

        //        Doc.LoadHtml(html);

        //        Doc.DocumentNode.SelectSingleNode("//table[contains(.,'Buenos Aires 2023')]").Remove();
        //        Doc.DocumentNode.SelectSingleNode("//table[@border='0']").Remove();
        //        Doc.DocumentNode.SelectSingleNode("//table[contains(.,'Convention Production Progress')]").Remove();
        //        Doc.DocumentNode.SelectSingleNode("//p[contains(.,'Agent Detail')]").Remove();

        //        var parentNode = Doc.DocumentNode.SelectSingleNode("//body");

        //        ExtractAgentInfo(parentNode, agents);

        //        WriteToCSVFile(agents);

        //        Console.WriteLine();
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine();
        //    }
        //}

        //private static void ExtractAgentInfo(HtmlNode parentNode, List<Agent> agents)
        //{
        //    try
        //    {
        //        if (parentNode.SelectSingleNode("//p[@align='center']/b/font[@face='Times New Roman' and @size='4']") != null)
        //        {
        //            var NameNode = parentNode.SelectSingleNode("//p[@align='center']/b/font[@face='Times New Roman' and @size='4']").InnerText.Trim();
        //            NameNode = NameNode.Replace("             ", "");

        //            parentNode.SelectSingleNode("//p[@align='center']/b/font[@face='Times New Roman' and @size='4']").Remove();

        //            var Last_7_DataRow = parentNode.SelectSingleNode("//table[contains(.,'Last 7 days Production')]");
        //            var Last_7_Values = Last_7_DataRow.SelectNodes("td");

        //            var MTDDataRow = parentNode.SelectSingleNode("//table[@align='center' and @width='70%' and contains(.,'MTD Production')]");
        //            var MTDValues = MTDDataRow.SelectNodes("td");

        //            var YTDDataRow = parentNode.SelectSingleNode("//table[@align='center' and @width='70%' and contains(.,'YTD Production')]");
        //            var YTDValues = YTDDataRow.SelectNodes("td[@align='right' and @bgcolor='#b3cee0']");

        //            Agent agent = new Agent();
        //            agent.Name = NameNode;

        //            agent.MTD_Submit = MTDValues[MTDValues.Count - 3].InnerText.Trim();
        //            agent.MTD_Paid = MTDValues[MTDValues.Count - 1].InnerText.Trim();

        //            agent.YTD_Submit = YTDValues[YTDValues.Count - 3].InnerText.Trim();
        //            agent.YTD_Paid = YTDValues[YTDValues.Count - 1].InnerText.Trim();

        //            agent.Last_7_Submit = Last_7_Values[Last_7_Values.Count - 3].InnerText.Trim();
        //            agent.Last_7_Paid = Last_7_Values[Last_7_Values.Count - 1].InnerText.Trim();

        //            agents.Add(agent);

        //            parentNode.RemoveChild(parentNode.SelectSingleNode("//table[contains(.,'Last 7 days Production')]"));
        //            parentNode.RemoveChild(parentNode.SelectSingleNode("//table[@align='center' and @width='70%' and contains(.,'MTD Production')]"));
        //            parentNode.RemoveChild(parentNode.SelectSingleNode("//table[@align='center' and @width='70%' and contains(.,'YTD Production')]"));

        //            ExtractAgentInfo(parentNode, agents);
        //        }

        //        else
        //        {
        //            return;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine();
        //    }
        //}


        //static void WriteToCSVFile(List<Agent> agents)
        //{
        //    try
        //    {
        //        using (var writer = new StreamWriter("../Agents_Detail_Prod_Report.csv", false))
        //        {
        //            using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
        //            {
        //                csvWriter.Configuration.Delimiter = ",";
        //                csvWriter.Configuration.HasHeaderRecord = true;
        //                csvWriter.Configuration.AutoMap<Product>();

        //                csvWriter.WriteField("Sr. No");
        //                csvWriter.WriteField("Name");
        //                csvWriter.WriteField("Last_7_Submit");
        //                csvWriter.WriteField("Last_7_Paid");
        //                csvWriter.WriteField("MTD_Submit");
        //                csvWriter.WriteField("MTD_Paid");
        //                csvWriter.WriteField("YTD_Submit");
        //                csvWriter.WriteField("YTD_Paid");
        //                csvWriter.NextRecord();

        //                int AgentNum = 0;

        //                foreach (var agent in agents)
        //                {
        //                    csvWriter.WriteField(AgentNum + 1);
        //                    csvWriter.WriteField(agent.Name);
        //                    csvWriter.WriteField(agent.Last_7_Submit);
        //                    csvWriter.WriteField(agent.Last_7_Paid);
        //                    csvWriter.WriteField(agent.MTD_Submit);
        //                    csvWriter.WriteField(agent.MTD_Paid);
        //                    csvWriter.WriteField(agent.YTD_Submit);
        //                    csvWriter.WriteField(agent.YTD_Paid);
        //                    csvWriter.NextRecord();
        //                    AgentNum++;
        //                }

        //                //csvWriter.WriteRecords(DataList);
        //                writer.Flush();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}


    }
}
