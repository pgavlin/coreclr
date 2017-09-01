using CoreclrTestLib;
using Xunit;

namespace JIT_jit64
{
    public class _regress_vsw_560402_opadd_opadd_
    {
        [OuterLoop]
        [Fact]
        public void _regress_vsw_560402_opadd_opadd_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\jit64\\regress\\vsw\\560402\\opadd\\opadd.cmd");
        }
    }
}
