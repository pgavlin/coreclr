using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relhan3__relhan3_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relhan3__relhan3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relhan3\\_relhan3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
