using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_cs_unsafe_ro_unsafe_ro_
    {
        [Fact]
        public void _eh_cs_unsafe_ro_unsafe_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\cs\\unsafe_ro\\unsafe_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
