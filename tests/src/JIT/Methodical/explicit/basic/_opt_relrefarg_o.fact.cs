using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_o__opt_relrefarg_o_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_relrefarg_o__opt_relrefarg_o_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_o\\_opt_relrefarg_o.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
