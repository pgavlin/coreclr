using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_601425_stret_stret_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_601425_stret_stret_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\601425\\stret\\stret.cmd");
        }
    }
}
