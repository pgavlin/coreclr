using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relhanoi__relhanoi_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relhanoi__relhanoi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relhanoi\\_relhanoi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
