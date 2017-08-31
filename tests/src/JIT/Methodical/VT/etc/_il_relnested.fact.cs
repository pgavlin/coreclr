using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_relnested__il_relnested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_relnested__il_relnested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_relnested\\_il_relnested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
