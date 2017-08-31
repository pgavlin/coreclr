using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__speed_relbinop__speed_relbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__speed_relbinop__speed_relbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_speed_relbinop\\_speed_relbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
