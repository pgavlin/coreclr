using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relnested__relnested_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relnested__relnested_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relnested\\_relnested.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
