using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _CnsLng1_CnsLng1_
    {
        [OuterLoop]
        [Fact]
        public void _CnsLng1_CnsLng1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\CnsLng1\\CnsLng1.cmd");
        }
    }
}
