using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_relrefarg_c__il_relrefarg_c_
    {
        [Fact]
        public void _explicit_basic__il_relrefarg_c__il_relrefarg_c_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_relrefarg_c\\_il_relrefarg_c.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
