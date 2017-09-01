using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _div1_div1_
    {
        [OuterLoop]
        [Fact]
        public void _div1_div1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\div1\\div1.cmd");
        }
    }
}
