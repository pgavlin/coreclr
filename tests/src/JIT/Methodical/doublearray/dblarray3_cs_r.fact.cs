using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray3_cs_r_dblarray3_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray3_cs_r_dblarray3_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray3_cs_r\\dblarray3_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
