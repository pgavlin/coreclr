using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_relexplicit4__opt_relexplicit4_
    {
        [Fact]
        public void _explicit_misc__opt_relexplicit4__opt_relexplicit4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_relexplicit4\\_opt_relexplicit4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
