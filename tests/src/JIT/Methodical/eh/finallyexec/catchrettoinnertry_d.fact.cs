using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_finallyexec_catchrettoinnertry_d_catchrettoinnertry_d_
    {
        [Fact]
        public void _eh_finallyexec_catchrettoinnertry_d_catchrettoinnertry_d_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\finallyexec\\catchrettoinnertry_d\\catchrettoinnertry_d.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
