using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_basic__il_relrefarg_f4__il_relrefarg_f4_
    {
        [Fact]
        public void _explicit_basic__il_relrefarg_f4__il_relrefarg_f4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\basic\\_il_relrefarg_f4\\_il_relrefarg_f4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
