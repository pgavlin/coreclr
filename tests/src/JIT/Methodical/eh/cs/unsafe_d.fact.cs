using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_cs_unsafe_d_unsafe_d_
    {
        [OuterLoop]
        [Fact]
        public void _eh_cs_unsafe_d_unsafe_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\cs\\unsafe_d\\unsafe_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
