using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _VT_etc__relknight__relknight_
    {
        [OuterLoop]
        [Fact]
        public void _VT_etc__relknight__relknight_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\VT\\etc\\_relknight\\_relknight.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
