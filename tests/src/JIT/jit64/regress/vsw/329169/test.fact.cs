using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_329169_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_329169_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\329169\\test\\test.cmd");
        }
    }
}
