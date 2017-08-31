using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__relselfref__relselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__relselfref__relselfref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_relselfref\\_relselfref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
