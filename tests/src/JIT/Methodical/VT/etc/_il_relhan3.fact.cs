using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_relhan3__il_relhan3_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_relhan3__il_relhan3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_relhan3\\_il_relhan3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
