using CoreclrTestLib;
using Xunit;

namespace Regressions_coreclr
{
    public class _1333_testInterface_testInterface_
    {
        [OuterLoop]
        [Fact]
        public void _1333_testInterface_testInterface_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\coreclr\\1333\\testInterface\\testInterface.cmd");
        }
    }
}
