using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _NotRMW_NotRMW_
    {
        [OuterLoop]
        [Fact]
        public void _NotRMW_NotRMW_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NotRMW\\NotRMW.cmd");
        }
    }
}
