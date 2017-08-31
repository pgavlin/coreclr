using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_catchrettoinnertry_cs_r_catchrettoinnertry_cs_r_
    {
        [Fact]
        public void _eh_finallyexec_catchrettoinnertry_cs_r_catchrettoinnertry_cs_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\catchrettoinnertry_cs_r\\catchrettoinnertry_cs_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
