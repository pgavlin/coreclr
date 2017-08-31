using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_relhan2__speed_relhan2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_relhan2__speed_relhan2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_relhan2\\_speed_relhan2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
