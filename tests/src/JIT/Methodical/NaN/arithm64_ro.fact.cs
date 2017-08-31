using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_arithm64_ro_arithm64_ro_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_ro_arithm64_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_ro\\arithm64_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
