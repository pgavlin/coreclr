using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_catchrettoinnertry_r_catchrettoinnertry_r_
    {
        [Fact]
        public void _eh_finallyexec_catchrettoinnertry_r_catchrettoinnertry_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\catchrettoinnertry_r\\catchrettoinnertry_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
