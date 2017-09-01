using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _IntConv_IntConv_
    {
        [OuterLoop]
        [Fact]
        public void _IntConv_IntConv_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\IntConv\\IntConv.cmd");
        }
    }
}
