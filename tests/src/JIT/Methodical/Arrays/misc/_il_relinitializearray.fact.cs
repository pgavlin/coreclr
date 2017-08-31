using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_relinitializearray__il_relinitializearray_
    {
        [Fact]
        public void _Arrays_misc__il_relinitializearray__il_relinitializearray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_relinitializearray\\_il_relinitializearray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
