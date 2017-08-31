using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray4_cs_r_dblarray4_cs_r_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray4_cs_r_dblarray4_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray4_cs_r\\dblarray4_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
