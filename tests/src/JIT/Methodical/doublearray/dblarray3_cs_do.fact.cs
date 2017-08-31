using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray3_cs_do_dblarray3_cs_do_
    {
        [Fact]
        public void _doublearray_dblarray3_cs_do_dblarray3_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray3_cs_do\\dblarray3_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
