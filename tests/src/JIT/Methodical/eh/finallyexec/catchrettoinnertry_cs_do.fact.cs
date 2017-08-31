using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_catchrettoinnertry_cs_do_catchrettoinnertry_cs_do_
    {
        [Fact]
        public void _eh_finallyexec_catchrettoinnertry_cs_do_catchrettoinnertry_cs_do_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\catchrettoinnertry_cs_do\\catchrettoinnertry_cs_do.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
