using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_c__opt_relrefarg_c_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_relrefarg_c__opt_relrefarg_c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_c\\_opt_relrefarg_c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
