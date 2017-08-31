using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__il_dbgrefarg_box_val__il_dbgrefarg_box_val_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_misc__il_dbgrefarg_box_val__il_dbgrefarg_box_val_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_il_dbgrefarg_box_val\\_il_dbgrefarg_box_val.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
