using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__il_relbinop__il_relbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__il_relbinop__il_relbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_il_relbinop\\_il_relbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
