using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_543645_test_test_
    {
        [Fact]
        public void _regress_vsw_543645_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\543645\\test\\test.cmd");
        }
    }
}
