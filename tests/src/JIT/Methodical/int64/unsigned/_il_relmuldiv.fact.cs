using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_unsigned__il_relmuldiv__il_relmuldiv_
    {
        [Fact]
        public void _int64_unsigned__il_relmuldiv__il_relmuldiv_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\unsigned\\_il_relmuldiv\\_il_relmuldiv.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
