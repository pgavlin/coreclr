using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray1_cs_do_dblarray1_cs_do_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray1_cs_do_dblarray1_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray1_cs_do\\dblarray1_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
