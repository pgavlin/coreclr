using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _LngConv_LngConv_
    {
        [OuterLoop]
        [Fact]
        public void _LngConv_LngConv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\LngConv\\LngConv.cmd");
        }
    }
}
