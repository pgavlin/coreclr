using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relhan2__relhan2_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relhan2__relhan2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relhan2\\_relhan2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
