using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _doublearray_dblarray3_cs_ro_dblarray3_cs_ro_
    {
        [OuterLoop]
        [Fact]
        public void _doublearray_dblarray3_cs_ro_dblarray3_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\doublearray\\dblarray3_cs_ro\\dblarray3_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
