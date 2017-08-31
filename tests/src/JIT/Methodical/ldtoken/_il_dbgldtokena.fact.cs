using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_dbgldtokena__il_dbgldtokena_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_dbgldtokena__il_dbgldtokena_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_dbgldtokena\\_il_dbgldtokena.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
