using CoreclrTestLib;
using Xunit;

namespace JIT_CodeGenBringUpTests
{
    public class _Gt1_Gt1_
    {
        [OuterLoop]
        [Fact]
        public void _Gt1_Gt1_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\CodeGenBringUpTests\\Gt1\\Gt1.cmd");
        }
    }
}
