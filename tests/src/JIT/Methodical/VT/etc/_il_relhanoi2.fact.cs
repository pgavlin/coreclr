using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_relhanoi2__il_relhanoi2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_relhanoi2__il_relhanoi2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_relhanoi2\\_il_relhanoi2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
