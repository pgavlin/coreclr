using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_i2__opt_relrefarg_i2_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_basic__opt_relrefarg_i2__opt_relrefarg_i2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_i2\\_opt_relrefarg_i2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
