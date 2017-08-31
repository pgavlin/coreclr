using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_cs_unsafe_do_unsafe_do_
    {
        [OuterLoop]
        [Fact]
        public void _eh_cs_unsafe_do_unsafe_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\cs\\unsafe_do\\unsafe_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
