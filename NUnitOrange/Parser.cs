namespace NUnitOrange
{
    using System;
    using System.Collections;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Text.RegularExpressions;

    class Parser
    {
        private string outFile;
        private XmlDocument doc;

        public void BuildHTMLFile()
        {
            XmlNode testRun = doc.GetElementsByTagName("test-run")[0];

            string markup = Markup.Base.Replace(MarkupFlag("totaltests"), testRun.Attributes["total"].InnerText)
                                        .Replace(MarkupFlag("passed"), testRun.Attributes["passed"].InnerText)
                                        .Replace(MarkupFlag("failed"), testRun.Attributes["failed"].InnerText)
                                        .Replace(MarkupFlag("inconclusive"), testRun.Attributes["inconclusive"].InnerText)
                                        .Replace(MarkupFlag("skipped"), testRun.Attributes["skipped"].InnerText)
                                        .Replace(MarkupFlag("duration"), testRun.Attributes["duration"].InnerText)
                                        .Replace(MarkupFlag("randomseed"), testRun.Attributes["random-seed"].InnerText)
                                        .Replace(MarkupFlag("starttime"), testRun.Attributes["start-time"].InnerText)
                                        .Replace(MarkupFlag("endtime"), testRun.Attributes["end-time"].InnerText)
                                        .Replace(MarkupFlag("result"), testRun.Attributes["result"].InnerText)
                                        .Replace(MarkupFlag("fullname"), testRun.Attributes["fullname"].InnerText)
                                        .Replace(MarkupFlag("name"), testRun.Attributes["name"].InnerText)
                                        .Replace(MarkupFlag("id"), testRun.Attributes["id"].InnerText);

            XmlNode env = doc.GetElementsByTagName("environment")[0];

            markup = markup.Replace(MarkupFlag("culture"), env.Attributes["culture"].InnerText)
                            .Replace(MarkupFlag("userdomain"), env.Attributes["user-domain"].InnerText)
                            .Replace(MarkupFlag("user"), env.Attributes["user"].InnerText)
                            .Replace(MarkupFlag("machinename"), env.Attributes["machine-name"].InnerText)
                            .Replace(MarkupFlag("platform"), env.Attributes["platform"].InnerText)
                            .Replace(MarkupFlag("osversion"), env.Attributes["os-version"].InnerText)
                            .Replace(MarkupFlag("clrversion"), env.Attributes["clr-version"].InnerText)
                            .Replace(MarkupFlag("nunitversion"), env.Attributes["nunit-version"].InnerText);


            string pre = null;
            XmlNode parent = null;
            ArrayList fixtureStatus = new ArrayList();

            foreach (XmlNode testcase in doc.SelectNodes(".//test-case"))
            {
                if (testcase.ParentNode != parent)
                {
                    markup = markup.Replace(MarkupFlag("fixtureresult"), GetFixtureStatus(fixtureStatus))
                                    .Replace(MarkupFlag("fixtureresultico"), FontIco(GetFixtureStatus(fixtureStatus)))
                                    .Replace(MarkupFlag("inserttest"), "")
                                    .Replace(MarkupFlag("insertfixture"), Markup.Fixture)
                                    .Replace(MarkupFlag("fixturename"), RegexReplace(testcase.ParentNode.Attributes["name"].InnerText, "<.*>", ""));

                    fixtureStatus.Clear();
                }

                fixtureStatus.Add(testcase.Attributes["result"].InnerText);
                parent = testcase.ParentNode;
                pre = "";

                if (new[] { "FAILED", "SKIPPED" }.Contains(testcase.Attributes["result"].InnerText.ToUpper()))
                {
                    pre = testcase.SelectNodes(".//message").Count == 1 ? "<pre>" + testcase.SelectNodes(".//message")[0].InnerText : "";
                    pre += testcase.SelectNodes(".//stack-trace").Count == 1 ? " -> " + testcase.SelectNodes(".//stack-trace")[0].InnerText.Replace("\r", "").Replace("\n", "") : "";
                    pre += "</pre>";
                }

                markup = markup.Replace(MarkupFlag("inserttest"), Markup.Test)
                            .Replace(MarkupFlag("testname"), testcase.Attributes["name"].InnerText.Replace("<", "[").Replace(">", "]"))
                            .Replace(MarkupFlag("teststatus"), testcase.Attributes["result"].InnerText.ToLower())
                            .Replace(MarkupFlag("teststatusmsg"), pre);
            }

            markup = markup.Replace(MarkupFlag("fixtureresult"), GetFixtureStatus(fixtureStatus)).Replace(MarkupFlag("fixtureresultico"), FontIco(GetFixtureStatus(fixtureStatus)));

            File.WriteAllText(outFile, markup);
        }

        // fixture level status codes
        private string GetFixtureStatus(ArrayList list)
        {
            if (list.Contains("Failed")) return "failed";
            if (list.Contains("Inconclusive")) return "inconclusive";
            if (list.Contains("Passed"))
                return "passed";
            else
                return "skipped";
        }

        // icons from font-awesome
        // http://fortawesome.github.io/Font-Awesome/
        private string FontIco(string status)
        {
            switch (status.ToLower())
            {
                case "passed": return "fa-check";
                case "failed": return "fa-times";
                case "skipped": return "fa-angle-double-right";
                case "inconclusive": return "fa-question";
                default: return "info";
            }
        }

        private string RegexReplace(string input, string pattern, string replacement)
        {
            Regex rgx = new Regex(pattern);
            return rgx.Replace(input, replacement);
        }

        private string MarkupFlag(string name)
        {
            return "<!--%" + name.ToUpper() + "%-->";
        }

        public Parser(string inFile, string outFile)
        {
            this.outFile = outFile;

            if (!File.Exists(inFile) || Path.GetExtension(inFile) == "xml")
            {
                Console.WriteLine("Input file does not exist or is invalid");
                Console.WriteLine("Input file: " + inFile);
            }

            doc = new XmlDocument();
            doc.Load(inFile);
        }
    }
}
