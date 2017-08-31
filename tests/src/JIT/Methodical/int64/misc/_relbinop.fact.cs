using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _int64_misc__relbinop__relbinop_
    {
        [OuterLoop]
        [Fact]
        public void _int64_misc__relbinop__relbinop_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\int64\\misc\\_relbinop\\_relbinop.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
