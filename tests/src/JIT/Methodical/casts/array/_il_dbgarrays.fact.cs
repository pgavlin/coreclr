using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _casts_array__il_dbgarrays__il_dbgarrays_
    {
        [Fact]
        public void _casts_array__il_dbgarrays__il_dbgarrays_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\casts\\array\\_il_dbgarrays\\_il_dbgarrays.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
