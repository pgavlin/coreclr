using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_i1__opt_relrefarg_i1_
    {
        [Fact]
        public void _explicit_basic__opt_relrefarg_i1__opt_relrefarg_i1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_i1\\_opt_relrefarg_i1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
