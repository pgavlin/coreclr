using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _eh_basics_throwisfirstinstruction_throwisfirstinstruction_
    {
        [OuterLoop]
        [Fact]
        public void _eh_basics_throwisfirstinstruction_throwisfirstinstruction_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\eh\\basics\\throwisfirstinstruction\\throwisfirstinstruction.cmd");
        }
    }
}
