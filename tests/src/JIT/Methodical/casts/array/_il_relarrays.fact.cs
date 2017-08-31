using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_relarrays__il_relarrays_
    {
        [Fact]
        public void _casts_array__il_relarrays__il_relarrays_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_relarrays\\_il_relarrays.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
