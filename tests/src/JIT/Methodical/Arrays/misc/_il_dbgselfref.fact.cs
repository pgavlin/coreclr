using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_dbgselfref__il_dbgselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__il_dbgselfref__il_dbgselfref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_dbgselfref\\_il_dbgselfref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
