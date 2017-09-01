using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _testInterface_testInterface_
    {
        [OuterLoop]
        [Fact]
        public void _testInterface_testInterface_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\testInterface\\testInterface.cmd");
        }
    }
}
