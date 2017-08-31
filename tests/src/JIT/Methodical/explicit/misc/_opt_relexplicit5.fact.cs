using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_relexplicit5__opt_relexplicit5_
    {
        [Fact]
        public void _explicit_misc__opt_relexplicit5__opt_relexplicit5_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_relexplicit5\\_opt_relexplicit5.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
