using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_606733_Bug606733_Bug606733_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_606733_Bug606733_Bug606733_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\606733\\Bug606733\\Bug606733.cmd");
        }
    }
}
