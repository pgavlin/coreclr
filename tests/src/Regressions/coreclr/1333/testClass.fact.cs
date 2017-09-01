using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _1333_testClass_testClass_
    {
        [OuterLoop]
        [Fact]
        public void _1333_testClass_testClass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\1333\\testClass\\testClass.cmd");
        }
    }
}
