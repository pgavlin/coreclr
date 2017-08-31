using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray4_cs_d_dblarray4_cs_d_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray4_cs_d_dblarray4_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray4_cs_d\\dblarray4_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
