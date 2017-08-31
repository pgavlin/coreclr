using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _Arrays_misc__speed_relselfref__speed_relselfref_
    {
        [OuterLoop]
        [Fact]
        public void _Arrays_misc__speed_relselfref__speed_relselfref_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\Arrays\\misc\\_speed_relselfref\\_speed_relselfref.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
