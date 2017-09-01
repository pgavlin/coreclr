using CoreclrTestLib;
using Xunit;

namespace JIT_Regression
{
    public class _Dev11_dev10_865840_dev10_865840_dev10_865840_
    {
        [ActiveIssue("2445")]
        [Trait("ExcludeBuiltAgainstPackages", "Unix")]
        [OuterLoop]
        [Fact]
        public void _Dev11_dev10_865840_dev10_865840_dev10_865840_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\Regression\\Dev11\\dev10_865840\\dev10_865840\\dev10_865840.cmd");
        }
    }
}
