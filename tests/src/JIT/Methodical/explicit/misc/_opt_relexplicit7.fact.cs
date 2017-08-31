using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_relexplicit7__opt_relexplicit7_
    {
        [Fact]
        public void _explicit_misc__opt_relexplicit7__opt_relexplicit7_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_relexplicit7\\_opt_relexplicit7.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
