using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _ldtoken__il_relldtoken__il_relldtoken_
    {
        [OuterLoop]
        [Fact]
        public void _ldtoken__il_relldtoken__il_relldtoken_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\ldtoken\\_il_relldtoken\\_il_relldtoken.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
