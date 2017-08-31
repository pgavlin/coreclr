using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_relhan3_ref__il_relhan3_ref_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_relhan3_ref__il_relhan3_ref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_relhan3_ref\\_il_relhan3_ref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
