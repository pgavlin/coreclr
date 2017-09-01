using CoreclrTestLib;
using Xunit;

namespace Regressions_common
{
    public class _testClass_testClass_
    {
        [OuterLoop]
        [Fact]
        public void _testClass_testClass_cmd()
        {
            CoreclrTestWrapperLib.RunTest("Regressions\\common\\testClass\\testClass.cmd");
        }
    }
}
