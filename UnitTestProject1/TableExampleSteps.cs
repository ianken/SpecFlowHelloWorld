using System;
using System.Collections.Generic;
using Calc;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [Binding]
    public class TableExampleSteps
    {

        List<int> results = new List<int>();
        IEnumerable<Calculator> cal;

        [Given(@"user enters the following values")]
        public void GivenUserEntersTheFollowingValues(Table table)
        {
            cal = table.CreateSet<Calculator>();

            //Run all the calculations and add them to the results list
            foreach (Calculator c in cal)
            {
                results.Add(c.Add());
            }
        }
        
        [Then(@"validate results")]
        public void ThenValidateResults(Table table)
        {
            int index = 0;

            if (table.RowCount > results.Count)
                throw new IndexOutOfRangeException("Input data and output data row counts do not match...");

            foreach (TableRow r in table.Rows)
            {
                //There's only one column, so this will work. 
                //TableRow has no indexer...
                foreach (var res in r.Values)
                {
                    Assert.AreEqual(Convert.ToInt32(res), results[index]);
                    index++;
                }
            }
        }
    }
}
