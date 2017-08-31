using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray4_cs_do_dblarray4_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray4_cs_do_dblarray4_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray4_cs_do\\dblarray4_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
