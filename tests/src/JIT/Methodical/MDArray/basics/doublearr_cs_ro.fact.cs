using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _MDArray_basics_doublearr_cs_ro_doublearr_cs_ro_
    {
        [Fact]
        public void _MDArray_basics_doublearr_cs_ro_doublearr_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\MDArray\\basics\\doublearr_cs_ro\\doublearr_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
