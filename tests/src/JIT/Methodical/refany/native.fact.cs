using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _refany_native_native_
    {
        [OuterLoop]
        [Fact]
        public void _refany_native_native_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\refany\\native\\native.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
