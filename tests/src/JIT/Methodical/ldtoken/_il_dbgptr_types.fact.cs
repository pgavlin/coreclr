using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_dbgptr_types__il_dbgptr_types_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_dbgptr_types__il_dbgptr_types_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_dbgptr_types\\_il_dbgptr_types.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
