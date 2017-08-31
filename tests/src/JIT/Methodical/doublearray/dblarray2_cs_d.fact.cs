using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray2_cs_d_dblarray2_cs_d_
    {
        [Fact]
        public void _doublearray_dblarray2_cs_d_dblarray2_cs_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray2_cs_d\\dblarray2_cs_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
