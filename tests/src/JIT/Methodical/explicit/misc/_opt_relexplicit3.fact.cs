using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _explicit_misc__opt_relexplicit3__opt_relexplicit3_
    {
        [Fact]
        public void _explicit_misc__opt_relexplicit3__opt_relexplicit3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\explicit\\misc\\_opt_relexplicit3\\_opt_relexplicit3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
