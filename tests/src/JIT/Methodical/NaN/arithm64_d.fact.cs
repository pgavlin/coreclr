using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _NaN_arithm64_d_arithm64_d_
    {
        [OuterLoop]
        [Fact]
        public void _NaN_arithm64_d_arithm64_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\NaN\\arithm64_d\\arithm64_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
