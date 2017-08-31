using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__il_relrefarg_box_f8__il_relrefarg_box_f8_
    {
        [Fact]
        public void _explicit_misc__il_relrefarg_box_f8__il_relrefarg_box_f8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_il_relrefarg_box_f8\\_il_relrefarg_box_f8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
