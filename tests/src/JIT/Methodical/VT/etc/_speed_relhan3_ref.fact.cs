using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__speed_relhan3_ref__speed_relhan3_ref_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__speed_relhan3_ref__speed_relhan3_ref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_speed_relhan3_ref\\_speed_relhan3_ref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
