using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_153682_test_test_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_153682_test_test_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\153682\\test\\test.cmd");
        }
    }
}
