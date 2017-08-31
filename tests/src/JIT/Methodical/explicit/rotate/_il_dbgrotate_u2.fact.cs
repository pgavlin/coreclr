using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_rotate__il_dbgrotate_u2__il_dbgrotate_u2_
    {
        [OuterLoop]
        [Fact]
        public void _explicit_rotate__il_dbgrotate_u2__il_dbgrotate_u2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\rotate\\_il_dbgrotate_u2\\_il_dbgrotate_u2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
