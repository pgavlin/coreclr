using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__il_relhanoi__il_relhanoi_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__il_relhanoi__il_relhanoi_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_il_relhanoi\\_il_relhanoi.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
