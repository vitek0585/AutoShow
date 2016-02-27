using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;

namespace CarEngine
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestDel()
        {
            List<Action> delList = new List<Action>();
            foreach (var i in Enumerable.Range(0, 10))
            {
                delList.Add(() => { Debug.WriteLine(i); });

            }

            var @is = true;
            foreach (var del in delList)
            {
                if (@is)
                {
                    for (int i = 0; i < double.MaxValue; i++)
                    {
                        delList[0]=new Action(()=>Debug.WriteLine(0));

                    }
                        delList.Add(() => { Debug.WriteLine(100); });

                }
                del();
            }

        }
    }
}