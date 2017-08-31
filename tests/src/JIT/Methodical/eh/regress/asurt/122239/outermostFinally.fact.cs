using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_regress_asurt_122239_outermostFinally_outermostFinally_
    {
        [Fact]
        public void _eh_regress_asurt_122239_outermostFinally_outermostFinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\regress\\asurt\\122239\\outermostFinally\\outermostFinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
