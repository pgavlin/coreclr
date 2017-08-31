using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__opt_relrefarg_f8__opt_relrefarg_f8_
    {
        [Fact]
        public void _explicit_basic__opt_relrefarg_f8__opt_relrefarg_f8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_opt_relrefarg_f8\\_opt_relrefarg_f8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
