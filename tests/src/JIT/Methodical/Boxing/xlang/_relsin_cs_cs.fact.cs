using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Boxing_xlang__relsin_cs_cs__relsin_cs_cs_
    {
        [Fact]
        public void _Boxing_xlang__relsin_cs_cs__relsin_cs_cs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Boxing\\xlang\\_relsin_cs_cs\\_relsin_cs_cs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
