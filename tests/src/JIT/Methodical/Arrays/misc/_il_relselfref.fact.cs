using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__il_relselfref__il_relselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__il_relselfref__il_relselfref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_il_relselfref\\_il_relselfref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
