using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _NegRMW_NegRMW_
    {
        [OuterLoop]
        [Fact]
        public void _NegRMW_NegRMW_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\NegRMW\\NegRMW.cmd");
        }
    }
}
