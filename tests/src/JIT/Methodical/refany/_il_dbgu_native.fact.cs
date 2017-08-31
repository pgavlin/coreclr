using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany__il_dbgu_native__il_dbgu_native_
    {
        [OuterLoop]
        [Fact]
        public void _refany__il_dbgu_native__il_dbgu_native_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\_il_dbgu_native\\_il_dbgu_native.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
