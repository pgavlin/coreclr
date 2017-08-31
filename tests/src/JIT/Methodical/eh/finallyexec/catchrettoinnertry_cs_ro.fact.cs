using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_catchrettoinnertry_cs_ro_catchrettoinnertry_cs_ro_
    {
        [Fact]
        public void _eh_finallyexec_catchrettoinnertry_cs_ro_catchrettoinnertry_cs_ro_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\catchrettoinnertry_cs_ro\\catchrettoinnertry_cs_ro.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
