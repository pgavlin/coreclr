using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_relexplicit8__opt_relexplicit8_
    {
        [Fact]
        public void _explicit_misc__opt_relexplicit8__opt_relexplicit8_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_relexplicit8\\_opt_relexplicit8.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
